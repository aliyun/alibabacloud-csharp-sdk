// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupSchedulingPreviewRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("fastScheduling")]
        [Validation(Required=false)]
        public GetServiceGroupSchedulingPreviewRequestFastScheduling FastScheduling { get; set; }
        public class GetServiceGroupSchedulingPreviewRequestFastScheduling : TeaModel {
            /// <summary>
            /// FAST_CHOICE
            /// </summary>
            [NameInMap("dutyPlan")]
            [Validation(Required=false)]
            public string DutyPlan { get; set; }

            [NameInMap("schedulingUsers")]
            [Validation(Required=false)]
            public List<GetServiceGroupSchedulingPreviewRequestFastSchedulingSchedulingUsers> SchedulingUsers { get; set; }
            public class GetServiceGroupSchedulingPreviewRequestFastSchedulingSchedulingUsers : TeaModel {
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

            /// <summary>
            /// DAY
            /// </summary>
            [NameInMap("singleDurationUnit")]
            [Validation(Required=false)]
            public string SingleDurationUnit { get; set; }

        }

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

            [NameInMap("schedulingFineShifts")]
            [Validation(Required=false)]
            public List<GetServiceGroupSchedulingPreviewRequestFineSchedulingSchedulingFineShifts> SchedulingFineShifts { get; set; }
            public class GetServiceGroupSchedulingPreviewRequestFineSchedulingSchedulingFineShifts : TeaModel {
                [NameInMap("schedulingEndTime")]
                [Validation(Required=false)]
                public string SchedulingEndTime { get; set; }

                [NameInMap("schedulingOrder")]
                [Validation(Required=false)]
                public long? SchedulingOrder { get; set; }

                [NameInMap("schedulingStartTime")]
                [Validation(Required=false)]
                public string SchedulingStartTime { get; set; }

                [NameInMap("shiftName")]
                [Validation(Required=false)]
                public string ShiftName { get; set; }

            }

            [NameInMap("shiftType")]
            [Validation(Required=false)]
            public string ShiftType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("schedulingWay")]
        [Validation(Required=false)]
        public string SchedulingWay { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
