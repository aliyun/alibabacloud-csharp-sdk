// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPipelineResponseBody : TeaModel {
        /// <summary>
        /// The header of the response.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPipelineResponseBodyHeaders Headers { get; set; }
        public class ListPipelineResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The response.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPipelineResponseBodyResult> Result { get; set; }
        public class ListPipelineResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the pipeline was created.
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// The time when the pipeline was updated.
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// The ID of the ApsaraVideo Media Processing (MPS) queue that is used to run the job.
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// The status of the pipeline. Supported:
            /// 
            /// *   NOT_DEPLOYED: The node is not deployed.
            /// *   RUNNING
            /// *   DELETED: Deleted. The console does not display this status.
            /// </summary>
            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

        }

    }

}
