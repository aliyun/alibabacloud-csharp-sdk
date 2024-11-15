// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeAllTextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("AlgoVersion")]
            [Validation(Required=false)]
            public string AlgoVersion { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("DebugInfo")]
            [Validation(Required=false)]
            public object DebugInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsMixedMode")]
            [Validation(Required=false)]
            public bool? IsMixedMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.xlsx">https://example.xlsx</a></para>
            /// </summary>
            [NameInMap("KvExcelUrl")]
            [Validation(Required=false)]
            public string KvExcelUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SubImageCount")]
            [Validation(Required=false)]
            public int? SubImageCount { get; set; }

            [NameInMap("SubImages")]
            [Validation(Required=false)]
            public List<RecognizeAllTextResponseBodyDataSubImages> SubImages { get; set; }
            public class RecognizeAllTextResponseBodyDataSubImages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public int? Angle { get; set; }

                [NameInMap("BarCodeInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesBarCodeInfo BarCodeInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("BarCodeCount")]
                    [Validation(Required=false)]
                    public int? BarCodeCount { get; set; }

                    [NameInMap("BarCodeDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetails> BarCodeDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BarCodeAngle")]
                        [Validation(Required=false)]
                        public int? BarCodeAngle { get; set; }

                        [NameInMap("BarCodePoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodePoints> BarCodePoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodePoints : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("BarCodeRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodeRect BarCodeRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBarCodeInfoBarCodeDetailsBarCodeRect : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>&quot;1100011XXXXXX&quot;</para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public object Data { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Code128</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("BlockInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesBlockInfo BlockInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesBlockInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("BlockCount")]
                    [Validation(Required=false)]
                    public int? BlockCount { get; set; }

                    [NameInMap("BlockDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetails> BlockDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BlockAngle")]
                        [Validation(Required=false)]
                        public int? BlockAngle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>98</para>
                        /// </summary>
                        [NameInMap("BlockConfidence")]
                        [Validation(Required=false)]
                        public int? BlockConfidence { get; set; }

                        [NameInMap("BlockContent")]
                        [Validation(Required=false)]
                        public string BlockContent { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("BlockId")]
                        [Validation(Required=false)]
                        public int? BlockId { get; set; }

                        [NameInMap("BlockPoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockPoints> BlockPoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockPoints : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("BlockRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockRect BlockRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsBlockRect : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                        [NameInMap("CharInfos")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfos> CharInfos { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfos : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>95</para>
                            /// </summary>
                            [NameInMap("CharConfidence")]
                            [Validation(Required=false)]
                            public int? CharConfidence { get; set; }

                            [NameInMap("CharContent")]
                            [Validation(Required=false)]
                            public string CharContent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("CharId")]
                            [Validation(Required=false)]
                            public int? CharId { get; set; }

                            [NameInMap("CharPoints")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharPoints> CharPoints { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharPoints : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>200</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            [NameInMap("CharRect")]
                            [Validation(Required=false)]
                            public RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharRect CharRect { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesBlockInfoBlockDetailsCharInfosCharRect : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("CenterX")]
                                [Validation(Required=false)]
                                public int? CenterX { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>200</para>
                                /// </summary>
                                [NameInMap("CenterY")]
                                [Validation(Required=false)]
                                public int? CenterY { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ParagraphId")]
                        [Validation(Required=false)]
                        public int? ParagraphId { get; set; }

                    }

                }

                [NameInMap("QrCodeInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesQrCodeInfo QrCodeInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("QrCodeCount")]
                    [Validation(Required=false)]
                    public int? QrCodeCount { get; set; }

                    [NameInMap("QrCodeDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetails> QrCodeDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>“<a href="http://www.gsxt.gov.cn/indeXXX%E2%80%9D">http://www.gsxt.gov.cn/indeXXX”</a></para>
                        /// </summary>
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public object Data { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("QrCodeAngle")]
                        [Validation(Required=false)]
                        public int? QrCodeAngle { get; set; }

                        [NameInMap("QrCodePoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodePoints> QrCodePoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodePoints : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("QrCodeRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodeRect QrCodeRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesQrCodeInfoQrCodeDetailsQrCodeRect : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>90.5</para>
                    /// </summary>
                    [NameInMap("CompletenessScore")]
                    [Validation(Required=false)]
                    public float? CompletenessScore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCopy")]
                    [Validation(Required=false)]
                    public bool? IsCopy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsReshoot")]
                    [Validation(Required=false)]
                    public bool? IsReshoot { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80.5</para>
                    /// </summary>
                    [NameInMap("QualityScore")]
                    [Validation(Required=false)]
                    public float? QualityScore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10.5</para>
                    /// </summary>
                    [NameInMap("TamperScore")]
                    [Validation(Required=false)]
                    public float? TamperScore { get; set; }

                }

                [NameInMap("RowInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesRowInfo RowInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesRowInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RowId")]
                        [Validation(Required=false)]
                        public int? RowId { get; set; }

                    }

                }

                [NameInMap("StampInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesStampInfo StampInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesStampInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>&quot;3205823XXXXXX&quot;</para>
                            /// </summary>
                            [NameInMap("AntiFakeCode")]
                            [Validation(Required=false)]
                            public string AntiFakeCode { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>&quot;XXX&quot;</para>
                            /// </summary>
                            [NameInMap("CompanyId")]
                            [Validation(Required=false)]
                            public string CompanyId { get; set; }

                            [NameInMap("OrganizationName")]
                            [Validation(Required=false)]
                            public string OrganizationName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>&quot;&quot;</para>
                            /// </summary>
                            [NameInMap("OrganizationNameEng")]
                            [Validation(Required=false)]
                            public string OrganizationNameEng { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>&quot;3205823XXXXXX&quot;</para>
                            /// </summary>
                            [NameInMap("OtherText")]
                            [Validation(Required=false)]
                            public string OtherText { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>&quot;&quot;</para>
                            /// </summary>
                            [NameInMap("TaxpayerId")]
                            [Validation(Required=false)]
                            public string TaxpayerId { get; set; }

                            [NameInMap("TopText")]
                            [Validation(Required=false)]
                            public string TopText { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("StampAngle")]
                        [Validation(Required=false)]
                        public int? StampAngle { get; set; }

                        [NameInMap("StampPoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampPoints> StampPoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampPoints : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("StampRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampRect StampRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesStampInfoStampDetailsStampRect : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubImageId")]
                [Validation(Required=false)]
                public int? SubImageId { get; set; }

                [NameInMap("SubImagePoints")]
                [Validation(Required=false)]
                public List<RecognizeAllTextResponseBodyDataSubImagesSubImagePoints> SubImagePoints { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesSubImagePoints : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

                [NameInMap("SubImageRect")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesSubImageRect SubImageRect { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesSubImageRect : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CenterX")]
                    [Validation(Required=false)]
                    public int? CenterX { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("CenterY")]
                    [Validation(Required=false)]
                    public int? CenterY { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("TableInfo")]
                [Validation(Required=false)]
                public RecognizeAllTextResponseBodyDataSubImagesTableInfo TableInfo { get; set; }
                public class RecognizeAllTextResponseBodyDataSubImagesTableInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("TableCount")]
                    [Validation(Required=false)]
                    public int? TableCount { get; set; }

                    [NameInMap("TableDetails")]
                    [Validation(Required=false)]
                    public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetails> TableDetails { get; set; }
                    public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>29</para>
                        /// </summary>
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

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("CellAngle")]
                            [Validation(Required=false)]
                            public int? CellAngle { get; set; }

                            [NameInMap("CellContent")]
                            [Validation(Required=false)]
                            public string CellContent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("CellId")]
                            [Validation(Required=false)]
                            public int? CellId { get; set; }

                            [NameInMap("CellPoints")]
                            [Validation(Required=false)]
                            public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellPoints> CellPoints { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellPoints : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>200</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            [NameInMap("CellRect")]
                            [Validation(Required=false)]
                            public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellRect CellRect { get; set; }
                            public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsCellDetailsCellRect : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("CenterX")]
                                [Validation(Required=false)]
                                public int? CenterX { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>200</para>
                                /// </summary>
                                [NameInMap("CenterY")]
                                [Validation(Required=false)]
                                public int? CenterY { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("Height")]
                                [Validation(Required=false)]
                                public int? Height { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("Width")]
                                [Validation(Required=false)]
                                public int? Width { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>5</para>
                            /// </summary>
                            [NameInMap("ColumnEnd")]
                            [Validation(Required=false)]
                            public int? ColumnEnd { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("ColumnStart")]
                            [Validation(Required=false)]
                            public int? ColumnStart { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("RowEnd")]
                            [Validation(Required=false)]
                            public int? RowEnd { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("RowStart")]
                            [Validation(Required=false)]
                            public int? RowStart { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("ColumnCount")]
                        [Validation(Required=false)]
                        public int? ColumnCount { get; set; }

                        [NameInMap("Footer")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsFooter Footer { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsFooter : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
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
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("BlockId")]
                            [Validation(Required=false)]
                            public int? BlockId { get; set; }

                            [NameInMap("Contents")]
                            [Validation(Required=false)]
                            public List<string> Contents { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("RowCount")]
                        [Validation(Required=false)]
                        public int? RowCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("TableId")]
                        [Validation(Required=false)]
                        public int? TableId { get; set; }

                        [NameInMap("TablePoints")]
                        [Validation(Required=false)]
                        public List<RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTablePoints> TablePoints { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTablePoints : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("TableRect")]
                        [Validation(Required=false)]
                        public RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTableRect TableRect { get; set; }
                        public class RecognizeAllTextResponseBodyDataSubImagesTableInfoTableDetailsTableRect : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("CenterX")]
                            [Validation(Required=false)]
                            public int? CenterX { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>200</para>
                            /// </summary>
                            [NameInMap("CenterY")]
                            [Validation(Required=false)]
                            public int? CenterY { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public int? Height { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public int? Width { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.xlsx">https://example.xlsx</a></para>
                    /// </summary>
                    [NameInMap("TableExcel")]
                    [Validation(Required=false)]
                    public string TableExcel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.html">https://example.html</a></para>
                    /// </summary>
                    [NameInMap("TableHtml")]
                    [Validation(Required=false)]
                    public string TableHtml { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("XmlResult")]
            [Validation(Required=false)]
            public string XmlResult { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>illegalImageUrl</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E2A98925-DC2C-18FB-995F-BAF507XXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
