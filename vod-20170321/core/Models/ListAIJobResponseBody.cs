// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIJobResponseBody : TeaModel {
        /// <summary>
        /// The list of jobs.
        /// </summary>
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class ListAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<ListAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class ListAIJobResponseBodyAIJobListAIJob : TeaModel {
                /// <summary>
                /// The error code. This parameter is returned if the value of Status is fail.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The time when the job was complete. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                /// <summary>
                /// The time when the job was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The returned data. The value is a JSON string. For more information, see [AITemplateConfig](~~89863~~).
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                /// <summary>
                /// The job ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The ID of the video file.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The error message. This parameter is returned if the value of Status is fail.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The status of the job. Valid values:
                /// 
                /// *   **success**: The job is successful.
                /// *   **fail**: The job failed.
                /// *   **init**: The job is being initialized.
                /// *   **Processing**: The job is in progress.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the job. Valid values:
                /// 
                /// *   **AIMediaDNA**: video fingerprinting
                /// *   **AIVideoTag**: smart tagging
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the jobs that do not exist.
        /// </summary>
        [NameInMap("NonExistAIJobIds")]
        [Validation(Required=false)]
        public ListAIJobResponseBodyNonExistAIJobIds NonExistAIJobIds { get; set; }
        public class ListAIJobResponseBodyNonExistAIJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
