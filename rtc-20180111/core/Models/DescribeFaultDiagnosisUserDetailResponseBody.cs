// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Basic call information, returned when QueryCallUserInfo=false.</para>
        /// </summary>
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyCallInfo : TeaModel {
            /// <summary>
            /// <para>App ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0rbd****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Call status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IN</b>: In progress.</description></item>
            /// <item><description><b>OUT</b>: Ended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <para>Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>311</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The time when the call was created, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620957905</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>The time when the call was released, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620958150</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>Call duration in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        /// <summary>
        /// <para>List of impact factors. An empty list indicates that the impact factors are unknown.</para>
        /// </summary>
        [NameInMap("FactorList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorList> FactorList { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFactorList : TeaModel {
            /// <summary>
            /// <para>The factor ID. For details, see the factor ID values below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            /// <summary>
            /// <para>Abnormal source: LOCAL indicates the local end; REMOTE indicates the remote end.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LOCAL</para>
            /// </summary>
            [NameInMap("FaultSource")]
            [Validation(Required=false)]
            public string FaultSource { get; set; }

            /// <summary>
            /// <para>Associated management events, grouped by time. Coordinate data is returned when FaultType is AUDIO_STUCK, VIDEO_STUCK, VIDEO_VAGUE, or HIGH_DELAY.</para>
            /// </summary>
            [NameInMap("RelatedEventDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas> RelatedEventDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas : TeaModel {
                /// <summary>
                /// <para>List of event data.</para>
                /// </summary>
                [NameInMap("EventDataItems")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems> EventDataItems { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems : TeaModel {
                    /// <summary>
                    /// <para>Event List.</para>
                    /// </summary>
                    [NameInMap("EventList")]
                    [Validation(Required=false)]
                    public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList> EventList { get; set; }
                    public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList : TeaModel {
                        /// <summary>
                        /// <para>Event Name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>开始发布</para>
                        /// </summary>
                        [NameInMap("EventName")]
                        [Validation(Required=false)]
                        public string EventName { get; set; }

                        /// <summary>
                        /// <para>Event Type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>USER</b>: User event.</description></item>
                        /// <item><description><b>SYSTEM</b>: System event.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USER</para>
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public string EventType { get; set; }

                        /// <summary>
                        /// <para>The time of the first management event occurrence, represented as a UNIX timestamp in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1614936817</para>
                        /// </summary>
                        [NameInMap("Ts")]
                        [Validation(Required=false)]
                        public long? Ts { get; set; }

                    }

                    /// <summary>
                    /// <para>[responses_200_schema_properties_FaultMetricData_properties_Nodes_description]List of metric coordinate points.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1614936817</para>
                    /// </summary>
                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                }

                /// <summary>
                /// <para>Source role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SENDER</b>: Publisher (upstream).</description></item>
                /// <item><description><b>RECEIVER</b>: Subscriber (downstream).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SENDER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>0a497933****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>Associated metrics and coordinate data, returned when FaultType is AUDIO_STUCK, VIDEO_STUCK, VIDEO_VAGUE, or HIGH_DELAY.</para>
            /// </summary>
            [NameInMap("RelatedMetricDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas> RelatedMetricDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas : TeaModel {
                /// <summary>
                /// <para>[responses_200_schema_properties_FactorList_items_properties_RelatedEventDatas_items_properties_EventDataItems_items_properties_EventList_items_properties_EventName_type]string</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes> Nodes { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes : TeaModel {
                    /// <summary>
                    /// <para>[responses_200_schema_properties_FactorList_items_properties_RelatedEventDatas_items_properties_EventDataItems_items_properties_EventList_items_properties_Ts_title]The time of the first management event occurrence, represented as a UNIX timestamp in seconds.</para>
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Ext { get; set; }

                    /// <summary>
                    /// <para>[responses_200_schema_properties_FactorList_items_properties_FactorId_title]Factor ID: 1: Poor publisher-side Network; 2: Poor subscriber-side Network; 3: Poor publisher-side device Performance; 4: Publisher-side camera shutdown; 5: Publisher-side app moved to background Run</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1615892596</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    /// <summary>
                    /// <para>[responses_200_schema_properties_RequestId_title]The Request ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                }

                /// <summary>
                /// <para>Source role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SENDER</b>: Publisher.</description></item>
                /// <item><description><b>RECEIVER</b>: Subscriber.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SENDER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>Metric type, consistent with the metric types defined in the end-to-end metrics API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AUDIO_STUCK</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>User ID of the publisher from which the data originates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0a497933****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>Abnormal metrics.</para>
        /// </summary>
        [NameInMap("FaultMetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData FaultMetricData { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData : TeaModel {
            /// <summary>
            /// <para>List of metric coordinate points.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes : TeaModel {
                /// <summary>
                /// <para>指标趋势图中x轴横坐标，单位时间为1分钟。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620957900</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <para>指标趋势图中y轴纵坐标。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4540</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        /// <summary>
        /// <para>List of Network carriers</para>
        /// </summary>
        [NameInMap("NetworkOperators")]
        [Validation(Required=false)]
        public List<string> NetworkOperators { get; set; }

        /// <summary>
        /// <para>The Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>[responses_200_schema_properties_UserDetail_properties_CreatedTs_type]integer</para>
        /// </summary>
        [NameInMap("UserDetail")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyUserDetail UserDetail { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetail : TeaModel {
            /// <summary>
            /// <para>Call creation time, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620957919</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <para>[responses_200_schema_properties_UserDetail_properties_OnlineDuration_type]integer</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620958150</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <para>[responses_200_schema_properties_FactorList_title]List of impact factors. An empty value indicates that the impact factors are unknown.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Geographic location information, such as: Beijing City - Beijing Municipality.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省-杭州市</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>[responses_200_schema_properties_UserDetail_properties_OnlinePeriods_items_properties_JoinTs_title]Time of joining the call, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>Online duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            /// <summary>
            /// <para>Online period information.</para>
            /// </summary>
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods : TeaModel {
                /// <summary>
                /// <para>Time of joining the call, represented as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620957919</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <para>Time of leaving the call, represented as a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620958150</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <para>[responses_200_schema_properties_UserDetail_properties_OnlinePeriods_type]array</para>
            /// 
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>[responses_200_schema_properties_UserDetail_properties_Location_title]Geographic location information, such as: Beijing City - Beijing Municipality</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <para>[responses_200_schema_properties_UserDetail_properties_OnlinePeriods_items_properties_LeaveTs_title]Time of leaving the call, represented as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0a497933****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
