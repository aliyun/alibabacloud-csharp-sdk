// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpDBDeleteJobListResponseBody : TeaModel {
        /// <summary>
        /// The jobs of deleting a media fingerprint library. For more information, see the "FpDBDeleteJob" section of the [Data types](https://www.alibabacloud.com/help/en/apsaravideo-for-media-processing/latest/datatypes) topic.
        /// </summary>
        [NameInMap("FpDBDeleteJobList")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList FpDBDeleteJobList { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobList : TeaModel {
            [NameInMap("FpDBDeleteJob")]
            [Validation(Required=false)]
            public List<QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob> FpDBDeleteJob { get; set; }
            public class QueryFpDBDeleteJobListResponseBodyFpDBDeleteJobListFpDBDeleteJob : TeaModel {
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
                /// The type of the operation.
                /// </summary>
                [NameInMap("DelType")]
                [Validation(Required=false)]
                public string DelType { get; set; }

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
                /// The status of the job. Valid values:
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
        /// The IDs of the jobs that do not exist.
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpDBDeleteJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpDBDeleteJobListResponseBodyNonExistIds : TeaModel {
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
