// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScanImageResponseBodyData Data { get; set; }
        public class ScanImageResponseBodyData : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ScanImageResponseBodyDataResults> Results { get; set; }
            public class ScanImageResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>uuid-xxxx-xxx-1234</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xxx.xxx.xxx/xxx.jpg">http://xxx.xxx.xxx/xxx.jpg</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("SubResults")]
                [Validation(Required=false)]
                public List<ScanImageResponseBodyDataResultsSubResults> SubResults { get; set; }
                public class ScanImageResponseBodyDataResultsSubResults : TeaModel {
                    [NameInMap("Frames")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsFrames> Frames { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsFrames : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>89.85</para>
                        /// </summary>
                        [NameInMap("Rate")]
                        [Validation(Required=false)]
                        public float? Rate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="http://xxx.xxx.com/xxx-0.jpg">http://xxx.xxx.com/xxx-0.jpg</a></para>
                        /// </summary>
                        [NameInMap("URL")]
                        [Validation(Required=false)]
                        public string URL { get; set; }

                    }

                    [NameInMap("HintWordsInfoList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsHintWordsInfoList> HintWordsInfoList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsHintWordsInfoList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>abc</para>
                        /// </summary>
                        [NameInMap("Context")]
                        [Validation(Required=false)]
                        public string Context { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("LogoDataList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsLogoDataList> LogoDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsLogoDataList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>106</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>abc</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TV</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>106</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>140</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>68</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OCRDataList")]
                    [Validation(Required=false)]
                    public List<string> OCRDataList { get; set; }

                    [NameInMap("ProgramCodeDataList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsProgramCodeDataList> ProgramCodeDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsProgramCodeDataList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>413.0</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>402.0</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11.0</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ad</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    [NameInMap("SfaceDataList")]
                    [Validation(Required=false)]
                    public List<ScanImageResponseBodyDataResultsSubResultsSfaceDataList> SfaceDataList { get; set; }
                    public class ScanImageResponseBodyDataResultsSubResultsSfaceDataList : TeaModel {
                        [NameInMap("Faces")]
                        [Validation(Required=false)]
                        public List<ScanImageResponseBodyDataResultsSubResultsSfaceDataListFaces> Faces { get; set; }
                        public class ScanImageResponseBodyDataResultsSubResultsSfaceDataListFaces : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>AliFace_0001234</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>abc</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>91.54</para>
                            /// </summary>
                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public float? Rate { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>131</para>
                        /// </summary>
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public float? Height { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>97</para>
                        /// </summary>
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>49</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>39</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>img4wlJcb7p4wH4lAP3111111-123456</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69B41AE8-1234-1234-1234-12D395695D2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
