// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateOncallScheduleRequest : TeaModel {
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
        public List<UpdateOncallScheduleRequestRotations> Rotations { get; set; }
        public class UpdateOncallScheduleRequestRotations : TeaModel {
            /// <summary>
            /// <para>The days of the week when the rotation takes effect.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("activeDays")]
            [Validation(Required=false)]
            public List<int?> ActiveDays { get; set; }

            /// <summary>
            /// <para>The IDs of the contacts.</para>
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
            /// <para>test</para>
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
            /// <para>The length of the shift cycle. Used in conjunction with shiftRecurrenceFrequency, such as switching to the next on-call person every 3 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("shiftLength")]
            [Validation(Required=false)]
            public int? ShiftLength { get; set; }

            /// <summary>
            /// <para>The unit of the shift cycle. Used in conjunction with shiftRecurrenceFrequency, such as switching to the next on-call person every week.</para>
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
            /// <para>2024-04-04</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The time zone name. Uses the IANA Time Zone Database standard, such as Asia/Shanghai.</para>
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
        /// <para>The ID of the shift reminder chatbot.</para>
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
        public List<UpdateOncallScheduleRequestSubstitudes> Substitudes { get; set; }
        public class UpdateOncallScheduleRequestSubstitudes : TeaModel {
            /// <summary>
            /// <para>The contact ID of the substitute.</para>
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
            /// <para>The contact ID of the replaced person.</para>
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

    }

}
