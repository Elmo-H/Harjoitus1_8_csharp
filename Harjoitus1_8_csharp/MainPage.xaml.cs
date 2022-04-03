using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Harjoitus1_8_csharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int num1;
        int num2;
        string operation;
        int answer;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void selectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string comboText = ((ComboBoxItem)selectionBox.SelectedItem).Content.ToString();

            switch (comboText)
            {
                case "Addition":
                    answer = num1 + num2;
                    break;
                case "Subtraction":
                    answer = num1 - num2;
                case "Multiplication":
                    answer = num1 * num2;
                case "Division":
                    answer = num1 / num2;
            }

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }


    private void Sum_Numbers(object sender, RoutedEventArgs e)
    {
        int input1 = Convert.ToInt16(num1.Text);
        int input2 = Convert.ToInt16(num2.Text);

        result.Text = Convert.ToString(input1 + input2);

    }


}

