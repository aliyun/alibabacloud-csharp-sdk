// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIImageJobsResponseBody : TeaModel {
        /// <summary>
        /// The image AI processing jobs.
        /// </summary>
        [NameInMap("AIImageJobList")]
        [Validation(Required=false)]
        public List<GetAIImageJobsResponseBodyAIImageJobList> AIImageJobList { get; set; }
        public class GetAIImageJobsResponseBodyAIImageJobList : TeaModel {
            /// <summary>
            /// The Object Storage Service (OSS) URL of the image file.
            /// 
            /// > This parameter does not include the complete authentication information. To obtain the authentication information, you must generate a signed URL. Alternatively, you can call the [ListAIImageInfo](~~ListAIImageInfo~~) operation to obtain the image information.
            /// </summary>
            [NameInMap("AIImageResult")]
            [Validation(Required=false)]
            public string AIImageResult { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The time when the image AI processing job was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the image AI processing job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   **success**
            /// *   **fail**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The configurations of the AI template that was used to submit the job.
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// The ID of the AI template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The user data.
            /// 
            /// *   The value must be a JSON string.
            /// *   The MessageCallback or Extend parameter is returned.
            /// *   The value contains a maximum of 512 bytes.
            /// 
            /// For more information, see the "UserData: specifies the custom configurations for media upload" section of the [Request parameters](~~86952~~) topic.
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// The ID of the video.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
