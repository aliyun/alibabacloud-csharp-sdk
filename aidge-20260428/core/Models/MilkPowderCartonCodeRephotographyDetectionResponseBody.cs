// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MilkPowderCartonCodeRephotographyDetectionResponseBody : TeaModel {
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
        public MilkPowderCartonCodeRephotographyDetectionResponseBodyData Data { get; set; }
        public class MilkPowderCartonCodeRephotographyDetectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the recapture detection result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResult Result { get; set; }
            public class MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The supplementary element localization result.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGrounding Grounding { get; set; }
                public class MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGrounding : TeaModel {
                    /// <summary>
                    /// <para>The coverage. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>complete</c>: The relevant visible targets are complete.</description></item>
                    /// <item><description><c>partial</c>: Only some targets are valid or recognizable.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>complete</para>
                    /// </summary>
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    /// <summary>
                    /// <para>The target array. It contains up to 12 items. It can be empty if no relevant targets are found.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGroundingRegions : TeaModel {
                        /// <summary>
                        /// <para>The bounding box coordinates.</para>
                        /// <list type="bullet">
                        /// <item><description><c>[top-left x, top-left y, bottom-right x, bottom-right y]</c></description></item>
                        /// <item><description>Value range: 0–1000.</description></item>
                        /// <item><description>Left &lt; right, top &lt; bottom.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Bbox2d")]
                        [Validation(Required=false)]
                        public List<float?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The target category. For valid values, see the following table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>milk_powder</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The recognized text. It contains up to 24 characters of a confirmed short name or text. It is an empty string if the text is unclear.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Milk powder</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the image is a recapture.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is suspected to be a recapture.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSuspect")]
                [Validation(Required=false)]
                public bool? IsSuspect { get; set; }

                /// <summary>
                /// <para>The recapture status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>0</c>: Non-recapture.</description></item>
                /// <item><description><c>1</c>: Recapture.</description></item>
                /// <item><description><c>2</c>: Suspected recapture.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PhotoStatus")]
                [Validation(Required=false)]
                public int? PhotoStatus { get; set; }

                /// <summary>
                /// <para>The recapture confidence score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.89</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>The detection type. Fixed to <c>boxCode</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>boxCode</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information. It is <c>{&quot;ProcessingCount&quot;:1}</c> if the call is successful, or an empty object if the call fails.</para>
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
