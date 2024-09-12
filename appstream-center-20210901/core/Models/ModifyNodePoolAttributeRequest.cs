// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyNodePoolAttributeRequest : TeaModel {
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

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

            [NameInMap("MaxScalingAmount")]
            [Validation(Required=false)]
            public int? MaxScalingAmount { get; set; }

            /// <summary>
            /// 购买资源的数量。取值范围：1~100。
            /// 
            /// > 
            /// - 若为包年包月资源，则该参数不可修改。
            /// - 若为按量付费资源，则当弹性模式（`StrategyType`）为固定数量（`NODE_FIXED`）或自动扩缩容（`NODE_SCALING_BY_USAGE`）时该参数可修改。
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// 策略执行周期列表。`StrategyType`（弹性模式）设为`NODE_SCALING_BY_SCHEDULE`（定时扩缩容）时，该字段必填。
            /// </summary>
            [NameInMap("RecurrenceSchedules")]
            [Validation(Required=false)]
            public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules> RecurrenceSchedules { get; set; }
            public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedules : TeaModel {
                /// <summary>
                /// 策略执行周期的类型。必须同时指定`RecurrenceType`和`RecurrenceValues`。
                /// </summary>
                [NameInMap("RecurrenceType")]
                [Validation(Required=false)]
                public string RecurrenceType { get; set; }

                /// <summary>
                /// 策略执行周期的数值列表。
                /// </summary>
                [NameInMap("RecurrenceValues")]
                [Validation(Required=false)]
                public List<int?> RecurrenceValues { get; set; }

                /// <summary>
                /// 策略执行周期的时间段列表。时间段设置要求：
                /// 
                /// - 最多可添加3个时间段。
                /// - 时间段之间不重叠。
                /// - 时间段之间的间隔大于或等于5分钟。
                /// - 单个时间段的时长大于或等于15分钟。
                /// - 所有时间段累计不跨天。
                /// </summary>
                [NameInMap("TimerPeriods")]
                [Validation(Required=false)]
                public List<ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods> TimerPeriods { get; set; }
                public class ModifyNodePoolAttributeRequestNodePoolStrategyRecurrenceSchedulesTimerPeriods : TeaModel {
                    /// <summary>
                    /// 资源数量。
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// 结束时间。格式为HH:mm。
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// 开始时间。格式为HH:mm。
                    /// </summary>
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

            /// <summary>
            /// 策略失效日期。格式为：yyyy-MM-dd。失效日期与生效日期的间隔必须介于7天到1年之间（含7天和1年）。`StrategyType`（弹性模式）设为`NODE_SCALING_BY_SCHEDULE`（定时扩缩容）时，该字段必填。
            /// </summary>
            [NameInMap("StrategyDisableDate")]
            [Validation(Required=false)]
            public string StrategyDisableDate { get; set; }

            /// <summary>
            /// 策略生效日期。格式为：yyyy-MM-dd。该日期必须大于或等于当前日期。`StrategyType`（弹性模式）设为`NODE_SCALING_BY_SCHEDULE`（定时扩缩容）时，该字段必填。
            /// </summary>
            [NameInMap("StrategyEnableDate")]
            [Validation(Required=false)]
            public string StrategyEnableDate { get; set; }

            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

            /// <summary>
            /// 是否开启资源预热策略。`StrategyType`（弹性模式）设为`NODE_SCALING_BY_SCHEDULE`（定时扩缩容）时，该字段必填。
            /// </summary>
            [NameInMap("WarmUp")]
            [Validation(Required=false)]
            public bool? WarmUp { get; set; }

        }

        [NameInMap("PoolId")]
        [Validation(Required=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// 产品类型。
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
