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
            [NameInMap("ConnectionSet")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataConnectionSet ConnectionSet { get; set; }
            public class OnsConsumerStatusResponseBodyDataConnectionSet : TeaModel {
                [NameInMap("ConnectionDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataConnectionSetConnectionDo> ConnectionDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataConnectionSetConnectionDo : TeaModel {
                    [NameInMap("ClientAddr")]
                    [Validation(Required=false)]
                    public string ClientAddr { get; set; }

                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Diff")]
                    [Validation(Required=false)]
                    public long? Diff { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("RemoteIP")]
                    [Validation(Required=false)]
                    public string RemoteIP { get; set; }

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

            [NameInMap("ConsumerConnectionInfoList")]
            [Validation(Required=false)]
            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList ConsumerConnectionInfoList { get; set; }
            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoList : TeaModel {
                [NameInMap("ConsumerConnectionInfoDo")]
                [Validation(Required=false)]
                public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDo> ConsumerConnectionInfoDo { get; set; }
                public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDo : TeaModel {
                    [NameInMap("ClientId")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    [NameInMap("Connection")]
                    [Validation(Required=false)]
                    public string Connection { get; set; }

                    [NameInMap("ConsumeModel")]
                    [Validation(Required=false)]
                    public string ConsumeModel { get; set; }

                    [NameInMap("ConsumeType")]
                    [Validation(Required=false)]
                    public string ConsumeType { get; set; }

                    [NameInMap("Jstack")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstack Jstack { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstack : TeaModel {
                        [NameInMap("ThreadTrackDo")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDo> ThreadTrackDo { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoJstackThreadTrackDo : TeaModel {
                            [NameInMap("Thread")]
                            [Validation(Required=false)]
                            public string Thread { get; set; }

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

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    [NameInMap("RunningDataList")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataList RunningDataList { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataList : TeaModel {
                        [NameInMap("ConsumerRunningDataDo")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataListConsumerRunningDataDo> ConsumerRunningDataDo { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoRunningDataListConsumerRunningDataDo : TeaModel {
                            [NameInMap("FailedCountPerHour")]
                            [Validation(Required=false)]
                            public long? FailedCountPerHour { get; set; }

                            [NameInMap("FailedTps")]
                            [Validation(Required=false)]
                            public float? FailedTps { get; set; }

                            [NameInMap("OkTps")]
                            [Validation(Required=false)]
                            public float? OkTps { get; set; }

                            [NameInMap("Rt")]
                            [Validation(Required=false)]
                            public float? Rt { get; set; }

                            [NameInMap("Topic")]
                            [Validation(Required=false)]
                            public string Topic { get; set; }

                        }

                    }

                    [NameInMap("StartTimeStamp")]
                    [Validation(Required=false)]
                    public long? StartTimeStamp { get; set; }

                    [NameInMap("SubscriptionSet")]
                    [Validation(Required=false)]
                    public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSet SubscriptionSet { get; set; }
                    public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSet : TeaModel {
                        [NameInMap("SubscriptionData")]
                        [Validation(Required=false)]
                        public List<OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionData> SubscriptionData { get; set; }
                        public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionData : TeaModel {
                            [NameInMap("SubString")]
                            [Validation(Required=false)]
                            public string SubString { get; set; }

                            [NameInMap("SubVersion")]
                            [Validation(Required=false)]
                            public long? SubVersion { get; set; }

                            [NameInMap("TagsSet")]
                            [Validation(Required=false)]
                            public OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionDataTagsSet TagsSet { get; set; }
                            public class OnsConsumerStatusResponseBodyDataConsumerConnectionInfoListConsumerConnectionInfoDoSubscriptionSetSubscriptionDataTagsSet : TeaModel {
                                [NameInMap("Tag")]
                                [Validation(Required=false)]
                                public List<string> Tag { get; set; }

                            }

                            [NameInMap("Topic")]
                            [Validation(Required=false)]
                            public string Topic { get; set; }

                        }

                    }

                    [NameInMap("ThreadCount")]
                    [Validation(Required=false)]
                    public int? ThreadCount { get; set; }

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

                    [NameInMap("LastTimestamp")]
                    [Validation(Required=false)]
                    public long? LastTimestamp { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

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
