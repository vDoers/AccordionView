using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AccordianView.ViewModel
{
    public class AccordianViewModel : BaseViewModel
    {

        #region Private Fields

        private string imageCollapseName = "collapse.png";
        private string imageExpandName = "expand.png";

        #endregion

        #region Consructor

        public AccordianViewModel()
        {
            ImageFirstFile = ImageSecondFile = ImageThirdFile = imageExpandName;
            
        }

        #endregion

        #region Properties

        private bool _isFirstVisible;
        public bool IsFirstVisible
        {
            get { return _isFirstVisible; }
            set { _isFirstVisible = value; OnPropertyChanged(); }
        }

        private bool _isSecondVisible;
        public bool IsSecondVisible
        {
            get { return _isSecondVisible; }
            set { _isSecondVisible = value; OnPropertyChanged(); }
        }

        private bool _isThirdVisible;
        public bool IsThirdVisible
        {
            get { return _isThirdVisible; }
            set { _isThirdVisible = value; OnPropertyChanged(); }
        }

        private string imageFirstFile;
        public string ImageFirstFile
        {
            get { return imageFirstFile; }
            set { imageFirstFile = value; OnPropertyChanged(); }
        }

        private string imageSecondFile;
        public string ImageSecondFile
        {
            get { return imageSecondFile; }
            set { imageSecondFile = value; OnPropertyChanged(); }
        }

        private string imageThirdFile;
        public string ImageThirdFile
        {
            get { return imageThirdFile; }
            set { imageThirdFile = value; OnPropertyChanged(); }
        }

        #endregion

        #region Commands

        public ICommand CollapsExpandCommand
        {
            get
            {
                return new Command((arg) =>
                {
                    switch (Convert.ToInt32(arg))
                    {
                        case 1:
                            if (IsFirstVisible)
                                IsFirstVisible = false;
                            else
                                IsFirstVisible = true;
                            ImageFirstFile = IsFirstVisible ? imageCollapseName : imageExpandName;
                            break;
                        case 2:
                            if (IsSecondVisible)
                                IsSecondVisible = false;
                            else
                                IsSecondVisible = true;
                            ImageSecondFile = IsSecondVisible ? imageCollapseName : imageExpandName;
                            break;
                        case 3:
                            if (IsThirdVisible)
                                IsThirdVisible = false;
                            else
                                IsThirdVisible = true;
                            ImageThirdFile = IsThirdVisible ? imageCollapseName : imageExpandName;
                            break;
                        default:
                            break;
                    }
                });
            }
        }

        #endregion
    }
}
