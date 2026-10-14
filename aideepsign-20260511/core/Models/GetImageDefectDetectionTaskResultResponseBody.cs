// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetImageDefectDetectionTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The image abnormality reason.</b> This field is returned only when <c>Status</c> is <c>succeeded</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The main subject of the image is blurry</para>
        /// </summary>
        [NameInMap("AbnormalityReason")]
        [Validation(Required=false)]
        public string AbnormalityReason { get; set; }

        /// <summary>
        /// <para><b>The image abnormality score.</b> The value ranges from 0 to 1. A higher value indicates a more severe image abnormality. This field is returned only when <c>Status</c> is <c>succeeded</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9667</para>
        /// </summary>
        [NameInMap("AbnormalityScore")]
        [Validation(Required=false)]
        public float? AbnormalityScore { get; set; }

        /// <summary>
        /// <para><b>The business error code.</b> The value &quot;OK&quot; is returned for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para><b>The HTTP status code.</b> The value 200 is returned for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The failure reason. This field is returned only when <c>Status</c> is <c>failed</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>poll timeout: no result within 30m0s</para>
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
        /// <para>The raw downstream detection result (JSON string). The <c>AbnormalityScore</c> and <c>AbnormalityReason</c> fields are parsed from this raw result. The raw result is retained for debugging and passing through newly added upstream fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;image_abnormality_score&quot;: 0.75, &quot;image_abnormality_reason&quot;: &quot;The main subject of the image is blurry&quot;}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>The risk code. <b>This field is deprecated and has no meaning.</b> Determine whether an abnormality exists based on the AbnormalityScore, AbnormalityReason, and Result fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;0&quot;</para>
        /// </summary>
        [NameInMap("RiskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

        /// <summary>
        /// <para><b>The task status.</b> Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>running</c>: The task is running.</description></item>
        /// <item><description><c>succeeded</c>: The task is completed.</description></item>
        /// <item><description><c>failed</c>: The task failed.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para><b>The task ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
