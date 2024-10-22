// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAttributeRequest : TeaModel {
        /// <summary>
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

        [NameInMap("NodePoolStrategy")]
        [Validation(Required=false)]
        public ModifyNodePoolAttributeRequestNodePoolStrategy NodePoolStrategy { get; set; }
        public class ModifyNodePoolAttributeRequestNodePoolStrategy : TeaModel {
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
            /// <para>购买资源的数量。取值范围：1~100。</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>若为包年包月资源，则该参数不可修改。</description></item>
            /// <item><description>若为按量付费资源，则当弹性模式（<c>StrategyType</c>）为固定数量（<c>NODE_FIXED</c>）或自动扩缩容（<c>NODE_SCALING_BY_USAGE</c>）时该参数可修改。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>策略执行周期列表。<c>StrategyType</c>（弹性模式）设为<c>NODE_SCALING_BY_SCHEDULE</c>（定时扩缩容）时，该字段必填。</para>
            /// </summary>
            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules : TeaModel {
                /// <summary>
                /// <para>策略执行周期的类型。必须同时指定<c>RecurrenceType</c>和<c>RecurrenceValues</c>。</para>
                /// 
                /// <b>Example:</b>
                /// <para>weekly</para>
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                /// <summary>
                /// <para>策略执行周期的数值列表。</para>
                /// </summary>
                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<int?> RecurrenceValues { get; set; }

                /// <summary>
                /// <para>策略执行周期的时间段列表。时间段设置要求：</para>
                /// <list type="bullet">
                /// <item><description>最多可添加3个时间段。</description></item>
                /// <item><description>时间段之间不重叠。</description></item>
                /// <item><description>时间段之间的间隔大于或等于5分钟。</description></item>
                /// <item><description>单个时间段的时长大于或等于15分钟。</description></item>
                /// <item><description>所有时间段累计不跨天。</description></item>
                /// </list>
                /// </summary>
                [NameInMap("TimerPeriods")]
                [Validation(Required=false)]
                public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods : TeaModel {
                    /// <summary>
                    /// <para>资源数量。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// <para>结束时间。格式为HH:mm。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15:00</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>开始时间。格式为HH:mm。</para>
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
            /// <para>策略失效日期。格式为：yyyy-MM-dd。失效日期与生效日期的间隔必须介于7天到1年之间（含7天和1年）。<c>StrategyType</c>（弹性模式）设为<c>NODE_SCALING_BY_SCHEDULE</c>（定时扩缩容）时，该字段必填。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-19</para>
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// <para>策略生效日期。格式为：yyyy-MM-dd。该日期必须大于或等于当前日期。<c>StrategyType</c>（弹性模式）设为<c>NODE_SCALING_BY_SCHEDULE</c>（定时扩缩容）时，该字段必填。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-05</para>
            /// </summary>
            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// <para>是否开启资源预热策略。<c>StrategyType</c>（弹性模式）设为<c>NODE_SCALING_BY_SCHEDULE</c>（定时扩缩容）时，该字段必填。</para>
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
        /// <para>产品类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
