using System.Windows.Controls;

namespace LymeInJA
{
  	public static class Switcher
  	{
    	public static PageSwitcher pageSwitcher;

    	public static void Switch1(UserControl newPage)
    	{
      		pageSwitcher.Navigate(newPage);
    	}

    	public static void Switch(UserControl newPage, object state)
    	{
      		pageSwitcher.Navigate(newPage, state);
    	}

        public static MainPage mainSwitcher;

        public static void Switch2(UserControl newPage)
        {
            mainSwitcher.Navigate(newPage);
        }
        
        public static void Switch2(UserControl newPage, object state)
        {
            mainSwitcher.Navigate(newPage, state);
        }


  	}
}
