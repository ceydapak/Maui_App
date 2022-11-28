namespace _180209010_CeydaPak_App6;

public partial class MainPage : ContentPage
{
	public List<Sales> Sales = new List<Sales>();	

	public MainPage()
	{
		InitializeComponent();
		
	}

	private void Add_Button_Clicked(object sender, EventArgs e)
	{
     
        if (Gender_F.IsChecked == true)
        {
           
                Sales.Add(new Sales(S_Name.Text, S_L_Name.Text, S_Tel.Text, "Female"));
            

        }
        else { 
          
                Sales.Add(new Sales(S_Name.Text, S_L_Name.Text, S_Tel.Text, "male"));
           
           
        }

    }

    private void Show_Button_Clicked(object sender, EventArgs e)
	{
        List_View.ItemsSource = null;
        List_View.ItemsSource = Sales;
    }
}

