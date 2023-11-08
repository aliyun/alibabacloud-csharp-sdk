// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                [NameInMap("AutoRenewInstance")]
                [Validation(Required=false)]
                public bool? AutoRenewInstance { get; set; }

                [NameInMap("ClassicEndpoint")]
                [Validation(Required=false)]
                public string ClassicEndpoint { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("MaxEipTps")]
                [Validation(Required=false)]
                public int? MaxEipTps { get; set; }

                [NameInMap("MaxQueue")]
                [Validation(Required=false)]
                public int? MaxQueue { get; set; }

                [NameInMap("MaxTps")]
                [Validation(Required=false)]
                public int? MaxTps { get; set; }

                [NameInMap("MaxVhost")]
                [Validation(Required=false)]
                public int? MaxVhost { get; set; }

                [NameInMap("OrderCreateTime")]
                [Validation(Required=false)]
                public long? OrderCreateTime { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("PrivateEndpoint")]
                [Validation(Required=false)]
                public string PrivateEndpoint { get; set; }

                [NameInMap("PublicEndpoint")]
                [Validation(Required=false)]
                public string PublicEndpoint { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public int? StorageSize { get; set; }

                [NameInMap("SupportEIP")]
                [Validation(Required=false)]
                public bool? SupportEIP { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListInstancesResponseBodyDataInstancesTags> Tags { get; set; }
                public class ListInstancesResponseBodyDataInstancesTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

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
