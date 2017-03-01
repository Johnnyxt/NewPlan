using JW8307A.ViewModels;

namespace JW8307A.Models
{
    internal class TestItemModel : NotificationObject
    {
        private string wave;

        private string ilValue;

        private string rlValue;

        public string IlValue
        {
            get { return ilValue; }
            set
            {
                ilValue = value;
                RaisePropertyChanged("IlValue");
            }
        }

        public string RlValue
        {
            get { return rlValue; }
            set
            {
                rlValue = value;
                RaisePropertyChanged("RlValue");
            }
        }

        public string Wave
        {
            get { return wave; }
            set
            {
                wave = value;
                RaisePropertyChanged("Wave");
            }
        }
    }
}