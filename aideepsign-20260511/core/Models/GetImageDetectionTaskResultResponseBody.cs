// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetImageDetectionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. The value <c>&quot;OK&quot;</c> is returned when the request succeeds.</para>
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
        /// <para>This parameter is returned only when <c>Status</c> is <c>succeeded</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tamper</para>
        /// </summary>
        [NameInMap("DetectMode")]
        [Validation(Required=false)]
        public string DetectMode { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value <c>200</c> is returned when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of AIGC detection result labels. This parameter is returned only when <c>Status</c> is <c>succeeded</c> and the task includes AIGC detection.</para>
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
            /// <para>The detection label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ai_generated: AI-generated.</description></item>
            /// <item><description>non_ai_generated: not AI-generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>non_ai_generated</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

        /// <summary>
        /// <para>The additional information. The value <c>&quot;success&quot;</c> is returned when the request succeeds. An error message is returned when the task fails. This parameter is returned only when <c>Status</c> is <c>failed</c>.</para>
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
        /// <item><description><c>pending</c>: waiting.</description></item>
        /// <item><description><c>running</c>: in progress.</description></item>
        /// <item><description><c>succeeded</c>: completed.</description></item>
        /// <item><description><c>failed</c>: failed.</description></item>
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
        /// <para>The tamper detection results. This parameter is returned only when <c>DetectType</c> is <c>tamper</c> or <c>auto</c> (and the image is identified as a credential-type image).</para>
        /// </summary>
        [NameInMap("Tamper")]
        [Validation(Required=false)]
        public GetImageDetectionTaskResultResponseBodyTamper Tamper { get; set; }
        public class GetImageDetectionTaskResultResponseBodyTamper : TeaModel {
            /// <summary>
            /// <para>The basic detection results, including detection scores across multiple dimensions.</para>
            /// </summary>
            [NameInMap("BaseResults")]
            [Validation(Required=false)]
            public GetImageDetectionTaskResultResponseBodyTamperBaseResults BaseResults { get; set; }
            public class GetImageDetectionTaskResultResponseBodyTamperBaseResults : TeaModel {
                /// <summary>
                /// <para>The AIGC detection score.</para>
                /// </summary>
                [NameInMap("Aigc")]
                [Validation(Required=false)]
                public GetImageDetectionTaskResultResponseBodyTamperBaseResultsAigc Aigc { get; set; }
                public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsAigc : TeaModel {
                    /// <summary>
                    /// <para>The description of the AIGC detection result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>疑似AI生成图片</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

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
                    /// <para>The description of the AI post-processing detection result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未发现AI后处理痕迹</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

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
                /// <para>The PS tamper localization results.</para>
                /// </summary>
                [NameInMap("PsLoc")]
                [Validation(Required=false)]
                public GetImageDetectionTaskResultResponseBodyTamperBaseResultsPsLoc PsLoc { get; set; }
                public class GetImageDetectionTaskResultResponseBodyTamperBaseResultsPsLoc : TeaModel {
                    /// <summary>
                    /// <para>The description of the PS tamper localization result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>发现1处疑似PS修改区域</para>
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
                        /// <para>The bounding box coordinates of the tampered region in the format <c>[x1, y1, x2, y2]</c>.</para>
                        /// </summary>
                        [NameInMap("Bbox")]
                        [Validation(Required=false)]
                        public List<float?> Bbox { get; set; }

                        /// <summary>
                        /// <para>The tamper confidence level for the region. Value range: <c>0 to 1</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.67</para>
                        /// </summary>
                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public float? Score { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The comprehensive analysis result from the large language model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>该图片经检测存在AI生成痕迹，AIGC检测得分0.95，建议进一步核实图片来源。</para>
            /// </summary>
            [NameInMap("LlmResult")]
            [Validation(Required=false)]
            public string LlmResult { get; set; }

            /// <summary>
            /// <para>The risk code. A value of <c>&quot;0&quot;</c> indicates no risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskCode")]
            [Validation(Required=false)]
            public string RiskCode { get; set; }

            /// <summary>
            /// <para>The list of risk reasons. An empty array is returned when no risk is detected.</para>
            /// </summary>
            [NameInMap("RiskReasons")]
            [Validation(Required=false)]
            public List<string> RiskReasons { get; set; }

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
