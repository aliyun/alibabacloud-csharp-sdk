// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the delivery group resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-hangzhou: China (Hangzhou)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCapacity")]
        [Validation(Required=false)]
        public int? NodeCapacity { get; set; }

        /// <summary>
        /// <para>The auto scaling policy used by the delivery group.</para>
        /// </summary>
        [NameInMap("NodePoolStrategy")]
        [Validation(Required=false)]
        public ModifyNodePoolAttributeRequestNodePoolStrategy NodePoolStrategy { get; set; }
        public class ModifyNodePoolAttributeRequestNodePoolStrategy : TeaModel {
            /// <summary>
            /// <para>The maximum number of idle sessions. After you specify a value for this parameter, auto scaling is triggered only if the number of idle sessions in the delivery group is smaller than the specified value and the session usage exceeds the value specified for <c>ScalingUsageThreshold</c>. Otherwise, the system determines that the idle sessions in the delivery group are sufficient and does not perform auto scaling.`` You can use this parameter to flexibly manage auto scaling and reduce costs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxIdleAppInstanceAmount")]
            [Validation(Required=false)]
            public int? MaxIdleAppInstanceAmount { get; set; }

            /// <summary>
            /// <para>The maximum number of resources that can be created for scale-out. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_USAGE</c>.</para>
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
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If you use subscription resources, you cannot modify this parameter.</description></item>
            /// <item><description>If you use pay-as-you-go resources, you can modify this parameter only if you set <c>StrategyType</c> to <c>NODE_FIXED</c> or <c>NODE_SCALING_BY_USAGE</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The intervals at which the scaling policy is executed. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// </summary>
            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules : TeaModel {
                /// <summary>
                /// <para>The schedule type of the scaling policy. This parameter must be configured together with <c>RecurrenceValues</c>.``</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>weekly: The scaling policy is executed on specific days each week.</description></item>
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
                public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods : TeaModel {
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
                    /// <para>The end of the time period during which the scaling policy is executed. Format: HH:mm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time period during which the scaling policy is executed. Format: HH:mm.</para>
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
            /// <item><description>If a scale-out is automatically triggered after the resource is scaled in, the scale-in is not executed. This prevents repeated scale-in and scale-out.</description></item>
            /// <item><description>If a scale-out is automatically triggered due to an increase in the number of sessions during the specified period of time, the resource is not scaled in and the countdown restarts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <para>The number of resources that are created each time resources are scaled out. Valid values: 1 to 10. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_USAGE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <para>The upper limit of session usage. If the session usage exceeds the specified upper limit, auto scaling is automatically triggered. The session usage is calculated by using the following formula: <c>Session usage = Number of current sessions/(Total number of resources × Number of concurrent sessions) × 100%</c>. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_USAGE</c>. Valid values: 0 to 100. Default value: 85.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("ScalingUsageThreshold")]
            [Validation(Required=false)]
            public string ScalingUsageThreshold { get; set; }

            /// <summary>
            /// <para>The expiration date of the scaling policy. Format: yyyy-MM-dd. The interval between the expiration date and the effective date must be from 7 days to 1 year. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-19</para>
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// <para>The effective date of the scaling policy. Format: yyyy-MM-dd. The date must be the same as or later than the current date. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-05</para>
            /// </summary>
            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            /// <summary>
            /// <para>The scaling mode.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><c>NODE_FIXED</c>: no scaling. This value is applicable to pay-as-you-go resources and subscription resources.</description></item>
            /// <item><description><c>NODE_SCALING_BY_USAGE</c>: auto scaling. This value is applicable to pay-as-you-go resources and subscription resources.</description></item>
            /// <item><description><c>NODE_SCALING_BY_SCHEDULE</c>: scheduled scaling. This value is applicable only to pay-as-you-go resources.</description></item>
            /// </list>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NODE_FIXED: no scaling</description></item>
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
            /// <para>Specifies whether to enable the warmup policy for resources. This parameter is required only if you set <c>StrategyType</c> to <c>NODE_SCALING_BY_SCHEDULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WarmUp")]
            [Validation(Required=false)]
            public bool? WarmUp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-ew7va2g1wl3vm****</para>
        /// </summary>
        [NameInMap("PoolId")]
        [Validation(Required=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
