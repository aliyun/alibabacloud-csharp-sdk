// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ImageBatchModerationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageBatchModerationResponseBodyData Data { get; set; }
        public class ImageBatchModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResult> Result { get; set; }
            public class ImageBatchModerationResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>81.22</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>violent_explosion</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ImageBatchModerationResponseBodyDataResults> Results { get; set; }
            public class ImageBatchModerationResponseBodyDataResults : TeaModel {
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public ImageBatchModerationResponseBodyDataResultsExt Ext { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsExt : TeaModel {
                    [NameInMap("CustomImage")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtCustomImage> CustomImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtCustomImage : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1965304870002</para>
                        /// </summary>
                        [NameInMap("LibId")]
                        [Validation(Required=false)]
                        public string LibId { get; set; }

                        [NameInMap("LibName")]
                        [Validation(Required=false)]
                        public string LibName { get; set; }

                    }

                    [NameInMap("LogoData")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtLogoData LogoData { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtLogoData : TeaModel {
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public ImageBatchModerationResponseBodyDataResultsExtLogoDataLocation Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLocation : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                        [NameInMap("Logo")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo> Logo { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtLogoDataLogo : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>99.1</para>
                            /// </summary>
                            [NameInMap("Confidence")]
                            [Validation(Required=false)]
                            public float? Confidence { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>logo_sns</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    [NameInMap("PublicFigure")]
                    [Validation(Required=false)]
                    public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigure> PublicFigure { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtPublicFigure : TeaModel {
                        [NameInMap("FigureId")]
                        [Validation(Required=false)]
                        public string FigureId { get; set; }

                        [NameInMap("FigureName")]
                        [Validation(Required=false)]
                        public string FigureName { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation> Location { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtPublicFigureLocation : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>440</para>
                            /// </summary>
                            [NameInMap("H")]
                            [Validation(Required=false)]
                            public int? H { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>330</para>
                            /// </summary>
                            [NameInMap("W")]
                            [Validation(Required=false)]
                            public int? W { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>11</para>
                            /// </summary>
                            [NameInMap("X")]
                            [Validation(Required=false)]
                            public int? X { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>22</para>
                            /// </summary>
                            [NameInMap("Y")]
                            [Validation(Required=false)]
                            public int? Y { get; set; }

                        }

                    }

                    [NameInMap("TextInImage")]
                    [Validation(Required=false)]
                    public ImageBatchModerationResponseBodyDataResultsExtTextInImage TextInImage { get; set; }
                    public class ImageBatchModerationResponseBodyDataResultsExtTextInImage : TeaModel {
                        [NameInMap("CustomText")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText> CustomText { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageCustomText : TeaModel {
                            [NameInMap("KeyWords")]
                            [Validation(Required=false)]
                            public string KeyWords { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>123456</para>
                            /// </summary>
                            [NameInMap("LibId")]
                            [Validation(Required=false)]
                            public string LibId { get; set; }

                            [NameInMap("LibName")]
                            [Validation(Required=false)]
                            public string LibName { get; set; }

                        }

                        [NameInMap("OcrResult")]
                        [Validation(Required=false)]
                        public List<ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult> OcrResult { get; set; }
                        public class ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResult : TeaModel {
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResultLocation Location { get; set; }
                            public class ImageBatchModerationResponseBodyDataResultsExtTextInImageOcrResultLocation : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>33</para>
                                /// </summary>
                                [NameInMap("H")]
                                [Validation(Required=false)]
                                public int? H { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>44</para>
                                /// </summary>
                                [NameInMap("W")]
                                [Validation(Required=false)]
                                public int? W { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>11</para>
                                /// </summary>
                                [NameInMap("X")]
                                [Validation(Required=false)]
                                public int? X { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>22</para>
                                /// </summary>
                                [NameInMap("Y")]
                                [Validation(Required=false)]
                                public int? Y { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>abcd</para>
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                        [NameInMap("RiskWord")]
                        [Validation(Required=false)]
                        public List<string> RiskWord { get; set; }

                    }

                }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<ImageBatchModerationResponseBodyDataResultsResult> Result { get; set; }
                public class ImageBatchModerationResponseBodyDataResultsResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>81.22</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>violent_explosion</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>baselineCheck</para>
                /// </summary>
                [NameInMap("Service")]
                [Validation(Required=false)]
                public string Service { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6CF2815C-C8C7-4A01-B52E-FF6E24F53492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
