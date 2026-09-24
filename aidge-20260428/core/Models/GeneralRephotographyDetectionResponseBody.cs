// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class GeneralRephotographyDetectionResponseBody : TeaModel {
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
        /// <para>The recapture detection result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GeneralRephotographyDetectionResponseBodyData Data { get; set; }
        public class GeneralRephotographyDetectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business result. This value is an empty object if the request fails.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GeneralRephotographyDetectionResponseBodyDataResult Result { get; set; }
            public class GeneralRephotographyDetectionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The supplementary element localization result.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public GeneralRephotographyDetectionResponseBodyDataResultGrounding Grounding { get; set; }
                public class GeneralRephotographyDetectionResponseBodyDataResultGrounding : TeaModel {
                    /// <summary>
                    /// <para>The coverage of the localization. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>complete: All relevant visible targets are fully covered.</description></item>
                    /// <item><description>partial: Only some targets are valid or recognizable.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>complete</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The array of targets. A maximum of 12 items are returned. This value can be empty if no relevant targets exist.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<GeneralRephotographyDetectionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class GeneralRephotographyDetectionResponseBodyDataResultGroundingRegions : TeaModel {
                        /// <summary>
                        /// <para>The bounding box coordinates.</para>
                        /// </summary>
                        [NameInMap("Bbox2d")]
                        [Validation(Required=false)]
                        public List<float?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The target category. For valid values, see the table below.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>product</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confirmed short name or text of up to 24 characters. This value is an empty string if the text is unreadable.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Product</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the image is a recaptured photo.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// <para>The detection type. The value is fixed as general.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information. The value is <c>{&quot;ProcessingCount&quot;:1}</c> on success, or an empty object on failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The response message or failure description.</para>
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
