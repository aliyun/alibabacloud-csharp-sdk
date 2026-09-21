// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The application image ID. You can obtain the ID from the <b>O&amp;M</b> &gt; <b>Custom Images</b> or <b>System Images</b> page in the <a href="https://appstreaming.console.aliyun.com/">WUYING CloudApp console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-8z4nztpaqvay4****</para>
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        /// <summary>
        /// <para>The name of the delivery group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeApp</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The package type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser.package.5.250.appstreaming.general.basic</para>
        /// </summary>
        [NameInMap("AppPackageType")]
        [Validation(Required=false)]
        public string AppPackageType { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-0clfzcy0adpcf****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The delivery group authorization mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>App</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthMode")]
        [Validation(Required=false)]
        public string AuthMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cls-d39iq73l5c0a8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <remarks>
        /// <para>To use this parameter, submit a ticket.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestNetwork Network { get; set; }
        public class CreateAppInstanceGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The domain name rule configurations.</para>
            /// </summary>
            [NameInMap("DomainRules")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNetworkDomainRules> DomainRules { get; set; }
            public class CreateAppInstanceGroupRequestNetworkDomainRules : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The policy value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            /// <summary>
            /// <para>The duration in minutes after which a public IP address triggers an update upon the next logon. Minimum value: 60. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("IpExpireMinutes")]
            [Validation(Required=false)]
            public int? IpExpireMinutes { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong+dir-842567****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The route configurations. This parameter can be configured only when the network policy type (StrategyType) is set to mixed mode (Mixed).</para>
            /// </summary>
            [NameInMap("Routes")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNetworkRoutes> Routes { get; set; }
            public class CreateAppInstanceGroupRequestNetworkRoutes : TeaModel {
                /// <summary>
                /// <para>The access destination in CIDR format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139.196.XX.XX/32</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                /// <summary>
                /// <para>The network egress mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shared</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The network policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shared</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs.</para>
            /// <list type="bullet">
            /// <item><description>Valid only for custom office networks.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The node pool object.</para>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestNodePool NodePool { get; set; }
        public class CreateAppInstanceGroupRequestNodePool : TeaModel {
            /// <summary>
            /// <para>The maximum number of idle sessions. When this value is specified, automatic scale-out is triggered only when the session usage exceeds <c>ScalingUsageThreshold</c> and the number of idle sessions in the current delivery group is less than <c>MaxIdleAppInstanceAmount</c>. Otherwise, the idle sessions in the delivery group are considered sufficient and no automatic scale-out is performed. This parameter allows you to flexibly control elastic scaling behavior and reduce costs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxIdleAppInstanceAmount")]
            [Validation(Required=false)]
            public int? MaxIdleAppInstanceAmount { get; set; }

            /// <summary>
            /// <para>The maximum number of resources that can be created during scale-out. This parameter is required when <c>StrategyType</c> is set to <c>NODE_SCALING_BY_USAGE</c> (elastic resources).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxScalingAmount")]
            [Validation(Required=false)]
            public int? MaxScalingAmount { get; set; }

            /// <summary>
            /// <para>The number of resources to purchase. Valid values: 1 to 100.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required for subscription resources.</description></item>
            /// <item><description>This parameter is required for pay-as-you-go resources when the scaling mode (<c>StrategyType</c>) is set to fixed quantity (<c>NODE_FIXED</c>) or automatic scaling (<c>NODE_SCALING_BY_USAGE</c>).</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The number of concurrent sessions, which is the number of sessions that a single resource can handle simultaneously. Too many simultaneous sessions may degrade the application experience. The valid value range varies by resource specification. You can obtain the valid value range for each resource specification by calling the ListNodeInstanceType operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            /// <summary>
            /// <para>The instance type ID of the resource to purchase. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/428502.html">ListNodeInstanceType</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.general.4c8g</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <para>The list of policy execution schedules. This parameter is required when <c>StrategyType</c> (scaling mode) is set to <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling).</para>
            /// </summary>
            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class CreateAppInstanceGroupRequestNodePoolRecurrenceSchedules : TeaModel {
                /// <summary>
                /// <para>The type of the policy execution schedule. You must specify both <c>RecurrenceType</c> and <c>RecurrenceValues</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weekly</para>
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                /// <summary>
                /// <para>The list of values for the policy execution schedule.</para>
                /// </summary>
                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<int?> RecurrenceValues { get; set; }

                /// <summary>
                /// <para>The list of time periods for the policy execution schedule. Requirements for time period settings:</para>
                /// <list type="bullet">
                /// <item><description>You can add up to three time periods.</description></item>
                /// <item><description>Time periods cannot overlap.</description></item>
                /// <item><description>The interval between time periods must be at least 5 minutes.</description></item>
                /// <item><description>Each time period must be at least 15 minutes long.</description></item>
                /// <item><description>All time periods combined must not span across days.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("TimerPeriods")]
                [Validation(Required=false)]
                public List<CreateAppInstanceGroupRequestNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class CreateAppInstanceGroupRequestNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                    /// <summary>
                    /// <para>The resource count.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// <para>The end time. Format: HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time. Format: HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The maximum duration (in minutes) that a resource without session connections is retained. When no sessions are connected to a resource, a countdown starts based on the duration specified here. The resource is released when the countdown ends. Valid values: 5 to 120. Default value: 5. The following exceptions apply:</para>
            /// <list type="bullet">
            /// <item><description>If the scale-in would trigger automatic scale-out again, the scale-in is not performed to avoid repeated scale-in and scale-out operations.</description></item>
            /// <item><description>If automatic scale-out is triggered due to an increase in sessions during this period, the resource is not released as originally planned, and the countdown restarts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <para>The number of resources created per scale-out operation. Valid values: 1 to 10. This parameter is required when <c>StrategyType</c> is set to <c>NODE_SCALING_BY_USAGE</c> (elastic resources).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <para>The upper threshold of session usage (%). Automatic scale-out is triggered when the session usage exceeds this threshold. The session usage is calculated as follows: <c>Session usage = Current sessions ÷ (Total resources × Concurrent sessions per resource) × 100%</c>. This parameter is required when <c>StrategyType</c> is set to <c>NODE_SCALING_BY_USAGE</c> (elastic resources). Valid values: 0 to 100. Default value: 85.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <para>The date when the policy expires. Format: yyyy-MM-dd. The interval between the expiration date and the effective date must be between 7 days and 1 year, inclusive. This parameter is required when <c>StrategyType</c> (scaling mode) is set to <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08</para>
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// <para>The date when the policy takes effect. Format: yyyy-MM-dd. The date must be equal to or later than the current date. This parameter is required when <c>StrategyType</c> (scaling mode) is set to <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01</para>
            /// </summary>
            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            /// <summary>
            /// <para>The scaling mode.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><c>NODE_FIXED</c> (Fixed Quantity): applicable to subscription and pay-as-you-go resources.</description></item>
            /// <item><description><c>NODE_SCALING_BY_USAGE</c> (Automatic Scaling): applicable to subscription and pay-as-you-go resources.</description></item>
            /// <item><description><c>NODE_SCALING_BY_SCHEDULE</c> (Scheduled Scaling): applicable only to pay-as-you-go resources.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NODE_FIXED</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the resource prefetch policy. This parameter is required when <c>StrategyType</c> (scaling mode) is set to <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WarmUp")]
            [Validation(Required=false)]
            public bool? WarmUp { get; set; }

        }

        /// <summary>
        /// <para>The duration for which you want to purchase resources when <c>ChargeType</c> is set to <c>PrePaid</c>. This parameter is required in this case. The unit is specified by <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Week</c>, valid values of this parameter:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values of this parameter:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values of this parameter:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When <c>ChargeType</c> is set to <c>PostPaid</c>, set this parameter to the fixed value 1.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration when <c>ChargeType</c> is set to <c>PrePaid</c>.</para>
        /// <remarks>
        /// <para>This parameter is case-sensitive. For example, <c>Week</c> is valid, but <c>week</c> is invalid.
        /// In addition, if the request parameters do not match the valid combinations, such as <c>2 Week</c>, the API call succeeds but an error occurs during the order placement phase.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When <c>ChargeType</c> is set to <c>PostPaid</c>, set this parameter to the fixed value <c>Month</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The pre-opened application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cag-b2ronxxd****</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The promotion ID. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The runtime policy.</para>
        /// </summary>
        [NameInMap("RuntimePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestRuntimePolicy RuntimePolicy { get; set; }
        public class CreateAppInstanceGroupRequestRuntimePolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable debug mode. To call the GetDebugAppInstance and CreateImageFromAppInstanceGroup operations, set this parameter to ON.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFF</para>
            /// </summary>
            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public string DebugMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow only one application per session.</para>
            /// <list type="bullet">
            /// <item><description>If enabled, opening multiple applications within a delivery group allocates a separate session for each application, which consumes more sessions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PerSessionPerApp")]
            [Validation(Required=false)]
            public bool? PerSessionPerApp { get; set; }

            /// <summary>
            /// <para>The persistent session scheduling mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DYNAMIC</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("PersistentAppInstanceScheduleMode")]
            [Validation(Required=false)]
            public string PersistentAppInstanceScheduleMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable session pre-opening.</para>
            /// <list type="bullet">
            /// <item><description>If this parameter is not specified, the default value is true.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SessionPreOpen")]
            [Validation(Required=false)]
            public string SessionPreOpen { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The generation mode for session users.</para>
            /// <list type="bullet">
            /// <item><description>wyid: In this mode, the session pre-open parameter SessionPreOpen must be set to false.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>wyid</para>
            /// </summary>
            [NameInMap("SessionUserGenerationMode")]
            [Validation(Required=false)]
            public string SessionUserGenerationMode { get; set; }

        }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateAppInstanceGroupRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to reset after unbinding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip user authorization verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>The application recycling time, in minutes. After an end user disconnects from a cloud application for a period of time, the cloud application process exits. This period is the application recycling time. Set this parameter to <c>-1</c> if you do not want to recycle the application. Valid values: -1 and 3 to 300 (integer). Default value: <c>15</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>The storage policy.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestStoragePolicy StoragePolicy { get; set; }
        public class CreateAppInstanceGroupRequestStoragePolicy : TeaModel {
            /// <summary>
            /// <para>The list of storage types.</para>
            /// </summary>
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

            /// <summary>
            /// <para>The user data roaming configuration.</para>
            /// </summary>
            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public CreateAppInstanceGroupRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class CreateAppInstanceGroupRequestStoragePolicyUserProfile : TeaModel {
                /// <summary>
                /// <para>The remote storage path for user data roaming.</para>
                /// <list type="bullet">
                /// <item><description>If this parameter is not specified, the default value is the delivery group ID.</description></item>
                /// <item><description>To enable user data roaming across delivery groups within the same VPC, set this parameter to the same value for all delivery groups involved.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ID20250101</para>
                /// </summary>
                [NameInMap("RemoteStoragePath")]
                [Validation(Required=false)]
                public string RemoteStoragePath { get; set; }

                /// <summary>
                /// <para>The remote storage type used for user data roaming.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAS</para>
                /// </summary>
                [NameInMap("RemoteStorageType")]
                [Validation(Required=false)]
                public string RemoteStorageType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable user data roaming.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UserProfileSwitch")]
                [Validation(Required=false)]
                public bool? UserProfileSwitch { get; set; }

            }

        }

        /// <summary>
        /// <para>The billing method subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postPaid</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The user-defined policy.</para>
        /// </summary>
        [NameInMap("UserDefinePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestUserDefinePolicy UserDefinePolicy { get; set; }
        public class CreateAppInstanceGroupRequestUserDefinePolicy : TeaModel {
            /// <summary>
            /// <para>The custom policy content. The content must comply with the image version specifications. To use this parameter, submit a ticket to request whitelist access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;target&quot;:&quot;agent&quot;,&quot;config&quot;:{&quot;abc&quot;:&quot;xxx&quot;}}]</para>
            /// </summary>
            [NameInMap("CustomConfig")]
            [Validation(Required=false)]
            public string CustomConfig { get; set; }

        }

        /// <summary>
        /// <para>The list of authorized user group IDs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The information about the users to be added as assigned users of the delivery group. This parameter is required if the <c>Users</c> parameter is specified.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestUserInfo UserInfo { get; set; }
        public class CreateAppInstanceGroupRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The type of the user account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Simple</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of usernames to be added as assigned users of the delivery group.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// <para>The display policy.</para>
        /// </summary>
        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestVideoPolicy VideoPolicy { get; set; }
        public class CreateAppInstanceGroupRequestVideoPolicy : TeaModel {
            /// <summary>
            /// <para>The frame rate (FPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public int? FrameRate { get; set; }

            /// <summary>
            /// <para>The height of the resolution. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            /// <summary>
            /// <para>The width of the resolution. Unit: pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            /// <summary>
            /// <para>The streaming mode. This parameter is used together with the Webrtc parameter to specify the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>Webrtc=<c>true</c> and StreamingMode=<c>video</c>: WebRTC streaming.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>video</c>: video streaming.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>mix</c>: hybrid streaming.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to use adaptive resolution.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The session resolution follows the terminal display area changes. In this case, SessionResolutionWidth and SessionResolutionHeight specify the maximum resolution values.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The session resolution does not follow the terminal display area changes. In this case, the resolution is fixed to the values of SessionResolutionWidth and SessionResolutionHeight.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TerminalResolutionAdaptive")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptive { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable WebRTC. This parameter is used together with the StreamingMode parameter to specify the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>Webrtc=<c>true</c> and StreamingMode=<c>video</c>: WebRTC streaming.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>video</c>: video streaming.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>mix</c>: hybrid streaming.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Webrtc")]
            [Validation(Required=false)]
            public bool? Webrtc { get; set; }

        }

    }

}
