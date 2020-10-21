using System.Collections.ObjectModel;

namespace NodeWithImageDemo
{
    public class OutlookViewModel
    {
        public OutlookViewModel()
        {
            mainMailCollection = GetInboxMails();
        }

        private ObservableCollection<SortedMailCollection> mainMailCollection;
        public ObservableCollection<SortedMailCollection> SelectedMailCollection
        {
            get { return mainMailCollection; }
            set { mainMailCollection = value; }
        }

        private ObservableCollection<SortedMailCollection> GetInboxMails()
        {
            ObservableCollection<SortedMailCollection> inboxMails = new ObservableCollection<SortedMailCollection>();
            SortedMailCollection sorted1 = new SortedMailCollection();
            sorted1.Header = "Today";
            MailModel mail1 = new MailModel();
            mail1.SenderDetails = "Maria Anders";
            mail1.ToAddress = "Jane Jonk";
            mail1.Subject = "Regarding Meeting";
            mail1.IsUnRead = true;
            mail1.Date = "16/04/2020";
            mail1.Message = @" Hi Jane Jonk, Can we schedule Meeting Appointment for today?.";
            sorted1.MailCollection.Add(mail1);
            MailModel mail2 = new MailModel();
            mail2.SenderDetails = "Thomas Hardy";
            mail2.ToAddress = "Chris Kol";
            mail2.Subject = "Customer has accpeted...";
            mail2.IsUnRead = true;
            mail2.Date = "10/04/2020";
            mail2.Message = @" Hi Chris Kol, Customer has accepted our proposal. Would it be possible for arrange meeting tomorrow?";
            sorted1.MailCollection.Add(mail2);
            MailModel mail3 = new MailModel();
            mail3.SenderDetails = "Christina Berglund";
            mail3.ToAddress = "Dev Khar";
            mail3.Subject = "Greeting";
            mail3.IsUnRead = true;
            mail3.Date = "08/04/2020";
            mail3.Message = @" Hi Dev Khar, Merry Christmas.";
            sorted1.MailCollection.Add(mail3);
            inboxMails.Add(sorted1);

            SortedMailCollection sorted2 = new SortedMailCollection();
            sorted2.Header = "Yesterday";
            MailModel mail4 = new MailModel();
            mail4.SenderDetails = "Martín Sommer";
            mail4.ToAddress = "Anil Pahr";
            mail4.Subject = "Please come and collect ";
            mail4.IsUnRead = false;
            mail4.Date = "07/04/2020";
            mail4.Message = @"  Hi Anil Pahr, Please come and collect the rent receipt.";
            sorted2.MailCollection.Add(mail4);

            MailModel mail5 = new MailModel();
            mail5.SenderDetails = "Victoria Ashworth";
            mail5.ToAddress = "Shanakar";
            mail5.Subject = "Regarding meeting";
            mail5.IsUnRead = false;
            mail5.Date = "01/04/2020";
            mail5.Message = @"  Hi Shanakar, Yes we are available for meeting tomorrow.";
            sorted2.MailCollection.Add(mail5);
            MailModel mail6 = new MailModel();
            mail6.SenderDetails = "Yang Wang.";
            mail6.ToAddress = "Krish Kael";
            mail6.Subject = "Schedule meeting";
            mail6.IsUnRead = false;
            mail6.Date = "11/03/2020";
            mail6.Message = @"  Hi Krish Kael, Please schedule the meeting on tomorrow.";
            sorted2.MailCollection.Add(mail6);
            SortedMailCollection sorted3 = new SortedMailCollection();
            sorted3.Header = "LastWeek";
            MailModel mail7 = new MailModel();
            mail7.SenderDetails = "Sven Ottlieb";
            mail7.ToAddress = "Marie Krilsh";
            mail7.Subject = "Greeting";
            mail7.IsUnRead = false;
            mail7.Date = "23/03/2020";
            mail7.Message = @" Hi Marie Krilsh, Merry Christmas.";
            sorted3.MailCollection.Add(mail7);
            MailModel mail8 = new MailModel();
            mail8.SenderDetails = "Aria Cruz";
            mail8.ToAddress = "Maria Krilsh";
            mail8.Subject = "New year Greeting";
            mail8.IsUnRead = false;
            mail8.Date = "29/02/2020";
            mail8.Message = @" Hi Maria Krilsh, I wish you Happy new year.";
            sorted3.MailCollection.Add(mail8);
            MailModel mail9 = new MailModel();
            mail9.SenderDetails = "Diego Roel";
            mail9.ToAddress = "Michael";
            mail9.Subject = "Weekend Greeting";
            mail9.IsUnRead = false;
            mail9.Date = "01/02/2020";
            mail9.Message = @" Hi Michael, Have a Great Weekend.";
            sorted3.MailCollection.Add(mail9);

            SortedMailCollection sorted4 = new SortedMailCollection();
            sorted4.Header = "Last Month";
            MailModel mail10 = new MailModel();
            mail10.SenderDetails = "Paolo Accorti.";
            mail10.ToAddress = "John Michael";
            mail10.Subject = "Greeting";
            mail10.IsUnRead = false;
            mail10.Date = "26/01/2020";
            mail10.Message = @" Hi John Michael, Have a Great Day.";
            sorted4.MailCollection.Add(mail10);
            inboxMails.Add(sorted2);
            inboxMails.Add(sorted3);
            inboxMails.Add(sorted4);
            return inboxMails;
        }
    }
}
