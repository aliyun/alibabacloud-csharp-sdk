// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetStatisticsByVhostResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStatisticsByVhostResponseBodyData Data { get; set; }
        public class GetStatisticsByVhostResponseBodyData : TeaModel {
            [NameInMap("ConnectionStatistics")]
            [Validation(Required=false)]
            public List<GetStatisticsByVhostResponseBodyDataConnectionStatistics> ConnectionStatistics { get; set; }
            public class GetStatisticsByVhostResponseBodyDataConnectionStatistics : TeaModel {
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("ChannelNum")]
                [Validation(Required=false)]
                public int? ChannelNum { get; set; }

                [NameInMap("ChannelStatisticsList")]
                [Validation(Required=false)]
                public GetStatisticsByVhostResponseBodyDataConnectionStatisticsChannelStatisticsList ChannelStatisticsList { get; set; }
                public class GetStatisticsByVhostResponseBodyDataConnectionStatisticsChannelStatisticsList : TeaModel {
                    [NameInMap("ChannelStatistics")]
                    [Validation(Required=false)]
                    public List<GetStatisticsByVhostResponseBodyDataConnectionStatisticsChannelStatisticsListChannelStatistics> ChannelStatistics { get; set; }
                    public class GetStatisticsByVhostResponseBodyDataConnectionStatisticsChannelStatisticsListChannelStatistics : TeaModel {
                        [NameInMap("AckQps")]
                        [Validation(Required=false)]
                        public float? AckQps { get; set; }

                        [NameInMap("ConfirmQps")]
                        [Validation(Required=false)]
                        public float? ConfirmQps { get; set; }

                        [NameInMap("DeliverQps")]
                        [Validation(Required=false)]
                        public float? DeliverQps { get; set; }

                        [NameInMap("GetQps")]
                        [Validation(Required=false)]
                        public float? GetQps { get; set; }

                        [NameInMap("Prefetch")]
                        [Validation(Required=false)]
                        public int? Prefetch { get; set; }

                        [NameInMap("PublishQps")]
                        [Validation(Required=false)]
                        public float? PublishQps { get; set; }

                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public int? State { get; set; }

                        [NameInMap("Unacked")]
                        [Validation(Required=false)]
                        public int? Unacked { get; set; }

                        [NameInMap("Unconfirmed")]
                        [Validation(Required=false)]
                        public int? Unconfirmed { get; set; }

                    }

                }

                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                [NameInMap("DeliverQps")]
                [Validation(Required=false)]
                public float? DeliverQps { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("PublishQps")]
                [Validation(Required=false)]
                public float? PublishQps { get; set; }

                [NameInMap("RemoteAddress")]
                [Validation(Required=false)]
                public string RemoteAddress { get; set; }

                [NameInMap("SecurityTransport")]
                [Validation(Required=false)]
                public bool? SecurityTransport { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

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
