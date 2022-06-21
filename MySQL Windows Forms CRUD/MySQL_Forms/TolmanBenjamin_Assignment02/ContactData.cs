using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_CRUD_Forms
{
    public class ContactData
    {
        int mId = 0;
        string mFirstName = "";
        string mLastName = "";
        string mPhoneNumber = "";
        string mEmail = "";
        string mRelation = "";

        public int ID
        {
            get { return mId; }
            set { mId = value; }
        }
        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string Relation
        {
            get { return mRelation; }
            set { mRelation = value; }
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName);
        }
    }
}
