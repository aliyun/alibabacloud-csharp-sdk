// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetVideoTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para><b>Business error code.</b> Returns &quot;OK&quot; if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The cause of the failure. This field is returned only when the task status is failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
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
        /// <para>The task status. Valid values: running, succeeded, and failed. Set the polling interval to at least 5 seconds.</para>
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
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f47ac10b-58cc-4372-a567-0e02b2c3d479</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The list of video information.</para>
        /// </summary>
        [NameInMap("Videos")]
        [Validation(Required=false)]
        public List<GetVideoTaskResultResponseBodyVideos> Videos { get; set; }
        public class GetVideoTaskResultResponseBodyVideos : TeaModel {
            /// <summary>
            /// <para>The OSS key of the output object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai_deep_sign/1192853035118460/image-generation/2026/06/25/024d6974-1b14-4741-8919-9d02b7e3901b.mp4</para>
            /// </summary>
            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The presigned download URL of the video stored in OSS after C2PA signing.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://duguang-database-public.oss-cn-hangzhou.aliyuncs.com/cosmetic_plicense_init/024d6974-1b14-4741-8919-9d02b7e3901b.mp4">http://duguang-database-public.oss-cn-hangzhou.aliyuncs.com/cosmetic_plicense_init/024d6974-1b14-4741-8919-9d02b7e3901b.mp4</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
