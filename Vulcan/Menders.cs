using System.Collections.Generic;
using Clio.Utilities;
using LlamaLibrary.Helpers.NPC;

namespace Vulcan
{
    public class Menders
    {
        public static List<Npc> ListOfMenders = new List<Npc>()
        {
            //Alistair
            //Limsa Lominsa Lower Decks 
            new Npc(1001206, 129, new Vector3(-247.1199f,16.2f,51.86536f)),
            
            //merchant & mender
            //Middle La Noscea (Summerford Farms)
            new Npc(1003257, 134, new Vector3(201.709f, 98.42287f, -206.1036f)),

            //merchant & mender
            //Lower La Noscea (Moraby Drydocks)
            new Npc(1003259, 135, new Vector3(201.2207f, 14.096f, 677.4546f)),

            //merchant & mender
            //Eastern La Noscea (Costa del Sol)
            new Npc(1003261, 137, new Vector3(460.3798f, 17.12659f, 486.5948f)),

            //merchant & mender
            //Eastern La Noscea (Wineport)
            new Npc(1003262, 137, new Vector3(-37.58301f, 71.754f, -39.62775f)),

            //merchant & mender
            //Western La Noscea (Swiftperch)
            new Npc(1003263, 138, new Vector3(667.4143f, 9.82882f, 494.5602f)),

            //merchant & mender
            //Western La Noscea (Aleport)
            new Npc(1003264, 138, new Vector3(240.2533f, -24.99897f, 231.4336f)),

            //merchant & mender
            //Upper La Noscea (Camp Bronze Lake)
            new Npc(1003268, 139, new Vector3(427.2678f, 4.098778f, 115.2819f)),

            //merchant & mender
            //Outer La Noscea (Camp Overlook)
            new Npc(1005182, 180, new Vector3(-102.0371f, 64.20702f, -202.9908f)),

            //Erkenbaud (Independent Arms Mender)
            //New Gridania (New Gridania)
            new Npc(1000394, 132, new Vector3(24.82642f, -8.011047f, 93.18677f)),

            //merchant & mender
            //Central Shroud (Blue Badger Gate (Central Shroud))
            new Npc(1000220, 148, new Vector3(16.18976f, -8.010209f, -15.64056f)),

            //merchant & mender
            //East Shroud (The Hawthorne Hut)
            new Npc(1000222, 152, new Vector3(-213.9468f, 2.324794f, 300.4348f)),

            //independent arms mender
            //South Shroud (Quarrymill)
            new Npc(1000397, 153, new Vector3(161.9745f, 9.536191f, -60.10535f)),

            //merchant & mender
            //South Shroud (Camp Tranquil)
            new Npc(1002372, 153, new Vector3(-214.313f, 21.15425f, 367.2389f)),

            //merchant & mender
            //North Shroud (Fallgourd Float)
            new Npc(1002376, 154, new Vector3(10.6355f, -44.73348f, 220.2029f)),

            //merchant & mender
            //Western Thanalan (Horizon)
            new Npc(1003737, 140, new Vector3(42.52686f, 45.65809f, -266.8345f)),

            //merchant & mender
            //Central Thanalan (Black Brush Station)
            new Npc(1001563, 141, new Vector3(-8.346741f, -2.04808f, -149.3401f)),

            //merchant & mender
            //Eastern Thanalan (Camp Drybone)
            new Npc(1004426, 145, new Vector3(-406.302f, -53.69653f, 95.14001f)),

            //merchant & mender
            //Southern Thanalan (Little Ala Mhigo)
            new Npc(1004429, 146, new Vector3(-157.3663f, 27.18816f, -434.9279f)),

            //merchant & mender
            //Southern Thanalan (Forgotten Springs)
            new Npc(1004430, 146, new Vector3(-278.7976f, 8f, 378.8662f)),

            //merchant & mender
            //Northern Thanalan (Camp Bluefog)
            new Npc(1004160, 147, new Vector3(-29.2821f, 7.003099f, 474.6624f)),

            //merchant & mender
            //Northern Thanalan (Ceruleum Processing Plant)
            new Npc(1004598, 147, new Vector3(-3.250244f, 43.13602f, 32.66956f)),

            //Herebert (Independent Arms Mender)
            //The Gold Saucer (Entrance & Card Squares)
            new Npc(1011590, 144, new Vector3(-52.38079f, 1.6f, 16.59031f)),

            //merchant & mender
            //Coerthas Central Highlands (Camp Dragonhead)
            new Npc(1006798, 155, new Vector3(242.4506f, 302.265f, -252.7047f)),

            //independent mender
            //Coerthas Western Highlands (Falcon's Nest)
            new Npc(1011229, 397, new Vector3(504.9058f, 212.6954f, 716.2126f)),

            //mender of wreckage
            //The Sea of Clouds (Camp Cloudtop)
            new Npc(1011948, 401, new Vector3(-650.1412f, -123.7568f, 525.9631f)),

            //traveling mender
            //The Dravanian Forelands (Tailfeather)
            new Npc(1011913, 398, new Vector3(479.3926f, -51.1414f, 24.64331f)),

            //mender of sticks
            //The Churning Mists (Moghome)
            new Npc(1012074, 400, new Vector3(293.0494f, -42.84921f, 577.4165f)),

            //merchant & mender
            //The Fringes (Castrum Oriens)
            new Npc(1019513, 612, new Vector3(-634.1802f, 130.0831f, -526.0853f)),

            //tribe mender
            //The Fringes (The Peering Stones)
            new Npc(1020803, 612, new Vector3(410.0862f, 114.3358f, 222.2477f)),

            //independent mender
            //The Peaks (Ala Gannha)
            new Npc(1020838, 620, new Vector3(150.1335f, 118.766f, -791.989f)),

            //independent mender
            //The Peaks (Ala Ghiri)
            new Npc(1020867, 620, new Vector3(-253.5897f, 257.5265f, 757.9614f)),

            //local mender
            //The Lochs (The Ala Mhigan Quarter)
            new Npc(1023043, 621, new Vector3(628.046f, 80.00001f, 634.5464f)),

            //Blue mender
            //The Ruby Sea (Tamamizu)
            new Npc(1019176, 613, new Vector3(323.2623f, -120.0298f, -229.2058f)),

            //independent mender
            //The Ruby Sea (Onokoro)
            new Npc(1021502, 613, new Vector3(108.3848f, 1.945865f, -618.3108f)),

            //village mender
            //Yanxia (Namai)
            new Npc(1019253, 614, new Vector3(472.9227f, 68.0285f, -102.2507f)),

            //independent mender
            //Yanxia (The House of the Fierce)
            new Npc(1019268, 614, new Vector3(214.8928f, 5.211083f, -393.4234f)),

            //traveling mender
            //The Azim Steppe (Reunion)
            new Npc(1019341, 622, new Vector3(554.467f, -19.50564f, 309.4376f)),

            //Oroniri mender
            //The Azim Steppe (The Dawn Throne)
            new Npc(1019420, 622, new Vector3(90.8064f, 114.905f, 23.63617f)),

            //Gyosui (Mender)
            //The Azim Steppe (Dhoro Iloh)
            new Npc(1025990, 622, new Vector3(-767.3304f, 127.2415f, 139.8184f)),

            //Atapa (Mender)
            //Radz-at-Han (Radz-at-Han)
            new Npc(1037299, 963, new Vector3(5.264343f, -2.894874E-06f, -40.36017f)),

            //mender
            //Thavnair (Yedlihmad)
            new Npc(1037632, 957, new Vector3(165.5756f, 5.345162f, 624.7806f)),

            //mender
            //Thavnair (The Great Work)
            new Npc(1037637, 957, new Vector3(-508.7206f, 11.71412f, 85.06897f)),

            //mender
            //Thavnair (Palaka's Stand)
            new Npc(1037639, 957, new Vector3(432.6084f, 3.116879f, -237.2626f)),

            //mender
            //Garlemald (Camp Broken Glass)
            new Npc(1037721, 958, new Vector3(-426.838f, 22.42968f, 448.6326f)),

            //mender
            //Garlemald (Tertium)
            new Npc(1037726, 958, new Vector3(495.047f, -36.06747f, -192.8192f)),

            //Jasfort (Merchant & Mender)
            //The Crystarium (Temenos Rookery)
            new Npc(1027269, 819, new Vector3(-76.3714f, 20.04979f, -89.52472f)),

            //Franric (Mender)
            //Eulmore (The Mainstay)
            new Npc(1027539, 820, new Vector3(27.77855f, 82.04999f, 5.618801f)),

            //merchant & mender
            //Lakeland (Fort Jobb)
            new Npc(1027343, 813, new Vector3(715.4192f, 21.87024f, -46.0365f)),

            //arms mender
            //Lakeland (The Ostall Imperative)
            new Npc(1027384, 813, new Vector3(-785.0309f, 53.1209f, -222.5834f)),

            //mender
            //Kholusia (Stilltide)
            new Npc(1027309, 814, new Vector3(684.8706f, 28.11721f, 292.9884f)),

            //mender
            //Kholusia (Wright)
            new Npc(1027430, 814, new Vector3(-223.9872f, 21.25016f, 371.9996f)),

            //Tholl smith (Mender)
            //Kholusia (Tomra)
            new Npc(1027298, 814, new Vector3(-431.3268f, 417.1787f, -637.171f)),

            //mender
            //Amh Araeng (Mord Souq)
            new Npc(1027880, 815, new Vector3(299.4888f, 1.468583f, -236.0418f)),

            //merchant & mender
            //Amh Araeng (Twine)
            new Npc(1027877, 815, new Vector3(-531.3344f, 45.60939f, -235.4009f)),

            //pixie meddler (Mender)
            //Il Mheg (Lydha Lran)
            new Npc(1027652, 816, new Vector3(-319.4171f, 47.99375f, 530.3578f)),

            //Marn Ose (Tool Mender)
            //Il Mheg (Pla Enni)
            new Npc(1027667, 816, new Vector3(-43.83923f, 104.9272f, -856.5347f)),

            //mender
            //The Rak'tika Greatwood (Slitherbough)
            new Npc(1027739, 817, new Vector3(-87.72418f, -19.0277f, 283.4058f)),

            //mender
            //The Rak'tika Greatwood (Fanow)
            new Npc(1027707, 817, new Vector3(311.4823f, 33.76286f, -169.1768f)),

            //mender
            //The Tempest (The Ondo Cups)
            new Npc(1031420, 818, new Vector3(524.895f, 348.3595f, -206.6224f)),

            //independent mender
            //Mor Dhona (Revenant's Toll)
            new Npc(1006899, 156, new Vector3(18.32605f, 28.99997f, -727.657f)),

            //Elftrudis (Mender)
            //Old Sharlayan (The Baldesion Annex)
            new Npc(1037095, 962, new Vector3(-90.0741f, 3.898939f, 7.94989f)),

            //mender
            //Labyrinthos (The Archeion)
            new Npc(1037479, 956, new Vector3(422.1713f, 166.1927f, -428.6107f)),

            //mender
            //Labyrinthos (Sharlayan Hamlet)
            new Npc(1037481, 956, new Vector3(32.63892f, -31.53043f, -71.94635f)),

            //mender
            //Labyrinthos (Aporia)
            new Npc(1037487, 956, new Vector3(-763.5767f, -31.53043f, 294.1176f)),

            //mender
            //Mare Lamentorum (Bestways Burrow)
            new Npc(1037792, 959, new Vector3(-19.85205f, -132.9464f, -456.5347f)),

            //merchant & mender
            //Ultima Thule (Base Omicron)
            new Npc(1038003, 960, new Vector3(467.0023f, 437.0017f, 327.1992f)),

            //mender
            //Elpis (Anagnorisis)
            new Npc(1037908, 961, new Vector3(146.3798f, 10.38586f, 164.4159f)),

            //mender
            //Elpis (The Twelve Wonders)
            new Npc(1037911, 961, new Vector3(-595.5444f, -22.39482f, 549.8588f)),

            //mender
            //Elpis (Poieten Oikos)
            new Npc(1037913, 961, new Vector3(-566.1555f, 166.7222f, -234.8821f)),
        };
        
