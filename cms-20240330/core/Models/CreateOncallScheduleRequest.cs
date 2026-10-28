// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateOncallScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the on-call schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testOncallScheduleId</para>
        /// </summary>
        [NameInMap("oncallScheduleId")]
        [Validation(Required=false)]
        public string OncallScheduleId { get; set; }

        /// <summary>
        /// <para>The name of the on-call schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testOncallScheduleName</para>
        /// </summary>
        [NameInMap("oncallScheduleName")]
        [Validation(Required=false)]
        public string OncallScheduleName { get; set; }

        /// <summary>
        /// <para>The list of rotations.</para>
        /// </summary>
        [NameInMap("rotations")]
        [Validation(Required=false)]
        public List<CreateOncallScheduleRequestRotations> Rotations { get; set; }
        public class CreateOncallScheduleRequestRotations : TeaModel {
            /// <summary>
            /// <para>The days of the week when the rotation is active.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("activeDays")]
            [Validation(Required=false)]
            public List<int?> ActiveDays { get; set; }

            /// <summary>
            /// <para>The list of contacts.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// <para>The end time of the rotation. Format: HH:mm.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24:00</para>
            /// </summary>
            [NameInMap("rotationEndTime")]
            [Validation(Required=false)]
            public string RotationEndTime { get; set; }

            /// <summary>
            /// <para>The name of the rotation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRotationName</para>
            /// </summary>
            [NameInMap("rotationName")]
            [Validation(Required=false)]
            public string RotationName { get; set; }

            /// <summary>
            /// <para>The start time of the rotation. Format: HH:mm.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("rotationStartTime")]
            [Validation(Required=false)]
            public string RotationStartTime { get; set; }

            /// <summary>
            /// <para>The length of the shift interval. Use this parameter in conjunction with shiftRecurrenceFrequency. For example, set this parameter to 3 to rotate to the next on-call contact every 3 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("shiftLength")]
            [Validation(Required=false)]
            public int? ShiftLength { get; set; }

            /// <summary>
            /// <para>The unit of the shift interval. Use this parameter in conjunction with shiftRecurrenceFrequency. For example, set this parameter to week to rotate to the next on-call contact every week.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEEKLY</para>
            /// </summary>
            [NameInMap("shiftRecurrenceFrequency")]
            [Validation(Required=false)]
            public string ShiftRecurrenceFrequency { get; set; }

            /// <summary>
            /// <para>The start date of the rotation. Format: yyyy-MM-dd.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-14</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The name of the time zone. The time zone must follow the <b>IANA Time Zone Database</b> standard, such as <c>Asia/Shanghai</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <para>The ID of the chatbot for shift reminders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRobotId</para>
        /// </summary>
        [NameInMap("shiftRobotId")]
        [Validation(Required=false)]
        public string ShiftRobotId { get; set; }

        /// <summary>
        /// <para>The list of substitution rules.</para>
        /// </summary>
        [NameInMap("substitudes")]
        [Validation(Required=false)]
        public List<CreateOncallScheduleRequestSubstitudes> Substitudes { get; set; }
        public class CreateOncallScheduleRequestSubstitudes : TeaModel {
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

}
