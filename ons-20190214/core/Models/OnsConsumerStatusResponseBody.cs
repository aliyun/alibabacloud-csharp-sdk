// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerStatusResponseBody : TeaModel {
        /// <summary>
        /// The query results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerStatusResponseBodyData Data { get; set; }
        public class OnsConsumerStatusResponseBodyData : TeaModel {
            /// <summary>
            /// The information about online consumers in the consumer group.
            /// </summary>
            [NameInMap("ConnectionSet")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataConnectionSet ConnectionSet { get; set; }
            public class OnsConsumerStatusResponseBodyDataConnectionSet : TeaModel {
                [NameInMap("ConnectionDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataConnectionSetConnectionDo> ConnectionDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataConnectionSetConnectionDo : TeaModel {
                    /// <summary>
                    /// The IP address and port number of the consumer instance.
                    /// </summary>
                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    /// <summary>
                    /// The ID of the consumer instance.
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// The programming language that the consumer client supports.
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// The private or public IP address of the host.
                    /// </summary>
                    [NameInMap("RemoteIP")]
                    [Validation(Required=false)]
                    public string RemoteIP { get; set; }

                    /// <summary>
                    /// The version of the consumer client.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The consumption mode. Valid values:
            /// 
            /// *   **CLUSTERING:** the clustering consumption mode
            /// *   **BROADCASTING:** the broadcasting consumption mode
            /// 
            /// For more information about consumption modes, see [Clustering consumption and broadcasting consumption](~~43163~~).
            /// </summary>
            [NameInMap("ConsumeModel")]
            [Validation(Required=false)]
            public string ConsumeModel { get; set; }

            /// <summary>
            /// The TPS for message consumption.
            /// </summary>
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public float? ConsumeTps { get; set; }

            /// <summary>
            /// The details of online consumers in the consumer group, including the information about the thread stack traces and the consumption response time (RT). If you want to obtain the details of online consumers in the consumer group, make sure that the **Detail** parameter in the request is set to **true**. If the Detail parameter is not set to true, the value of this parameter is empty.
            /// </summary>
            [NameInMap("ConsumerConnectionInfoList")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList ConsumerConnectionInfoList { get; set; }
            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList : TeaModel {
                [NameInMap("ConsumerConnectionInfoDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDo> ConsumerConnectionInfoDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDo : TeaModel {
                    /// <summary>
                    /// The ID of the consumer instance.
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// The connection information.
                    /// </summary>
                    [NameInMap("Connection")]
                    [Validation(Required=false)]
                    public string Connection { get; set; }

                    /// <summary>
                    /// The consumption mode. Valid values:
                    /// 
                    /// *   **CLUSTERING:** the clustering consumption mode
                    /// *   **BROADCASTING:** the broadcasting consumption mode
                    /// 
                    /// For more information about consumption modes, see [Clustering consumption and broadcasting consumption](~~43163~~).
                    /// </summary>
                    [NameInMap("ConsumeModel")]
                    [Validation(Required=false)]
                    public string ConsumeModel { get; set; }

                    /// <summary>
                    /// The mode in which the consumer consumes messages. Valid values:
                    /// 
                    /// *   **PUSH:** The Message Queue for Apache RocketMQ broker pushes messages to the consumer.
                    /// *   **PULL:** The consumer pulls messages from the Message Queue for Apache RocketMQ broker.
                    /// </summary>
                    [NameInMap("ConsumeType")]
                    [Validation(Required=false)]
                    public string ConsumeType { get; set; }

                    /// <summary>
                    /// The information about thread stack traces. If you want to obtain the information about thread stack traces, make sure that the **NeedJstack** parameter in the request is set to **true**. If the NeedJstack parameter is not set to true, the value of this parameter is empty.
                    /// </summary>
                    [NameInMap("Jstack")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstack Jstack { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstack : TeaModel {
                        [NameInMap("ThreadTrackDo")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDo> ThreadTrackDo { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDo : TeaModel {
                            /// <summary>
                            /// The name of the thread.
                            /// </summary>
                            [NameInMap("Thread")]
                            [Validation(Required=false)]
                            public string Thread { get; set; }

                            /// <summary>
                            /// The details of thread stack traces.
                            /// </summary>
                            [NameInMap("TrackList")]
                            [Validation(Required=false)]
                            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDoTrackList TrackList { get; set; }
                            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDoTrackList : TeaModel {
                                [NameInMap("Track")]
                                [Validation(Required=false)]
                                public List<string> Track { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// The programming language that the consumer supports.
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// The most recent point in time when a message was consumed.
                    /// 
                    /// The value of this parameter is a UNIX timestamp in milliseconds.
                    /// </summary>
                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    /// <summary>
                    /// The real-time statistics.
                    /// </summary>
                    [NameInMap("RunningDataList")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataList RunningDataList { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataList : TeaModel {
                        [NameInMap("ConsumerRunningDataDo")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataListConsumerRunningDataDo> ConsumerRunningDataDo { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataListConsumerRunningDataDo : TeaModel {
                            /// <summary>
                            /// The number of messages that failed to be consumed each hour.
                            /// </summary>
                            [NameInMap("FailedCountPerHour")]
                            [Validation(Required=false)]
                            public long? FailedCountPerHour { get; set; }

                            /// <summary>
                            /// The TPS for failed message consumption.
                            /// </summary>
                            [NameInMap("FailedTps")]
                            [Validation(Required=false)]
                            public float? FailedTps { get; set; }

                            /// <summary>
                            /// The ID of the consumer group.
                            /// </summary>
                            [NameInMap("GroupId")]
                            [Validation(Required=false)]
                            public string GroupId { get; set; }

                            /// <summary>
                            /// The TPS for successful message consumption.
                            /// </summary>
                            [NameInMap("OkTps")]
                            [Validation(Required=false)]
                            public float? OkTps { get; set; }

                            /// <summary>
                            /// The consumption RT. Unit: milliseconds.
                            /// </summary>
                            [NameInMap("Rt")]
                            [Validation(Required=false)]
                            public float? Rt { get; set; }

                            /// <summary>
                            /// The name of the topic to which the consumer subscribes.
                            /// </summary>
                            [NameInMap("Topic")]
                            [Validation(Required=false)]
                            public string Topic { get; set; }

                        }

                    }

                    /// <summary>
                    /// The earliest point in time when a message was consumed.
                    /// 
                    /// The value of this parameter is a UNIX timestamp in milliseconds.
                    /// </summary>
                    [NameInMap("StartTimeStamp")]
                    [Validation(Required=false)]
                    public long? StartTimeStamp { get; set; }

                    /// <summary>
                    /// The information about subscriptions.
                    /// </summary>
                    [NameInMap("SubscriptionSet")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSet SubscriptionSet { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSet : TeaModel {
                        [NameInMap("SubscriptionData")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionData> SubscriptionData { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionData : TeaModel {
                            /// <summary>
                            /// The expression that is used to specify the tags of messages in the subscribed topic.
                            /// </summary>
                            [NameInMap("SubString")]
                            [Validation(Required=false)]
                            public string SubString { get; set; }

                            /// <summary>
                            /// The subscription version. The value is of the LONG type and is automatically incremented.
                            /// </summary>
                            [NameInMap("SubVersion")]
                            [Validation(Required=false)]
                            public long? SubVersion { get; set; }

                            /// <summary>
                            /// The information about the tags of the topic to which the consumer subscribes.
                            /// </summary>
                            [NameInMap("TagsSet")]
                            [Validation(Required=false)]
                            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionDataTagsSet TagsSet { get; set; }
                            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionDataTagsSet : TeaModel {
                                [NameInMap("Tag")]
                                [Validation(Required=false)]
                                public List<string> Tag { get; set; }

                            }

                            /// <summary>
                            /// The name of the topic to which the consumer subscribes.
                            /// </summary>
                            [NameInMap("Topic")]
                            [Validation(Required=false)]
                            public string Topic { get; set; }

                        }

                    }

                    /// <summary>
                    /// The number of consumer threads.
                    /// </summary>
                    [NameInMap("ThreadCount")]
                    [Validation(Required=false)]
                    public int? ThreadCount { get; set; }

                    /// <summary>
                    /// The version of the consumer client.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The maximum latency of message consumption in all topics to which the consumer group subscribe. Unit: milliseconds.
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }

            /// <summary>
            /// The information about message consumption by topic. If you want to obtain the information about the consumption status of each topic, make sure that the **Detail** parameter in the request is set to **true**. If the Detail parameter is not set to true, the value of this parameter is empty.
            /// </summary>
            [NameInMap("DetailInTopicList")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataDetailInTopicList DetailInTopicList { get; set; }
            public class OnsConsumerStatusResponseBodyDataDetailInTopicList : TeaModel {
                [NameInMap("DetailInTopicDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataDetailInTopicListDetailInTopicDo> DetailInTopicDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataDetailInTopicListDetailInTopicDo : TeaModel {
                    /// <summary>
                    /// The latency of message consumption in the topic. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("DelayTime")]
                    [Validation(Required=false)]
                    public long? DelayTime { get; set; }

                    /// <summary>
                    /// The most recent point in time when a message was consumed.
                    /// 
                    /// The value of this parameter is a UNIX timestamp in milliseconds.
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    /// <summary>
                    /// The name of the topic.
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// The number of accumulated messages in the topic.
                    /// </summary>
                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The most recent point in time when a message was consumed.
            /// 
            /// The value of this parameter is a UNIX timestamp in milliseconds.
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// Indicates whether the consumer group is online.
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// Indicates whether load balancing is performed as expected. Valid values:
            /// 
            /// *   **true:** Load balancing is performed as expected.
            /// *   **false:** Load balancing is not performed as expected.
            /// </summary>
            [NameInMap("RebalanceOK")]
            [Validation(Required=false)]
            public bool? RebalanceOK { get; set; }

            /// <summary>
            /// Indicates whether all consumers in the consumer group subscribe to the same topics and tags.
            /// </summary>
            [NameInMap("SubscriptionSame")]
            [Validation(Required=false)]
            public bool? SubscriptionSame { get; set; }

            /// <summary>
            /// The total number of accumulated messages.
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
