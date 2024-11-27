// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerStatusResponseBodyData Data { get; set; }
        public class OnsConsumerStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about online consumers in the consumer group.</para>
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
                    /// <para>The IP address and port number of the consumer instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30.5.121.**</para>
                    /// </summary>
                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30.5.121.**@25560#-1999745829#-1737591554#458773089270275</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The programming language in which the consumer is developed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JAVA</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// <para>The private or public IP address of the host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>42.120.74.**</para>
                    /// </summary>
                    [NameInMap("RemoteIP")]
                    [Validation(Required=false)]
                    public string RemoteIP { get; set; }

                    /// <summary>
                    /// <para>The version of the consumer client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V4_3_6_SNAPSHOT</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The consumption mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CLUSTERING</b>: the clustering consumption mode</description></item>
            /// <item><description><b>BROADCASTING</b>: the broadcasting consumption mode</description></item>
            /// </list>
            /// <para>For more information about consumption modes, see <a href="https://help.aliyun.com/document_detail/43163.html">Clustering consumption and broadcasting consumption</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLUSTERING</para>
            /// </summary>
            [NameInMap("ConsumeModel")]
            [Validation(Required=false)]
            public string ConsumeModel { get; set; }

            /// <summary>
            /// <para>The TPS for message consumption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ConsumeTps")]
            [Validation(Required=false)]
            public float? ConsumeTps { get; set; }

            /// <summary>
            /// <para>The details of online consumers in the consumer group, including the information about the thread stack traces and the consumption response time (RT). If you want to obtain the details of online consumers in the consumer group, make sure that the <b>Detail</b> parameter in the request is set to <b>true</b>. If the Detail parameter is not set to true, the value of this parameter is empty.</para>
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
                    /// <para>The ID of the consumer instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>30.5.**.**</c>@25560#-1999745829#-1737591554#458773089270275</para>
                    /// </summary>
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The connection information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>**</para>
                    /// </summary>
                    [NameInMap("Connection")]
                    [Validation(Required=false)]
                    public string Connection { get; set; }

                    /// <summary>
                    /// <para>The consumption mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>CLUSTERING</b>: the clustering consumption mode</description></item>
                    /// <item><description><b>BROADCASTING</b>: the broadcasting consumption mode</description></item>
                    /// </list>
                    /// <para>For more information about consumption modes, see <a href="https://help.aliyun.com/document_detail/43163.html">Clustering consumption and broadcasting consumption</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CLUSTERING</para>
                    /// </summary>
                    [NameInMap("ConsumeModel")]
                    [Validation(Required=false)]
                    public string ConsumeModel { get; set; }

                    /// <summary>
                    /// <para>The mode in which the consumer consumes messages. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>PUSH</b>: The ApsaraMQ for RocketMQ broker pushes messages to the consumer.</description></item>
                    /// <item><description><b>PULL</b>: The consumer pulls messages from the ApsaraMQ for RocketMQ broker.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PUSH</para>
                    /// </summary>
                    [NameInMap("ConsumeType")]
                    [Validation(Required=false)]
                    public string ConsumeType { get; set; }

                    /// <summary>
                    /// <para>The information about thread stack traces. If you want to obtain the information about thread stack traces, make sure that the <b>NeedJstack</b> parameter in the request is set to <b>true</b>. If the NeedJstack parameter is not set to true, the value of this parameter is empty.</para>
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
                            /// <para>The name of the thread.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ConsumeMessageThread_0</para>
                            /// </summary>
                            [NameInMap("Thread")]
                            [Validation(Required=false)]
                            public string Thread { get; set; }

                            /// <summary>
                            /// <para>The details of thread stack traces.</para>
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
                    /// <para>The programming language that the consumer supports.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>JAVA</para>
                    /// </summary>
                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    /// <summary>
                    /// <para>The most recent point in time when a message was consumed.</para>
                    /// <para>The value of this parameter is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570701368114</para>
                    /// </summary>
                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    /// <summary>
                    /// <para>The real-time statistics.</para>
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
                            /// <para>The number of messages that failed to be consumed each hour.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("FailedCountPerHour")]
                            [Validation(Required=false)]
                            public long? FailedCountPerHour { get; set; }

                            /// <summary>
                            /// <para>The TPS for failed message consumption.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("FailedTps")]
                            [Validation(Required=false)]
                            public float? FailedTps { get; set; }

                            /// <summary>
                            /// <para>The TPS for successful message consumption.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("OkTps")]
                            [Validation(Required=false)]
                            public float? OkTps { get; set; }

                            /// <summary>
                            /// <para>The consumption RT. Unit: milliseconds.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Rt")]
                            [Validation(Required=false)]
                            public float? Rt { get; set; }

                            /// <summary>
                            /// <para>The name of the topic to which the consumer subscribes.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test-mq_topic</para>
                            /// </summary>
                            [NameInMap("Topic")]
                            [Validation(Required=false)]
                            public string Topic { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The earliest point in time when a message was consumed.</para>
                    /// <para>The value of this parameter is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570701361528</para>
                    /// </summary>
                    [NameInMap("StartTimeStamp")]
                    [Validation(Required=false)]
                    public long? StartTimeStamp { get; set; }

                    /// <summary>
                    /// <para>The information about subscriptions.</para>
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
                            /// <para>The expression that is used to specify the tags of messages in the subscribed topic.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <list type="bullet">
                            /// <item><description></description></item>
                            /// </list>
                            /// </summary>
                            [NameInMap("SubString")]
                            [Validation(Required=false)]
                            public string SubString { get; set; }

                            /// <summary>
                            /// <para>The subscription version. The value is of the LONG type and is automatically incremented.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1570701364301</para>
                            /// </summary>
                            [NameInMap("SubVersion")]
                            [Validation(Required=false)]
                            public long? SubVersion { get; set; }

                            /// <summary>
                            /// <para>The information about the tags of the topic to which the consumer subscribes.</para>
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
                            /// <para>The name of the topic to which the consumer subscribes.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>test-mq_topic</para>
                            /// </summary>
                            [NameInMap("Topic")]
                            [Validation(Required=false)]
                            public string Topic { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The number of consumer threads.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("ThreadCount")]
                    [Validation(Required=false)]
                    public int? ThreadCount { get; set; }

                    /// <summary>
                    /// <para>The version of the consumer client.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>V4_3_6</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The maximum latency of message consumption in all topics to which the consumer group subscribes. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100857</para>
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public long? DelayTime { get; set; }

            /// <summary>
            /// <para>The information about message consumption by topic. If you want to obtain the information about the consumption status of each topic, make sure that the <b>Detail</b> parameter in the request is set to <b>true</b>. If the Detail parameter is not set to true, the value of this parameter is empty.</para>
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
                    /// <para>The latency of message consumption in the topic. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DelayTime")]
                    [Validation(Required=false)]
                    public long? DelayTime { get; set; }

                    /// <summary>
                    /// <para>The most recent point in time when a message was consumed.</para>
                    /// <para>The value of this parameter is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570701259403</para>
                    /// </summary>
                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    /// <summary>
                    /// <para>The topic name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-mq_topic</para>
                    /// </summary>
                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    /// <summary>
                    /// <para>The number of accumulated messages in the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalDiff")]
                    [Validation(Required=false)]
                    public long? TotalDiff { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_111111111111_DOxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The most recent point in time when a message was consumed.</para>
            /// <para>The value of this parameter is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1566883844954</para>
            /// </summary>
            [NameInMap("LastTimestamp")]
            [Validation(Required=false)]
            public long? LastTimestamp { get; set; }

            /// <summary>
            /// <para>Indicates whether the consumer group is online.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>Indicates whether load balancing is performed as expected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Load balancing is performed as expected.</description></item>
            /// <item><description><b>false</b>: Load balancing is not performed as expected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RebalanceOK")]
            [Validation(Required=false)]
            public bool? RebalanceOK { get; set; }

            /// <summary>
            /// <para>Indicates whether all consumers in the consumer group subscribe to the same topics and tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SubscriptionSame")]
            [Validation(Required=false)]
            public bool? SubscriptionSame { get; set; }

            /// <summary>
            /// <para>The total number of accumulated messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>197</para>
            /// </summary>
            [NameInMap("TotalDiff")]
            [Validation(Required=false)]
            public long? TotalDiff { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10EDC518-10E7-4B34-92FB-171235FA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
