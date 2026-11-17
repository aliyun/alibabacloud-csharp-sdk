// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetWatermarkSignTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The <b>business error code</b>. <c>OK</c> is returned when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error code of the task. This parameter is returned when Status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2PA_CERTIFICATE_SERVICE_UNAVAILABLE</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message of the task. This parameter is returned under the same conditions as ErrorCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>the certificate service is temporarily unavailable</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mediaFakeCheck error: code=4010 message=async poll timeout after 30 retries, uuid:D9390706E5EC263C09825D414601BDE7_33.63.90.51_1784254068.723000_937</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The destination object key returned when the signing result is written to the user\&quot;s bucket. This parameter is returned only when the task succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-deepsign-signed/example_signed.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The temporary download URL of the signed file. This parameter is returned when the task succeeds in internal bucket mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example-bucket.oss-cn-hangzhou.aliyuncs.com/example_signed.png?Expires=1788000000&Signature=">https://example-bucket.oss-cn-hangzhou.aliyuncs.com/example_signed.png?Expires=1788000000&amp;Signature=</a>***</para>
        /// </summary>
        [NameInMap("SignedFileUrl")]
        [Validation(Required=false)]
        public string SignedFileUrl { get; set; }

        /// <summary>
        /// <para>The current processing stage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WATERMARK: Invisible watermark embedding.</description></item>
        /// <item><description>SIGNING: C2PA signing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SIGNING</para>
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROCESSING: The task is being processed.</description></item>
        /// <item><description>SUCCEEDED: The task succeeded. This is a final state.</description></item>
        /// <item><description>FAILED: The task failed. This is a final state.</description></item>
        /// <item><description>CANCELED: The task is canceled. This is a final state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the combined task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
