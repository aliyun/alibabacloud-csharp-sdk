// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceGroupSchedulingRequest : TeaModel {
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
        public CreateServiceGroupSchedulingRequestFastScheduling FastScheduling { get; set; }
        public class CreateServiceGroupSchedulingRequestFastScheduling : TeaModel {
            [NameInMap("dutyPlan")]
            [Validation(Required=false)]
            public string DutyPlan { get; set; }
            [NameInMap("schedulingUsers")]
            [Validation(Required=false)]
            public List<CreateServiceGroupSchedulingRequestFastSchedulingSchedulingUsers> SchedulingUsers { get; set; }
            public class CreateServiceGroupSchedulingRequestFastSchedulingSchedulingUsers : TeaModel {
                public long? SchedulingOrder { get; set; }
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
        public CreateServiceGroupSchedulingRequestFineScheduling FineScheduling { get; set; }
        public class CreateServiceGroupSchedulingRequestFineScheduling : TeaModel {
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }
            [NameInMap("periodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }
            [NameInMap("schedulingFineShifts")]
            [Validation(Required=false)]
            public List<CreateServiceGroupSchedulingRequestFineSchedulingSchedulingFineShifts> SchedulingFineShifts { get; set; }
            public class CreateServiceGroupSchedulingRequestFineSchedulingSchedulingFineShifts : TeaModel {
                public int? CycleOrder { get; set; }
                public string SchedulingEndTime { get; set; }
                public int? SchedulingOrder { get; set; }
                public string SchedulingStartTime { get; set; }
                public long? SchedulingUserId { get; set; }
                public string ShiftName { get; set; }
                public bool? SkipOneDay { get; set; }
            }
            [NameInMap("schedulingTemplateFineShifts")]
            [Validation(Required=false)]
            public List<CreateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts> SchedulingTemplateFineShifts { get; set; }
            public class CreateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts : TeaModel {
                public string SchedulingEndTime { get; set; }
                public long? SchedulingOrder { get; set; }
                public string SchedulingStartTime { get; set; }
                public long? SchedulingUserId { get; set; }
                public string SchedulingUserName { get; set; }
                public bool? SkipOneDay { get; set; }
            }
            [NameInMap("shiftType")]
            [Validation(Required=false)]
            public string ShiftType { get; set; }
        };

        /// <summary>
        /// 排班方式 FAST 快速排班 FINE  精细排班
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
