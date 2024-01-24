// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueuesResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueuesResponseBodyData Data { get; set; }
        public class ListQueuesResponseBodyData : TeaModel {
            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that marks the end of the current returned page. If this parameter is empty, all data is retrieved.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The queues.
            /// </summary>
            [NameInMap("Queues")]
            [Validation(Required=false)]
            public List<ListQueuesResponseBodyDataQueues> Queues { get; set; }
            public class ListQueuesResponseBodyDataQueues : TeaModel {
                /// <summary>
                /// The attributes.
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                /// <summary>
                /// Indicates whether the queue was automatically deleted.
                /// </summary>
                [NameInMap("AutoDeleteState")]
                [Validation(Required=false)]
                public bool? AutoDeleteState { get; set; }

                /// <summary>
                /// The time when the queue was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// Indicates whether the queue is an exclusive queue.
                /// </summary>
                [NameInMap("ExclusiveState")]
                [Validation(Required=false)]
                public bool? ExclusiveState { get; set; }

                /// <summary>
                /// The time when messages in the queue were last consumed.
                /// </summary>
                [NameInMap("LastConsumeTime")]
                [Validation(Required=false)]
                public long? LastConsumeTime { get; set; }

                /// <summary>
                /// The queue name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the ApsaraMQ for RabbitMQ instance to which the queue belongs.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// The vhost name.
                /// </summary>
                [NameInMap("VHostName")]
                [Validation(Required=false)]
                public string VHostName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
