// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceGroupSchedulingRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
                [NameInMap("schedulingObjectType")]
                [Validation(Required=false)]
                public string SchedulingObjectType { get; set; }

                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public long? SchedulingOrder { get; set; }

                [NameInMap("schedulingUserId")]
                [Validation(Required=false)]
                public long? SchedulingUserId { get; set; }

                [NameInMap("schedulingUserIdList")]
                [Validation(Required=false)]
                public List<long?> SchedulingUserIdList { get; set; }

            }

            [NameInMap("singleDuration")]
            [Validation(Required=false)]
            public int? SingleDuration { get; set; }

            [NameInMap("singleDurationUnit")]
            [Validation(Required=false)]
            public string SingleDurationUnit { get; set; }

        }

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
                [NameInMap("cycleOrder")]
                [Validation(Required=false)]
                public int? CycleOrder { get; set; }

                [NameInMap("schedulingEndTime")]
                [Validation(Required=false)]
                public string SchedulingEndTime { get; set; }

                [NameInMap("schedulingObjectType")]
                [Validation(Required=false)]
                public string SchedulingObjectType { get; set; }

                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public int? SchedulingOrder { get; set; }

                [NameInMap("schedulingStartTime")]
                [Validation(Required=false)]
                public string SchedulingStartTime { get; set; }

                [NameInMap("schedulingUserId")]
                [Validation(Required=false)]
                public long? SchedulingUserId { get; set; }

                [NameInMap("schedulingUserIdList")]
                [Validation(Required=false)]
                public List<long?> SchedulingUserIdList { get; set; }

                [NameInMap("shiftName")]
                [Validation(Required=false)]
                public string ShiftName { get; set; }

                [NameInMap("skipOneDay")]
                [Validation(Required=false)]
                public bool? SkipOneDay { get; set; }

            }

            [NameInMap("schedulingTemplateFineShifts")]
            [Validation(Required=false)]
            public List<CreateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts> SchedulingTemplateFineShifts { get; set; }
            public class CreateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts : TeaModel {
                [NameInMap("schedulingEndTime")]
                [Validation(Required=false)]
                public string SchedulingEndTime { get; set; }

                [NameInMap("schedulingObjectType")]
                [Validation(Required=false)]
                public string SchedulingObjectType { get; set; }

                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public long? SchedulingOrder { get; set; }

                [NameInMap("schedulingStartTime")]
                [Validation(Required=false)]
                public string SchedulingStartTime { get; set; }

                [NameInMap("schedulingUserId")]
                [Validation(Required=false)]
                public long? SchedulingUserId { get; set; }

                [NameInMap("schedulingUserIdList")]
                [Validation(Required=false)]
                public List<long?> SchedulingUserIdList { get; set; }

                [NameInMap("schedulingUserName")]
                [Validation(Required=false)]
                public string SchedulingUserName { get; set; }

                [NameInMap("skipOneDay")]
                [Validation(Required=false)]
                public bool? SkipOneDay { get; set; }

            }

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

    }

}
