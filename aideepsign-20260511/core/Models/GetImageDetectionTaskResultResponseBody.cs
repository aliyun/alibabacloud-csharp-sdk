// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetImageDetectionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. The value &quot;OK&quot; is returned when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detection mode that was actually executed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aigc: AIGC only.</description></item>
        /// <item><description>tamper: tamper detection.</description></item>
        /// </list>
        /// <para>This field is returned only when Status is succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tamper</para>
        /// </summary>
        [NameInMap("DetectMode")]
        [Validation(Required=false)]
        public string DetectMode { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value 200 is returned when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of detection result labels. This field is returned only when Status is succeeded and AIGC detection is included. The label values and confidence ranges vary depending on DetectMode. In aigc mode, AIGC generation identification labels are returned (see the table below). In tamper mode, aigc/aips labels are returned (confidence range: 0 to 1).</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetImageDetectionTaskResultResponseBodyLabels> Labels { get; set; }
        public class GetImageDetectionTaskResultResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The confidence level. Value range: 0 to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9562</para>
            /// </summary>
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public float? Confidence { get; set; }

            /// <summary>
            /// <para>The detection label. When DetectMode is aigc, valid values are: risk_aigc (the image is suspected to be AIGC-generated), risk_fake (the image is suspected to be a composite image), risk_edit (the image is suspected to be AI-edited). When DetectMode is tamper, valid values are: aigc (AIGC detection score), aips (AI post-processing detection score).</para>
            /// 
            /// <b>Example:</b>
            /// <para>risk_aigc</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

        /// <summary>
        /// <para>The additional information. The value &quot;success&quot; is returned when the request succeeds. The error message is returned when the task fails. This field is returned only when Status is failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pending: waiting.</description></item>
        /// <item><description>running: in progress.</description></item>
        /// <item><description>succeeded: completed.</description></item>
        /// <item><description>failed: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The tamper detection result.</para>
        /// </summary>
        [NameInMap("Tamper")]
        [Validation(Required=false)]
        public GetImageDetectionTaskResultResponseBodyTamper Tamper { get; set; }
        public class GetImageDetectionTaskResultResponseBodyTamper : TeaModel {
            /// <summary>
            /// <para>The AI visible watermark. This field is returned only in large model mode. It is empty in small model mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>是</para>
            /// </summary>
            [NameInMap("AiWatermark")]
            [Validation(Required=false)]
            public string AiWatermark { get; set; }

            /// <summary>
            /// <para>The basic algorithm detection results, including multi-dimensional detection scores and risk labels.</para>
            /// </summary>
            [NameInMap("BaseResults")]
            [Validation(Required=false)]
            public GetImageDetectionTaskResultResponseBodyTamperBaseResults BaseResults { get; set; }
            public class GetImageDetectionTaskResultResponseBodyTamperBaseResults : TeaModel {
                /// <summary>
                /// <para>The AIGC detection result.</para>
                /// </summary>
                [NameInMap("Aigc")]
                [Validation(Required=false)]
                public GetImageDetectionTaskResultResponseBodyTamperBaseResultsAigc Aigc { get; set; }
                public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsAigc : TeaModel {
                    /// <summary>
                    /// <para>The AIGC detection result description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Suspected AI-generated image</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The AIGC dimension risk label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>高风险</para>
                    /// </summary>
                    [NameInMap("Risk")]
                    [Validation(Required=false)]
                    public string Risk { get; set; }

                    /// <summary>
                    /// <para>The AIGC detection score. Value range: 0 to 1. A higher value indicates a greater likelihood of AI generation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.47</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                /// <summary>
                /// <para>The AI post-processing detection score.</para>
                /// </summary>
                [NameInMap("Aips")]
                [Validation(Required=false)]
                public GetImageDetectionTaskResultResponseBodyTamperBaseResultsAips Aips { get; set; }
                public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsAips : TeaModel {
                    /// <summary>
                    /// <para>The AI post-processing detection result description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>No AI post-processing traces detected</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The local PS/AI editing dimension risk label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>高风险</para>
                    /// </summary>
                    [NameInMap("Risk")]
                    [Validation(Required=false)]
                    public string Risk { get; set; }

                    /// <summary>
                    /// <para>The AI post-processing detection score. Value range: 0 to 1. A higher value indicates a greater likelihood of AI post-processing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.12</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                /// <summary>
                /// <para>The image type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>natural</para>
                /// </summary>
                [NameInMap("ImgType")]
                [Validation(Required=false)]
                public string ImgType { get; set; }

                /// <summary>
                /// <para>The PS tamper localization result.</para>
                /// </summary>
                [NameInMap("PsLoc")]
                [Validation(Required=false)]
                public GetImageDetectionTaskResultResponseBodyTamperBaseResultsPsLoc PsLoc { get; set; }
                public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsPsLoc : TeaModel {
                    /// <summary>
                    /// <para>The PS tamper localization result description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1 suspected PS-modified region detected</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The list of tampered regions.</para>
                    /// </summary>
                    [NameInMap("Items")]
                    [Validation(Required=false)]
                    public List<GetImageDetectionTaskResultResponseBodyTamperBaseResultsPsLocItems> Items { get; set; }
                    public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsPsLocItems : TeaModel {
                        /// <summary>
                        /// <para>The bounding box coordinates of the tampered region, in the format <c>[x1, y1, x2, y2]</c>.</para>
                        /// </summary>
                        [NameInMap("Bbox")]
                        [Validation(Required=false)]
                        public List<float?> Bbox { get; set; }

                        /// <summary>
                        /// <para>The tamper confidence of the region. Value range: 0 to 1.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.67</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public float? Score { get; set; }

                    }

                }

                /// <summary>
                /// <para>The recapture/copy detection result.</para>
                /// </summary>
                [NameInMap("Recap")]
                [Validation(Required=false)]
                public GetImageDetectionTaskResultResponseBodyTamperBaseResultsRecap Recap { get; set; }
                public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsRecap : TeaModel {
                    /// <summary>
                    /// <para>The recapture/copy detection result description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Recapture detection score</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The recapture/copy dimension risk label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>高风险</para>
                    /// </summary>
                    [NameInMap("Risk")]
                    [Validation(Required=false)]
                    public string Risk { get; set; }

                    /// <summary>
                    /// <para>The recapture/copy detection score. Value range: 0 to 1. A higher value indicates a greater likelihood of recapture or copying.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.9998</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }

            /// <summary>
            /// <para>The final conclusion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Metadata data analytics result verified as high risk</para>
            /// </summary>
            [NameInMap("FinalConclusion")]
            [Validation(Required=false)]
            public string FinalConclusion { get; set; }

            /// <summary>
            /// <para>The comprehensive analysis result from the large language model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The image has been detected with traces of AI generation. The AIGC detection score is 0.95. We recommend further verifying the image source</para>
            /// </summary>
            [NameInMap("LlmResult")]
            [Validation(Required=false)]
            public string LlmResult { get; set; }

            /// <summary>
            /// <para>The metadata AI flag. This field is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>高风险</para>
            /// </summary>
            [NameInMap("MetadataAiFlag")]
            [Validation(Required=false)]
            public string MetadataAiFlag { get; set; }

            /// <summary>
            /// <para>The source of the metadata AI flag. This field is returned only in large model mode. It is empty in small model mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>通义</para>
            /// </summary>
            [NameInMap("MetadataAiSource")]
            [Validation(Required=false)]
            public string MetadataAiSource { get; set; }

            /// <summary>
            /// <para>The determination result. This field is always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>高风险</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
