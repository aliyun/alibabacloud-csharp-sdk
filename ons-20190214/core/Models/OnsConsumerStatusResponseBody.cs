// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerStatusResponseBodyData Data { get; set; }
        public class OnsConsumerStatusResponseBodyData : TeaModel {
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public float? ConsumeTps { get; set; }
            [NameInMap("ConsumeModel")]
            [Validation(Required=false)]
            public string ConsumeModel { get; set; }
            [NameInMap("ConnectionSet")]
            [Validation(Required=false)]
            public List<OnsConsumerStatusResponseBodyDataConnectionSet> ConnectionSet { get; set; }
            public class OnsConsumerStatusResponseBodyDataConnectionSet : TeaModel {
                public string RemoteIP { get; set; }
                public string Version { get; set; }
                public string ClientAddr { get; set; }
                public string Language { get; set; }
                public string ClientId { get; set; }
            }
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }
            [NameInMap("ConsumerConnectionInfoList")]
            [Validation(Required=false)]
            public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList> ConsumerConnectionInfoList { get; set; }
            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList : TeaModel {
                public string ConsumeModel { get; set; }
                public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListRunningDataList> RunningDataList { get; set; }
                public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListRunningDataList : TeaModel {
                    public string GroupId { get; set; }
                    public float? Rt { get; set; }
                    public string Topic { get; set; }
                    public long? FailedCountPerHour { get; set; }
                    public float? OkTps { get; set; }
                    public float? FailedTps { get; set; }
                }
                public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListSubscriptionSet> SubscriptionSet { get; set; }
                public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListSubscriptionSet : TeaModel {
                    public string SubString { get; set; }
                    public long? SubVersion { get; set; }
                    public string Topic { get; set; }
                    public List<string> TagsSet { get; set; }
                }
                public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListJstack> Jstack { get; set; }
                public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListJstack : TeaModel {
                    public List<string> TrackList { get; set; }
                    public string Thread { get; set; }
                }
                public long? LastTimeStamp { get; set; }
                public long? StartTimeStamp { get; set; }
                public string Language { get; set; }
                public string ClientId { get; set; }
                public string Connection { get; set; }
                public string Version { get; set; }
                public string ConsumeType { get; set; }
                public int? ThreadCount { get; set; }
            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public List<OnsConsumerStatusResponseBodyDataDetailInTopicList> DetailInTopicList { get; set; }
            public class OnsConsumerStatusResponseBodyDataDetailInTopicList : TeaModel {
                public long? DelayTime { get; set; }
                public long? TotalDiff { get; set; }
                public long? LastTimestamp { get; set; }
                public string Topic { get; set; }
            }
            [NameInMap("SubscriptionSame")]
            [Validation(Required=false)]
            public bool? SubscriptionSame { get; set; }
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("RebalanceOK")]
            [Validation(Required=false)]
            public bool? RebalanceOK { get; set; }
        };

    }

}
