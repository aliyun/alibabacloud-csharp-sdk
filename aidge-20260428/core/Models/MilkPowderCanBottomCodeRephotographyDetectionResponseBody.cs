// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MilkPowderCanBottomCodeRephotographyDetectionResponseBody : TeaModel {
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
        public MilkPowderCanBottomCodeRephotographyDetectionResponseBodyData Data { get; set; }
        public class MilkPowderCanBottomCodeRephotographyDetectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the recapture detection result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MilkPowderCanBottomCodeRephotographyDetectionResponseBodyDataResult Result { get; set; }
            public class MilkPowderCanBottomCodeRephotographyDetectionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The localization information.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public MilkPowderCanBottomCodeRephotographyDetectionResponseBodyDataResultGrounding Grounding { get; set; }
                public class MilkPowderCanBottomCodeRephotographyDetectionResponseBodyDataResultGrounding : TeaModel {
                    /// <summary>
                    /// <para>The coverage. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>complete: The relevant visible targets are complete.</description></item>
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
                    /// <para>The list of regions.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<MilkPowderCanBottomCodeRephotographyDetectionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class MilkPowderCanBottomCodeRephotographyDetectionResponseBodyDataResultGroundingRegions : TeaModel {
                        /// <summary>
                        /// <para>The bounding box coordinates in the format of <c>[top-left x, top-left y, bottom-right x, bottom-right y]</c>. Valid values: 0 to 1000. The left value must be less than the right value, and the top value must be less than the bottom value.</para>
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
                        /// <para>The confirmed short name or text of up to 24 characters. If the text is unclear, an empty string is returned.</para>
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
                /// <para>Specifies whether the image is recaptured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// <para>The detection type. The value is fixed to canBottom.</para>
                /// 
                /// <b>Example:</b>
                /// <para>canBottom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information. If the call is successful, the value is <c>{&quot;ProcessingCount&quot;:1}</c>. If the call fails, an empty object is returned.</para>
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
        /// <para>Specifies whether the call is successful. A valid business conclusion does not mean that the review is passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
