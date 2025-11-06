// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetConsumeTraceByQueueAndRocketMqMsgIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetConsumeTraceByQueueAndRocketMqMsgIdResponseBodyData> Data { get; set; }
        public class GetConsumeTraceByQueueAndRocketMqMsgIdResponseBodyData : TeaModel {
            [NameInMap("AutoAckTag")]
            [Validation(Required=false)]
            public string AutoAckTag { get; set; }

            [NameInMap("ClientAddress")]
            [Validation(Required=false)]
            public string ClientAddress { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ConsumeType")]
            [Validation(Required=false)]
            public string ConsumeType { get; set; }

            [NameInMap("ConsumerTag")]
            [Validation(Required=false)]
            public string ConsumerTag { get; set; }

            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            [NameInMap("DeliveryErrorInfo")]
            [Validation(Required=false)]
            public string DeliveryErrorInfo { get; set; }

            [NameInMap("DeliveryTag")]
            [Validation(Required=false)]
            public string DeliveryTag { get; set; }

            [NameInMap("DlqQueueMsgIdMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DlqQueueMsgIdMap { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ShowAckIcon")]
            [Validation(Required=false)]
            public bool? ShowAckIcon { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
