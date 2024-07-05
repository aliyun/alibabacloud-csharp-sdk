// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpFileDeleteJobListResponseBody : TeaModel {
        /// <summary>
        /// The jobs of deleting media files from a media fingerprint library. For more information, see the "FpFileDeleteJob" section of the [Data types](https://help.aliyun.com/document_detail/93555.html) topic.
        /// </summary>
        [NameInMap("FpFileDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobList FpFileDeleteJobList { get; set; }
        public class QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobList : TeaModel {
            [NameInMap("FpFileDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobListFpFileDeleteJob> FpFileDeleteJob { get; set; }
            public class QueryFpFileDeleteJobListResponseBodyFpFileDeleteJobListFpFileDeleteJob : TeaModel {
                /// <summary>
                /// The error code returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The time when the job was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the file.
                /// </summary>
                [NameInMap("FileIds")]
                [Validation(Required=false)]
                public string FileIds { get; set; }

                /// <summary>
                /// The time when the job was complete.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The ID of the media fingerprint library.
                /// </summary>
                [NameInMap("FpDBId")]
                [Validation(Required=false)]
                public string FpDBId { get; set; }

                /// <summary>
                /// The ID of the job.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The error message returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the ApsaraVideo Media Processing (MPS) queue to which the job was submitted.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The status of the job. Valid values: Valid values:
                /// 
                /// *   **Queuing**: The job is waiting in the queue.
                /// *   **Analysing**: The job is in progress.
                /// *   **Success**: The job is successful.
                /// *   **Fail**: The job fails.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The user-defined data.
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpFileDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpFileDeleteJobListResponseBodyNonExistIds : TeaModel {
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
