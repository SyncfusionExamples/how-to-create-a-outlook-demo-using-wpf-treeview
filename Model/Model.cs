using System.Collections.ObjectModel;

namespace NodeWithImageDemo
{
    public class MailModel
    {
        /// <summary>
        ///  Maintains the sender details.
        /// </summary>
        private string senderDetails;

        /// <summary>
        ///  Maintains the to address.
        /// </summary>
        private string toAddress;

        /// <summary>
        ///  Maintains the message.
        /// </summary>
        private string message;

        /// <summary>
        ///  Maintains the subject.
        /// </summary>
        private string subject;

        /// <summary>
        /// Indicates whether the message unread or not.
        /// </summary>
        private bool isUnRead;

        /// <summary>
        ///  Maintains the mail category.
        /// </summary>
        private string category;

        /// <summary>
        ///  Maintains the date.
        /// </summary>
        private string date;

        /// <summary>
        /// Indicates whether the item is flagged or not.
        /// </summary>
        private bool isFlagged;

        /// <summary>
        /// Gets or sets the sender details <see cref="MailModel"/> class.
        /// </summary>
        public string SenderDetails
        {
            get
            {
                return senderDetails;
            }
            set
            {
                if (senderDetails != value)
                    senderDetails = value;
            }
        }

        /// <summary>
        /// Gets or sets the to address <see cref="MailModel"/> class.
        /// </summary>
        public string ToAddress
        {
            get
            {
                return toAddress;
            }
            set
            {
                if (toAddress != value)
                    toAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets the message <see cref="MailModel"/> class.
        /// </summary>
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                if (message != value)
                    message = value;
            }
        }

        /// <summary>
        /// Gets or sets the subject <see cref="MailModel"/> class.
        /// </summary>
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                if (subject != value)
                    subject = value;
            }
        }

        /// <summary>
        ///  Gets or sets a value indicating whether the message readable or not <see cref="MailModel"/> class.
        /// </summary>
        public bool IsUnRead
        {
            get { return isUnRead; }
            set { isUnRead = value; }
        }

        /// <summary>
        /// Gets or sets the category <see cref="MailModel"/> class.
        /// </summary>
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (category != value)
                    category = value;
            }
        }

        /// <summary>
        /// Gets or sets the date <see cref="MailModel"/> class.
        /// </summary>
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                if (date != value)
                    date = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the message flagged or not <see cref="MailModel"/> class.
        /// </summary>
        public bool IsFlagged
        {
            get
            {
                return isFlagged;
            }
            set
            {
                if (isFlagged != value)
                    isFlagged = value;
            }

        }
    }

    public class SortedMailCollection
    {
        /// <summary>
        ///  Maintains the header.
        /// </summary>
        private string header;

        /// <summary>
        ///  Maintains the collection of sorted mails.
        /// </summary>
        private ObservableCollection<MailModel> sortedMailCollection = new ObservableCollection<MailModel>();

        /// <summary>
        /// Gets or sets the header <see cref="SortedMailCollection"/> class.
        /// </summary>
        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        /// <summary>
        /// Gets or sets the mails to the collection  <see cref="SortedMailCollection"/> class.
        /// </summary>
        public ObservableCollection<MailModel> MailCollection
        {
            get { return sortedMailCollection; }
            set { sortedMailCollection = value; }
        }
    }
}
