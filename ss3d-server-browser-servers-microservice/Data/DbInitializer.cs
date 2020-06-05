﻿using System.Collections.Generic;
using System.Linq;
using ss3d_server_browser_shared;
using ss3d_server_browser_shared.Models.Servers;

namespace ss3d_server_browser_servers_microservice.Data
{
    public class DbInitializer
    {
        public static void Initialize(GameServerDataContext context)
        {
            context.Database.EnsureCreated();

            if (context.GameServerData.Any()) return;

            List<GameServerData> mockData = new List<GameServerData>
            {
                new GameServerData(0,"Asteraceae Station 6", "recontextualize extensible architectures",
                    "117.139.138.233",
                    7325, 9478, 55, 55, "Playing", 102, "Box", "Secret", "SS3D", "SS3D-Master", "4.9.1",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Liliaceae Station 2", "redefine cross-media metrics", "42.238.121.20", 9088,
                    4537, 9,
                    31, "Lobby", 117, "Meta", "Secret", "SS3D", "SS3D-Master", "8.2.0",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Fabaceae Station 3", "evolve user-centric systems", "100.156.43.113",
                    9649, 7351, 14, 42, "Starting", 118, "Box", "Secret", "SS3D", "SS3D-Master", "4.73",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Fissidentaceae Station", "", "113.167.195.101", 5971, 2336, 54, 56, "Playing",
                    118,
                    "Alpha", "Secret", "SS3D", "SS3D-Master", "0.84",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Poaceae Station 1", "streamline back-end eyeballs", "91.173.19.225", 5674, 1475,
                    8, 38,
                    "Lobby", 124, "Alpha", "Secret", "SS3D", "SS3D-Master", "0.76",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Collemataceae Station", "productize robust communities", "191.147.106.235",
                    4760, 5844,
                    42, 51, "Starting", 131, "Box", "Secret", "SS3D", "SS3D-Master", "0.4.2",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Liliaceae Station 1", "harness strategic synergies", "151.119.236.186", 4363,
                    6305, 64,
                    64, "Playing", 140, "Box", "Secret", "SS3D", "SS3D-Master", "5.4.8",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Brassicaceae Station 3", "drive ubiquitous web-readiness", "127.144.38.250",
                    0485, 8424,
                    6, 47, "Lobby", 141, "Delta", "Secret", "SS3D", "SS3D-Master", "0.85",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Euphorbiaceae Station 2", "", "95.82.115.184", 8338, 3444, 46, 55, "Starting",
                    146,
                    "Alpha", "Secret", "SS3D", "SS3D-Master", "0.1.0",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Rosaceae Station 1", "enable efficient convergence", "101.230.36.52", 2602,
                    9927, 43,
                    60, "Playing", 15, "Box", "Secret", "SS3D", "SS3D-Master", "0.33",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Gentianaceae Station", "transition sexy channels", "123.154.28.159", 6939, 1833,
                    35, 50,
                    "Lobby", 150, "Delta", "Secret", "SS3D", "SS3D-Master", "1.8.8",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Boraginaceae Station 1", "", "80.253.218.229", 7850, 8672, 63, 64, "Starting",
                    154,
                    "Delta", "Secret", "SS3D", "SS3D-Master", "0.31",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Rosaceae Station 2", "revolutionize cross-platform e-tailers", "78.109.112.215",
                    8710,
                    4872, 39, 41, "Playing", 158, "Meta", "Secret", "SS3D", "SS3D-Master", "1.7",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Asteraceae Station 3", "harness dot-com web services", "108.10.93.41", 4081,
                    5774, 39,
                    64, "Lobby", 163, "Delta", "Secret", "SS3D", "SS3D-Master", "7.1",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Asteraceae Station 7", "maximize next-generation bandwidth", "50.76.213.242",
                    3802,
                    3546, 24, 37, "Starting", 164, "Delta", "Secret", "SS3D", "SS3D-Master", "0.94",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Pinaceae Station", "whiteboard dynamic communities", "126.171.128.72", 5174,
                    6098, 60,
                    62, "Playing", 166, "Meta", "Secret", "SS3D", "SS3D-Master", "2.4.4",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Ericaceae Station", "facilitate real-time initiatives", "95.199.199.236", 8837,
                    0419,
                    60, 63, "Lobby", 168, "Delta", "Secret", "SS3D", "SS3D-Master", "3.5",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Gunneraceae Station", "optimize killer web services", "61.11.98.117", 0710,
                    3936, 6, 55,
                    "Starting", 172, "Box", "Secret", "SS3D", "SS3D-Master", "1.80",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Rubiaceae Station 1", "implement viral web services", "12.151.149.138", 3698,
                    7817, 52,
                    60, "Playing", 174, "Box", "Secret", "SS3D", "SS3D-Master", "0.29",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Polytrichaceae Station", "benchmark transparent ROI", "247.216.44.178", 3928,
                    2324, 42,
                    63, "Lobby", 175, "Alpha", "Secret", "SS3D", "SS3D-Master", "0.5.3",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Liliaceae Station 3", "engineer bricks-and-clicks markets", "192.174.124.82",
                    3487,
                    2649, 21, 63, "Starting", 176, "Delta", "Secret", "SS3D", "SS3D-Master", "1.1",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Rubiaceae Station 2", "benchmark e-business initiatives", "215.117.199.27",
                    6136, 4178,
                    12, 42, "Playing", 179, "Meta", "Traitor", "SS3D", "SS3D-Master", "6.02",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Caprifoliaceae Station", "revolutionize turn-key initiatives", "135.85.248.228",
                    1647,
                    9397, 54, 60, "Lobby", 182, "Alpha", "Traitor", "SS3D", "SS3D-Master", "0.14",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Poaceae Station 2", "integrate next-generation action-items", "72.204.57.239",
                    1150,
                    5211, 51, 54, "Starting", 188, "Alpha", "Traitor", "SS3D", "SS3D-Master", "1.73",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Cyperaceae Station 1", "expedite web-enabled convergence", "17.100.56.123",
                    7434, 4562,
                    38, 43, "Playing", 193, "Meta", "Traitor", "SS3D", "SS3D-Master", "0.1.4",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Cladoniaceae Station", "", "17.0.94.150", 1368, 4902, 29, 41, "Lobby", 198,
                    "Alpha",
                    "Traitor", "SS3D", "SS3D-Master", "0.7.3",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Cyperaceae Station 2", "repurpose scalable interfaces", "248.240.22.203", 1253,
                    1190,
                    51, 63, "Starting", 203, "Alpha", "Traitor", "SS3D", "SS3D-Master", "5.32",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Verbenaceae Station", "recontextualize turn-key e-markets", "4.76.252.150",
                    2523, 3759,
                    32, 63, "Playing", 211, "Meta", "Traitor", "SS3D", "SS3D-Master", "0.69",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Polemoniaceae Station", "", "170.134.37.48", 7496, 7807, 34, 55, "Lobby", 23,
                    "Alpha",
                    "Traitor", "SS3D", "SS3D-Master", "7.0",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Rutaceae Station", "", "66.234.72.80", 9364, 4229, 2, 24, "Starting", 232,
                    "Meta",
                    "Traitor", "SS3D", "SS3D-Master", "0.7.1",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Asteraceae Station 5", "empower turn-key markets", "199.7.44.129", 9817, 4170,
                    51, 62,
                    "Playing", 240, "Meta", "Traitor", "SS3D", "SS3D-Master", "0.69",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Poaceae Station 3", "evolve robust markets", "65.225.187.81", 7782, 3632, 41,
                    57,
                    "Lobby", 248, "Box", "Traitor", "SS3D", "SS3D-Master", "0.6.7",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Fabaceae Station 1", "empower vertical applications", "235.99.101.29", 3333,
                    7488, 59,
                    64, "Starting", 251, "Meta", "Traitor", "SS3D", "SS3D-Master", "0.3.2",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Physciaceae Station", "architect 24/7 channels", "70.15.142.82", 1707, 5940, 30,
                    46,
                    "Playing", 256, "Box", "Traitor", "SS3D", "SS3D-Master", "3.64",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Fabaceae Station 4", "aggregate killer vortals", "84.51.43.164", 6312, 7816, 35,
                    64,
                    "Lobby", 263, "Alpha", "Traitor", "SS3D", "SS3D-Master", "3.1.8",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Euphorbiaceae Station 3", "integrate integrated architectures",
                    "84.122.224.164", 1573,
                    4140, 16, 37, "Starting", 267, "Meta", "Traitor", "SS3D", "SS3D-Master", "0.1.6",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Asteraceae Station 1", "recontextualize back-end communities", "167.232.150.71",
                    6479,
                    2610, 42, 46, "Playing", 27, "Delta", "Traitor", "SS3D", "SS3D-Master", "1.95",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Fabaceae Station 5", "strategize extensible metrics", "250.225.243.248", 1117,
                    9599, 43,
                    43, "Lobby", 286, "Delta", "Traitor", "SS3D", "SS3D-Master", "0.9.5",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Rosaceae Station 3", "disintermediate distributed paradigms", "71.94.41.213",
                    2527,
                    3240, 32, 42, "Starting", 286, "Meta", "Traitor", "SS3D", "SS3D-Master", "7.7",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Campanulaceae Station", "mesh integrated e-business", "113.20.150.235", 9780,
                    2589, 13,
                    22, "Playing", 288, "Delta", "Traitor", "SS3D", "SS3D-Master", "0.7.0",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Polygonaceae Station 2", "maximize open-source applications", "60.202.68.102",
                    3862,
                    5877, 6, 42, "Lobby", 3, "Alpha", "Traitor", "SS3D", "SS3D-Master", "2.0.4",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Scrophulariaceae Station", "cultivate synergistic communities",
                    "39.112.123.218", 6958,
                    4663, 2, 56, "Starting", 35, "Alpha", "Traitor", "SS3D", "SS3D-Master", "0.3.6",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Fabaceae Station 2", "extend strategic models", "36.51.85.117", 2113, 0704, 20,
                    59,
                    "Playing", 37, "Box", "Secret", "SS3D", "SS3D-Master", "3.3",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Asteraceae Station 2", "brand sticky models", "216.228.51.212", 0235, 1293, 30,
                    36,
                    "Lobby", 43, "Meta", "Secret", "SS3D", "SS3D-Master", "0.3.2",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Brassicaceae Station 2", "visualize sexy e-business", "232.7.15.168", 6165,
                    0634, 42,
                    48, "Starting", 45, "Box", "Secret", "SS3D", "SS3D-Master", "0.2.0",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Euphorbiaceae Station 1", "", "206.220.204.47", 4224, 7650, 43, 57, "Playing",
                    5,
                    "Delta", "Secret", "SS3D", "SS3D-Master", "2.3.3",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Polygonaceae Station 3", "leverage one-to-one experiences", "152.196.160.77",
                    6079,
                    4019, 32, 38, "Lobby", 56, "Alpha", "Secret", "SS3D", "SS3D-Master", "2.68",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Asteraceae Station 4", "", "75.254.145.157", 6322, 4858, 55, 55, "Starting", 76,
                    "Delta", "Secret", "SS3D", "SS3D-Master", "0.4.0",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Hydrophyllaceae Station", "transform extensible eyeballs", "12.211.191.199",
                    4628, 8202,
                    48, 56, "Playing", 91, "Box", "Secret", "SS3D", "SS3D-Master", "4.8",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip"),
                new GameServerData(0,"Polygonaceae Station 1", "unleash cutting-edge models", "137.177.28.87", 0825,
                    8172, 47,
                    56, "Lobby", 94, "Delta", "Secret", "SS3D", "SS3D-Master", "4.6.8",
                    "https://github.com/RE-SS3D/SS3D/releases/download/0.3.0/RESS3D_0.3.0.zip")
            };

            context.GameServerData.AddRange(mockData);
            context.SaveChanges();
        }
    }
}