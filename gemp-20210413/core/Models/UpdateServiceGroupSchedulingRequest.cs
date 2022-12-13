// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateServiceGroupSchedulingRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public int? SchedulingOrder { get; set; }

                [NameInMap("schedulingUserId")]
                [Validation(Required=false)]
                public long? SchedulingUserId { get; set; }

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
                [NameInMap("cycleOrder")]
                [Validation(Required=false)]
                public int? CycleOrder { get; set; }

                [NameInMap("schedulingEndTime")]
                [Validation(Required=false)]
                public string SchedulingEndTime { get; set; }

                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public long? SchedulingOrder { get; set; }

                [NameInMap("schedulingStartTime")]
                [Validation(Required=false)]
                public string SchedulingStartTime { get; set; }

                [NameInMap("schedulingUserId")]
                [Validation(Required=false)]
                public long? SchedulingUserId { get; set; }

                [NameInMap("shiftName")]
                [Validation(Required=false)]
                public string ShiftName { get; set; }

                [NameInMap("skipOneDay")]
                [Validation(Required=false)]
                public bool? SkipOneDay { get; set; }

            }

            [NameInMap("schedulingTemplateFineShifts")]
            [Validation(Required=false)]
            public List<UpdateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts> SchedulingTemplateFineShifts { get; set; }
            public class UpdateServiceGroupSchedulingRequestFineSchedulingSchedulingTemplateFineShifts : TeaModel {
                [NameInMap("schedulingEndTime")]
                [Validation(Required=false)]
                public string SchedulingEndTime { get; set; }

                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public int? SchedulingOrder { get; set; }

                [NameInMap("schedulingStartTime")]
                [Validation(Required=false)]
                public string SchedulingStartTime { get; set; }

                [NameInMap("schedulingUserId")]
                [Validation(Required=false)]
                public long? SchedulingUserId { get; set; }

                [NameInMap("shiftName")]
                [Validation(Required=false)]
                public string ShiftName { get; set; }

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
