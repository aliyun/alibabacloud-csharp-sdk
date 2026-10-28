// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListOncallSchedulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of on-call schedules.</para>
        /// </summary>
        [NameInMap("oncallSchedules")]
        [Validation(Required=false)]
        public List<ListOncallSchedulesResponseBodyOncallSchedules> OncallSchedules { get; set; }
        public class ListOncallSchedulesResponseBodyOncallSchedules : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the on-call schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("oncallScheduleId")]
            [Validation(Required=false)]
            public string OncallScheduleId { get; set; }

            /// <summary>
            /// <para>The name of the on-call schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("oncallScheduleName")]
            [Validation(Required=false)]
            public string OncallScheduleName { get; set; }

            /// <summary>
            /// <para>The list of rotations.</para>
            /// </summary>
            [NameInMap("rotations")]
            [Validation(Required=false)]
            public List<ListOncallSchedulesResponseBodyOncallSchedulesRotations> Rotations { get; set; }
            public class ListOncallSchedulesResponseBodyOncallSchedulesRotations : TeaModel {
                /// <summary>
                /// <para>The days of the week when the rotation is active.</para>
                /// </summary>
                [NameInMap("activeDays")]
                [Validation(Required=false)]
                public List<int?> ActiveDays { get; set; }

                /// <summary>
                /// <para>The IDs of the contacts.</para>
                /// </summary>
                [NameInMap("contacts")]
                [Validation(Required=false)]
                public List<string> Contacts { get; set; }

                /// <summary>
                /// <para>The end time of the rotation. Format: HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24:00</para>
                /// </summary>
                [NameInMap("rotationEndTime")]
                [Validation(Required=false)]
                public string RotationEndTime { get; set; }

                /// <summary>
                /// <para>The name of the rotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testName</para>
                /// </summary>
                [NameInMap("rotationName")]
                [Validation(Required=false)]
                public string RotationName { get; set; }

                /// <summary>
                /// <para>The start time of the rotation. Format: HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("rotationStartTime")]
                [Validation(Required=false)]
                public string RotationStartTime { get; set; }

                /// <summary>
                /// <para>The length of the shift interval. Used in conjunction with shiftRecurrenceFrequency. For example, a value of 3 indicates that the on-call personnel rotates every 3 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("shiftLength")]
                [Validation(Required=false)]
                public int? ShiftLength { get; set; }

                /// <summary>
                /// <para>The unit of the shift interval. Used in conjunction with shiftLength. For example, a value of Week indicates that the on-call personnel rotates every week.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WEEKLY</para>
                /// </summary>
                [NameInMap("shiftRecurrenceFrequency")]
                [Validation(Required=false)]
                public string ShiftRecurrenceFrequency { get; set; }

                /// <summary>
                /// <para>The start date of the rotation. Format: yyyy-MM-dd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01</para>
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                /// <summary>
                /// <para>The name of the time zone. The IANA Time Zone Database standard is used. Example: Asia/Shanghai.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <para>The ID of the chatbot that sends shift reminders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("shiftRobotId")]
            [Validation(Required=false)]
            public string ShiftRobotId { get; set; }

            /// <summary>
            /// <para>The list of substitution rules.</para>
            /// </summary>
            [NameInMap("substitudes")]
            [Validation(Required=false)]
            public List<ListOncallSchedulesResponseBodyOncallSchedulesSubstitudes> Substitudes { get; set; }
            public class ListOncallSchedulesResponseBodyOncallSchedulesSubstitudes : TeaModel {
                /// <summary>
                /// <para>The ID of the substitute contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testId</para>
                /// </summary>
                [NameInMap("contactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <para>The end time of the substitution. Format: YYYY-MM-DD HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-15 18:00</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the replaced contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testId</para>
                /// </summary>
                [NameInMap("replacedContactId")]
                [Validation(Required=false)]
                public string ReplacedContactId { get; set; }

                /// <summary>
                /// <para>The start time of the substitution. Format: YYYY-MM-DD HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-10 09:00</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-5884500827389836-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
