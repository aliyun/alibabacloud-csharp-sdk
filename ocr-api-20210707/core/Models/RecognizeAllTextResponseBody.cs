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
                        public object Data { get; set; }

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
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public object Data { get; set; }

                        [NameInMap("QrCodeAngle")]
                        [Validation(Required=false)]
                        public int? QrCodeAngle { get; set; }

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
