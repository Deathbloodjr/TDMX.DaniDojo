using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniDojo.Assets.Sprites
{
    internal class DaniSprites
    {
        public static string RootFolder = Plugin.Instance.ConfigDaniDojoAssetLocation.Value;

        [Folder("Common")]
        public static class Common
        {
            [Folder("CourseIcon")]
            public static class CourseIcon
            {
                [Folder("Background")]
                public enum Background
                {
                    [FileName("Kyu.png")]
                    Kyu,
                    [FileName("Blue.png")]
                    Blue,
                    [FileName("Red.png")]
                    Red,
                    [FileName("Silver.png")]
                    Silver,
                    [FileName("Gold.png")]
                    Gold,
                    [FileName("Sousaku.png")]
                    Sousaku,
                    [FileName("Gaiden.png")]
                    Gaiden,
                }

                [Folder("Text")]
                public enum Text
                {
                    [FileName("5kyu.png")]
                    FifthKyu,
                    [FileName("4kyu.png")]
                    FourthKyu,
                    [FileName("3kyu.png")]
                    ThirdKyu,
                    [FileName("2kyu.png")]
                    SecondKyu,
                    [FileName("1kyu.png")]
                    FirstKyu,
                    [FileName("1dan.png")]
                    FirstDan,
                    [FileName("2dan.png")]
                    SecondDan,
                    [FileName("3dan.png")]
                    ThirdDan,
                    [FileName("4dan.png")]
                    FourthDan,
                    [FileName("5dan.png")]
                    FifthDan,
                    [FileName("6dan.png")]
                    SixthDan,
                    [FileName("7dan.png")]
                    SeventhDan,
                    [FileName("8dan.png")]
                    EighthDan,
                    [FileName("9dan.png")]
                    NinthDan,
                    [FileName("10dan.png")]
                    TenthDan,
                    [FileName("kuroto.png")]
                    Kuroto,
                    [FileName("meijin.png")]
                    Meijin,
                    [FileName("chojin.png")]
                    Chojin,
                    [FileName("tatsujin.png")]
                    Tatsujin,
                    [FileName("sousaku.png")]
                    Sousaku,
                    [FileName("gaiden.png")]
                    Gaiden,
                }
            }

            [Folder("Numbers")]
            public static class Numbers
            {
                [Folder("Highscore")]
                public enum Highscore
                {
                    [FileName("0.png")]
                    _0,
                    [FileName("1.png")]
                    _1,
                    [FileName("2.png")]
                    _2,
                    [FileName("3.png")]
                    _3,
                    [FileName("4.png")]
                    _4,
                    [FileName("5.png")]
                    _5,
                    [FileName("6.png")]
                    _6,
                    [FileName("7.png")]
                    _7,
                    [FileName("8.png")]
                    _8,
                    [FileName("9.png")]
                    _9,
                }

                [Folder("RequirementsBig")]
                public static class RequirementsBig
                {
                    [Folder("Background")]
                    public enum Background
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Fill")]
                    public enum Fill
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Transparent")]
                    public enum Transparent
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }
                }

                [Folder("RequirementsMedium")]
                public static class RequirementsMedium
                {
                    [Folder("Background")]
                    public enum Background
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Fill")]
                    public enum Fill
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Transparent")]
                    public enum Transparent
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }
                }

                [Folder("RequirementsSmall")]
                public static class RequirementsSmall
                {
                    [Folder("Background")]
                    public enum Background
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Fill")]
                    public enum Fill
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Transparent")]
                    public enum Transparent
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }
                }

                [Folder("ScoreResults")]
                public static class ScoreResults
                {
                    [Folder("Background")]
                    public enum Background
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Fill")]
                    public enum Fill
                    {
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }
                }

                [Folder("TamashiiResults")]
                public static class TamashiiResults
                {
                    [Folder("Background")]
                    public enum Background
                    {
                        [FileName("%.png")]
                        Percent,
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Fill")]
                    public enum Fill
                    {
                        [FileName("%.png")]
                        Percent,
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }

                    [Folder("Transparent")]
                    public enum Transparent
                    {
                        [FileName("%.png")]
                        Percent,
                        [FileName("0.png")]
                        _0,
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                    }
                }

                [Folder("ValueResults")]
                public enum ValueResults
                {
                    [FileName("0.png")]
                    _0,
                    [FileName("1.png")]
                    _1,
                    [FileName("2.png")]
                    _2,
                    [FileName("3.png")]
                    _3,
                    [FileName("4.png")]
                    _4,
                    [FileName("5.png")]
                    _5,
                    [FileName("6.png")]
                    _6,
                    [FileName("7.png")]
                    _7,
                    [FileName("8.png")]
                    _8,
                    [FileName("9.png")]
                    _9,
                }
            }

            [Folder("Requirements")]
            public static class Requirements
            {
                [Folder("TotalRequirements")]
                public static class TotalRequirements
                {
                    [Folder("Rainbow")]
                    public enum Rainbow
                    {
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                        [FileName("10.png")]
                        _10,
                        [FileName("11.png")]
                        _11,
                        [FileName("12.png")]
                        _12,
                        [FileName("13.png")]
                        _13,
                        [FileName("14.png")]
                        _14,
                        [FileName("15.png")]
                        _15,
                        [FileName("16.png")]
                        _16,
                    }

                    public enum Files
                    {
                        [FileName("BlankBar.png")]
                        BlankBar,
                        [FileName("BarBorder.png")]
                        BarBorder,
                    }
                }

                public enum Files
                {
                    [FileName("IconTotal.png")]
                    IconTotal,
                    [FileName("IconSong1.png")]
                    IconSong1,
                    [FileName("IconSong2.png")]
                    IconSong2,
                    [FileName("IconSong3.png")]
                    IconSong3,
                }
            }

            [Folder("SongInfo")]
            public static class SongInfo
            {
                [Folder("DifficultyCourse")]
                public enum DifficultyCourse
                {
                    [FileName("Easy.png")]
                    Easy,
                    [FileName("Normal.png")]
                    Normal,
                    [FileName("Hard.png")]
                    Hard,
                    [FileName("Oni.png")]
                    Oni,
                    [FileName("Ura.png")]
                    Ura,
                }

                [Folder("DifficultyLevel")]
                public enum DifficultyLevel
                {
                    [FileName("1.png")]
                    _1,
                    [FileName("2.png")]
                    _2,
                    [FileName("3.png")]
                    _3,
                    [FileName("4.png")]
                    _4,
                    [FileName("5.png")]
                    _5,
                    [FileName("6.png")]
                    _6,
                    [FileName("7.png")]
                    _7,
                    [FileName("8.png")]
                    _8,
                    [FileName("9.png")]
                    _9,
                    [FileName("10.png")]
                    _10,
                    [FileName("10+.png")]
                    _10Plus,
                }

                public enum Files
                {
                    [FileName("SongBackground.png")]
                    SongBackground,
                    [FileName("Song1.png")]
                    Song1,
                    [FileName("Song2.png")]
                    Song2,
                    [FileName("Song3.png")]
                    Song3,
                }
            }

            [Folder("TamashiiGauge")]
            public static class TamashiiGauge
            {
                [Folder("Colors")]
                public static class Colors
                {
                    [Folder("Blur")]
                    public enum Blur
                    {
                        [FileName("Blue.png")]
                        Blue,
                        [FileName("Red.png")]
                        Red,
                        [FileName("Yellow.png")]
                        Yellow,
                    }

                    [Folder("Fill")]
                    public enum Fill
                    {
                        [FileName("Blue.png")]
                        Blue,
                        [FileName("Red.png")]
                        Red,
                        [FileName("Yellow.png")]
                        Yellow,
                    }

                    [Folder("Rainbow")]
                    public enum Rainbow
                    {
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                    }
                }

                [Folder("Flames")]
                public enum Flames
                {
                    [FileName("1.png")]
                    _1,
                    [FileName("2.png")]
                    _2,
                    [FileName("3.png")]
                    _3,
                    [FileName("4.png")]
                    _4,
                    [FileName("5.png")]
                    _5,
                    [FileName("6.png")]
                    _6,
                    [FileName("7.png")]
                    _7,
                    [FileName("8.png")]
                    _8,
                }

                [Folder("Icon")]
                public enum Icon
                {
                    [FileName("Bright.png")]
                    Bright,
                    [FileName("Dark.png")]
                    Dark,
                    [FileName("Normal.png")]
                    Normal,
                }

                public enum Files
                {
                    [FileName("EnsoBackground.png")]
                    EnsoBackground,
                    [FileName("RequirementHeader.png")]
                    RequirementHeader,
                    [FileName("RequirementMarker.png")]
                    RequirementMarker,
                    [FileName("ResultBackground.png")]
                    ResultBackground,
                    [FileName("SegmentBars.png")]
                    SegmentBars,
                }
            }
        }

        [Folder("CourseSelect")]
        public static class CourseSelect
        {
            [Folder("Background")]
            public enum Background
            {
                [FileName("BGOff.png")]
                BGOff,
                [FileName("BGOn.png")]
                BGOn,
                [FileName("Students.png")]
                Students,
                [FileName("Master.png")]
                Master,
            }

            [Folder("ConfirmWindow")]
            public static class ConfirmWindow
            {
                [Folder("MainWindow")]
                public static class MainWindow
                {
                    [Folder("OptionsButton")]
                    public enum OptionsButton
                    {
                        [FileName("Button.png")]
                        Button,
                        [FileName("DimHighlight.png")]
                        DimHighlight,
                        [FileName("BrightHighlight.png")]
                        BrightHighlight,
                        [FileName("WhiteHighlight.png")]
                        WhiteHighlight,
                    }

                    [Folder("OrangeButton")]
                    public enum OrangeButton
                    {
                        [FileName("Selected.png")]
                        Selected,
                        [FileName("Shadow.png")]
                        Shadow,
                        [FileName("WhiteColorHighlight.png")]
                        WhiteColorHighlight,
                        [FileName("DimSelectedHighlight.png")]
                        DimSelectedHighlight,
                        [FileName("BrightSelectedHighlight.png")]
                        BrightSelectedHighlight,
                        [FileName("WhiteSelectedHighlight.png")]
                        WhiteSelectedHighlight,
                    }

                    public enum Files
                    {
                        [FileName("Background.png")]
                        Background,
                    }
                }
            }

            [Folder("CourseInfo")]
            public static class CourseInfo
            {
                [Folder("Background")]
                public static class Background
                {
                    [Folder("Borders")]
                    public static class Borders
                    {
                        [Folder("Blue")]
                        public enum Blue
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }

                        [Folder("Gaiden")]
                        public enum Gaiden
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }

                        [Folder("Gold")]
                        public enum Gold
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }

                        [Folder("Kyu")]
                        public enum Kyu
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }

                        [Folder("Red")]
                        public enum Red
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }

                        [Folder("Silver")]
                        public enum Silver
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }

                        [Folder("Sousaku")]
                        public enum Sousaku
                        {
                            [FileName("Left.png")]
                            Left,
                            [FileName("Right.png")]
                            Right,
                        }
                    }

                    public enum Files
                    {
                        [FileName("Background.png")]
                        Background,
                    }
                }

                [Folder("Requirements")]
                public enum Requirements
                {
                    [FileName("RequirementsTopBorder.png")]
                    RequirementsTopBorder,
                    [FileName("RequirementsSideBorders.png")]
                    RequirementsSideBorders,
                    [FileName("SoulGaugeBackground.png")]
                    SoulGaugeBackground,
                    [FileName("IndividualRequirementBorder.png")]
                    IndividualRequirementBorder,
                    [FileName("TotalRequirementBackground.png")]
                    TotalRequirementBackground,
                    [FileName("Song1RequirementBackground.png")]
                    Song1RequirementBackground,
                    [FileName("Song2RequirementBackground.png")]
                    Song2RequirementBackground,
                    [FileName("Song3RequirementBackground.png")]
                    Song3RequirementBackground,
                    [FileName("HighScoreBackground.png")]
                    HighScoreBackground,
                }
            }

            [Folder("Intro")]
            public static class Intro
            {
                [Folder("Text")]
                public enum Text
                {
                    [FileName("TopLeft.png")]
                    TopLeft,
                    [FileName("TopRight.png")]
                    TopRight,
                    [FileName("BotLeft.png")]
                    BotLeft,
                    [FileName("BotRight.png")]
                    BotRight,
                }

                public enum Files
                {
                    [FileName("BG.png")]
                    BG,
                    [FileName("Cover.png")]
                    Cover,
                }
            }

            [Folder("TopCourses")]
            public static class TopCourses
            {
                [Folder("Background")]
                public enum Background
                {
                    [FileName("Kyu.png")]
                    Kyu,
                    [FileName("Blue.png")]
                    Blue,
                    [FileName("Red.png")]
                    Red,
                    [FileName("Silver.png")]
                    Silver,
                    [FileName("Gold.png")]
                    Gold,
                    [FileName("Gaiden.png")]
                    Gaiden,
                }

                [Folder("Result")]
                public enum Result
                {
                    [FileName("RedClear.png")]
                    RedClear,
                    [FileName("RedFC.png")]
                    RedFC,
                    [FileName("RedDFC.png")]
                    RedDFC,
                    [FileName("GoldClear.png")]
                    GoldClear,
                    [FileName("GoldFC.png")]
                    GoldFC,
                    [FileName("GoldDFC.png")]
                    GoldDFC,
                }

                [Folder("Text")]
                public enum Text
                {
                    [FileName("5kyu.png")]
                    FifthKyu,
                    [FileName("4kyu.png")]
                    FourthKyu,
                    [FileName("3kyu.png")]
                    ThirdKyu,
                    [FileName("2kyu.png")]
                    SecondKyu,
                    [FileName("1kyu.png")]
                    FirstKyu,
                    [FileName("1dan.png")]
                    FirstDan,
                    [FileName("2dan.png")]
                    SecondDan,
                    [FileName("3dan.png")]
                    ThirdDan,
                    [FileName("4dan.png")]
                    FourthDan,
                    [FileName("5dan.png")]
                    FifthDan,
                    [FileName("6dan.png")]
                    SixthDan,
                    [FileName("7dan.png")]
                    SeventhDan,
                    [FileName("8dan.png")]
                    EighthDan,
                    [FileName("9dan.png")]
                    NinthDan,
                    [FileName("10dan.png")]
                    TenthDan,
                    [FileName("kuroto.png")]
                    Kuroto,
                    [FileName("meijin.png")]
                    Meijin,
                    [FileName("chojin.png")]
                    Chojin,
                    [FileName("tatsujin.png")]
                    Tatsujin,
                    [FileName("gaiden.png")]
                    Gaiden,
                }

                public enum Files
                {
                    [FileName("SelectedHighlight.png")]
                    SelectedHighlight,
                    [FileName("LeftArrow.png")]
                    LeftArrow,
                    [FileName("RightArrow.png")]
                    RightArrow,
                }
            }
        }

        [Folder("Enso")]
        public static class Enso
        {
            [Folder("DonBG")]
            public enum DonBG
            {
                [FileName("Background.png")]
                Background,
                [FileName("BlueBack.png")]
                BlueBack,
                [FileName("BlueMid.png")]
                BlueMid,
                [FileName("BlueFrontSmall.png")]
                BlueFrontSmall,
                [FileName("BlueFrontBig.png")]
                BlueFrontBig,
                [FileName("Petals.png")]
                Petals,
                [FileName("FlowersTop.png")]
                FlowersTop,
                [FileName("FlowersMid.png")]
                FlowersMid,
                [FileName("FlowersBot.png")]
                FlowersBot,
            }

            [Folder("Info")]
            public enum Info
            {
                [FileName("Background.png")]
                Background,
                [FileName("DaniCourseIcon.png")]
                DaniCourseIcon,
            }

            [Folder("Lane")]
            public enum Lane
            {
                [FileName("Lane.png")]
                Lane,
                [FileName("LaneCover.png")]
                LaneCover,
            }

            [Folder("LoadingIntro")]
            public enum LoadingIntro
            {
                [FileName("Background.png")]
                Background,
            }

            [Folder("Requirements")]
            public static class Requirements
            {
                [Folder("SongRequirements")]
                public static class SongRequirements
                {
                    [Folder("PreviousSongs")]
                    public enum PreviousSongs
                    {
                        [FileName("Background.png")]
                        Background,
                        [FileName("IconSong1.png")]
                        IconSong1,
                        [FileName("IconSong2.png")]
                        IconSong2,
                        [FileName("BlankBar.png")]
                        BlankBar,
                        [FileName("BarBorder.png")]
                        BarBorder,
                        [FileName("RainbowBar.png")]
                        RainbowBar,
                    }

                    [Folder("Rainbow")]
                    public enum Rainbow
                    {
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                    }

                    public enum Files
                    {
                        [FileName("BlankBar.png")]
                        BlankBar,
                        [FileName("BarBorder.png")]
                        BarBorder,
                    }
                }

                public enum Files
                {
                    [FileName("Background.png")]
                    Background,
                    [FileName("RequirementBackground.png")]
                    RequirementBackground,
                }
            }
        }

        [Folder("Results")]
        public static class Results
        {
            [Folder("Advancement")]
            public static class Advancement
            {
                [Folder("Background")]
                public static class Background
                {
                    [Folder("Background")]
                    public enum Background2
                    {
                        [FileName("NotFC.png")]
                        NotFC,
                        [FileName("FC.png")]
                        FC,
                        [FileName("DFC.png")]
                        DFC,
                    }

                    [Folder("Lights")]
                    public static class Lights
                    {
                        [Folder("GoldClear")]
                        public enum GoldClear
                        {
                            [FileName("1.png")]
                            _1,
                            [FileName("2.png")]
                            _2,
                            [FileName("3.png")]
                            _3,
                        }

                        [Folder("RedClear")]
                        public enum RedClear
                        {
                            [FileName("1.png")]
                            _1,
                            [FileName("2.png")]
                            _2,
                            [FileName("3.png")]
                            _3,
                        }
                    }
                }

                [Folder("Text")]
                public static class Text
                {
                    [Folder("GoldClear")]
                    public enum GoldClear
                    {
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                        [FileName("10.png")]
                        _10,
                        [FileName("First.png")]
                        First,
                        [FileName("Kyu.png")]
                        Kyu,
                        [FileName("Dan.png")]
                        Dan,
                        [FileName("Kuroto.png")]
                        Kuroto,
                        [FileName("Meijin.png")]
                        Meijin,
                        [FileName("Chojin.png")]
                        Chojin,
                        [FileName("Tatsujin.png")]
                        Tatsujin,
                        [FileName("Jin.png")]
                        Jin,
                        [FileName("ClearChar1.png")]
                        ClearChar1,
                        [FileName("ClearChar2.png")]
                        ClearChar2,
                        [FileName("GaidenChar1.png")]
                        GaidenChar1,
                        [FileName("GaidenChar2.png")]
                        GaidenChar2,
                    }

                    [Folder("RedClear")]
                    public enum RedClear
                    {
                        [FileName("1.png")]
                        _1,
                        [FileName("2.png")]
                        _2,
                        [FileName("3.png")]
                        _3,
                        [FileName("4.png")]
                        _4,
                        [FileName("5.png")]
                        _5,
                        [FileName("6.png")]
                        _6,
                        [FileName("7.png")]
                        _7,
                        [FileName("8.png")]
                        _8,
                        [FileName("9.png")]
                        _9,
                        [FileName("10.png")]
                        _10,
                        [FileName("First.png")]
                        First,
                        [FileName("Kyu.png")]
                        Kyu,
                        [FileName("Dan.png")]
                        Dan,
                        [FileName("Kuroto.png")]
                        Kuroto,
                        [FileName("Meijin.png")]
                        Meijin,
                        [FileName("Chojin.png")]
                        Chojin,
                        [FileName("Tatsujin.png")]
                        Tatsujin,
                        [FileName("Jin.png")]
                        Jin,
                        [FileName("ClearChar1.png")]
                        ClearChar1,
                        [FileName("ClearChar2.png")]
                        ClearChar2,
                        [FileName("GaidenChar1.png")]
                        GaidenChar1,
                        [FileName("GaidenChar2.png")]
                        GaidenChar2,
                    }
                }

                public enum Files
                {
                    [FileName("Confetti.png")]
                    Confetti,
                    [FileName("Sparkle.png")]
                    Sparkle,
                    [FileName("Polygon.png")]
                    Polygon,
                }
            }

            [Folder("Common")]
            public static class Common
            {
                [Folder("ClearIcon")]
                public static class ClearIcon
                {
                    [Folder("Clear")]
                    public static class Clear
                    {
                        [Folder("Background")]
                        public enum Background
                        {
                            [FileName("Blank.png")]
                            Blank,
                            [FileName("NotFC.png")]
                            NotFC,
                            [FileName("FC.png")]
                            FC,
                            [FileName("DFC.png")]
                            DFC,
                        }

                        [Folder("Outline")]
                        public enum Outline
                        {
                            [FileName("NotFC.png")]
                            NotFC,
                            [FileName("FC.png")]
                            FC,
                            [FileName("DFC.png")]
                            DFC,
                        }

                        [Folder("Sparkle")]
                        public enum Sparkle
                        {
                            [FileName("NotFC.png")]
                            NotFC,
                            [FileName("FC.png")]
                            FC,
                            [FileName("DFC.png")]
                            DFC,
                        }

                        [Folder("Text")]
                        public enum Text
                        {
                            [FileName("Blank.png")]
                            Blank,
                            [FileName("RedClear.png")]
                            RedClear,
                            [FileName("GoldClear.png")]
                            GoldClear,
                            [FileName("RedHighlight.png")]
                            RedHighlight,
                            [FileName("GoldHighlight.png")]
                            GoldHighlight,
                        }

                        [Folder("TextShineAnimation")]
                        public enum TextShineAnimation
                        {
                            [FileName("1.png")]
                            _1,
                            [FileName("2.png")]
                            _2,
                            [FileName("3.png")]
                            _3,
                            [FileName("4.png")]
                            _4,
                            [FileName("5.png")]
                            _5,
                            [FileName("6.png")]
                            _6,
                            [FileName("7.png")]
                            _7,
                            [FileName("8.png")]
                            _8,
                            [FileName("9.png")]
                            _9,
                            [FileName("10.png")]
                            _10,
                            [FileName("11.png")]
                            _11,
                            [FileName("12.png")]
                            _12,
                            [FileName("13.png")]
                            _13,
                            [FileName("14.png")]
                            _14,
                            [FileName("15.png")]
                            _15,
                            [FileName("16.png")]
                            _16,
                            [FileName("17.png")]
                            _17,
                        }

                        public enum Files
                        {
                            [FileName("GoldSparkle.png")]
                            GoldSparkle,
                        }
                    }

                    [Folder("Fail")]
                    public static class Fail
                    {
                        [Folder("Char1")]
                        public enum Char1
                        {
                            [FileName("Shadow.png")]
                            Shadow,
                            [FileName("WhiteBackground.png")]
                            WhiteBackground,
                            [FileName("BlackBorder.png")]
                            BlackBorder,
                            [FileName("BlueText.png")]
                            BlueText,
                        }

                        [Folder("Char2")]
                        public enum Char2
                        {
                            [FileName("Shadow.png")]
                            Shadow,
                            [FileName("WhiteBackground.png")]
                            WhiteBackground,
                            [FileName("BlackBorder.png")]
                            BlackBorder,
                            [FileName("BlueText.png")]
                            BlueText,
                        }

                        [Folder("Char3")]
                        public enum Char3
                        {
                            [FileName("Shadow.png")]
                            Shadow,
                            [FileName("WhiteBackground.png")]
                            WhiteBackground,
                            [FileName("BlackBorder.png")]
                            BlackBorder,
                            [FileName("BlueText.png")]
                            BlueText,
                        }
                    }
                }

                public enum Files
                {
                    [FileName("Background.png")]
                    Background,
                }
            }

            [Folder("PlayResults")]
            public static class PlayResults
            {
                [Folder("DrumrollEtcHeader")]
                public enum DrumrollEtcHeader
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                [Folder("GoodOkBadHeader")]
                public enum GoodOkBadHeader
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                [Folder("Requirements")]
                public static class Requirements
                {
                    [Folder("IndividualSongBars")]
                    public static class IndividualSongBars
                    {
                        [Folder("Rainbow")]
                        public enum Rainbow
                        {
                            [FileName("1.png")]
                            _1,
                            [FileName("2.png")]
                            _2,
                            [FileName("3.png")]
                            _3,
                            [FileName("4.png")]
                            _4,
                            [FileName("5.png")]
                            _5,
                            [FileName("6.png")]
                            _6,
                            [FileName("7.png")]
                            _7,
                            [FileName("8.png")]
                            _8,
                            [FileName("9.png")]
                            _9,
                            [FileName("10.png")]
                            _10,
                            [FileName("11.png")]
                            _11,
                            [FileName("12.png")]
                            _12,
                            [FileName("13.png")]
                            _13,
                            [FileName("14.png")]
                            _14,
                            [FileName("15.png")]
                            _15,
                            [FileName("16.png")]
                            _16,
                        }

                        public enum Files
                        {
                            [FileName("BlankBar.png")]
                            BlankBar,
                            [FileName("BarBorder.png")]
                            BarBorder,
                        }
                    }

                    public enum Files
                    {
                        [FileName("Background.png")]
                        Background,
                    }
                }

                public enum Files
                {
                    [FileName("Background.png")]
                    Background,
                    [FileName("ScoreBackground.png")]
                    ScoreBackground,
                    [FileName("HighscoreBackground.png")]
                    HighscoreBackground,
                    [FileName("HighscoreHighlightBackground.png")]
                    HighscoreHighlightBackground,
                }
            }

            [Folder("SongsScreen")]
            public static class SongsScreen
            {
                [Folder("BadHeaders")]
                public enum BadHeaders
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                [Folder("DrumrollHeaders")]
                public enum DrumrollHeaders
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                [Folder("GoodHeaders")]
                public enum GoodHeaders
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                [Folder("NotCleared")]
                public enum NotCleared
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                [Folder("OKHeaders")]
                public enum OKHeaders
                {
                    [FileName("English.png")]
                    English,
                    [FileName("Japanese.png")]
                    Japanese,
                }

                public enum Files
                {
                    [FileName("SongPanelBackground.png")]
                    SongPanelBackground,
                    [FileName("SongBackground.png")]
                    SongBackground,
                }
            }
        }

        [Folder("SongSelect")]
        public static class SongSelect
        {
            [Folder("CourseSelect")]
            public static class CourseSelect
            {
                [Folder("Background")]
                public enum Background
                {
                    [FileName("Kyu.png")]
                    Kyu,
                    [FileName("Blue.png")]
                    Blue,
                    [FileName("Red.png")]
                    Red,
                    [FileName("Silver.png")]
                    Silver,
                    [FileName("Gold.png")]
                    Gold,
                }

                [Folder("Text")]
                public enum Text
                {
                    [FileName("5kyu.png")]
                    FifthKyu,
                    [FileName("4kyu.png")]
                    FourthKyu,
                    [FileName("3kyu.png")]
                    ThirdKyu,
                    [FileName("2kyu.png")]
                    SecondKyu,
                    [FileName("1kyu.png")]
                    FirstKyu,
                    [FileName("1dan.png")]
                    FirstDan,
                    [FileName("2dan.png")]
                    SecondDan,
                    [FileName("3dan.png")]
                    ThirdDan,
                    [FileName("4dan.png")]
                    FourthDan,
                    [FileName("5dan.png")]
                    FifthDan,
                    [FileName("6dan.png")]
                    SixthDan,
                    [FileName("7dan.png")]
                    SeventhDan,
                    [FileName("8dan.png")]
                    EighthDan,
                    [FileName("9dan.png")]
                    NinthDan,
                    [FileName("10dan.png")]
                    TenthDan,
                    [FileName("kuroto.png")]
                    Kuroto,
                    [FileName("meijin.png")]
                    Meijin,
                    [FileName("chojin.png")]
                    Chojin,
                    [FileName("tatsujin.png")]
                    Tatsujin,
                }
            }

            [Folder("Selected")]
            public static class Selected
            {
                [Folder("Background")]
                public enum Background
                {
                    [FileName("Kyu.png")]
                    Kyu,
                    [FileName("Blue.png")]
                    Blue,
                    [FileName("Red.png")]
                    Red,
                    [FileName("Silver.png")]
                    Silver,
                    [FileName("Gold.png")]
                    Gold,
                }

                [Folder("Difficulty")]
                public enum Difficulty
                {
                    [FileName("Easy.png")]
                    Easy,
                    [FileName("Normal.png")]
                    Normal,
                    [FileName("Hard.png")]
                    Hard,
                    [FileName("Oni.png")]
                    Oni,
                    [FileName("Ura.png")]
                    Ura,
                }

                [Folder("Text")]
                public enum Text
                {
                    [FileName("5kyu.png")]
                    FifthKyu,
                    [FileName("4kyu.png")]
                    FourthKyu,
                    [FileName("3kyu.png")]
                    ThirdKyu,
                    [FileName("2kyu.png")]
                    SecondKyu,
                    [FileName("1kyu.png")]
                    FirstKyu,
                    [FileName("1dan.png")]
                    FirstDan,
                    [FileName("2dan.png")]
                    SecondDan,
                    [FileName("3dan.png")]
                    ThirdDan,
                    [FileName("4dan.png")]
                    FourthDan,
                    [FileName("5dan.png")]
                    FifthDan,
                    [FileName("6dan.png")]
                    SixthDan,
                    [FileName("7dan.png")]
                    SeventhDan,
                    [FileName("8dan.png")]
                    EighthDan,
                    [FileName("9dan.png")]
                    NinthDan,
                    [FileName("10dan.png")]
                    TenthDan,
                    [FileName("kuroto.png")]
                    Kuroto,
                    [FileName("meijin.png")]
                    Meijin,
                    [FileName("chojin.png")]
                    Chojin,
                    [FileName("tatsujin.png")]
                    Tatsujin,
                }
            }

            [Folder("Unselected")]
            public static class Unselected
            {
                [Folder("Background")]
                public enum Background
                {
                    [FileName("Kyu.png")]
                    Kyu,
                    [FileName("Blue.png")]
                    Blue,
                    [FileName("Red.png")]
                    Red,
                    [FileName("Silver.png")]
                    Silver,
                    [FileName("Gold.png")]
                    Gold,
                }

                [Folder("Difficulty")]
                public enum Difficulty
                {
                    [FileName("Easy.png")]
                    Easy,
                    [FileName("Normal.png")]
                    Normal,
                    [FileName("Hard.png")]
                    Hard,
                    [FileName("Oni.png")]
                    Oni,
                    [FileName("Ura.png")]
                    Ura,
                }

                [Folder("Text")]
                public enum Text
                {
                    [FileName("5kyu.png")]
                    FifthKyu,
                    [FileName("4kyu.png")]
                    FourthKyu,
                    [FileName("3kyu.png")]
                    ThirdKyu,
                    [FileName("2kyu.png")]
                    SecondKyu,
                    [FileName("1kyu.png")]
                    FirstKyu,
                    [FileName("1dan.png")]
                    FirstDan,
                    [FileName("2dan.png")]
                    SecondDan,
                    [FileName("3dan.png")]
                    ThirdDan,
                    [FileName("4dan.png")]
                    FourthDan,
                    [FileName("5dan.png")]
                    FifthDan,
                    [FileName("6dan.png")]
                    SixthDan,
                    [FileName("7dan.png")]
                    SeventhDan,
                    [FileName("8dan.png")]
                    EighthDan,
                    [FileName("9dan.png")]
                    NinthDan,
                    [FileName("10dan.png")]
                    TenthDan,
                    [FileName("kuroto.png")]
                    Kuroto,
                    [FileName("meijin.png")]
                    Meijin,
                    [FileName("chojin.png")]
                    Chojin,
                    [FileName("tatsujin.png")]
                    Tatsujin,
                }
            }
        }
    }


}
