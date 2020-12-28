// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                public string Status { get; set; }
                public bool? SupportEIP { get; set; }
                public bool? AutoRenewInstance { get; set; }
                public long? ExpireTime { get; set; }
                public long? OrderCreateTime { get; set; }
                public string InstanceName { get; set; }
                public string PrivateEndpoint { get; set; }
                public string OrderType { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string PublicEndpoint { get; set; }
            }
        };

    }

}
