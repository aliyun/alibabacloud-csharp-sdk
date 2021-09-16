// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupSchedulingPreviewRequest : TeaModel {
        /// <summary>
        /// 服务组ID
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

        /// <summary>
        /// 排班方式 FAST 快速排班 FINE 精细排班
        /// </summary>
        [NameInMap("schedulingWay")]
        [Validation(Required=false)]
        public string SchedulingWay { get; set; }

        /// <summary>
        /// 快速排班
        /// </summary>
        [NameInMap("fastScheduling")]
        [Validation(Required=false)]
        public GetServiceGroupSchedulingPreviewRequestFastScheduling FastScheduling { get; set; }
        public class GetServiceGroupSchedulingPreviewRequestFastScheduling : TeaModel {
            [NameInMap("singleDuration")]
            [Validation(Required=false)]
            public int? SingleDuration { get; set; }
            [NameInMap("dutyPlan")]
            [Validation(Required=false)]
            public string DutyPlan { get; set; }
            [NameInMap("singleDurationUnit")]
            [Validation(Required=false)]
            public string SingleDurationUnit { get; set; }
            [NameInMap("schedulingUsers")]
            [Validation(Required=false)]
            public List<GetServiceGroupSchedulingPreviewRequestFastSchedulingSchedulingUsers> SchedulingUsers { get; set; }
            public class GetServiceGroupSchedulingPreviewRequestFastSchedulingSchedulingUsers : TeaModel {
                public long? SchedulingUserId { get; set; }
                public int? SchedulingOrder { get; set; }
            }
        };

        /// <summary>
        /// 精细排
        /// </summary>
        [NameInMap("fineScheduling")]
        [Validation(Required=false)]
        public GetServiceGroupSchedulingPreviewRequestFineScheduling FineScheduling { get; set; }
        public class GetServiceGroupSchedulingPreviewRequestFineScheduling : TeaModel {
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }
            [NameInMap("periodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }
            [NameInMap("shiftType")]
            [Validation(Required=false)]
            public string ShiftType { get; set; }
            [NameInMap("schedulingFineShifts")]
            [Validation(Required=false)]
            public List<GetServiceGroupSchedulingPreviewRequestFineSchedulingSchedulingFineShifts> SchedulingFineShifts { get; set; }
            public class GetServiceGroupSchedulingPreviewRequestFineSchedulingSchedulingFineShifts : TeaModel {
                public string SchedulingStartTime { get; set; }
                public string SchedulingEndTime { get; set; }
                public long? SchedulingOrder { get; set; }
                public string ShiftName { get; set; }
            }
        };

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 排班结束时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 排班开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
