// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeAllTextResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeAllTextResponseBodyData Data { get; set; }
        public class RecognizeAllTextResponseBodyData : TeaModel {
            [NameInMap("AlgoServer")]
            [Validation(Required=false)]
            public List<string> AlgoServer { get; set; }

            [NameInMap("AlgoVersion")]
            [Validation(Required=false)]
            public string AlgoVersion { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("DebugInfo")]
            [Validation(Required=false)]
            public object DebugInfo { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("IsMixedMode")]
            [Validation(Required=false)]
            public bool? IsMixedMode { get; set; }

            [NameInMap("KvExcelUrl")]
            [Validation(Required=false)]
            public string KvExcelUrl { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("SubImageCount")]
            [Validation(Required=false)]
            public int? SubImageCount { get; set; }

            [NameInMap("SubImages")]
            [Validation(Required=false)]
            public List<RecognizeAllTextResponseBodyDataSubImages> SubImages { get; set; }
            public class RecognizeAllTextResponseBodyDataSubImages : TeaModel {
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public int? Angle { get; set; }

                [NameInMap("BarCodeInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesBarCodeInfo BarCodeInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfo : TeaModel {
                    [NameInMap("BarCodeCount")]
                    [Validation(Required=false)]
                    public int? BarCodeCount { get; set; }

                    [NameInMap("BarCodeDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetails> BarCodeDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetails : TeaModel {
                        [NameInMap("BarCodeAngle")]
                        [Validation(Required=false)]
                        public int? BarCodeAngle { get; set; }

                        [NameInMap("BarCodePoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodePoints> BarCodePoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodePoints : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("BarCodeRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodeRect BarCodeRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodeRect : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public byte[] Data { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("BlockInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesBlockInfo BlockInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesBlockInfo : TeaModel {
                    [NameInMap("BlockCount")]
                    [Validation(Required=false)]
                    public int? BlockCount { get; set; }

                    [NameInMap("BlockDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetails> BlockDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetails : TeaModel {
                        [NameInMap("BlockAngle")]
                        [Validation(Required=false)]
                        public int? BlockAngle { get; set; }

                        [NameInMap("BlockConfidence")]
                        [Validation(Required=false)]
                        public int? BlockConfidence { get; set; }

                        [NameInMap("BlockContent")]
                        [Validation(Required=false)]
                        public string BlockContent { get; set; }

                        [NameInMap("BlockId")]
                        [Validation(Required=false)]
                        public int? BlockId { get; set; }

                        [NameInMap("BlockPoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockPoints> BlockPoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockPoints : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("BlockRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockRect BlockRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockRect : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("CharInfos")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfos> CharInfos { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfos : TeaModel {
                            [NameInMap("CharConfidence")]
                            [Validation(Required=false)]
                            public int? CharConfidence { get; set; }

                            [NameInMap("CharContent")]
                            [Validation(Required=false)]
                            public string CharContent { get; set; }

                            [NameInMap("CharId")]
                            [Validation(Required=false)]
                            public int? CharId { get; set; }

                            [NameInMap("CharPoints")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharPoints> CharPoints { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharPoints : TeaModel {
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            [NameInMap("CharRect")]
                            [Validation(Required=false)]
                            public RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharRect CharRect { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharRect : TeaModel {
                                [NameInMap("CenterX")]
                                [Validation(Required=false)]
                                public int? CenterX { get; set; }

                                [NameInMap("CenterY")]
                                [Validation(Required=false)]
                                public int? CenterY { get; set; }

                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("DocLayouts")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesDocLayouts> DocLayouts { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesDocLayouts : TeaModel {
                    [NameInMap("LayoutPoints")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesDocLayoutsLayoutPoints> LayoutPoints { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesDocLayoutsLayoutPoints : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("LayoutRect")]
                    [Validation(Required=false)]
                    public RecognizeAllTextResponseBodyDataSubImagesDocLayoutsLayoutRect LayoutRect { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesDocLayoutsLayoutRect : TeaModel {
                        [NameInMap("CenterX")]
                        [Validation(Required=false)]
                        public int? CenterX { get; set; }

                        [NameInMap("CenterY")]
                        [Validation(Required=false)]
                        public int? CenterY { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    [NameInMap("LayoutType")]
                    [Validation(Required=false)]
                    public string LayoutType { get; set; }

                }

                [NameInMap("DocSpecialTexts")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesDocSpecialTexts> DocSpecialTexts { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesDocSpecialTexts : TeaModel {
                    [NameInMap("SpecialTextPos")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesDocSpecialTextsSpecialTextPos> SpecialTextPos { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesDocSpecialTextsSpecialTextPos : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("SpecialTextRect")]
                    [Validation(Required=false)]
                    public RecognizeAllTextResponseBodyDataSubImagesDocSpecialTextsSpecialTextRect SpecialTextRect { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesDocSpecialTextsSpecialTextRect : TeaModel {
                        [NameInMap("CenterX")]
                        [Validation(Required=false)]
                        public int? CenterX { get; set; }

                        [NameInMap("CenterY")]
                        [Validation(Required=false)]
                        public int? CenterY { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    [NameInMap("SpecialTextType")]
                    [Validation(Required=false)]
                    public string SpecialTextType { get; set; }

                }

                [NameInMap("DocSubField")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesDocSubField> DocSubField { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesDocSubField : TeaModel {
                    [NameInMap("SubFieldPos")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesDocSubFieldSubFieldPos> SubFieldPos { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesDocSubFieldSubFieldPos : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("SubFieldRect")]
                    [Validation(Required=false)]
                    public RecognizeAllTextResponseBodyDataSubImagesDocSubFieldSubFieldRect SubFieldRect { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesDocSubFieldSubFieldRect : TeaModel {
                        [NameInMap("CenterX")]
                        [Validation(Required=false)]
                        public int? CenterX { get; set; }

                        [NameInMap("CenterY")]
                        [Validation(Required=false)]
                        public int? CenterY { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    [NameInMap("SubFieldType")]
                    [Validation(Required=false)]
                    public string SubFieldType { get; set; }

                }

                [NameInMap("FigureInfo")]
                [Validation(Required=false)]
                public Dictionary<string, DataSubImagesFigureInfoValue> FigureInfo { get; set; }

                [NameInMap("KvInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesKvInfo KvInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesKvInfo : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public object Data { get; set; }

                    [NameInMap("KvCount")]
                    [Validation(Required=false)]
                    public int? KvCount { get; set; }

                    [NameInMap("KvDetails")]
                    [Validation(Required=false)]
                    public Dictionary<string, DataSubImagesKvInfoKvDetailsValue> KvDetails { get; set; }

                }

                [NameInMap("MathInfos")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesMathInfos> MathInfos { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesMathInfos : TeaModel {
                    [NameInMap("MathInfoPoints")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesMathInfosMathInfoPoints> MathInfoPoints { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesMathInfosMathInfoPoints : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("MathInfoRect")]
                    [Validation(Required=false)]
                    public RecognizeAllTextResponseBodyDataSubImagesMathInfosMathInfoRect MathInfoRect { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesMathInfosMathInfoRect : TeaModel {
                        [NameInMap("CenterX")]
                        [Validation(Required=false)]
                        public int? CenterX { get; set; }

                        [NameInMap("CenterY")]
                        [Validation(Required=false)]
                        public int? CenterY { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("NewStyleData")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesNewStyleData NewStyleData { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesNewStyleData : TeaModel {
                    [NameInMap("DocInfo")]
                    [Validation(Required=false)]
                    public RecognizeAllTextResponseBodyDataSubImagesNewStyleDataDocInfo DocInfo { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesNewStyleDataDocInfo : TeaModel {
                        [NameInMap("Pages")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesNewStyleDataDocInfoPages> Pages { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesNewStyleDataDocInfoPages : TeaModel {
                            [NameInMap("ImageWidth")]
                            [Validation(Required=false)]
                            public int? ImageWidth { get; set; }

                            [NameInMap("InageHeight")]
                            [Validation(Required=false)]
                            public int? InageHeight { get; set; }

                            [NameInMap("PageIdAllDocs")]
                            [Validation(Required=false)]
                            public int? PageIdAllDocs { get; set; }

                            [NameInMap("PageIdCurDoc")]
                            [Validation(Required=false)]
                            public int? PageIdCurDoc { get; set; }

                        }

                    }

                    [NameInMap("LayoutInfos")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesNewStyleDataLayoutInfos> LayoutInfos { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesNewStyleDataLayoutInfos : TeaModel {
                        [NameInMap("Alignment")]
                        [Validation(Required=false)]
                        public string Alignment { get; set; }

                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("LayoutPoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesNewStyleDataLayoutInfosLayoutPoints> LayoutPoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesNewStyleDataLayoutInfosLayoutPoints : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("LayoutRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesNewStyleDataLayoutInfosLayoutRect LayoutRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesNewStyleDataLayoutInfosLayoutRect : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("PageNum")]
                        [Validation(Required=false)]
                        public List<int?> PageNum { get; set; }

                        [NameInMap("Source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        [NameInMap("SubType")]
                        [Validation(Required=false)]
                        public string SubType { get; set; }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("UniqueID")]
                        [Validation(Required=false)]
                        public string UniqueID { get; set; }

                    }

                    [NameInMap("Styles")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesNewStyleDataStyles> Styles { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesNewStyleDataStyles : TeaModel {
                        [NameInMap("Bold")]
                        [Validation(Required=false)]
                        public bool? Bold { get; set; }

                        [NameInMap("CharScale")]
                        [Validation(Required=false)]
                        public float? CharScale { get; set; }

                        [NameInMap("Color")]
                        [Validation(Required=false)]
                        public string Color { get; set; }

                        [NameInMap("DeleteLine")]
                        [Validation(Required=false)]
                        public bool? DeleteLine { get; set; }

                        [NameInMap("FontName")]
                        [Validation(Required=false)]
                        public string FontName { get; set; }

                        [NameInMap("FontSize")]
                        [Validation(Required=false)]
                        public int? FontSize { get; set; }

                        [NameInMap("Italic")]
                        [Validation(Required=false)]
                        public bool? Italic { get; set; }

                        [NameInMap("StyleId")]
                        [Validation(Required=false)]
                        public int? StyleId { get; set; }

                        [NameInMap("Underline")]
                        [Validation(Required=false)]
                        public bool? Underline { get; set; }

                    }

                }

                [NameInMap("PageId")]
                [Validation(Required=false)]
                public int? PageId { get; set; }

                [NameInMap("PageInfos")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesPageInfos> PageInfos { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesPageInfos : TeaModel {
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public int? Angle { get; set; }

                    [NameInMap("DocIndex")]
                    [Validation(Required=false)]
                    public int? DocIndex { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("PageId")]
                    [Validation(Required=false)]
                    public int? PageId { get; set; }

                    [NameInMap("SubjectInfos")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfos> SubjectInfos { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfos : TeaModel {
                        [NameInMap("BlockInfo")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfo BlockInfo { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfo : TeaModel {
                            [NameInMap("BlockCount")]
                            [Validation(Required=false)]
                            public int? BlockCount { get; set; }

                            [NameInMap("BlockDetails")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetails> BlockDetails { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetails : TeaModel {
                                [NameInMap("Angle")]
                                [Validation(Required=false)]
                                public int? Angle { get; set; }

                                [NameInMap("BlockId")]
                                [Validation(Required=false)]
                                public int? BlockId { get; set; }

                                [NameInMap("BlockPoints")]
                                [Validation(Required=false)]
                                public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsBlockPoints> BlockPoints { get; set; }
                                public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsBlockPoints : TeaModel {
                                    [NameInMap("X")]
                                    [Validation(Required=false)]
                                    public int? X { get; set; }

                                    [NameInMap("Y")]
                                    [Validation(Required=false)]
                                    public int? Y { get; set; }

                                }

                                [NameInMap("BlockRect")]
                                [Validation(Required=false)]
                                public RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsBlockRect BlockRect { get; set; }
                                public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsBlockRect : TeaModel {
                                    [NameInMap("CenterX")]
                                    [Validation(Required=false)]
                                    public int? CenterX { get; set; }

                                    [NameInMap("CenterY")]
                                    [Validation(Required=false)]
                                    public int? CenterY { get; set; }

                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public int? Height { get; set; }

                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public int? Width { get; set; }

                                }

                                [NameInMap("CharInfo")]
                                [Validation(Required=false)]
                                public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsCharInfo> CharInfo { get; set; }
                                public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsCharInfo : TeaModel {
                                    [NameInMap("CharId")]
                                    [Validation(Required=false)]
                                    public int? CharId { get; set; }

                                    [NameInMap("CharPoints")]
                                    [Validation(Required=false)]
                                    public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsCharInfoCharPoints> CharPoints { get; set; }
                                    public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsCharInfoCharPoints : TeaModel {
                                        [NameInMap("X")]
                                        [Validation(Required=false)]
                                        public int? X { get; set; }

                                        [NameInMap("Y")]
                                        [Validation(Required=false)]
                                        public int? Y { get; set; }

                                    }

                                    [NameInMap("CharRect")]
                                    [Validation(Required=false)]
                                    public RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsCharInfoCharRect CharRect { get; set; }
                                    public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosBlockInfoBlockDetailsCharInfoCharRect : TeaModel {
                                        [NameInMap("CenterX")]
                                        [Validation(Required=false)]
                                        public int? CenterX { get; set; }

                                        [NameInMap("CenterY")]
                                        [Validation(Required=false)]
                                        public int? CenterY { get; set; }

                                        [NameInMap("Height")]
                                        [Validation(Required=false)]
                                        public int? Height { get; set; }

                                        [NameInMap("Width")]
                                        [Validation(Required=false)]
                                        public int? Width { get; set; }

                                    }

                                    [NameInMap("Confidence")]
                                    [Validation(Required=false)]
                                    public int? Confidence { get; set; }

                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                }

                                [NameInMap("Confidence")]
                                [Validation(Required=false)]
                                public int? Confidence { get; set; }

                                [NameInMap("Content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                            }

                        }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("ContentInfos")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosContentInfos> ContentInfos { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosContentInfos : TeaModel {
                            [NameInMap("ContentPoints")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosContentInfosContentPoints> ContentPoints { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosContentInfosContentPoints : TeaModel {
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            [NameInMap("ContentRect")]
                            [Validation(Required=false)]
                            public RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosContentInfosContentRect ContentRect { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesPageInfosSubjectInfosContentInfosContentRect : TeaModel {
                                [NameInMap("CenterX")]
                                [Validation(Required=false)]
                                public int? CenterX { get; set; }

                                [NameInMap("CenterY")]
                                [Validation(Required=false)]
                                public int? CenterY { get; set; }

                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            [NameInMap("DocIndex")]
                            [Validation(Required=false)]
                            public int? DocIndex { get; set; }

                        }

                        [NameInMap("Ids")]
                        [Validation(Required=false)]
                        public List<int?> Ids { get; set; }

                        [NameInMap("IsMultiPage")]
                        [Validation(Required=false)]
                        public bool? IsMultiPage { get; set; }

                    }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("PageTitle")]
                [Validation(Required=false)]
                public string PageTitle { get; set; }

                [NameInMap("ParagraphInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesParagraphInfo ParagraphInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesParagraphInfo : TeaModel {
                    [NameInMap("ParagraphCount")]
                    [Validation(Required=false)]
                    public int? ParagraphCount { get; set; }

                    [NameInMap("ParagraphDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesParagraphInfoParagraphDetails> ParagraphDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesParagraphInfoParagraphDetails : TeaModel {
                        [NameInMap("BlockList")]
                        [Validation(Required=false)]
                        public List<int?> BlockList { get; set; }

                        [NameInMap("ParagraphContent")]
                        [Validation(Required=false)]
                        public string ParagraphContent { get; set; }

                        [NameInMap("ParagraphId")]
                        [Validation(Required=false)]
                        public int? ParagraphId { get; set; }

                    }

                }

                [NameInMap("PartInfos")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesPartInfos> PartInfos { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesPartInfos : TeaModel {
                    [NameInMap("PartInfoPointsList")]
                    [Validation(Required=false)]
                    public List<List<RecognizeAllTextResponseBodyDataSubImagesPartInfosPartInfoPointsList>> PartInfoPointsList { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesPartInfosPartInfoPointsList : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public int? X { get; set; }

                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public int? Y { get; set; }

                    }

                    [NameInMap("PartInfoRectList")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosPartInfoRectList> PartInfoRectList { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesPartInfosPartInfoRectList : TeaModel {
                        [NameInMap("CenterX")]
                        [Validation(Required=false)]
                        public int? CenterX { get; set; }

                        [NameInMap("CenterY")]
                        [Validation(Required=false)]
                        public int? CenterY { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public int? Height { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public int? Width { get; set; }

                    }

                    [NameInMap("PartTitle")]
                    [Validation(Required=false)]
                    public string PartTitle { get; set; }

                    [NameInMap("SubjectList")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectList> SubjectList { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectList : TeaModel {
                        [NameInMap("AnswerPointsList")]
                        [Validation(Required=false)]
                        public List<List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListAnswerPointsList>> AnswerPointsList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListAnswerPointsList : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("AnswerRectList")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListAnswerRectList> AnswerRectList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListAnswerRectList : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public int? Confidence { get; set; }

                        [NameInMap("Elements")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElements> Elements { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElements : TeaModel {
                            [NameInMap("Contents")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsContents> Contents { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsContents : TeaModel {
                                [NameInMap("Confidence")]
                                [Validation(Required=false)]
                                public int? Confidence { get; set; }

                                [NameInMap("ContentPoints")]
                                [Validation(Required=false)]
                                public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsContentsContentPoints> ContentPoints { get; set; }
                                public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsContentsContentPoints : TeaModel {
                                    [NameInMap("X")]
                                    [Validation(Required=false)]
                                    public int? X { get; set; }

                                    [NameInMap("Y")]
                                    [Validation(Required=false)]
                                    public int? Y { get; set; }

                                }

                                [NameInMap("ContentRect")]
                                [Validation(Required=false)]
                                public RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsContentsContentRect ContentRect { get; set; }
                                public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsContentsContentRect : TeaModel {
                                    [NameInMap("CenterX")]
                                    [Validation(Required=false)]
                                    public int? CenterX { get; set; }

                                    [NameInMap("CenterY")]
                                    [Validation(Required=false)]
                                    public int? CenterY { get; set; }

                                    [NameInMap("Height")]
                                    [Validation(Required=false)]
                                    public int? Height { get; set; }

                                    [NameInMap("Width")]
                                    [Validation(Required=false)]
                                    public int? Width { get; set; }

                                }

                                [NameInMap("ContentType")]
                                [Validation(Required=false)]
                                public int? ContentType { get; set; }

                                [NameInMap("Option")]
                                [Validation(Required=false)]
                                public string Option { get; set; }

                                [NameInMap("Text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                            }

                            [NameInMap("ElementPointsList")]
                            [Validation(Required=false)]
                            public List<List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsElementPointsList>> ElementPointsList { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsElementPointsList : TeaModel {
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            [NameInMap("ElementRectList")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsElementRectList> ElementRectList { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListElementsElementRectList : TeaModel {
                                [NameInMap("CenterX")]
                                [Validation(Required=false)]
                                public int? CenterX { get; set; }

                                [NameInMap("CenterY")]
                                [Validation(Required=false)]
                                public int? CenterY { get; set; }

                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            [NameInMap("ElementType")]
                            [Validation(Required=false)]
                            public int? ElementType { get; set; }

                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                        [NameInMap("FigurePointsList")]
                        [Validation(Required=false)]
                        public List<List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListFigurePointsList>> FigurePointsList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListFigurePointsList : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("FigureRectList")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListFigureRectList> FigureRectList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListFigureRectList : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("Index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("NumChoices")]
                        [Validation(Required=false)]
                        public int? NumChoices { get; set; }

                        [NameInMap("SubjectPointsList")]
                        [Validation(Required=false)]
                        public List<List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListSubjectPointsList>> SubjectPointsList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListSubjectPointsList : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("SubjectRectList")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListSubjectRectList> SubjectRectList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListSubjectRectList : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public string CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public string CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                        [NameInMap("SubjectType")]
                        [Validation(Required=false)]
                        public int? SubjectType { get; set; }

                        [NameInMap("TablePointsList")]
                        [Validation(Required=false)]
                        public List<List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListTablePointsList>> TablePointsList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListTablePointsList : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("TableRectList")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListTableRectList> TableRectList { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesPartInfosSubjectListTableRectList : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                [NameInMap("QrCodeInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesQrCodeInfo QrCodeInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfo : TeaModel {
                    [NameInMap("QrCodeCount")]
                    [Validation(Required=false)]
                    public int? QrCodeCount { get; set; }

                    [NameInMap("QrCodeDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetails> QrCodeDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetails : TeaModel {
                        [NameInMap("Angle")]
                        [Validation(Required=false)]
                        public int? Angle { get; set; }

                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public byte[] Data { get; set; }

                        [NameInMap("QrCodePoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodePoints> QrCodePoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodePoints : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("QrCodeRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodeRect QrCodeRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodeRect : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("QualityInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesQualityInfo QualityInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesQualityInfo : TeaModel {
                    [NameInMap("CompletenessScore")]
                    [Validation(Required=false)]
                    public float? CompletenessScore { get; set; }

                    [NameInMap("IsCopy")]
                    [Validation(Required=false)]
                    public bool? IsCopy { get; set; }

                    [NameInMap("IsReshoot")]
                    [Validation(Required=false)]
                    public bool? IsReshoot { get; set; }

                    [NameInMap("QualityScore")]
                    [Validation(Required=false)]
                    public float? QualityScore { get; set; }

                    [NameInMap("TamperScore")]
                    [Validation(Required=false)]
                    public float? TamperScore { get; set; }

                }

                [NameInMap("RowInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesRowInfo RowInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesRowInfo : TeaModel {
                    [NameInMap("RowCount")]
                    [Validation(Required=false)]
                    public int? RowCount { get; set; }

                    [NameInMap("RowDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesRowInfoRowDetails> RowDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesRowInfoRowDetails : TeaModel {
                        [NameInMap("BlockList")]
                        [Validation(Required=false)]
                        public List<int?> BlockList { get; set; }

                        [NameInMap("RowContent")]
                        [Validation(Required=false)]
                        public string RowContent { get; set; }

                        [NameInMap("RowId")]
                        [Validation(Required=false)]
                        public int? RowId { get; set; }

                    }

                }

                [NameInMap("StampInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesStampInfo StampInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesStampInfo : TeaModel {
                    [NameInMap("StampCount")]
                    [Validation(Required=false)]
                    public int? StampCount { get; set; }

                    [NameInMap("StampDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetails> StampDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetails : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsData Data { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsData : TeaModel {
                            [NameInMap("AntiFakeCode")]
                            [Validation(Required=false)]
                            public string AntiFakeCode { get; set; }

                            [NameInMap("CompanyId")]
                            [Validation(Required=false)]
                            public string CompanyId { get; set; }

                            [NameInMap("OrganizationName")]
                            [Validation(Required=false)]
                            public string OrganizationName { get; set; }

                            [NameInMap("OrganizationNameEng")]
                            [Validation(Required=false)]
                            public string OrganizationNameEng { get; set; }

                            [NameInMap("OtherText")]
                            [Validation(Required=false)]
                            public string OtherText { get; set; }

                            [NameInMap("TaxpayerId")]
                            [Validation(Required=false)]
                            public string TaxpayerId { get; set; }

                            [NameInMap("TopText")]
                            [Validation(Required=false)]
                            public string TopText { get; set; }

                        }

                        [NameInMap("StampAngle")]
                        [Validation(Required=false)]
                        public int? StampAngle { get; set; }

                        [NameInMap("StampPoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampPoints> StampPoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampPoints : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("StampRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampRect StampRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampRect : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                    }

                }

                [NameInMap("SubImageId")]
                [Validation(Required=false)]
                public int? SubImageId { get; set; }

                [NameInMap("SubImagePoints")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesSubImagePoints> SubImagePoints { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesSubImagePoints : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

                [NameInMap("SubImageRect")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesSubImageRect SubImageRect { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesSubImageRect : TeaModel {
                    [NameInMap("CenterX")]
                    [Validation(Required=false)]
                    public int? CenterX { get; set; }

                    [NameInMap("CenterY")]
                    [Validation(Required=false)]
                    public int? CenterY { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("TableInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesTableInfo TableInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesTableInfo : TeaModel {
                    [NameInMap("TableCount")]
                    [Validation(Required=false)]
                    public int? TableCount { get; set; }

                    [NameInMap("TableDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetails> TableDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetails : TeaModel {
                        [NameInMap("CellCount")]
                        [Validation(Required=false)]
                        public int? CellCount { get; set; }

                        [NameInMap("CellDetails")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetails> CellDetails { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetails : TeaModel {
                            [NameInMap("BlockList")]
                            [Validation(Required=false)]
                            public List<int?> BlockList { get; set; }

                            [NameInMap("CellAngle")]
                            [Validation(Required=false)]
                            public int? CellAngle { get; set; }

                            [NameInMap("CellContent")]
                            [Validation(Required=false)]
                            public string CellContent { get; set; }

                            [NameInMap("CellId")]
                            [Validation(Required=false)]
                            public int? CellId { get; set; }

                            [NameInMap("CellPoints")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellPoints> CellPoints { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellPoints : TeaModel {
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            [NameInMap("CellRect")]
                            [Validation(Required=false)]
                            public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellRect CellRect { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellRect : TeaModel {
                                [NameInMap("CenterX")]
                                [Validation(Required=false)]
                                public int? CenterX { get; set; }

                                [NameInMap("CenterY")]
                                [Validation(Required=false)]
                                public int? CenterY { get; set; }

                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            [NameInMap("ColumnEnd")]
                            [Validation(Required=false)]
                            public int? ColumnEnd { get; set; }

                            [NameInMap("ColumnStart")]
                            [Validation(Required=false)]
                            public int? ColumnStart { get; set; }

                            [NameInMap("RowEnd")]
                            [Validation(Required=false)]
                            public int? RowEnd { get; set; }

                            [NameInMap("RowStart")]
                            [Validation(Required=false)]
                            public int? RowStart { get; set; }

                        }

                        [NameInMap("ColumnCount")]
                        [Validation(Required=false)]
                        public int? ColumnCount { get; set; }

                        [NameInMap("Footer")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsFooter Footer { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsFooter : TeaModel {
                            [NameInMap("BlockId")]
                            [Validation(Required=false)]
                            public int? BlockId { get; set; }

                            [NameInMap("Contents")]
                            [Validation(Required=false)]
                            public List<string> Contents { get; set; }

                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsFooterPoints> Points { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsFooterPoints : TeaModel {
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                        }

                        [NameInMap("Header")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsHeader Header { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsHeader : TeaModel {
                            [NameInMap("BlockId")]
                            [Validation(Required=false)]
                            public int? BlockId { get; set; }

                            [NameInMap("Contents")]
                            [Validation(Required=false)]
                            public List<string> Contents { get; set; }

                            [NameInMap("Points")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsHeaderPoints> Points { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsHeaderPoints : TeaModel {
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                        }

                        [NameInMap("RowCount")]
                        [Validation(Required=false)]
                        public int? RowCount { get; set; }

                        [NameInMap("TableId")]
                        [Validation(Required=false)]
                        public int? TableId { get; set; }

                        [NameInMap("TablePoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTablePoints> TablePoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTablePoints : TeaModel {
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("TableRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTableRect TableRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTableRect : TeaModel {
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                    }

                    [NameInMap("TableExcel")]
                    [Validation(Required=false)]
                    public string TableExcel { get; set; }

                    [NameInMap("TableHtml")]
                    [Validation(Required=false)]
                    public string TableHtml { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            [NameInMap("XmlResult")]
            [Validation(Required=false)]
            public string XmlResult { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
