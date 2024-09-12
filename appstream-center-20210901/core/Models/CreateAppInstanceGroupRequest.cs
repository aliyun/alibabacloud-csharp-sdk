// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestNetwork Network { get; set; }
        public class CreateAppInstanceGroupRequestNetwork : TeaModel {
            [NameInMap("DomainRules")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNetworkDomainRules> DomainRules { get; set; }
            public class CreateAppInstanceGroupRequestNetworkDomainRules : TeaModel {
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            [NameInMap("IpExpireMinutes")]
            [Validation(Required=false)]
            public int? IpExpireMinutes { get; set; }

            [NameInMap("Routes")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNetworkRoutes> Routes { get; set; }
            public class CreateAppInstanceGroupRequestNetworkRoutes : TeaModel {
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

        }

        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestNodePool NodePool { get; set; }
        public class CreateAppInstanceGroupRequestNodePool : TeaModel {
            [NameInMap("MaxIdleAppInstanceAmount")]
            [Validation(Required=false)]
            public int? MaxIdleAppInstanceAmount { get; set; }

            [NameInMap("MaxScalingAmount")]
            [Validation(Required=false)]
            public int? MaxScalingAmount { get; set; }

            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class CreateAppInstanceGroupRequestNodePoolRecurrenceSchedules : TeaModel {
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<int?> RecurrenceValues { get; set; }

                [NameInMap("TimerPeriods")]
                [Validation(Required=false)]
                public List<CreateAppInstanceGroupRequestNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class CreateAppInstanceGroupRequestNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

            }

            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            [NameInMap("WarmUp")]
            [Validation(Required=false)]
            public bool? WarmUp { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("RuntimePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestRuntimePolicy RuntimePolicy { get; set; }
        public class CreateAppInstanceGroupRequestRuntimePolicy : TeaModel {
            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public string DebugMode { get; set; }

            /// <summary>
            /// 会话类型。
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

        }

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateAppInstanceGroupRequestSecurityPolicy : TeaModel {
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestStoragePolicy StoragePolicy { get; set; }
        public class CreateAppInstanceGroupRequestStoragePolicy : TeaModel {
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

        }

        [NameInMap("UserDefinePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestUserDefinePolicy UserDefinePolicy { get; set; }
        public class CreateAppInstanceGroupRequestUserDefinePolicy : TeaModel {
            [NameInMap("CustomConfig")]
            [Validation(Required=false)]
            public string CustomConfig { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestUserInfo UserInfo { get; set; }
        public class CreateAppInstanceGroupRequestUserInfo : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestVideoPolicy VideoPolicy { get; set; }
        public class CreateAppInstanceGroupRequestVideoPolicy : TeaModel {
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public int? FrameRate { get; set; }

            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            [NameInMap("TerminalResolutionAdaptive")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptive { get; set; }

            [NameInMap("Webrtc")]
            [Validation(Required=false)]
            public bool? Webrtc { get; set; }

        }

    }

}
