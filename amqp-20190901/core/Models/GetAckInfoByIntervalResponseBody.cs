// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetAckInfoByIntervalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAckInfoByIntervalResponseBodyData Data { get; set; }
        public class GetAckInfoByIntervalResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public List<GetAckInfoByIntervalResponseBodyDataVoList> VoList { get; set; }
            public class GetAckInfoByIntervalResponseBodyDataVoList : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("ConnectionId")]
                [Validation(Required=false)]
                public string ConnectionId { get; set; }

                [NameInMap("DeliveryTag")]
                [Validation(Required=false)]
                public long? DeliveryTag { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("RocketMqMsgId")]
                [Validation(Required=false)]
                public string RocketMqMsgId { get; set; }

                [NameInMap("Rt")]
                [Validation(Required=false)]
                public int? Rt { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

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
