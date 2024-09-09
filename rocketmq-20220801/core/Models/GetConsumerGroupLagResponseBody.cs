// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetConsumerGroupLagResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerGroupLagResponseBodyData Data { get; set; }
        public class GetConsumerGroupLagResponseBodyData : TeaModel {
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("topicLagMap")]
            [Validation(Required=false)]
            public Dictionary<string, DataTopicLagMapValue> TopicLagMap { get; set; }

            [NameInMap("totalLag")]
            [Validation(Required=false)]
            public GetConsumerGroupLagResponseBodyDataTotalLag TotalLag { get; set; }
            public class GetConsumerGroupLagResponseBodyDataTotalLag : TeaModel {
                [NameInMap("deliveryDuration")]
                [Validation(Required=false)]
                public long? DeliveryDuration { get; set; }

                [NameInMap("inflightCount")]
                [Validation(Required=false)]
                public long? InflightCount { get; set; }

                [NameInMap("readyCount")]
                [Validation(Required=false)]
                public long? ReadyCount { get; set; }

            }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
