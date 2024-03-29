// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        /// <summary>
        /// The time when the pipeline was updated.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the queue. Valid values:
        /// 
        /// *   MEMORY: a traditional memory-based queue.
        /// *   PERSISTED: disk-based ACKed queue (persistent queue).
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyResult Result { get; set; }
        public class DescribePipelineResponseBodyResult : TeaModel {
            /// <summary>
            /// The time when the pipeline was created.
            /// </summary>
            [NameInMap("batchDelay")]
            [Validation(Required=false)]
            public int? BatchDelay { get; set; }

            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// The description of the pipeline.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The state of the MPS queue. Valid values:
            /// 
            /// *   NOT_DEPLOYED: The node is not deployed.
            /// *   RUNNING
            /// *   DELETED: Deleted. The console does not display this status.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// The total capacity of the queue in bytes. Unit: MB.
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// Number of queue checkpoint writes.
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

            /// <summary>
            /// Pipeline batch delay. Unit: milliseconds.
            /// </summary>
            [NameInMap("queueCheckPointWrites")]
            [Validation(Required=false)]
            public int? QueueCheckPointWrites { get; set; }

            /// <summary>
            /// The number of pipeline workers.
            /// </summary>
            [NameInMap("queueMaxBytes")]
            [Validation(Required=false)]
            public int? QueueMaxBytes { get; set; }

            /// <summary>
            /// The specific configuration of the pipeline.
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// The size of the pipeline batch.
            /// </summary>
            [NameInMap("workers")]
            [Validation(Required=false)]
            public int? Workers { get; set; }

        }

    }

}
