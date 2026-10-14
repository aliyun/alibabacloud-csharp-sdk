// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetWatermarkExtractTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The average extraction confidence, ranging from 0 to 1. This parameter is returned only when Status is succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.99</para>
        /// </summary>
        [NameInMap("AvgAcc")]
        [Validation(Required=false)]
        public double? AvgAcc { get; set; }

        /// <summary>
        /// <para>The business error code. OK is returned if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether a watermark is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Detected")]
        [Validation(Required=false)]
        public bool? Detected { get; set; }

        /// <summary>
        /// <para>The HTTP status code. 200 is returned if the request is successful.</para>
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
        /// <para>The request has failed due to a temporary failure of the server.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>running: In progress.</description></item>
        /// <item><description>succeeded: Completed.</description></item>
        /// <item><description>failed: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The dark watermark extraction task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The extracted watermark content. This parameter is returned only when <c>Status</c> is <c>succeeded</c> and <c>Detected=true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wm-e2e-85970647</para>
        /// </summary>
        [NameInMap("WatermarkContent")]
        [Validation(Required=false)]
        public string WatermarkContent { get; set; }

    }

}
