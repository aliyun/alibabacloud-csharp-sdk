// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetMessageDetailResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMessageDetailResponseBodyData Data { get; set; }
        public class GetMessageDetailResponseBodyData : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public string Body { get; set; }

            [NameInMap("bodySize")]
            [Validation(Required=false)]
            public int? BodySize { get; set; }

            [NameInMap("bornHost")]
            [Validation(Required=false)]
            public string BornHost { get; set; }

            [NameInMap("bornTime")]
            [Validation(Required=false)]
            public string BornTime { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("messageGroup")]
            [Validation(Required=false)]
            public string MessageGroup { get; set; }

            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            [NameInMap("messageKeys")]
            [Validation(Required=false)]
            public List<string> MessageKeys { get; set; }

            [NameInMap("messageTag")]
            [Validation(Required=false)]
            public string MessageTag { get; set; }

            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("storeHost")]
            [Validation(Required=false)]
            public string StoreHost { get; set; }

            [NameInMap("storeTime")]
            [Validation(Required=false)]
            public string StoreTime { get; set; }

            [NameInMap("systemProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> SystemProperties { get; set; }

            [NameInMap("topicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            [NameInMap("userProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> UserProperties { get; set; }

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
