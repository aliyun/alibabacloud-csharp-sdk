// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListFpShotImportJobResponseBody : TeaModel {
        /// <summary>
        /// The jobs of importing text files to a text fingerprint library.
        /// </summary>
        [NameInMap("FpShotImportJobList")]
        [Validation(Required=false)]
        public List<ListFpShotImportJobResponseBodyFpShotImportJobList> FpShotImportJobList { get; set; }
        public class ListFpShotImportJobResponseBodyFpShotImportJobList : TeaModel {
            /// <summary>
            /// The error code returned when the job fails.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the job was completed.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The ID of the text fingerprint library.
            /// </summary>
            [NameInMap("FpDBId")]
            [Validation(Required=false)]
            public string FpDBId { get; set; }

            /// <summary>
            /// The import configuration.
            /// </summary>
            [NameInMap("FpImportConfig")]
            [Validation(Required=false)]
            public string FpImportConfig { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The input file.
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// The error message returned when the job fails.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the ApsaraVideo Media Processing (MPS) queue to which the job is submitted.
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// The processing information of the job.
            /// </summary>
            [NameInMap("ProcessMessage")]
            [Validation(Required=false)]
            public string ProcessMessage { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   Processing: The job is in progress.
            /// *   Fail: The job fails.
            /// *   Success: The job is successful.
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

        /// <summary>
        /// The job IDs that do not exist. This parameter is not returned if all specified job IDs exist.
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public List<string> NonExistIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
