// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMqSofamqConsumerStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMqSofamqConsumerStatusResponseBodyData Data { get; set; }
        public class GetMqSofamqConsumerStatusResponseBodyData : TeaModel {
            [NameInMap("ConsumeModel")]
            [Validation(Required=false)]
            public string ConsumeModel { get; set; }
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public string ConsumeTps { get; set; }
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("RebalanceOk")]
            [Validation(Required=false)]
            public bool? RebalanceOk { get; set; }
            [NameInMap("SubscriptionSame")]
            [Validation(Required=false)]
            public bool? SubscriptionSame { get; set; }
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }
            [NameInMap("ConnectionSet")]
            [Validation(Required=false)]
            public List<GetMqSofamqConsumerStatusResponseBodyDataConnectionSet> ConnectionSet { get; set; }
            public class GetMqSofamqConsumerStatusResponseBodyDataConnectionSet : TeaModel {
                public string ClientAddr { get; set; }
                public string ClientId { get; set; }
                public string Language { get; set; }
                public string RemoteIp { get; set; }
                public string Version { get; set; }
            }
            [NameInMap("ConsumerConnectionInfoList")]
            [Validation(Required=false)]
            public List<GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoList> ConsumerConnectionInfoList { get; set; }
            public class GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoList : TeaModel {
                public string ClientId { get; set; }
                public string Connection { get; set; }
                public string ConsumeType { get; set; }
                public string Language { get; set; }
                public long? LastTimestamp { get; set; }
                public string MessageModel { get; set; }
                public long? StartTimestamp { get; set; }
                public long? ThreadCount { get; set; }
                public string Version { get; set; }
                public List<GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoListJstack> Jstack { get; set; }
                public class GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoListJstack : TeaModel {
                    public string Thread { get; set; }
                    public List<string> TrackList { get; set; }
                }
                public List<GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoListRunningDataList> RunningDataList { get; set; }
                public class GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoListRunningDataList : TeaModel {
                    public long? Diff { get; set; }
                    public long? FailedCountPerHour { get; set; }
                    public string FailedTps { get; set; }
                    public string GroupId { get; set; }
                    public string OkTps { get; set; }
                    public string Rt { get; set; }
                    public string Topic { get; set; }
                }
                public List<GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoListSubscriptionSet> SubscriptionSet { get; set; }
                public class GetMqSofamqConsumerStatusResponseBodyDataConsumerConnectionInfoListSubscriptionSet : TeaModel {
                    public string SubString { get; set; }
                    public long? SubVersion { get; set; }
                    public string Topic { get; set; }
                    public List<string> TagsSet { get; set; }
                }
            }
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public List<GetMqSofamqConsumerStatusResponseBodyDataDetailInTopicList> DetailInTopicList { get; set; }
            public class GetMqSofamqConsumerStatusResponseBodyDataDetailInTopicList : TeaModel {
                public long? DelayTime { get; set; }
                public long? LastTimestamp { get; set; }
                public string Topic { get; set; }
                public long? TotalDiff { get; set; }
            }
        };

    }

}
