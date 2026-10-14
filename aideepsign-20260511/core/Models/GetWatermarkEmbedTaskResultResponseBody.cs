// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetWatermarkEmbedTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The business error code.</b> The value OK is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para><b>The HTTP status code.</b> The value 200 is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The failure reason when the task fails. This parameter is returned only when Status is failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>poll timeout: no result within 10m0s</para>
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
        /// <para>The task status. The processing time is approximately equal to the media duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pending: The task is waiting.</description></item>
        /// <item><description>running: The task is running.</description></item>
        /// <item><description>succeeded: The task succeeded.</description></item>
        /// <item><description>failed: The task failed.</description></item>
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
        /// <para>The invisible watermark embedding task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The pre-signed URL for accessing the watermarked file. This parameter is returned only when Status is succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-bucket.example.com/aideepsign/">https://oss-bucket.example.com/aideepsign/</a>...</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
