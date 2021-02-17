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
            public OnsConsumerStatusResponseBodyDataConnectionSet ConnectionSet { get; set; }
            public class OnsConsumerStatusResponseBodyDataConnectionSet : TeaModel {
                [NameInMap("ConnectionDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataConnectionSetConnectionDo> ConnectionDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataConnectionSetConnectionDo : TeaModel {
                    [NameInMap("RemoteIP")]
                    [Validation(Required=false)]
                    public string RemoteIP { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                }

            }
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }
            [NameInMap("ConsumerConnectionInfoList")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList ConsumerConnectionInfoList { get; set; }
            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList : TeaModel {
                [NameInMap("ConsumerConnectionInfoDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDo> ConsumerConnectionInfoDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDo : TeaModel {
                    [NameInMap("ConsumeModel")]
                    [Validation(Required=false)]
                    public string ConsumeModel { get; set; }

                    [NameInMap("RunningDataList")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataList RunningDataList { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataList : TeaModel {
                        [NameInMap("ConsumerRunningDataDo")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataListConsumerRunningDataDo> ConsumerRunningDataDo { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataListConsumerRunningDataDo : TeaModel {
                            public string GroupId { get; set; }
                            public float? Rt { get; set; }
                            public string Topic { get; set; }
                            public long? FailedCountPerHour { get; set; }
                            public float? OkTps { get; set; }
                            public float? FailedTps { get; set; }
                        }
                    };

                    [NameInMap("SubscriptionSet")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSet SubscriptionSet { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSet : TeaModel {
                        [NameInMap("SubscriptionData")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionData> SubscriptionData { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionData : TeaModel {
                            public string SubString { get; set; }
                            public long? SubVersion { get; set; }
                            public string Topic { get; set; }
                            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionDataTagsSet TagsSet { get; set; }
                            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionDataTagsSet : TeaModel {
                                [NameInMap("Tag")]
                                [Validation(Required=false)]
                                public List<string> Tag { get; set; }

                            }
                        }
                    };

                    [NameInMap("Jstack")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstack Jstack { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstack : TeaModel {
                        [NameInMap("ThreadTrackDo")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDo> ThreadTrackDo { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDo : TeaModel {
                            [NameInMap("Track")]
                            [Validation(Required=false)]
                            public List<string> Track { get; set; }

                        }
                    };

                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    [NameInMap("StartTimeStamp")]
                    [Validation(Required=false)]
                    public long? StartTimeStamp { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    [NameInMap("Connection")]
                    [Validation(Required=false)]
                    public string Connection { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("ConsumeType")]
                    [Validation(Required=false)]
                    public string ConsumeType { get; set; }

                    [NameInMap("ThreadCount")]
                    [Validation(Required=false)]
                    public int? ThreadCount { get; set; }

                }

            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataDetailInTopicList DetailInTopicList { get; set; }
            public class OnsConsumerStatusResponseBodyDataDetailInTopicList : TeaModel {
                [NameInMap("DetailInTopicDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataDetailInTopicListDetailInTopicDo> DetailInTopicDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataDetailInTopicListDetailInTopicDo : TeaModel {
                    [NameInMap("DelayTime")]
                    [Validation(Required=false)]
                    public long? DelayTime { get; set; }

                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

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
