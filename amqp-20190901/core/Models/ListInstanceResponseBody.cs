// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class ListInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyData Data { get; set; }
        public class ListInstanceResponseBodyData : TeaModel {
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyDataInstances> Instances { get; set; }
            public class ListInstanceResponseBodyDataInstances : TeaModel {
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                [NameInMap("ClassicEndpoint")]
                [Validation(Required=false)]
                public string ClassicEndpoint { get; set; }

                [NameInMap("Expire")]
                [Validation(Required=false)]
                public long? Expire { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("MaxEIPTPS")]
                [Validation(Required=false)]
                public int? MaxEIPTPS { get; set; }

                [NameInMap("MaxQueue")]
                [Validation(Required=false)]
                public int? MaxQueue { get; set; }

                [NameInMap("MaxTPS")]
                [Validation(Required=false)]
                public int? MaxTPS { get; set; }

                [NameInMap("MaxVhost")]
                [Validation(Required=false)]
                public int? MaxVhost { get; set; }

                [NameInMap("OrderCreate")]
                [Validation(Required=false)]
                public long? OrderCreate { get; set; }

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
                public ListInstanceResponseBodyDataInstancesTags Tags { get; set; }
                public class ListInstanceResponseBodyDataInstancesTags : TeaModel {
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<ListInstanceResponseBodyDataInstancesTagsTags> Tags { get; set; }
                    public class ListInstanceResponseBodyDataInstancesTagsTags : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
