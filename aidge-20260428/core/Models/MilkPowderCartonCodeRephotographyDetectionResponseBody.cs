// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MilkPowderCartonCodeRephotographyDetectionResponseBody : Darabonba.Model {
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
        public class MilkPowderCartonCodeRephotographyDetectionResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The details of the recapture detection result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResult Result { get; set; }
            public class MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResult : Darabonba.Model {
                /// <summary>
                /// <para>The supplementary element grounding results.</para>
                /// </summary>
                [NameInMap("Grounding")]
                [Validation(Required=false)]
                public MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGrounding Grounding { get; set; }
                public class MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGrounding : Darabonba.Model {
                    /// <summary>
                    /// <para>The coverage of the grounding. Valid values:</para>
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
                    /// <para>The array of targets, which contains up to 12 items. This array can be empty if no relevant targets are found.</para>
                    /// </summary>
                    [NameInMap("Regions")]
                    [Validation(Required=false)]
                    public List<MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGroundingRegions> Regions { get; set; }
                    public class MilkPowderCartonCodeRephotographyDetectionResponseBodyDataResultGroundingRegions : Darabonba.Model {
                        /// <summary>
                        /// <para>The coordinates of the bounding box in the <c>[top-left x, top-left y, bottom-right x, bottom-right y]</c> format. The value range is 0 to 1000. The left value must be less than the right value, and the top value must be less than the bottom value.</para>
                        /// </summary>
                        [NameInMap("Bbox2d")]
                        [Validation(Required=false)]
                        public List<float?> Bbox2d { get; set; }

                        /// <summary>
                        /// <para>The category of the target. For enumerated values, see the following table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>milk_powder</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The confirmed short name or text, which contains up to 24 characters. This field is an empty string if the text is unclear.</para>
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
                /// <para>Indicates whether the image is recaptured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is suspected to be recaptured.</para>
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
                /// <para>The confidence score for recapture detection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.89</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <para>The detection type. The value is fixed to <c>boxCode</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>boxCode</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information. The value is <c>{&quot;ProcessingCount&quot;:1}</c> if the call is successful, or an empty object if the call fails.</para>
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

