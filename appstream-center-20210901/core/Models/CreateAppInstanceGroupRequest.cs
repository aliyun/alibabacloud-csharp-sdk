// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-8z4nztpaqvay4****</para>
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        [NameInMap("AppPackageType")]
        [Validation(Required=false)]
        public string AppPackageType { get; set; }

        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("IpExpireMinutes")]
            [Validation(Required=false)]
            public int? IpExpireMinutes { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("Routes")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNetworkRoutes> Routes { get; set; }
            public class CreateAppInstanceGroupRequestNetworkRoutes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>139.196.XX.XX/32</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Shared</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Shared</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestNodePool NodePool { get; set; }
        public class CreateAppInstanceGroupRequestNodePool : TeaModel {
            [NameInMap("MaxIdleAppInstanceAmount")]
            [Validation(Required=false)]
            public int? MaxIdleAppInstanceAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxScalingAmount")]
            [Validation(Required=false)]
            public int? MaxScalingAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>weekly</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>15:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-08</para>
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-01</para>
            /// </summary>
            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NODE_FIXED</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WarmUp")]
            [Validation(Required=false)]
            public bool? WarmUp { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cag-b2ron*******</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
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

            [NameInMap("PerSessionPerApp")]
            [Validation(Required=false)]
            public bool? PerSessionPerApp { get; set; }

            [NameInMap("SessionPreOpen")]
            [Validation(Required=false)]
            public string SessionPreOpen { get; set; }

            /// <summary>
            /// <para>会话类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("SessionUserGenerationMode")]
            [Validation(Required=false)]
            public string SessionUserGenerationMode { get; set; }

        }

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateAppInstanceGroupRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
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

            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public CreateAppInstanceGroupRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class CreateAppInstanceGroupRequestStoragePolicyUserProfile : TeaModel {
                [NameInMap("RemoteStoragePath")]
                [Validation(Required=false)]
                public string RemoteStoragePath { get; set; }

                [NameInMap("RemoteStorageType")]
                [Validation(Required=false)]
                public string RemoteStorageType { get; set; }

                [NameInMap("UserProfileSwitch")]
                [Validation(Required=false)]
                public bool? UserProfileSwitch { get; set; }

            }

        }

        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

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
            /// <summary>
            /// <b>Example:</b>
            /// <para>Simple</para>
            /// </summary>
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
