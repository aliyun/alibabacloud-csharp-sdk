// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class UpdateReminderRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public UpdateReminderRequestDeviceInfo DeviceInfo { get; set; }
        public class UpdateReminderRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is set to SKILL_ID, the value is the application\&quot;s Skill ID.</description></item>
            /// <item><description>When the encoding type is set to PACKAGE_NAME, the value is the packageName of the corresponding client app.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device identity for Tmall Genie, and each method corresponds to a different encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used in the Android application customer flow.  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used in the cloud-based flow.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to either deviceOpenId or deviceUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of the device ID.  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: Default device ID.  </description></item>
            /// <item><description>UNION_ID: Organization-level device ID. This value is available only after an organization has been registered on the Tmall Genie skill application platform.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. This parameter is required when <b>IdType</b> is set to <b>UNION_ID</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>The input parameters for this service request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public UpdateReminderRequestPayload Payload { get; set; }
        public class UpdateReminderRequestPayload : TeaModel {
            /// <summary>
            /// <para>The detailed content of the reminder message.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>更新提醒内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the reminder to update.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20***34</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether this invocation is for debugging.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

            /// <summary>
            /// <para>Scheduling information for the reminder.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RecurrenceRule")]
            [Validation(Required=false)]
            public UpdateReminderRequestPayloadRecurrenceRule RecurrenceRule { get; set; }
            public class UpdateReminderRequestPayloadRecurrenceRule : TeaModel {
                /// <summary>
                /// <para>The date on which the reminder is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                /// <summary>
                /// <para>Configure monthly reminders, specifying on which day(s) of each month the reminder is triggered.</para>
                /// </summary>
                [NameInMap("DaysOfMonth")]
                [Validation(Required=false)]
                public List<int?> DaysOfMonth { get; set; }

                /// <summary>
                /// <para>Configure weekly reminders, indicating on which days of the week the reminder is triggered.</para>
                /// </summary>
                [NameInMap("DaysOfWeek")]
                [Validation(Required=false)]
                public List<int?> DaysOfWeek { get; set; }

                /// <summary>
                /// <para>The expiration time when the reminder ends, in milliseconds as a UNIX timestamp.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1635134700000</para>
                /// </summary>
                [NameInMap("EndDateTime")]
                [Validation(Required=false)]
                public long? EndDateTime { get; set; }

                /// <summary>
                /// <para>Recurrence type:</para>
                /// <list type="bullet">
                /// <item><description>ONCE: One-time</description></item>
                /// <item><description>DAILY: Daily</description></item>
                /// <item><description>WEEKLY: Weekly</description></item>
                /// <item><description>MONTHLY: Monthly</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("Freq")]
                [Validation(Required=false)]
                public string Freq { get; set; }

                /// <summary>
                /// <para>The hour of the time when the reminder is triggered.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Hour")]
                [Validation(Required=false)]
                public int? Hour { get; set; }

                /// <summary>
                /// <para>The minute of the time when the reminder is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public int? Minute { get; set; }

                /// <summary>
                /// <para>The month in which the reminder is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>The second of the time when the reminder is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Second")]
                [Validation(Required=false)]
                public int? Second { get; set; }

                /// <summary>
                /// <para>The effective start time of the reminder, in milliseconds as a UNIX timestamp.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1635134400000</para>
                /// </summary>
                [NameInMap("StartDateTime")]
                [Validation(Required=false)]
                public long? StartDateTime { get; set; }

                /// <summary>
                /// <para>The year of the time when the reminder is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("Year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        /// <summary>
        /// <para>User identifier information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public UpdateReminderRequestUserInfo UserInfo { get; set; }
        public class UpdateReminderRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is set to SKILL_ID, the value is the application\&quot;s Skill ID.  </description></item>
            /// <item><description>When the encoding type is set to PACKAGE_NAME, the value is the packageName of the corresponding client app.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the user identifier for Maojing, and each method corresponds to a different encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used in the Android application customer link.  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used in the cloud link.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>User identifier, set to either userOpenId or userUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of User ID  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: The default User ID identifier.  </description></item>
            /// <item><description>UNION_ID: The organization-dimension User ID identifier. This value is available only after an organization has been requested on the Tmall Genie Skill Application Open Platform.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. This parameter is required when <b>IdType</b> is set to <b>UNION_ID</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
