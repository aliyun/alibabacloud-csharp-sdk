// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class RecognizePublicFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizePublicFaceResponseBodyData Data { get; set; }
        public class RecognizePublicFaceResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizePublicFaceResponseBodyDataElements> Elements { get; set; }
            public class RecognizePublicFaceResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/facebody/xxx.jpg">https://viapi-oss.oss-cn-shanghai.aliyuncs.com/doc/facebody/xxx.jpg</a></para>
                /// </summary>
                [NameInMap("ImageURL")]
                [Validation(Required=false)]
                public string ImageURL { get; set; }

                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<RecognizePublicFaceResponseBodyDataElementsResults> Results { get; set; }
                public class RecognizePublicFaceResponseBodyDataElementsResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sface</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>98.35</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    [NameInMap("SubResults")]
                    [Validation(Required=false)]
                    public List<RecognizePublicFaceResponseBodyDataElementsResultsSubResults> SubResults { get; set; }
                    public class RecognizePublicFaceResponseBodyDataElementsResultsSubResults : TeaModel {
                        [NameInMap("Faces")]
                        [Validation(Required=false)]
                        public List<RecognizePublicFaceResponseBodyDataElementsResultsSubResultsFaces> Faces { get; set; }
                        public class RecognizePublicFaceResponseBodyDataElementsResultsSubResultsFaces : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>AliFace_0006272</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>98.35</para>
                            /// </summary>
                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public float? Rate { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>153</para>
                        /// </summary>
                        [NameInMap("H")]
                        [Validation(Required=false)]
                        public float? H { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>132</para>
                        /// </summary>
                        [NameInMap("W")]
                        [Validation(Required=false)]
                        public float? W { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>182</para>
                        /// </summary>
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public float? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>153</para>
                        /// </summary>
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public float? Y { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>review</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>img3dhYqt1e4wO77Wnf2y@t@E-1tYAEt</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AC4D107C-29E3-4873-A719-0D2217EA28A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
