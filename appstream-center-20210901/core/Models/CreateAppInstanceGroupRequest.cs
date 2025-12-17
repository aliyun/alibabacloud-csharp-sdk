// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The image ID of the application. To obtain the image ID, log on to the <a href="https://appstreaming.console.aliyun.com/">App Streaming console</a>. In the left-side navigation pane, choose <b>Maintenance</b> &gt; <b>Custom Images</b> or Maintenance &gt; <b>System Images</b>.</para>
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
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>Package type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser.package.5.250.appstreaming.general.basic</para>
        /// </summary>
        [NameInMap("AppPackageType")]
        [Validation(Required=false)]
        public string AppPackageType { get; set; }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-0clfzcy0adpcf****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The authentication mode of the delivery group.</para>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false: manual payment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false: manual payment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the region where the delivery group resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-hangzhou: China (Hangzhou)</description></item>
        /// </list>
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
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Node: by resource</description></item>
        /// </list>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cls-d39iq73l5c0a8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The network settings.</para>
        /// <remarks>
        /// <para> If you want to use this parameter, submit a ticket.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestNetwork Network { get; set; }
        public class CreateAppInstanceGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The domain name rules.</para>
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
                /// <para>The policy used for the domain name.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allow</description></item>
                /// <item><description>block</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

            /// <summary>
            /// <para>The validity period of the public IP address. If the specified value is exceeded, the IP address is updated at next logon. Minimum value: 60. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("IpExpireMinutes")]
            [Validation(Required=false)]
            public int? IpExpireMinutes { get; set; }

            /// <summary>
            /// <para>Office Network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong+dir-842567****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The route settings. This parameter is available only if you set <c>StrategyType</c> to <c>Mixed</c>.</para>
            /// </summary>
            [NameInMap("Routes")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNetworkRoutes> Routes { get; set; }
            public class CreateAppInstanceGroupRequestNetworkRoutes : TeaModel {
                /// <summary>
                /// <para>The destination. The value is a CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>139.196.XX.XX/32</para>
                /// </summary>
                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                /// <summary>
                /// <para>The network egress mode.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>Shared: accesses the network by using NAT Gateway.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Shared</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

            /// <summary>
            /// <para>The type of the network policy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Mixed: the hybrid mode. In this mode, a device is deployed in one virtual private cloud (VPC). Two NICs are provided and an independent public IP address is configured for the device.</description></item>
            /// <item><description>Shared: the shared mode. In this mode, a single NIC is provided for a device and the network is accessed by using NAT Gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Shared</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>List of virtual switch IDs.</para>
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
            /// <para>Maximum number of idle sessions. When this value is specified, auto-scaling is triggered only if the session utilization exceeds <c>ScalingUsageThreshold</c> and the current number of idle sessions in the delivery group is less than <c>MaxIdleAppInstanceAmount</c>. Otherwise, it is considered that sufficient idle sessions are available, and no auto-scaling will occur. This parameter allows flexible control over elastic scaling behavior and helps reduce usage costs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxIdleAppInstanceAmount")]
            [Validation(Required=false)]
            public int? MaxIdleAppInstanceAmount { get; set; }

            /// <summary>
            /// <para>The maximum number of resources that can be created for scale-out. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_USAGE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxScalingAmount")]
            [Validation(Required=false)]
            public int? MaxScalingAmount { get; set; }

            /// <summary>
            /// <para>The number of resources that you want to purchase. Valid values: 1 to 100.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is required if the resources are subscription resources.</para>
            /// </description></item>
            /// <item><description><para>If the resources are pay-as-you-go resources, this parameter is required only if you set <c>StrategyType</c> to <c>NODE_FIXED</c> or <c>NODE_SCALING_BY_USAGE</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The maximum number of sessions to which a resource can connect at the same time. If a resource connects to a large number of sessions at the same time, the user experience can be compromised. The value range varies based on the resource type. The following items describe the value ranges of different resource types:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general.4c8g: 1 to 2</description></item>
            /// <item><description>appstreaming.general.8c16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCapacity")]
            [Validation(Required=false)]
            public int? NodeCapacity { get; set; }

            /// <summary>
            /// <para>The ID of the resource type that you want to purchase. You can call the <a href="https://help.aliyun.com/document_detail/428502.html">ListNodeInstanceType</a> operation to obtain the ID.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.vgpu.8c16g.4g: WUYING - Graphics_8 vCPUs, 16 GiB Memory, 4 GiB GPU Memory</description></item>
            /// <item><description>appstreaming.general.8c16g: WUYING - General_8 vCPUs, 16 GiB Memory</description></item>
            /// <item><description>appstreaming.general.4c8g: WUYING - General_4 vCPUs, 8 GiB Memory</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: WUYING - Graphics_14 vCPUs, 93 GiB Memory, 12 GiB GPU Memory.</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: WUYING - Graphics_8 vCPUs, 31 GiB Memory, 16 GiB GPU Memory</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.general.4c8g</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <para>The schedules of the scaling policy. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// </summary>
            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<CreateAppInstanceGroupRequestNodePoolRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class CreateAppInstanceGroupRequestNodePoolRecurrenceSchedules : TeaModel {
                /// <summary>
                /// <para>The schedule type of the scaling policy. This parameter must be configured together with <c>RecurrenceValues</c>.``</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>Weekly: The scaling policy is executed on specific days each week.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>weekly</para>
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                /// <summary>
                /// <para>The days of each week on which the scaling policy is executed.</para>
                /// </summary>
                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<int?> RecurrenceValues { get; set; }

                /// <summary>
                /// <para>The time periods during which the scaling policy can be executed. The time periods must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description>Up to three time periods can be added.</description></item>
                /// <item><description>Time periods cannot be overlapped.</description></item>
                /// <item><description>The interval between two consecutive time periods must be greater than or equal to 5 minutes.</description></item>
                /// <item><description>Each time period must be greater than or equal to 15 minutes.</description></item>
                /// <item><description>The total length of the time periods that you specify cannot be greater than a day.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("TimerPeriods")]
                [Validation(Required=false)]
                public List<CreateAppInstanceGroupRequestNodePoolRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class CreateAppInstanceGroupRequestNodePoolRecurrenceSchedulesTimerPeriods : TeaModel {
                    /// <summary>
                    /// <para>The number of resources.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// <para>The end time of the time period. Format: HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the time period. Format: HH:mm.</para>
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
            /// <para>The maximum retention period of a resource to which no session is connected. If no session is connected to a resource, the resource is automatically scaled in after the specified retention period elapses. Valid values: 5 to 120. Default value: 5. Unit: minutes. If one of the following situations occurs, the resource is not scaled in.</para>
            /// <list type="bullet">
            /// <item><description>If automatic scale-out is triggered after the resource is scaled in, the scale-in is not executed. This prevents repeated scale-in and scale-out.</description></item>
            /// <item><description>If automatic scale-out is triggered due to an increase in the number of sessions during the specified period of time, the resource is not scaled in and the countdown restarts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <para>The number of resources that are created each time resources are scaled out. Valid values: 1 to 10. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_USAGE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <para>The upper limit of session usage. If the session usage exceeds the specified upper limit, auto scaling is automatically triggered. The session usage is calculated by using the following formula: <c>Session usage = Number of current sessions/(Total number of resources × Number of concurrent sessions) × 100%</c>. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_USAGE</c>. Valid values: 0 to 100. Default value: 85.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <para>The expiration date of the scaling policy. Format: yyyy-MM-dd. The interval between the expiration date and the effective date must be from 7 days to 1 year. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-08</para>
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// <para>The effective date of the scaling policy. Format: yyyy-MM-dd. The date must be the same as or later than the current date. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01</para>
            /// </summary>
            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            /// <summary>
            /// <para>The scaling policy of resources.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para><c>NODE_FIXED</c>: fixed number of resources. This value is applicable to pay-as-you-go resources and subscription resources.</para>
            /// </description></item>
            /// <item><description><para><c>NODE_SCALING_BY_USAGE</c>: auto scaling. This value is applicable to pay-as-you-go resources and subscription resources.</para>
            /// </description></item>
            /// <item><description><para><c>NODE_SCALING_BY_SCHEDULE</c>: scheduled scaling. This value is applicable only to pay-as-you-go resources.</para>
            /// </description></item>
            /// </list>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NODE_FIXED: fixed number of resources</description></item>
            /// <item><description>NODE_SCALING_BY_SCHEDULE: scheduled scaling</description></item>
            /// <item><description>NODE_SCALING_BY_USAGE: auto scaling</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NODE_FIXED</para>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the warmup policy for resources. This parameter is required if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WarmUp")]
            [Validation(Required=false)]
            public bool? WarmUp { get; set; }

        }

        /// <summary>
        /// <para>The subscription duration of resources. This parameter is required if you set <c>ChargeType</c> to <c>PrePaid</c>. The unit of this parameter is specified by <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid value if you set <c>PeriodUnit</c> to <c>Week</c>:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values if you set <c>PeriodUnit</c> to <c>Month</c>:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values if you set <c>PeriodUnit</c> to <c>Year</c>:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set <c>ChargeType</c> to <c>PostPaid</c>, set this parameter to 1.</para>
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
        /// <para>The unit of the subscription duration. This parameter is available if you set <c>ChargeType</c> to <c>PrePaid</c>.</para>
        /// <remarks>
        /// <para> The value of this parameter is case-insensitive. For example, <c>Week</c> is valid and <c>week</c> is invalid. If you specify an invalid value combination for Period and PeriodUnit, such as <c>2 Week</c>, the operation can still be called. However, an error occurs when you place the order.</para>
        /// </remarks>
        /// <remarks>
        /// <para> If you set <c>ChargeType</c> to <c>PostPaid</c>, set this parameter to <c>Month</c>.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// <item><description>Week</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the pre-open application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cag-b2ron*******</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The promotion ID. You can call the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation to obtain the ID.</para>
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
            /// <para>Specifies whether to enable the debugging mode. If you want to call the <c>GetDebugAppInstance</c> and <c>CreateImageFromAppInstanceGroup</c> operations, you must set this parameter to <c>ON</c>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OFF</description></item>
            /// <item><description>ON</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OFF</para>
            /// </summary>
            [NameInMap("DebugMode")]
            [Validation(Required=false)]
            public string DebugMode { get; set; }

            /// <summary>
            /// <para>Only one application is allowed to be opened within a single session.</para>
            /// <list type="bullet">
            /// <item><description>When enabled, launching multiple applications from the delivery group will allocate a separate session for each application, resulting in higher session consumption.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PerSessionPerApp")]
            [Validation(Required=false)]
            public bool? PerSessionPerApp { get; set; }

            /// <summary>
            /// <para>Persistent session scheduling mode.</para>
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
            /// <para>Session pre-launch toggle.</para>
            /// <list type="bullet">
            /// <item><description>If not specified, the default value is true.</description></item>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSOLE: console session</description></item>
            /// <item><description>NORMAL: Remote Desktop Protocol (RDP)-based O\&amp;M session</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The generation mode of the session users. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>wyid. In this case, you must set sessionPreOpen to false.</description></item>
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
            /// <para>Specifies whether to reset after unbinding from a delivery group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResetAfterUnbind")]
            [Validation(Required=false)]
            public bool? ResetAfterUnbind { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip user permission verification.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false: This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>The period of time during which the application can be recycled. The recycling period is the period of time between the time when the end user disconnects from the application and the time when processes exit the application. If you do not want to recycle the application, set this parameter to <c>-1</c>. Valid values:-1 and 3 to 300. The value must be an integer. Default value: <c>15</c>. Unit: minutes.</para>
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
            /// <para>The storage types.</para>
            /// </summary>
            [NameInMap("StorageTypeList")]
            [Validation(Required=false)]
            public List<string> StorageTypeList { get; set; }

            /// <summary>
            /// <para>User data roaming configuration.</para>
            /// </summary>
            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public CreateAppInstanceGroupRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class CreateAppInstanceGroupRequestStoragePolicyUserProfile : TeaModel {
                /// <summary>
                /// <para>Remote storage path for user data roaming.</para>
                /// <list type="bullet">
                /// <item><description>If left empty, the default value is the delivery group ID.</description></item>
                /// <item><description>For cross-delivery-group (within the same VPC) user data roaming, the same value must be configured for all participating delivery groups.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ID20250101</para>
                /// </summary>
                [NameInMap("RemoteStoragePath")]
                [Validation(Required=false)]
                public string RemoteStoragePath { get; set; }

                /// <summary>
                /// <para>Remote storage type used for user data roaming.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NAS</para>
                /// </summary>
                [NameInMap("RemoteStorageType")]
                [Validation(Required=false)]
                public string RemoteStorageType { get; set; }

                /// <summary>
                /// <para>User data roaming toggle.</para>
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
        /// <para>Payment method subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postPaid</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The custom policy.</para>
        /// </summary>
        [NameInMap("UserDefinePolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestUserDefinePolicy UserDefinePolicy { get; set; }
        public class CreateAppInstanceGroupRequestUserDefinePolicy : TeaModel {
            /// <summary>
            /// <para>The content of the custom policy. The content must meet the specifications of image versions. To use this parameter, submit a ticket to apply to enable the whitelist feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;target&quot;:&quot;agent&quot;,&quot;config&quot;:{&quot;abc&quot;:&quot;xxx&quot;}}]</para>
            /// </summary>
            [NameInMap("CustomConfig")]
            [Validation(Required=false)]
            public string CustomConfig { get; set; }

        }

        /// <summary>
        /// <para>List of authorized user group IDs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The information about the user that you want to add to the assigned user list of the delivery group. This parameter is required if you configure <c>Users</c>.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestUserInfo UserInfo { get; set; }
        public class CreateAppInstanceGroupRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The account type of the user.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Simple: convenience account</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Simple</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The users that you want to add to the assigned user list of the delivery group.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// <para>Display policy.</para>
        /// </summary>
        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public CreateAppInstanceGroupRequestVideoPolicy VideoPolicy { get; set; }
        public class CreateAppInstanceGroupRequestVideoPolicy : TeaModel {
            /// <summary>
            /// <para>Frame rate (FPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public int? FrameRate { get; set; }

            /// <summary>
            /// <para>Resolution height, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            /// <summary>
            /// <para>Resolution width, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            /// <summary>
            /// <para>Streaming mode. Combined with the Webrtc parameter, it indicates the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>When Webrtc=true and StreamingMode=video, it indicates a WebRTC stream.</description></item>
            /// <item><description>When Webrtc=false and StreamingMode=video, it indicates a video stream.</description></item>
            /// <item><description>When Webrtc=false and StreamingMode=mix, it indicates a mixed stream.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <para>Whether to use adaptive resolution.</para>
            /// <list type="bullet">
            /// <item><description><para>true: The session resolution follows changes in the terminal\&quot;s display area. In this case, SessionResolutionWidth and SessionResolutionHeight represent the maximum values for resolution adjustment.</para>
            /// </description></item>
            /// <item><description><para>false: The session resolution does not follow changes in the terminal\&quot;s display area. In this case, the resolution is fixed to the values of SessionResolutionWidth and SessionResolutionHeight.</para>
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
            /// <para>Whether to enable WebRTC. Combined with the StreamingMode parameter, it indicates the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>When Webrtc=true and StreamingMode=video, it indicates a WebRTC stream.</description></item>
            /// <item><description>When Webrtc=false and StreamingMode=video, it indicates a video stream.</description></item>
            /// <item><description>When Webrtc=false and StreamingMode=mix, it indicates a mixed stream.</description></item>
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
