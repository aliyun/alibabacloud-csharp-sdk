// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetImageTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. The value <c>OK</c> is returned if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when the task status is <c>failed</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance access forbidden.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value <c>200</c> is returned if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of generated images. This parameter is returned only when <c>Status</c> is <c>succeeded</c>.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<GetImageTaskResultResponseBodyImages> Images { get; set; }
        public class GetImageTaskResultResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The <c>ObjectKey</c> of the image in OSS. You can use this value in subsequent API calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deepsign/123456789/image-generation/abc12345-def6-7890-abcd-ef1234567890.png</para>
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The pre-signed download URL of the image. The URL is valid for 1 hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://bucket.oss-cn-hangzhou.aliyuncs.com/deepsign/123456789/image-generation/abc12345.png?Expires=1718700000&OSSAccessKeyId=">https://bucket.oss-cn-hangzhou.aliyuncs.com/deepsign/123456789/image-generation/abc12345.png?Expires=1718700000&amp;OSSAccessKeyId=</a>...</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The additional information. The value <c>success</c> is returned if the request succeeds. An error message is returned if the task fails. This parameter is returned only when <c>Status</c> is <c>failed</c>.</para>
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
        /// <para>The task status. Valid values: <c>pending</c> (waiting), <c>running</c> (in progress), <c>succeeded</c> (completed), <c>failed</c> (failed).</para>
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
