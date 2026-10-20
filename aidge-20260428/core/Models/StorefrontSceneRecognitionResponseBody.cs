// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class StorefrontSceneRecognitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The scene recognition result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StorefrontSceneRecognitionResponseBodyData Data { get; set; }
        public class StorefrontSceneRecognitionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The scene recognition result details.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public StorefrontSceneRecognitionResponseBodyDataResult Result { get; set; }
            public class StorefrontSceneRecognitionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The classification details. This can be an empty array.</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<StorefrontSceneRecognitionResponseBodyDataResultDetails> Details { get; set; }
                public class StorefrontSceneRecognitionResponseBodyDataResultDetails : TeaModel {
                    /// <summary>
                    /// <para>The non-empty category name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oppo vivo smartphone specialty store</para>
                    /// </summary>
                    [NameInMap("Clazz")]
                    [Validation(Required=false)]
                    public string Clazz { get; set; }

                    /// <summary>
                    /// <para>A finite numerical value. The source document does not specify a value range.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.99</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                }

                /// <summary>
                /// <para>The localization information.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public StorefrontSceneRecognitionResponseBodyDataResultGrounding Grounding { get; set; }
                public class StorefrontSceneRecognitionResponseBodyDataResultGrounding : TeaModel {
                    /// <summary>
                    /// <para>The coverage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>partial</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The region list.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<StorefrontSceneRecognitionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class StorefrontSceneRecognitionResponseBodyDataResultGroundingRegions : TeaModel {
                        /// <summary>
                        /// <para>The bounding box coordinates.</para>
                        /// </summary>
                        [NameInMap("Bbox2d")]
                        [Validation(Required=false)]
                        public List<float?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>store_sign</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The recognized text.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oppo</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                /// <summary>
                /// <para>The non-empty scene classification array.</para>
                /// </summary>
                [NameInMap("Scenes")]
                [Validation(Required=false)]
                public List<string> Scenes { get; set; }

            }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The returned message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