        public static Dictionary<uint, uint> SelectIconStringIndexes = new Dictionary<uint, uint>()
        {
            //Western La Noscea
            //Merchant & Mender
            {1003264, 3},

            //Upper La Noscea
            //Merchant & Mender
            {1003268, 3},
            
            //Outer La Noscea
            //Merchant & Mender
            {1005182, 5},
            
            //Central Shroud
            //Merchant & Mender
            {1000220, 5},

            //East Shroud
            //Merchant & Mender
            {1000222, 5},

            //South Shroud
            //Independent Arms Mender
            //{1000397, 0},
            
            //South Shroud
            //Merchant & Mender
            {1002372, 3},
            
            //North Shroud
            //Merchant & Mender
            {1002376, 3},
            
            //Western Thanalan
            //Merchant & Mender
            {1003737, 3},

            //Central Thanalan
            //Merchant & Mender
            {1001563, 3},
            
            //Eastern Thanalan
            //Merchant & Mender
            {1004426, 3},

            //Southern Thanalan
            //Merchant & Mender
            {1004429, 5},
            
            //Southern Thanalan
            //Merchant & Mender
            {1004430, 5},

            //Northern Thanalan
            //Merchant & Mender
            {1004160, 5},

            //Northern Thanalan
            //Merchant & Mender
            {1004598, 5},

            //The Gold Saucer
            //Herebert
            //{1011590, 0},

            //Coerthas Central Highlands
            //Merchant & Mender
            {1006798, 5},

            //Coerthas Western Highlands
            //Independent Merchant
            //{1011228, 0},

            //The Sea of Clouds
            //Mender of Wreckage
            //{1011948, 0},

            //The Dravanian Forelands
            //Traveling Mender
            //{1011913, 0},

            //The Churning Mists
            //Mender of Sticks
            //{1012074, 0},

            //The Fringes
            //Merchant & Mender
            {1019513, 6},

            //The Fringes
            //Tribe Mender
            //{1020803, 0},
            
            //The Peaks
            //Independent Mender
            //{1020838, 0},
            
            //The Peaks
            //Independent Mender
            //{1020867, 0},

            //The Lochs
            //Local Mender
            //{1023043, 0},

            //The Ruby Sea
            //Blue Mender
            //{1019176, 0},
            
            //The Ruby Sea
            //Independent Mender
            //{1021502, 0},
            
            //Yanxia
            //Village Mender
            //{1019253, 0},

            //Yanxia
            //Independent Mender
            //{1019268, 0},

            //The Azim Steppe
            //Traveling Mender
            //{1019341, 0},
            
            //The Azim Steppe
            //Oroniri Mender
            //{1019420, 0},

            //Radz-at-Han
            //Atapa
            //{1037299, 0},

            //Thavnair
            //Mender
            //{1037632, 0},

            //Thavnair
            //Mender
            //{1037632, 0},

            //Thavnair
            //Mender
            //{1037639, 0},

            //Garlemald
            //Mender
            //{1037721, 0},

            //Garlemald
            //Mender
            //{1037726, 0},
            
            //The Crystarium
            //Jasfort
            {1027269, 1},
            
            //Eulmore
            //Franric
            //{1027539, 0},
            
            //Lakeland
            //Merchant & Mender
            {1027343, 7},

            //Lakeland
            //Arms Mender
            //{1027384, 0},

            //Kholusia
            //Mender
            //{1027309, 0},
            
            //Kholusia
            //Mender
            //{1027430, 0},
            
            //Kholusia
            //Tholl Smith
            //{1027298, 0},

            //Amh Araeng
            //Mender
            //{1027880, 0},

            //Amh Araeng
            //Merchant & Mender
            {1027877, 7},
            
            //Il Mheg
            //Pixie Meddler
            //{1027652, 0},
            
            //Il Mheg
            //Marn Ose
            //{1027667, 0},
            
            //The Rak'tika Greatwood
            //Mender
            //{1027739, 0},

            //The Rak'tika Greatwood
            //Mender
            //{1027707, 0},
            
            //The Tempest
            //Mender
            //{1031420, 0},
            
            //Mor Dhona
            //Independent Mender
            //{1006899, 0},

            //Old Sharlayan
            //Elftrudis
            //{1037095, 0},
            
            //Labyrinthos
            //Mender
            //{1037479, 0},

            //Labyrinthos
            //Mender
            //{1037481, 0},
            
            //Labyrinthos
            //Mender
            //{1037487, 0},
            
            //Mare Lamentorum
            //Mender
            //{1037792, 0},

            //Ultima Thule
            //Merchant & Mender
            {1038003, 8},
            
            //Elpis
            //Mender
            //{1037908, 0},

            //Elpis
            //Mender
            //{1037911, 0},
            
            //Elpis
            //Mender
            //{1037913, 0},

            {1003261, 5},
            
            //Eastern La Noscea
            //Merchant & Mender
            {1003262, 5},
            
            //Western La Noscea
            //Merchant & Mender
            {1003263, 5},
            
            {1003257, 5}
        };
    }
}