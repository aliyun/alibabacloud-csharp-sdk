// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class QueryMessageByQueueNameResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMessageByQueueNameResponseBodyData Data { get; set; }
        public class QueryMessageByQueueNameResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public QueryMessageByQueueNameResponseBodyDataVoList VoList { get; set; }
            public class QueryMessageByQueueNameResponseBodyDataVoList : TeaModel {
                [NameInMap("AmqpMessageVO")]
                [Validation(Required=false)]
                public List<QueryMessageByQueueNameResponseBodyDataVoListAmqpMessageVO> AmqpMessageVO { get; set; }
                public class QueryMessageByQueueNameResponseBodyDataVoListAmqpMessageVO : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ContentEncoding")]
                    [Validation(Required=false)]
                    public string ContentEncoding { get; set; }

                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    [NameInMap("CorrelationId")]
                    [Validation(Required=false)]
                    public string CorrelationId { get; set; }

                    [NameInMap("DeliveryMode")]
                    [Validation(Required=false)]
                    public int? DeliveryMode { get; set; }

                    [NameInMap("ExchangeName")]
                    [Validation(Required=false)]
                    public string ExchangeName { get; set; }

                    [NameInMap("Expiration")]
                    [Validation(Required=false)]
                    public string Expiration { get; set; }

                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public string Headers { get; set; }

                    [NameInMap("Immediate")]
                    [Validation(Required=false)]
                    public bool? Immediate { get; set; }

                    [NameInMap("Mandatory")]
                    [Validation(Required=false)]
                    public bool? Mandatory { get; set; }

                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    [NameInMap("ProcessToken")]
                    [Validation(Required=false)]
                    public string ProcessToken { get; set; }

                    [NameInMap("ReconsumeTimes")]
                    [Validation(Required=false)]
                    public int? ReconsumeTimes { get; set; }

                    [NameInMap("ReplyTo")]
                    [Validation(Required=false)]
                    public string ReplyTo { get; set; }

                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public string RoutingKey { get; set; }

                    [NameInMap("StoreTimestamp")]
                    [Validation(Required=false)]
                    public long? StoreTimestamp { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

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
