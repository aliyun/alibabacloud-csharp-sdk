// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeFaultDiagnosisUserDetailResponseBody : TeaModel {
        /// <summary>
        /// 通信基本信息，QueryCallUserInfo=false是返回。
        /// </summary>
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyCallInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
        };

        /// <summary>
        /// 影响因素列表，空表示影响因素未知
        /// </summary>
        [NameInMap("FactorList")]
        [Validation(Required=false)]
        public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorList> FactorList { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFactorList : TeaModel {
            /// <summary>
            /// 影响因素ID： 1：发布端网络差 2：订阅端网络差 3：发布端设备性能差 4：发布端关闭摄像头 5：发布端切到后台运行
            /// </summary>
            [NameInMap("FactorId")]
            [Validation(Required=false)]
            public string FactorId { get; set; }

            /// <summary>
            /// 异常来源 LOCAL：本端 REMOTE：远端
            /// </summary>
            [NameInMap("FaultSource")]
            [Validation(Required=false)]
            public string FaultSource { get; set; }

            /// <summary>
            /// 关联的事件，按时间分组，当FaultType为AUDIO_STUCK、VIDEO_STUCK、VIDEO_VAGUE、HIGH_DELAY时返回
            /// </summary>
            [NameInMap("RelatedEventDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas> RelatedEventDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatas : TeaModel {
                /// <summary>
                /// 事件数据列表
                /// </summary>
                [NameInMap("EventDataItems")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems> EventDataItems { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItems : TeaModel {
                    /// <summary>
                    /// 事件列表。
                    /// </summary>
                    [NameInMap("EventList")]
                    [Validation(Required=false)]
                    public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList> EventList { get; set; }
                    public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedEventDatasEventDataItemsEventList : TeaModel {
                        [NameInMap("Acs")]
                        [Validation(Required=false)]
                        public string Acs { get; set; }

                        [NameInMap("EventCode")]
                        [Validation(Required=false)]
                        public string EventCode { get; set; }

                        /// <summary>
                        /// 事件名称。
                        /// </summary>
                        [NameInMap("EventName")]
                        [Validation(Required=false)]
                        public string EventName { get; set; }

                        /// <summary>
                        /// 事件类型，取值：USER：用户事件。SYSTEM：系统事件。
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public string EventType { get; set; }

                        [NameInMap("Os")]
                        [Validation(Required=false)]
                        public string Os { get; set; }

                        [NameInMap("Sdk")]
                        [Validation(Required=false)]
                        public string Sdk { get; set; }

                        [NameInMap("StreamName")]
                        [Validation(Required=false)]
                        public string StreamName { get; set; }

                        [NameInMap("StreamType")]
                        [Validation(Required=false)]
                        public string StreamType { get; set; }

                        [NameInMap("TrackCode")]
                        [Validation(Required=false)]
                        public string TrackCode { get; set; }

                        [NameInMap("TrackName")]
                        [Validation(Required=false)]
                        public string TrackName { get; set; }

                        /// <summary>
                        /// 事件发生的时间，使用UNIX时间戳表示，单位：秒。
                        /// </summary>
                        [NameInMap("Ts")]
                        [Validation(Required=false)]
                        public long? Ts { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// 第一个事件发生的时间，使用UNIX时间戳表示，单位：秒。
                    /// </summary>
                    [NameInMap("Ts")]
                    [Validation(Required=false)]
                    public long? Ts { get; set; }

                }

                /// <summary>
                /// 来源角色： SENDER：发布端，即上行 RECEIVER：订阅端，即下行
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// 用户ID
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 关联的指标，坐标数据，当FaultType为AUDIO_STUCK、VIDEO_STUCK、VIDEO_VAGUE、HIGH_DELAY时返回
            /// </summary>
            [NameInMap("RelatedMetricDatas")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas> RelatedMetricDatas { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatas : TeaModel {
                /// <summary>
                /// 坐标数据列表
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes> Nodes { get; set; }
                public class DescribeFaultDiagnosisUserDetailResponseBodyFactorListRelatedMetricDatasNodes : TeaModel {
                    /// <summary>
                    /// 扩展数据
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Ext { get; set; }

                    /// <summary>
                    /// X坐标值，秒级时间戳
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public string X { get; set; }

                    /// <summary>
                    /// Y坐标值，指标值
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public string Y { get; set; }

                }

                /// <summary>
                /// 来源角色： SENDER：发布端，即上行 RECEIVER：订阅端，即下行
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// 指标类型，参照端到端指标接口的指标类型
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 数据来自对应发布端的用户ID
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// 异常指标
        /// </summary>
        [NameInMap("FaultMetricData")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData FaultMetricData { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes> Nodes { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyFaultMetricDataNodes : TeaModel {
                public string X { get; set; }
                public string Y { get; set; }
            }
        };

        /// <summary>
        /// 网络运营商列表
        /// </summary>
        [NameInMap("NetworkOperators")]
        [Validation(Required=false)]
        public List<string> NetworkOperators { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 诊断用户详细信，QueryCallUserInfo=false是返回息
        /// </summary>
        [NameInMap("UserDetail")]
        [Validation(Required=false)]
        public DescribeFaultDiagnosisUserDetailResponseBodyUserDetail UserDetail { get; set; }
        public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetail : TeaModel {
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }
            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }
            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeFaultDiagnosisUserDetailResponseBodyUserDetailOnlinePeriods : TeaModel {
                public long? JoinTs { get; set; }
                public long? LeaveTs { get; set; }
            }
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }
            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

    }

}
