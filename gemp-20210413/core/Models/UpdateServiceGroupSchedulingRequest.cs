// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateServiceGroupSchedulingRequest : TeaModel {
        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 快速排班
        /// </summary>
        [NameInMap("fastScheduling")]
        [Validation(Required=false)]
        public UpdateServiceGroupSchedulingRequestFastScheduling FastScheduling { get; set; }
        public class UpdateServiceGroupSchedulingRequestFastScheduling : TeaModel {
            [NameInMap("dutyPlan")]
            [Validation(Required=false)]
            public string DutyPlan { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("schedulingUsers")]
            [Validation(Required=false)]
            public List<UpdateServiceGroupSchedulingRequestFastSchedulingSchedulingUsers> SchedulingUsers { get; set; }
            public class UpdateServiceGroupSchedulingRequestFastSchedulingSchedulingUsers : TeaModel {
                public int? SchedulingOrder { get; set; }
                public long? SchedulingUserId { get; set; }
            }
            [NameInMap("singleDuration")]
            [Validation(Required=false)]
            public int? SingleDuration { get; set; }
            [NameInMap("singleDurationUnit")]
            [Validation(Required=false)]
            public string SingleDurationUnit { get; set; }
        };

        /// <summary>
        /// 精细排班
        /// </summary>
        [NameInMap("fineScheduling")]
        [Validation(Required=false)]
        public UpdateServiceGroupSchedulingRequestFineScheduling FineScheduling { get; set; }
        public class UpdateServiceGroupSchedulingRequestFineScheduling : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }
            [NameInMap("periodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }
            [NameInMap("schedulingFineShifts")]
            [Validation(Required=false)]
            public List<UpdateServiceGroupSchedulingRequestFineSchedulingSchedulingFineShifts> SchedulingFineShifts { get; set; }
            public class UpdateServiceGroupSchedulingRequestFineSchedulingSchedulingFineShifts : TeaModel {
                public int? CycleOrder { get; set; }
                public string SchedulingEndTime { get; set; }
                public long? SchedulingOrder { get; set; }
                public string SchedulingStartTime { get; set; }
                public long? SchedulingUserId { get; set; }
                public string ShiftName { get; set; }
                public bool? SkipOneDay { get; set; }
            }
            [NameInMap("schedulingTemplateFineShifts")]
            [Validation(Required=false)]
            public List<UpdateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts> SchedulingTemplateFineShifts { get; set; }
            public class UpdateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts : TeaModel {
                public string SchedulingEndTime { get; set; }
                public int? SchedulingOrder { get; set; }
                public string SchedulingStartTime { get; set; }
                public long? SchedulingUserId { get; set; }
                public string ShiftName { get; set; }
                public bool? SkipOneDay { get; set; }
            }
            [NameInMap("shiftType")]
            [Validation(Required=false)]
            public string ShiftType { get; set; }
        };

        /// <summary>
        /// 排班方式 FAST 快速排班 FINE 精细排班
        /// </summary>
        [NameInMap("schedulingWay")]
        [Validation(Required=false)]
        public string SchedulingWay { get; set; }

        /// <summary>
        /// 服务组ID
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
