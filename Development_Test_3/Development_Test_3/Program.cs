namespace Development_Test_3
{
    internal class Program
    {
        public class Contact
        {
            private string name;
            public event EventHandler ContactSaved;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public void Save()
            {
                private void HandleContactSaved(object sender, EventArgs e)
                {
                    // Insert event handling code.
                }
                private void CreateContact()
                {
                    Contact oContact = new Contact();
                    oContact.ContactSaved += new EventHandler(HandleContactSaved);
                    oContact.Name = “SmurfitKappa”;
                    oContact.Save();
                }

                OnSave();
            }
            public virtual void OnSave()
            {
                // Raise the event:
                if (ContactSaved != null)
                {
                    ContactSaved(this, null);
                }
            }
        }
    }
}