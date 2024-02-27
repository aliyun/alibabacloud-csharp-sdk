// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerConnectionsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerConnectionsResponseBodyData Data { get; set; }
        public class ListConsumerConnectionsResponseBodyData : TeaModel {
            [NameInMap("connections")]
            [Validation(Required=false)]
            public List<ListConsumerConnectionsResponseBodyDataConnections> Connections { get; set; }
            public class ListConsumerConnectionsResponseBodyDataConnections : TeaModel {
                [NameInMap("clientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("egressIp")]
                [Validation(Required=false)]
                public string EgressIp { get; set; }

                [NameInMap("hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("messageModel")]
                [Validation(Required=false)]
                public string MessageModel { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
