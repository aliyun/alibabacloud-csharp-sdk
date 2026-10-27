// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetOncallScheduleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("oncallScheduleId")]
        [Validation(Required=false)]
        public string OncallScheduleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testOncallScheduleName</para>
        /// </summary>
        [NameInMap("oncallScheduleName")]
        [Validation(Required=false)]
        public string OncallScheduleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("rotations")]
        [Validation(Required=false)]
        public List<GetOncallScheduleResponseBodyRotations> Rotations { get; set; }
        public class GetOncallScheduleResponseBodyRotations : TeaModel {
            [NameInMap("activeDays")]
            [Validation(Required=false)]
            public List<int?> ActiveDays { get; set; }

            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<string> Contacts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24:00</para>
            /// </summary>
            [NameInMap("rotationEndTime")]
            [Validation(Required=false)]
            public string RotationEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("rotationName")]
            [Validation(Required=false)]
            public string RotationName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00:00</para>
            /// </summary>
            [NameInMap("rotationStartTime")]
            [Validation(Required=false)]
            public string RotationStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("shiftLength")]
            [Validation(Required=false)]
            public int? ShiftLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WEEKLY</para>
            /// </summary>
            [NameInMap("shiftRecurrenceFrequency")]
            [Validation(Required=false)]
            public string ShiftRecurrenceFrequency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-10</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testId</para>
        /// </summary>
        [NameInMap("shiftRobotId")]
        [Validation(Required=false)]
        public string ShiftRobotId { get; set; }

        [NameInMap("substitudes")]
        [Validation(Required=false)]
        public List<GetOncallScheduleResponseBodySubstitudes> Substitudes { get; set; }
        public class GetOncallScheduleResponseBodySubstitudes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-15 18:00</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testId</para>
            /// </summary>
            [NameInMap("replacedContactId")]
            [Validation(Required=false)]
            public string ReplacedContactId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-10 09:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-cms-5884500827389836-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
