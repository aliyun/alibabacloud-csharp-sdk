// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeFaultDiagnosisUserDetailResponseBody : TeaModel {
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
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>311</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620957905</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620958150</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        [NameInMap("FactorList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorList> FactorList { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFactorList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LOCAL</para>
            /// </summary>
            [NameInMap("FaultSource")]
            [Validation(Required=false)]
            public string FaultSource { get; set; }

            [NameInMap("RelatedEventDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas> RelatedEventDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas : TeaModel {
                [NameInMap("EventDataItems")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems> EventDataItems { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems : TeaModel {
                    [NameInMap("EventList")]
                    [Validation(Required=false)]
                    public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList> EventList { get; set; }
                    public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>开始发布</para>
                        /// </summary>
                        [NameInMap("EventName")]
                        [Validation(Required=false)]
                        public string EventName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>USER</para>
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public string EventType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1614936817</para>
                        /// </summary>
                        [NameInMap("Ts")]
                        [Validation(Required=false)]
                        public long? Ts { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1614936817</para>
                    /// </summary>
                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SENDER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0a497933****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("RelatedMetricDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas> RelatedMetricDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas : TeaModel {
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes> Nodes { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes : TeaModel {
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Ext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1615892596</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SENDER</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AUDIO_STUCK</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0a497933****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("FaultMetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData FaultMetricData { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1620957900</para>
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.4540</para>
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

        }

        [NameInMap("NetworkOperators")]
        [Validation(Required=false)]
        public List<string> NetworkOperators { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserDetail")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyUserDetail UserDetail { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1620957919</para>
            /// </summary>
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620958150</para>
            /// </summary>
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省-杭州市</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4G</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1620957919</para>
                /// </summary>
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1620958150</para>
                /// </summary>
                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0a497933****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
