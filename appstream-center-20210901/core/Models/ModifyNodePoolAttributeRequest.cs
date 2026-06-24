// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the delivery group. For more information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The number of concurrent sessions, which is the number of sessions that can be simultaneously connected to a single resource. If too many sessions are connected simultaneously, the application experience may degrade. The valid values vary depending on the resource specification. The valid values for each resource specification are as follows:</para>
        /// <list type="bullet">
        /// <item><description>appstreaming.general.4c8g: 1 to 2.</description></item>
        /// <item><description>appstreaming.general.8c16g: 1 to 4.</description></item>
        /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4.</description></item>
        /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4.</description></item>
        /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCapacity")]
        [Validation(Required=false)]
        public int? NodeCapacity { get; set; }

        /// <summary>
        /// <para>The automatic scaling policy of the delivery group.</para>
        /// </summary>
        [NameInMap("NodePoolStrategy")]
        [Validation(Required=false)]
        public ModifyNodePoolAttributeRequestNodePoolStrategy NodePoolStrategy { get; set; }
        public class ModifyNodePoolAttributeRequestNodePoolStrategy : TeaModel {
            /// <summary>
            /// <para>The maximum number of idle sessions. When this value is specified, automatic scale-out is triggered only when the session usage exceeds <c>ScalingUsageThreshold</c> and the number of idle sessions in the current delivery group is less than <c>MaxIdleAppInstanceAmount</c>. Otherwise, the idle sessions in the delivery group are considered sufficient, and no automatic scale-out is performed. This parameter can be used to flexibly control elastic scale-out behavior and reduce costs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxIdleAppInstanceAmount")]
            [Validation(Required=false)]
            public int? MaxIdleAppInstanceAmount { get; set; }

            /// <summary>
            /// <para>The maximum number of resources that can be created during scale-out. This parameter is required when <c>StrategyType</c> is set to <c>NODE_SCALING_BY_USAGE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxScalingAmount")]
            [Validation(Required=false)]
            public int? MaxScalingAmount { get; set; }

            /// <summary>
            /// <para>The number of purchased resources. Valid values: 1 to 100.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If the resources are subscription resources, this parameter cannot be modified.</description></item>
            /// <item><description>If the resources are pay-as-you-go resources, this parameter can be modified when the scaling mode (<c>StrategyType</c>) is set to fixed quantity (<c>NODE_FIXED</c>) or automatic scaling (<c>NODE_SCALING_BY_USAGE</c>).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The list of policy execution cycles. This parameter is required when <c>StrategyType</c> (scaling mode) is set to <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling).</para>
            /// </summary>
            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules : TeaModel {
                /// <summary>
                /// <para>The type of the policy execution cycle. You must specify both <c>RecurrenceType</c> and <c>RecurrenceValues</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>weekly</para>
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                /// <summary>
                /// <para>The list of values for the policy execution cycle.</para>
                /// </summary>
                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<int?> RecurrenceValues { get; set; }

                /// <summary>
                /// <para>The list of time periods for the policy execution cycle. Requirements for time period settings:</para>
                /// <list type="bullet">
                /// <item><description>You can add up to three time periods.</description></item>
                /// <item><description>Time periods must not overlap.</description></item>
                /// <item><description>The interval between time periods must be at least 5 minutes.</description></item>
                /// <item><description>Each time period must be at least 15 minutes long.</description></item>
                /// <item><description>All time periods combined must not span across days.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("TimerPeriods")]
                [Validation(Required=false)]
                public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods : TeaModel {
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
            /// <para>The maximum duration (in minutes) that a resource without session connections is retained. When no sessions are connected to a resource, a countdown starts based on the duration specified here. The resource is scaled in when the countdown ends. Valid values: 5 to 120. Default value: 5. The following exceptions apply:</para>
            /// <list type="bullet">
            /// <item><description>If scale-in would trigger automatic scale-out again, the scale-in is not performed to avoid repeated scale-in and scale-out operations.</description></item>
            /// <item><description>If automatic scale-out is triggered by an increase in sessions during this period, the resource is not scaled in as originally planned, and the countdown restarts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ScalingDownAfterIdleMinutes")]
            [Validation(Required=false)]
            public int? ScalingDownAfterIdleMinutes { get; set; }

            /// <summary>
            /// <para>The number of resources created per scale-out operation. Valid values: 1 to 10. This parameter is required when <c>StrategyType</c> is set to <c>NODE_SCALING_BY_USAGE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScalingStep")]
            [Validation(Required=false)]
            public int? ScalingStep { get; set; }

            /// <summary>
            /// <para>The upper threshold of session usage (%). Automatic scale-out is triggered when the session usage exceeds this threshold. The session usage is calculated by using the following formula: <c>Session usage = Current sessions ÷ (Total resources × Concurrent sessions per resource) × 100%</c>. This parameter is required when <c>StrategyType</c> is set to <c>NODE_SCALING_BY_USAGE</c>. Valid values: 0 to 100. Default value: 85.</para>
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
            /// <para>2023-01-19</para>
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// <para>The date when the policy takes effect. Format: yyyy-MM-dd. The date must be equal to or later than the current date. This parameter is required when <c>StrategyType</c> (scaling mode) is set to <c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling).</para>
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
            /// <item><description><c>NODE_FIXED</c> (fixed quantity): Applicable to subscription and pay-as-you-go resources.</description></item>
            /// <item><description><c>NODE_SCALING_BY_USAGE</c> (automatic scaling): Applicable to subscription and pay-as-you-go resources.</description></item>
            /// <item><description><c>NODE_SCALING_BY_SCHEDULE</c> (scheduled scaling): Applicable only to pay-as-you-go resources.</description></item>
            /// </list>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ew7va2g1wl3vm****</para>
        /// </summary>
        [NameInMap("PoolId")]
        [Validation(Required=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
