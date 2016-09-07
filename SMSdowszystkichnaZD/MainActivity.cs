using System;
using System.Text;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using Android.App;
using Android.Telephony;
//using Android.Content;
//using Android.Content.DialogInterface;
using System.Collections; 

namespace KONRADSTAWISKISMS
{
	[Activity (Label = "Juvenes Pro Medicina 2015 SMS", MainLauncher = true)]
	public class MainActivity : Activity
	{
		//int count = 1;
		public ArrayList telefony = new ArrayList ();
		public void sms(object sender,EventArgs e) {
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			EditText ed = FindViewById<EditText> (Resource.Id.editText1);
			ProgressBar prog = FindViewById <ProgressBar> (Resource.Id.progressBar1);



		
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			Button button2 = FindViewById<Button> (Resource.Id.myButton2);
			EditText ed = FindViewById<EditText> (Resource.Id.editText1);
			ProgressBar prog = FindViewById <ProgressBar> (Resource.Id.progressBar1);



			button2.Click += delegate { 
				telefony.Clear ();
				telefony.Add ("516275128");
				telefony.Add ("515478904");
				telefony.Add ("660796004");
				telefony.Add ("691454144");
				telefony.Add ("792910251");
				telefony.Add ("510357811");
				telefony.Add ("661499007");
				telefony.Add ("793264838");
				telefony.Add ("793207258");
				telefony.Add ("601948594");
				telefony.Add ("609347838");
				telefony.Add ("660230197");
				telefony.Add ("515252199");
				telefony.Add ("513995453");
				telefony.Add ("694976677");
				telefony.Add ("512981344");
				telefony.Add ("513084861");
				telefony.Add ("501760504");
				telefony.Add ("698946811");
				new AlertDialog.Builder (this)
					.SetPositiveButton ("Tak", (sender, args) => { 
					button.Enabled = false;
					ed.Enabled = false;
					prog.Progress = 0;
					prog.Max = telefony.Count;				
					foreach (string tel in telefony) {					
						SmsManager.Default.SendTextMessage (tel, null, ed.Text + "\n\n[Juvenes Pro Medicina 2015 SMS System by Konrad Stawiski]", null, null);
						prog.Progress++;
					}
					button.Enabled = true;
					ed.Enabled = true;
					ed.Text = "Wiadomość została wysłana do OC.";
				})
					.SetNegativeButton ("Nie", (sender, args) => {
					// User pressed no 
				})
					.SetMessage ("Na pewno wysłać do OC? : " + ed.Text)
					.SetTitle ("Potwierdź")
					.Show ();

			};
			

				button.Click += delegate { 
			
			
				telefony.Clear ();


					telefony.Add("501168211");
					telefony.Add("501540689");
					telefony.Add("501897084");
					telefony.Add("502321226");
					telefony.Add("502921157");
					telefony.Add("503080739");
					telefony.Add("504890985");
					telefony.Add("509192949");
					telefony.Add("512213657");
					telefony.Add("515706870");
					telefony.Add("519193123");
					telefony.Add("530133600");
					telefony.Add("530737179");
					telefony.Add("535852155");
					telefony.Add("538000947");
					telefony.Add("603070520");
					telefony.Add("609347838");
					telefony.Add("609661650");
					telefony.Add("660302379");
					telefony.Add("663127476");
					telefony.Add("691112125");
					telefony.Add("693896055");
					telefony.Add("695896437");
					telefony.Add("698946811");
					telefony.Add("722080824");
					telefony.Add("722262639");
					telefony.Add("724093709");
					telefony.Add("726461909");
					telefony.Add("728470132");
					telefony.Add("728510867");
					telefony.Add("728810353");
					telefony.Add("781061741");
					telefony.Add("784979502");
					telefony.Add("791530056");
					telefony.Add("794790420");
					telefony.Add("0037129499525");
					telefony.Add("00426787210");
					telefony.Add("500639875");
					telefony.Add("500760707");
					telefony.Add("501075408");
					telefony.Add("501170715");
					telefony.Add("501243116");
					telefony.Add("501360811");
					telefony.Add("501521792");
					telefony.Add("501785470");
					telefony.Add("501835002");
					telefony.Add("502128574");
					telefony.Add("502770969");
					telefony.Add("503505711");
					telefony.Add("503584643");
					telefony.Add("503987011");
					telefony.Add("504131771");
					telefony.Add("504277396");
					telefony.Add("504574567");
					telefony.Add("504605875");
					telefony.Add("505109315");
					telefony.Add("505114454");
					telefony.Add("505255775");
					telefony.Add("505449957");
					telefony.Add("505677558");
					telefony.Add("505844438");
					telefony.Add("505911502");
					telefony.Add("506050937");
					telefony.Add("506235881");
					telefony.Add("506366322");
					telefony.Add("506445407");
					telefony.Add("506867777");
					telefony.Add("506997680");
					telefony.Add("507131682");
					telefony.Add("507159765");
					telefony.Add("507771500");
					telefony.Add("508000112");
					telefony.Add("508122820");
					telefony.Add("508133198");
					telefony.Add("508299487");
					telefony.Add("508301252");
					telefony.Add("508330408");
					telefony.Add("508623497");
					telefony.Add("508741181");
					telefony.Add("509131810");
					telefony.Add("509223158");
					telefony.Add("509388818");
					telefony.Add("509492344");
					telefony.Add("509533025");
					telefony.Add("509533770");
					telefony.Add("509656949");
					telefony.Add("509874780");
					telefony.Add("510089745");
					telefony.Add("510227739");
					telefony.Add("510357811");
					telefony.Add("510409282");
					telefony.Add("511084861");
					telefony.Add("511114556");
					telefony.Add("511509403");
					telefony.Add("511862057");
					telefony.Add("512012857");
					telefony.Add("512285195");
					telefony.Add("512315548");
					telefony.Add("512498968");
					telefony.Add("513084861");
					telefony.Add("513185364");
					telefony.Add("513929106");
					telefony.Add("513981768");
					telefony.Add("514789379");
					telefony.Add("515131693");
					telefony.Add("515451474");
					telefony.Add("516275128");
					telefony.Add("518354784");
					telefony.Add("518561493");
					telefony.Add("519568460");
					telefony.Add("530220267");
					telefony.Add("531300211");
					telefony.Add("531702263");
					telefony.Add("535221289");
					telefony.Add("537119983");
					telefony.Add("537999484");
					telefony.Add("538138152");
					telefony.Add("600109523");
					telefony.Add("600388578");
					telefony.Add("600638605");
					telefony.Add("600701002");
					telefony.Add("601177871");
					telefony.Add("601240821");
					telefony.Add("601392523");
					telefony.Add("601869300");
					telefony.Add("602117894");
					telefony.Add("602608623");
					telefony.Add("602648093");
					telefony.Add("603571700");
					telefony.Add("604179331");
					telefony.Add("604410920");
					telefony.Add("604421633");
					telefony.Add("604942012");
					telefony.Add("604943348");
					telefony.Add("605140349");
					telefony.Add("605160594");
					telefony.Add("605174979");
					telefony.Add("605318277");
					telefony.Add("605732008");
					telefony.Add("606947843");
					telefony.Add("607099182");
					telefony.Add("607119359");
					telefony.Add("607216445");
					telefony.Add("607347977");
					telefony.Add("607515077");
					telefony.Add("607539927");
					telefony.Add("607670551");
					telefony.Add("608049270");
					telefony.Add("608463696");
					telefony.Add("608583657");
					telefony.Add("608598191");
					telefony.Add("608632857");
					telefony.Add("608675298");
					telefony.Add("608808201");
					telefony.Add("608820192");
					telefony.Add("609090865");
					telefony.Add("609098304");
					telefony.Add("609448927");
					telefony.Add("609461380");
					telefony.Add("609996486");
					telefony.Add("660138097");
					telefony.Add("660230197");
					telefony.Add("660252432");
					telefony.Add("660346267");
					telefony.Add("660467718");
					telefony.Add("660796004");
					telefony.Add("660884241");
					telefony.Add("661461691");
					telefony.Add("662255175");
					telefony.Add("662620352");
					telefony.Add("663108418");
					telefony.Add("664011093");
					telefony.Add("664311529");
					telefony.Add("664686706");
					telefony.Add("664727559");
					telefony.Add("664733858");
					telefony.Add("664744519");
					telefony.Add("664915071");
					telefony.Add("665077918");
					telefony.Add("665091566");
					telefony.Add("665467332");
					telefony.Add("665665962");
					telefony.Add("666379108");
					telefony.Add("667914617");
					telefony.Add("668162263");
					telefony.Add("668474824");
					telefony.Add("668667127");
					telefony.Add("668850564");
					telefony.Add("668983679");
					telefony.Add("669086701");
					telefony.Add("669473299");
					telefony.Add("691066904");
					telefony.Add("691133964");
					telefony.Add("691147510");
					telefony.Add("691454144");
					telefony.Add("691747353");
					telefony.Add("691848284");
					telefony.Add("692077001");
					telefony.Add("692377639");
					telefony.Add("692678511");
					telefony.Add("692696105");
					telefony.Add("693321314");
					telefony.Add("693344638");
					telefony.Add("693555488");
					telefony.Add("693636357");
					telefony.Add("693754865");
					telefony.Add("693781474");
					telefony.Add("694029922");
					telefony.Add("694069299");
					telefony.Add("694319233");
					telefony.Add("694608395");
					telefony.Add("694703395");
					telefony.Add("694804465");
					telefony.Add("694915952");
					telefony.Add("695120123");
					telefony.Add("695518445");
					telefony.Add("695606625");
					telefony.Add("695640514");
					telefony.Add("695990662");
					telefony.Add("696316505");
					telefony.Add("696411470");
					telefony.Add("696432333");
					telefony.Add("697455647");
					telefony.Add("697485661");
					telefony.Add("697793714");
					telefony.Add("697841312");
					telefony.Add("697917990");
					telefony.Add("698063701");
					telefony.Add("721145332");
					telefony.Add("721888804");
					telefony.Add("728538917");
					telefony.Add("781093811");
					telefony.Add("781105356");
					telefony.Add("781927677");
					telefony.Add("783581954");
					telefony.Add("783585445");
					telefony.Add("784112396");
					telefony.Add("784573241");
					telefony.Add("785715616");
					telefony.Add("787630066");
					telefony.Add("787896233");
					telefony.Add("788880352");
					telefony.Add("790479858");
					telefony.Add("790583113");
					telefony.Add("790634485");
					telefony.Add("790748144");
					telefony.Add("791558894");
					telefony.Add("791780370");
					telefony.Add("792434819");
					telefony.Add("792476316");
					telefony.Add("792483683");
					telefony.Add("793014933");
					telefony.Add("793028375");
					telefony.Add("793080046");
					telefony.Add("793122100");
					telefony.Add("793264838");
					telefony.Add("793441231");
					telefony.Add("795037823");
					telefony.Add("796122024");
					telefony.Add("796160009");
					telefony.Add("796198448");
					telefony.Add("796443331");
					telefony.Add("797559980");
					telefony.Add("798292064");
					telefony.Add("798968665");
					telefony.Add("880354928");
					telefony.Add("880703178");
					telefony.Add("880777610");
					telefony.Add("883589715");
					telefony.Add("883953633");
					telefony.Add("886460684");
					telefony.Add("888107777");
					telefony.Add("888510979");
					telefony.Add("888915957");
					telefony.Add("889998268");



//				AlertDialog.Builder builder = new AlertDialog.Builder(this);
//				AlertDialog alertDialog = builder.Create();
//				alertDialog.SetTitle("Potwierdź");
//				alertDialog.SetMessage("Na pewno wysłać?: " + ed.Text);
//				alertDialog.SetButton("Tak", delegate {
//
//
//				});
//				alertDialog.SetButton2("Nie", delegate {
//				});
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			;




//				
					new AlertDialog.Builder(this)
						.SetPositiveButton("Tak", (sender, args) => { 
						button.Enabled = false; ed.Enabled = false;
						prog.Progress = 0;
						prog.Max = telefony.Count;				
						foreach (string tel in telefony) {					
							SmsManager.Default.SendTextMessage (tel, null, ed.Text + "\n\n[Juvenes Pro Medicina 2015 SMS System by Konrad Stawiski]", null, null);prog.Progress++;
						} button.Enabled = true;
						ed.Enabled =true; ed.Text = "Wiadomość została wysłana do wszystkich.";
					 })
							.SetNegativeButton("Nie", (sender, args) =>
							                   {
								// User pressed no 
							})
						.SetMessage("Na pewno wysłać do wszystkich? : " + ed.Text)
							.SetTitle("Potwierdź")
							.Show();
					
				
			};
		}
	}
}


