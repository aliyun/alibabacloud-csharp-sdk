// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueuesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueuesResponseBodyData Data { get; set; }
        public class ListQueuesResponseBodyData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// Queue。
            /// </summary>
            [NameInMap("Queues")]
            [Validation(Required=false)]
            public List<ListQueuesResponseBodyDataQueues> Queues { get; set; }
            public class ListQueuesResponseBodyDataQueues : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                [NameInMap("AutoDeleteState")]
                [Validation(Required=false)]
                public bool? AutoDeleteState { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("ExclusiveState")]
                [Validation(Required=false)]
                public bool? ExclusiveState { get; set; }

                [NameInMap("LastConsumeTime")]
                [Validation(Required=false)]
                public long? LastConsumeTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                [NameInMap("VHostName")]
                [Validation(Required=false)]
                public string VHostName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
