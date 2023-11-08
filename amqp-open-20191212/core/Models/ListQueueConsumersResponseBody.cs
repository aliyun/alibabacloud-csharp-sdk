// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListQueueConsumersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListQueueConsumersResponseBodyData Data { get; set; }
        public class ListQueueConsumersResponseBodyData : TeaModel {
            [NameInMap("Consumers")]
            [Validation(Required=false)]
            public List<ListQueueConsumersResponseBodyDataConsumers> Consumers { get; set; }
            public class ListQueueConsumersResponseBodyDataConsumers : TeaModel {
                [NameInMap("ConsumerTag")]
                [Validation(Required=false)]
                public string ConsumerTag { get; set; }

            }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
