// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetSendTraceByConnectionAndChannelAndDeliveryTagResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSendTraceByConnectionAndChannelAndDeliveryTagResponseBodyData Data { get; set; }
        public class GetSendTraceByConnectionAndChannelAndDeliveryTagResponseBodyData : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            [NameInMap("Exchange")]
            [Validation(Required=false)]
            public string Exchange { get; set; }

            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            [NameInMap("QueueMsgIdMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> QueueMsgIdMap { get; set; }

            [NameInMap("RemoteAddress")]
            [Validation(Required=false)]
            public string RemoteAddress { get; set; }

            [NameInMap("RoutingKey")]
            [Validation(Required=false)]
            public string RoutingKey { get; set; }

            [NameInMap("SendErrorInfo")]
            [Validation(Required=false)]
            public string SendErrorInfo { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Vhost")]
            [Validation(Required=false)]
            public string Vhost { get; set; }

            [NameInMap("XDelay")]
            [Validation(Required=false)]
            public string XDelay { get; set; }

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
