// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupSchedulingResponseBody : TeaModel {
        /// <summary>
        /// 排班详情
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceGroupSchedulingResponseBodyData Data { get; set; }
        public class GetServiceGroupSchedulingResponseBodyData : TeaModel {
            [NameInMap("fastScheduling")]
            [Validation(Required=false)]
            public GetServiceGroupSchedulingResponseBodyDataFastScheduling FastScheduling { get; set; }
            public class GetServiceGroupSchedulingResponseBodyDataFastScheduling : TeaModel {
                /// <summary>
                /// 值班方案 dutyPlan FAST_CHOICE 快速选择   CUSTOM  自定义
                /// </summary>
                [NameInMap("dutyPlan")]
                [Validation(Required=false)]
                public string DutyPlan { get; set; }

                /// <summary>
                /// 快速排班ID
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 快速轮班用户
                /// </summary>
                [NameInMap("schedulingUsers")]
                [Validation(Required=false)]
                public List<GetServiceGroupSchedulingResponseBodyDataFastSchedulingSchedulingUsers> SchedulingUsers { get; set; }
                public class GetServiceGroupSchedulingResponseBodyDataFastSchedulingSchedulingUsers : TeaModel {
                    /// <summary>
                    /// 排班顺序
                    /// </summary>
                    [NameInMap("schedulingOrder")]
                    [Validation(Required=false)]
                    public int? SchedulingOrder { get; set; }

                    /// <summary>
                    /// 轮班用户ID
                    /// </summary>
                    [NameInMap("schedulingUserId")]
                    [Validation(Required=false)]
                    public long? SchedulingUserId { get; set; }

                    /// <summary>
                    /// 轮班用户名字
                    /// </summary>
                    [NameInMap("schedulingUserName")]
                    [Validation(Required=false)]
                    public string SchedulingUserName { get; set; }

                }

                /// <summary>
                /// 每人排班时长
                /// </summary>
                [NameInMap("singleDuration")]
                [Validation(Required=false)]
                public int? SingleDuration { get; set; }

                /// <summary>
                /// 每人排班时长单位 HOUR 小时 DAY 天
                /// </summary>
                [NameInMap("singleDurationUnit")]
                [Validation(Required=false)]
                public string SingleDurationUnit { get; set; }

            }
            [NameInMap("fineScheduling")]
            [Validation(Required=false)]
            public GetServiceGroupSchedulingResponseBodyDataFineScheduling FineScheduling { get; set; }
            public class GetServiceGroupSchedulingResponseBodyDataFineScheduling : TeaModel {
                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                /// <summary>
                /// 循环周期单位 HOUR 小时 DAY 天
                /// </summary>
                [NameInMap("periodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// 精细排班班次人员信息
                /// </summary>
                [NameInMap("schedulingFineShifts")]
                [Validation(Required=false)]
                public List<GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingFineShifts> SchedulingFineShifts { get; set; }
                public class GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingFineShifts : TeaModel {
                    /// <summary>
                    /// 循环次序
                    /// </summary>
                    [NameInMap("cycleOrder")]
                    [Validation(Required=false)]
                    public long? CycleOrder { get; set; }

                    /// <summary>
                    /// 排班结束时间
                    /// </summary>
                    [NameInMap("schedulingEndTime")]
                    [Validation(Required=false)]
                    public string SchedulingEndTime { get; set; }

                    /// <summary>
                    /// 排班顺序
                    /// </summary>
                    [NameInMap("schedulingOrder")]
                    [Validation(Required=false)]
                    public int? SchedulingOrder { get; set; }

                    /// <summary>
                    /// 排班开始时间
                    /// </summary>
                    [NameInMap("schedulingStartTime")]
                    [Validation(Required=false)]
                    public string SchedulingStartTime { get; set; }

                    /// <summary>
                    /// 排班用户ID
                    /// </summary>
                    [NameInMap("schedulingUserId")]
                    [Validation(Required=false)]
                    public long? SchedulingUserId { get; set; }

                    /// <summary>
                    /// 排班用户名字
                    /// </summary>
                    [NameInMap("schedulingUserName")]
                    [Validation(Required=false)]
                    public string SchedulingUserName { get; set; }

                    /// <summary>
                    /// 班次名称
                    /// </summary>
                    [NameInMap("shiftName")]
                    [Validation(Required=false)]
                    public string ShiftName { get; set; }

                    /// <summary>
                    /// 是否跨天
                    /// </summary>
                    [NameInMap("skipOneDay")]
                    [Validation(Required=false)]
                    public bool? SkipOneDay { get; set; }

                }

                /// <summary>
                /// 精细排班模版
                /// </summary>
                [NameInMap("schedulingTemplateFineShifts")]
                [Validation(Required=false)]
                public List<GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingTemplateFineShifts> SchedulingTemplateFineShifts { get; set; }
                public class GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingTemplateFineShifts : TeaModel {
                    /// <summary>
                    /// 排班结束时间
                    /// </summary>
                    [NameInMap("schedulingEndTime")]
                    [Validation(Required=false)]
                    public string SchedulingEndTime { get; set; }

                    /// <summary>
                    /// 排班顺序
                    /// </summary>
                    [NameInMap("schedulingOrder")]
                    [Validation(Required=false)]
                    public long? SchedulingOrder { get; set; }

                    /// <summary>
                    /// 排班开始时间
                    /// </summary>
                    [NameInMap("schedulingStartTime")]
                    [Validation(Required=false)]
                    public string SchedulingStartTime { get; set; }

                    /// <summary>
                    /// 用户ID
                    /// </summary>
                    [NameInMap("schedulingUserId")]
                    [Validation(Required=false)]
                    public string SchedulingUserId { get; set; }

                    /// <summary>
                    /// 排班用户名字
                    /// </summary>
                    [NameInMap("schedulingUserName")]
                    [Validation(Required=false)]
                    public string SchedulingUserName { get; set; }

                    /// <summary>
                    /// 班次名称
                    /// </summary>
                    [NameInMap("shiftName")]
                    [Validation(Required=false)]
                    public string ShiftName { get; set; }

                    /// <summary>
                    /// 是否跨天
                    /// </summary>
                    [NameInMap("skipOneDay")]
                    [Validation(Required=false)]
                    public bool? SkipOneDay { get; set; }

                }

                /// <summary>
                /// 班次类型 MORNING_NIGHT 早晚班 MORNING_NOON_NIGHT 早中晚班 CUSTOM 自定义
                /// </summary>
                [NameInMap("shiftType")]
                [Validation(Required=false)]
                public string ShiftType { get; set; }

            }
            [NameInMap("schedulingWay")]
            [Validation(Required=false)]
            public string SchedulingWay { get; set; }
            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<GetServiceGroupSchedulingResponseBodyDataUsers> Users { get; set; }
            public class GetServiceGroupSchedulingResponseBodyDataUsers : TeaModel {
                public long? UserId { get; set; }
                public string UserName { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
