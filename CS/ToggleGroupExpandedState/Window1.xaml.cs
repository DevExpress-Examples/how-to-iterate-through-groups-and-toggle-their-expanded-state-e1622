using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.NavBar;

namespace ToggleGroupExpandedState
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window{
        public Window1(){
            InitializeComponent();
        }
        #region #CodeBehind
        private void button1_Click(object sender, RoutedEventArgs e){
            for (int i = 0; i < navBarControl1.Groups.Count; i++){
                NavBarGroup currentGroup = navBarControl1.Groups[i];
                currentGroup.IsExpanded = !currentGroup.IsExpanded;
            }

        }
        #endregion #CodeBehind
    }
}
