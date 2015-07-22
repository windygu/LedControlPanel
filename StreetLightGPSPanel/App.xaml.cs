﻿using CeraDevices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StreetLightPanel
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
       // public CeraDevices.CoordinatorDevice dev;
        public CeraDevices.DeviceManager coor_mgr;
        public StreetLightInfo[] street_light_info;
        public bool IsStart = true;
        public static dynamic[,] Light2DInfo = new dynamic[,] {

#region 銘傳大學 士林
//{1, 121.526713, 25.086976},
//            {2, 121.526698, 25.086886},
//            {3, 121.526842, 25.086739},  //;(相同燈桿兩路燈)	
//            {4, 121.526811, 25.086794},  //;(相同燈桿兩路燈)	
//            {5, 121.527077, 25.086781},
//            {6, 121.527391, 25.086720},
//            {7, 121.527594, 25.086560},
//            {8, 121.527399, 25.086480},
//            {9, 121.527177, 25.086306},
//            {10, 121.527031, 25.086115},
//            {11, 121.526958, 25.085932},
//            {12, 121.526915, 25.085802},
//            {13, 121.527121, 25.085668},
//            {14, 121.527115, 25.085562},
//            {15, 121.527349, 25.085538},
//            {16, 121.527543, 25.085560},
//            {17, 121.527688, 25.085528},
//            {18, 121.527402, 25.085973},
//            {19, 121.527476, 25.086121},
//            {20, 121.527511, 25.086217},
//            {21, 121.527679, 25.086370},
//            {22, 121.527819, 25.086381},
//            {23, 121.527922, 25.086444},
//            {24, 121.527977, 25.086190},
//            {25, 121.528098, 25.086173},
//            {26, 121.528427, 25.086224},
//            {27, 121.528470, 25.086306},
//            {28, 121.528570, 25.086284},
//            {29, 121.528631, 25.086326},
//            {30, 121.528647, 25.086204},
//            {31, 121.528799, 25.086188},
//            {32, 121.528947, 25.086325},
//            {33, 121.529334, 25.086494},
			 
//            {34, 121.529435, 25.086444},
//            {35, 121.529544, 25.086428},
//            {36, 121.529644, 25.086489},
//            {37, 121.529730, 25.086368},
//            {38, 121.529640, 25.086341},// ;(相同燈桿兩路燈)		
//            {39, 121.529622, 25.086259}, //;(相同燈桿兩路燈)		
//            {40, 121.529429, 25.086275},
//            {41, 121.529299, 25.086187},// ;(相同燈桿兩路燈)	
//            {42, 121.529314, 25.086148}, // ;(相同燈桿兩路燈)	
//            {43, 121.529166, 25.086126},
//            {44, 121.529037, 25.086081},//  ;(相同燈桿兩路燈)		
//            {45, 121.529058, 25.086058}, // ;(相同燈桿兩路燈)	
//            {46, 121.528947, 25.086041},
//            {47, 121.528672, 25.085981},

#endregion

#region 銘傳大學 林口
     {1, 121.343305, 24.986208},
               {2, 121.34312, 24.986066},
               {3, 121.342925, 24.985974},
               {4, 121.342708, 24.985832},
               {5, 121.342512, 24.985715},
               {6, 121.342328, 24.985607},
               {7, 121.342204, 24.985457},
               {8, 121.341961, 24.985327},
               {9, 121.341734, 24.98518},
               {10, 121.3416675, 24.984975},
               {11, 121.341666, 24.984736},
               {12, 121.341682, 24.984575},
               {13, 121.341585, 24.984264},
               {14, 121.341321, 24.983926},
               {15, 121.341241, 24.983722},
               {16, 121.341242, 24.983560},
               {17, 121.341432, 24.983301},
               {18, 121.341553, 24.983215},
               {19, 121.341891, 24.983330},
               {20, 121.342052, 24.983431},
               {21, 121.342221, 24.983561},
               {22, 121.342358, 24.983659},
               {23, 121.342535, 24.983799},
               {24, 121.342715, 24.983932},
               {25, 121.342865, 24.984045},
               {26, 121.342983, 24.984178},
               {27, 121.343229, 24.984292},
               {28, 121.344338, 24.985074},
               {29, 121.344143, 24.985062},
               {30, 121.343974, 24.984958},
               {31, 121.343798, 24.984866},
               {32, 121.343601, 24.98469},
               {33, 121.34344, 24.984533},
               {34, 121.34323, 24.98443},
               {35, 121.343028, 24.984301},
               {36, 121.342701, 24.984136},
               {37, 121.342434, 24.983916},
               {38, 121.342262, 24.983762},
               {39, 121.341903, 24.983515},
               {40, 121.341721, 24.983387},
               {41, 121.341632, 24.983313},
               {42, 121.341546, 24.983407},
               {43, 121.341308, 24.983626},
               {44, 121.341390, 24.983807},
               {45, 121.341503, 24.98395},   
               {46, 121.341769, 24.984346},
               {47, 121.341802, 24.984574},
               {48, 121.34185, 24.984786},
               {49, 121.341855, 24.984922},
               {50, 121.34196, 24.985076},
               {51, 121.342152, 24.985291},
               {52, 121.342364, 24.985403},
               {53, 121.34252, 24.985505},
               {54, 121.342713, 24.985643},
               {55, 121.342894, 24.985762},
               {56, 121.343041, 24.985875},
               {57, 121.343216, 24.986008},
               {58, 121.342078, 24.98541},
               {59, 121.342025, 24.985591},
               {60, 121.342099, 24.985737}, 
               {61, 121.342201, 24.985865},
               {62, 121.342327, 24.986001},
               {63, 121.34249688, 24.98598724},
               {64, 121.342663, 24.986173},
               {65, 121.342573, 24.986004},
               {66, 121.342713, 24.986121},
               {67, 121.342824, 24.986216},
               {68, 121.342956, 24.986373},
               {69, 121.3430004, 24.986459},
               {70, 121.343018, 24.98666},
               {71, 121.342962, 24.986822},
               {72, 121.342845, 24.987012},
               {73, 121.34276, 24.98708},
               {74, 121.342627, 24.987181},
               {75, 121.342504, 24.987297},
               {76, 121.342367, 24.98743},
               {77, 121.342237, 24.98758},
               {78, 121.342166, 24.98767},
               {79, 121.342013, 24.9877846},
               {80, 121.34184, 24.987772},
               {81, 121.341799, 24.98785143},
               {82, 121.341958, 24.988043},
               {83, 121.342061, 24.988241},
               {84, 121.342132, 24.988484},
               {85, 121.342135, 24.988643},
               {86, 121.342098, 24.988854},
               {87, 121.341359, 24.98452},
               {88, 121.341009, 24.983786},
               {89, 121.340985, 24.983696},
               {90, 121.341747, 24.982855},
               {91, 121.341565, 24.982905},
               {92, 121.342285, 24.98387},
               {93, 121.34193, 24.984126},
               {94, 121.341806, 24.984239},
               {95,121.341838,24.985593},
               {96,121.342125,24.983926},
               {97, 121.342024, 24.982877},
               {98,121.342813,24.983360},
               {99,121.344027,24.985174},
               {100,121.344311,24.985214},
               {101, 121.342355, 24.986088},




#endregion
#region 銘傳大學 金門
    // {1,118.402011,24.501138},
    //{2,118.40185,24.501046},
    //{3,118.401812,24.500874},
    //{4,118.401712,24.500729},
    //{5,118.401617,24.500557},
    //{6,118.401526,24.500414},
    //{7,118.401420,24.500214},
    //{8,118.401715,24.500475},
    //{9,118.401830,24.500291},
    //{10,118.401796,24.500403},
    //{11,118.401944,24.500587},
    //{12,118.401941,24.500757},
    //{13,118.402031,24.500912},
    //{14,118.402026,24.500995},
    //{15,118.402180,24.501124},
    //{16,118.402061,24.500753},
    //{17,118.402169,24.500894},
    //{18,118.402219,24.501000},
    //{19,118.402336,24.501135},
    //{20, 118.402517 , 24.501155 },

    //{21,118.402663,24.501060},
    //{22,118.402834,24.500953},
    //{23,118.403000,24.500870},
    //{24,118.403190,24.500782},
    //{25,118.403129,24.500683},
    //{26,118.402982,24.500511},
    //{27,118.402892,24.500611},
    //{28,118.402762,24.500377},
    //{29,118.402573,24.500147},
    //{30,118.402910,24.500398},
    //{31,118.402817,24.500216},
    //{32,118.402720,24.500083},
    //{33,118.402551,24.499905},
    //{34,118.402484,24.499830},
    //{35,118.402450,24.499698},
    //{36,118.402424,24.499943}

#endregion
    };


        public App()
        {

            #if !DEBUG  //龜山
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
           coor_mgr = new DeviceManager(new CeraDevices.CoordinatorDevice[] { new CeraDevices.CoordinatorDevice("http://10.10.1.1:8080"), new CeraDevices.CoordinatorDevice("http://10.10.1.2:8080") });
          // 銘傳士林校區

         
          //  coor_mgr = new DeviceManager(new CeraDevices.CoordinatorDevice[] { new CeraDevices.CoordinatorDevice("http://10.10.1.1:8080")});
            try
            {

               street_light_info = coor_mgr.GetStreetLightList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "," + ex.StackTrace);
                Environment.Exit(-1);
            }
#endif
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

           
            MessageBox.Show(e.ExceptionObject.ToString());
            //throw new NotImplementedException();
        }
    }
}
