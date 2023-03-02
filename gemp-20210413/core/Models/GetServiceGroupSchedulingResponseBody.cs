// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupSchedulingResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceGroupSchedulingResponseBodyData Data { get; set; }
        public class GetServiceGroupSchedulingResponseBodyData : TeaModel {
            [NameInMap("fastScheduling")]
            [Validation(Required=false)]
            public GetServiceGroupSchedulingResponseBodyDataFastScheduling FastScheduling { get; set; }
            public class GetServiceGroupSchedulingResponseBodyDataFastScheduling : TeaModel {
                [NameInMap("dutyPlan")]
                [Validation(Required=false)]
                public string DutyPlan { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("schedulingUsers")]
                [Validation(Required=false)]
                public List<GetServiceGroupSchedulingResponseBodyDataFastSchedulingSchedulingUsers> SchedulingUsers { get; set; }
                public class GetServiceGroupSchedulingResponseBodyDataFastSchedulingSchedulingUsers : TeaModel {
                    [NameInMap("schedulingObjectType")]
                    [Validation(Required=false)]
                    public string SchedulingObjectType { get; set; }

                    [NameInMap("schedulingOrder")]
                    [Validation(Required=false)]
                    public int? SchedulingOrder { get; set; }

                    [NameInMap("schedulingUserId")]
                    [Validation(Required=false)]
                    public long? SchedulingUserId { get; set; }

                    [NameInMap("schedulingUserIdList")]
                    [Validation(Required=false)]
                    public List<long?> SchedulingUserIdList { get; set; }

                    [NameInMap("schedulingUserName")]
                    [Validation(Required=false)]
                    public string SchedulingUserName { get; set; }

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

                [NameInMap("periodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("schedulingFineShifts")]
                [Validation(Required=false)]
                public List<GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingFineShifts> SchedulingFineShifts { get; set; }
                public class GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingFineShifts : TeaModel {
                    [NameInMap("cycleOrder")]
                    [Validation(Required=false)]
                    public long? CycleOrder { get; set; }

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

                    [NameInMap("schedulingUserName")]
                    [Validation(Required=false)]
                    public string SchedulingUserName { get; set; }

                    [NameInMap("shiftName")]
                    [Validation(Required=false)]
                    public string ShiftName { get; set; }

                    [NameInMap("skipOneDay")]
                    [Validation(Required=false)]
                    public bool? SkipOneDay { get; set; }

                }

                [NameInMap("schedulingTemplateFineShifts")]
                [Validation(Required=false)]
                public List<GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingTemplateFineShifts> SchedulingTemplateFineShifts { get; set; }
                public class GetServiceGroupSchedulingResponseBodyDataFineSchedulingSchedulingTemplateFineShifts : TeaModel {
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
                    public string SchedulingUserId { get; set; }

                    [NameInMap("schedulingUserIdList")]
                    [Validation(Required=false)]
                    public List<long?> SchedulingUserIdList { get; set; }

                    [NameInMap("schedulingUserName")]
                    [Validation(Required=false)]
                    public string SchedulingUserName { get; set; }

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

            [NameInMap("users")]
            [Validation(Required=false)]
            public List<GetServiceGroupSchedulingResponseBodyDataUsers> Users { get; set; }
            public class GetServiceGroupSchedulingResponseBodyDataUsers : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
