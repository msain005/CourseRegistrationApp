using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace CoursemoApp
{
    public partial class Form1 : Form
    {
        public readonly string dbfilename = "Coursemo.mdf";
        public Form1()
        {
            InitializeComponent();

            db = new CoursemoEntities();

            // swplist1
            var query = from s in db.STUDENTs
                        orderby s.LastName, s.FirstName
                        select s;

            foreach (STUDENT s in query)
            {
               this.swpList1.Items.Add(s);
            }

            // swplist2
            var query2 = from c in db.COURSEs
                        orderby c.Department, c.CourseNumber, c.CRN
                        select c;

            foreach (COURSE c in query2)
            {
                this.swpList2.Items.Add(c);
            }

        }

        private void cmdStudents_Click(object sender, EventArgs e)
        {
            this.lstStudents.Items.Clear();

            var query = from s in db.STUDENTs
                        orderby s.LastName, s.FirstName
                        select s;

            try
            {
                //DataSet ds = datatier.ExecuteNonScalarQuery(sql);

                foreach (STUDENT s in query)
                {
                    this.lstStudents.Items.Add(s);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtclassSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstRegistration.Items.Clear();
            this.lstWaitlist.Items.Clear();
            //
            // retrieve selected customer object from list box:
            //
            COURSE c = (COURSE)this.lstCourses.SelectedItem;

            this.txtSemester.Text = c.Semester;
            this.txtYear.Text = c.Year.ToString();
            this.txtType.Text = c.Type;
            this.txtDay.Text = c.Day;
            this.txtTime.Text = c.Time;
            this.txtclassSize.Text = c.ClassSize.ToString();

            var query = from r in db.REGISTRATIONs
                        where r.CRN == c.CRN
                        orderby r.NetID
                        select r;

            this.lstRegistration.Items.Add("Students Registered:");

            foreach (var r2 in query)
            {
                this.lstRegistration.Items.Add(r2.NetID);
            }

            var query2 = from w in db.WAITLISTs
                        where w.CRN == c.CRN
                        orderby w.WID ascending
                        select w;

            this.lstWaitlist.Items.Add("Students Waitlisted:");

            foreach (var w2 in query2)
            {
                this.lstWaitlist.Items.Add(w2.NetID);
            }           

        }

        private void cmdCourses_Click(object sender, EventArgs e)
        {
            this.lstCourses.Items.Clear();

            var query = from c in db.COURSEs
                        orderby c.Department, c.CourseNumber, c.CRN
                        select c;

            try
            {
                //DataSet ds = datatier.ExecuteNonScalarQuery(sql);

                foreach (COURSE c in query)
                {
                    this.lstCourses.Items.Add(c);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lststudentReg.Items.Clear();
            this.lststudentWait.Items.Clear();

            STUDENT s = (STUDENT)this.lstStudents.SelectedItem;
            
            //Registration query
            var query = from r in db.REGISTRATIONs
                        join c in db.COURSEs on r.CRN equals c.CRN
                        where r.CRN == c.CRN && s.NetID == r.NetID
                        select c;

            this.lststudentReg.Items.Add("Courses Registered:");

            foreach (var c in query)
            {
                this.lststudentReg.Items.Add(c);
            }

            // Waitlist query
            var query2 = from w in db.WAITLISTs
                         join c in db.COURSEs on w.CRN equals c.CRN
                         where w.CRN == c.CRN && s.NetID == w.NetID
                         select c;

            this.lststudentWait.Items.Add("Courses Waitlisted:");

            foreach (var c in query2)
            {
                this.lststudentWait.Items.Add(c);
            }

        }

        private void cmdEnroll_Click(object sender, EventArgs e)
        {
            if (this.lstStudents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student...");
                return;
            }

            if (this.lstCourses.SelectedIndex < 0)  // already registered
            {
                MessageBox.Show("Sorry, this student is already registered");
                return;
            }

            STUDENT s = (STUDENT)this.lstStudents.SelectedItem;
            COURSE c = (COURSE)this.lstCourses.SelectedItem;

            using (var db = new CoursemoEntities())
            {
                var TxOptions = new TransactionOptions();
                TxOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

                //
                // pause
                //
                int timeInMS;
                if (Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true)
                    ;
                else
                    timeInMS = 0;  // no delay:

                System.Threading.Thread.Sleep(timeInMS);

                using (var Tx = new TransactionScope(TransactionScopeOption.Required, TxOptions))
                {
                    try
                    {
                        // registration query
                        var query1 = from r in db.REGISTRATIONs
                                     where r.NetID == s.NetID && r.CRN == c.CRN
                                     select r;

                        if (query1.Count() > 0)
                        {
                            MessageBox.Show("Student is already registered");
                            return;
                        }

                        // waitlist query
                        var query2 = from w in db.WAITLISTs
                                     where w.NetID == s.NetID && w.CRN == c.CRN
                                     select w;

                        if (query2.Count() > 0)
                        {
                            MessageBox.Show("Student is already on waitlist");
                            return;
                        }

                        // register query
                        var query3 = from r in db.REGISTRATIONs
                                     where r.CRN == c.CRN
                                     select r;

                        int registered = query3.Count();

                        var query4 = from ct in db.COURSEs
                                     where ct.CRN == c.CRN
                                     select ct.ClassSize;

                        int classSize = query4.First();

                        System.Diagnostics.Debug.Assert(registered <= classSize);

                        if (registered < classSize)
                        {
                            REGISTRATION registration = new REGISTRATION();
                            registration.NetID = s.NetID;
                            registration.CRN = c.CRN;

                            db.REGISTRATIONs.Add(registration);

                            db.SaveChanges();

                            Tx.Complete();

                            MessageBox.Show("Student Registration Complete");
                        }
                        else
                        {
                            WAITLIST waitlist = new WAITLIST();
                            waitlist.NetID = s.NetID;
                            waitlist.CRN = c.CRN;

                            db.WAITLISTs.Add(waitlist);

                            db.SaveChanges();

                            Tx.Complete();

                            MessageBox.Show("Class is full, Student placed in Waitlist");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Student Registration Failed");
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private CoursemoEntities db;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            // Reset the database, i.e. delete all the rentals and
            // set all bikes to *not* rented:
            //
            string filename, version, connectionInfo;

            version = "MSSQLLocalDB";
            filename = "Coursemo.mdf";
            connectionInfo = String.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;", version,
                      filename);

            DataAccessTier.Data datatier = new DataAccessTier.Data(dbfilename);
            SqlConnection db = null;

            db = new SqlConnection(connectionInfo);
            db.Open();
        
            // Added code
            string sql = string.Format(@"
            DELETE FROM REGISTRATION;  -- delete all registrations:

            DELETE FROM WAITLIST;  -- now delete all Waitlists:
            ");

            //MessageBox.Show(sql);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();

            // Clear listbox
            this.lststudentReg.Items.Clear();
            this.lststudentWait.Items.Clear();
            this.lstStudents.Items.Clear();
            this.lstCourses.Items.Clear();
            this.lstRegistration.Items.Clear();
            this.lstWaitlist.Items.Clear();
            this.lststudentWait.Items.Clear();
            this.lststudentReg.Items.Clear();

            this.txtSemester.Clear();
            this.txtDay.Clear();
            this.txtTime.Clear();
            this.txtType.Clear();
            this.txtYear.Clear();
            this.txtclassSize.Clear();
        }

        private void cmdDrop_Click(object sender, EventArgs e)
        {
            if (this.lstStudents.SelectedIndex < 0) // No students selected
            {
                MessageBox.Show("Please select a student...");
                return;
            }

            if (this.lstCourses.SelectedIndex < 0)  // No courses selected
            {
                MessageBox.Show("Please select a course...");
                return;
            }

            STUDENT s = (STUDENT)this.lstStudents.SelectedItem;
            COURSE c = (COURSE)this.lstCourses.SelectedItem;

            using (var db = new CoursemoEntities())
            {
                //db.Connection.open();
                var TxOptions = new TransactionOptions();
                TxOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

                using (var Tx = new TransactionScope(TransactionScopeOption.Required, TxOptions))
                {
                    try
                    {
                        // registration query
                        var query1 = from r in db.REGISTRATIONs
                                     where r.NetID == s.NetID
                                     select r;

                        var query4 = from w in db.WAITLISTs
                                     where w.CRN == c.CRN
                                     select w;

                        int waitlisted = query4.Count();

                        if (waitlisted > 0 && query1.Count() == 0)
                        {
                            var query7 = (from w in db.WAITLISTs
                                          where w.NetID == s.NetID && w.CRN == c.CRN
                                          select w).FirstOrDefault();

                            db.WAITLISTs.Remove(query7);

                            db.SaveChanges();

                            //
                            // pause
                            //
                            int timeInMS;
                            if (Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true)
                                ;
                            else
                                timeInMS = 0;  // no delay:

                            System.Threading.Thread.Sleep(timeInMS);

                            Tx.Complete();

                            MessageBox.Show("Student Drop from Waitlist Complete");
                            return;
                        }

                        if (query1.Count() == 0)
                        {
                          MessageBox.Show("Student is not registered for this class");
                          return;
                        }

                        // now start the Drop

                        var query3 = from r in db.REGISTRATIONs
                                     where r.CRN == c.CRN
                                     select r;

                        int registered = query3.Count();

                        var query5 = from ct in db.COURSEs
                                     where ct.CRN == c.CRN
                                     select ct.ClassSize;

                        int classSize = query5.First();


                        if (registered > 0)
                        {
                            var query6 = (from r in db.REGISTRATIONs
                                         where r.NetID == s.NetID && r.CRN == c.CRN
                                         select r).FirstOrDefault();

                            db.REGISTRATIONs.Remove(query6);
                           

                            if (waitlisted > 0)
                            {
                                // gets first person on waitlist
                                var query8 = (from w in db.WAITLISTs
                                             where w.CRN == c.CRN
                                             select w).First();

                                REGISTRATION registration = new REGISTRATION();
                                registration.NetID = query8.NetID;
                                registration.CRN = query8.CRN;

                                db.REGISTRATIONs.Add(registration);

                                db.WAITLISTs.Remove(query8);
                                //MessageBox.Show("Student Drop from Waitlist, then added to Course");

                            }

                            db.SaveChanges();

                            //
                            // pause
                            //
                            int timeInMS;
                            if (Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true)
                                ;
                            else
                                timeInMS = 0;  // no delay:

                            System.Threading.Thread.Sleep(timeInMS);

                            Tx.Complete();

                            MessageBox.Show("Student Drop Complete");
                        }

                    } // try
                    catch (Exception ex)
                    {
                        MessageBox.Show("Student Drop Failed");
                        MessageBox.Show(ex.Message);
                    } // catch
                }
            }
        }

        private void lstRegistration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void swpList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void swpList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdSwap_Click(object sender, EventArgs e)
        {
            STUDENT s = (STUDENT)this.lstStudents.SelectedItem;
            STUDENT s2 = (STUDENT)this.swpList1.SelectedItem;
            COURSE c = (COURSE)this.lstCourses.SelectedItem;
            COURSE c2 = (COURSE)this.swpList2.SelectedItem;

            if (this.lstStudents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student...");
                return;
            }

            if (this.swpList1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a second student...");
                return;
            }

            if (this.lstCourses.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a course to swap...");
                return;
            }

            if (this.swpList2.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a second course to swap...");
                return;
            }
            // query for student 1
            var query1 = from r in db.REGISTRATIONs
                         where r.NetID == s.NetID
                         select r;

            // query for student 2
            var query2 = from r in db.REGISTRATIONs
                         where r.NetID == s2.NetID
                         select r;

            // if the course is valid
            var query3 = from r in db.REGISTRATIONs
                         where r.CRN == c.CRN
                         select r;

            // if second course is valid
            var query4 = from r in db.REGISTRATIONs
                         where r.CRN == c2.CRN
                         select r;

            // if student1 and their course match
            var query5 = from r in db.REGISTRATIONs
                         where r.CRN == c.CRN && r.NetID == s.NetID
                         select r;

            // if student2 and their course match
            var query6 = from r in db.REGISTRATIONs
                         where r.CRN == c2.CRN && r.NetID == s2.NetID
                         select r;

            if (query1.Count() == 0)
            {
                MessageBox.Show("Student is not registered for this class");
                return;
            }

            if (query2.Count() == 0)
            {
                MessageBox.Show("Student 2 is not registered for this class");
                return;
            }

            if (query3.Count() == 0)
            {
                MessageBox.Show("No registrations for this course");
                return;
            }

            if (query4.Count() == 0)
            {
                MessageBox.Show("No registrations for this course");
                return;
            }

            if (query5.Count() == 0)
            {
                MessageBox.Show("Student1 and their course do not match");
                return;
            }

            if (query6.Count() == 0)
            {
                MessageBox.Show("Student2 and their course do not match");
                return;
            }


            using (var db = new CoursemoEntities())
            {
                var TxOptions = new TransactionOptions();
                TxOptions.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

                //
                // pause
                //
                int timeInMS;
                if (Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true)
                    ;
                else
                    timeInMS = 0;  // no delay:

                System.Threading.Thread.Sleep(timeInMS);

                using (var Tx = new TransactionScope(TransactionScopeOption.Required, TxOptions))
                {
                    try
                    {
                        // query for registration1
                        var query7 = (from r in db.REGISTRATIONs
                                      where r.NetID == s.NetID && r.CRN == c.CRN
                                      select r).FirstOrDefault();


                        // query for registration2
                        var query8 = (from r in db.REGISTRATIONs
                                      where r.NetID == s2.NetID && r.CRN == c2.CRN
                                      select r).FirstOrDefault();

                        REGISTRATION registration = new REGISTRATION();
                        REGISTRATION registration2 = new REGISTRATION();

                        registration.NetID = s.NetID;
                        registration.CRN = c2.CRN;

                        registration2.NetID = s2.NetID;
                        registration2.CRN = c.CRN;

                        db.REGISTRATIONs.Remove(query7);
                        db.REGISTRATIONs.Remove(query8);
                        db.REGISTRATIONs.Add(registration);
                        db.REGISTRATIONs.Add(registration2);


                        db.SaveChanges();

                        Tx.Complete();

                        MessageBox.Show("Student Swap Complete");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Student Swap Failed");
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
