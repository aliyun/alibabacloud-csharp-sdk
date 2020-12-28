// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueuesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueuesResponseBodyData Data { get; set; }
        public class ListQueuesResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("Queues")]
            [Validation(Required=false)]
            public List<ListQueuesResponseBodyDataQueues> Queues { get; set; }
            public class ListQueuesResponseBodyDataQueues : TeaModel {
                public bool? ExclusiveState { get; set; }
                public bool? AutoDeleteState { get; set; }
                public long? CreateTime { get; set; }
                public Dictionary<string, string> Attributes { get; set; }
                public string VHostName { get; set; }
                public string Name { get; set; }
                public string OwnerId { get; set; }
                public long? LastConsumeTime { get; set; }
            }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
        };

    }

}
