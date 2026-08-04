// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreateScheduleTaskRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestDeviceInfo DeviceInfo { get; set; }
        public class CreateScheduleTaskRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type. When the encoding type is SKILL_ID, the value is the SkillID of the application. When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device identity for Maojing, and each method corresponds to a different encoding type: PACKAGE_NAME: APK package name, used for Android application customer linkage; SKILL_ID: skill ID, used for cloud linkage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID (deviceOpenId or deviceUnionId)</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID: OPEN_ID: default device ID; UNION_ID: organization-level device ID, available only after applying for an organization in the Maojing Skill Application Open Platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required if IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Input parameters for the service request</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestPayload Payload { get; set; }
        public class CreateScheduleTaskRequestPayload : TeaModel {
            /// <summary>
            /// <para>Scheduling action parameters</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ActionDTOs")]
            [Validation(Required=false)]
            public List<CreateScheduleTaskRequestPayloadActionDTOs> ActionDTOs { get; set; }
            public class CreateScheduleTaskRequestPayloadActionDTOs : TeaModel {
                /// <summary>
                /// <para>Vendor-defined command</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:{&quot;key&quot;:1}}</para>
                /// </summary>
                [NameInMap("customAction")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomAction { get; set; }

            }

            /// <summary>
            /// <para>Idempotent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IdempotentId")]
            [Validation(Required=false)]
            public string IdempotentId { get; set; }

            /// <summary>
            /// <para>Scheduling information</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ScheduleDTO")]
            [Validation(Required=false)]
            public CreateScheduleTaskRequestPayloadScheduleDTO ScheduleDTO { get; set; }
            public class CreateScheduleTaskRequestPayloadScheduleDTO : TeaModel {
                /// <summary>
                /// <para>One-time Scan Configuration</para>
                /// </summary>
                [NameInMap("Once")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOOnce Once { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOOnce : TeaModel {
                    /// <summary>
                    /// <para>Trigger day</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>26</para>
                    /// </summary>
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    /// <summary>
                    /// <para>Trigger Hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger Minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    /// <summary>
                    /// <para>Trigger Month</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <para>Trigger Year</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022</para>
                    /// </summary>
                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                /// <summary>
                /// <para>Schedule end time</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1661589255000</para>
                /// </summary>
                [NameInMap("ScheduleEndTime")]
                [Validation(Required=false)]
                public long? ScheduleEndTime { get; set; }

                /// <summary>
                /// <para>Schedule Start Time</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1656318855000</para>
                /// </summary>
                [NameInMap("ScheduleStartTime")]
                [Validation(Required=false)]
                public long? ScheduleStartTime { get; set; }

                /// <summary>
                /// <para>Schedule Type</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONCE</para>
                /// </summary>
                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public string ScheduleType { get; set; }

                /// <summary>
                /// <para>Statutory working day schedule configuration</para>
                /// </summary>
                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOStatutoryWorkingDay : TeaModel {
                    /// <summary>
                    /// <para>Trigger hour; Multiple Choice</para>
                    /// </summary>
                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<int?> Hours { get; set; }

                    /// <summary>
                    /// <para>Trigger minute; Multiple Choice</para>
                    /// </summary>
                    [NameInMap("Minutes")]
                    [Validation(Required=false)]
                    public List<int?> Minutes { get; set; }

                }

                /// <summary>
                /// <para>Loop schedule configuration</para>
                /// </summary>
                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public CreateScheduleTaskRequestPayloadScheduleDTOWeekly Weekly { get; set; }
                public class CreateScheduleTaskRequestPayloadScheduleDTOWeekly : TeaModel {
                    /// <summary>
                    /// <para>Trigger days of the week, where 1–7 represent Monday through Sunday, respectively</para>
                    /// </summary>
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <para>Trigger hour</para>
                    /// </summary>
                    [NameInMap("Hours")]
                    [Validation(Required=false)]
                    public List<int?> Hours { get; set; }

                    /// <summary>
                    /// <para>Trigger minute</para>
                    /// </summary>
                    [NameInMap("Minutes")]
                    [Validation(Required=false)]
                    public List<int?> Minutes { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>User Identifier Information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateScheduleTaskRequestUserInfo UserInfo { get; set; }
        public class CreateScheduleTaskRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type. When the encoding type is SKILL_ID, the value is the application\&quot;s SkillID. When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding Type. There are multiple ways to obtain the user identifier for Maojing, and each method corresponds to a different encoding type: PACKAGE_NAME: APK package name, used for Android application customer links; SKILL_ID: Skill ID, used for cloud-based links.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>User Identifier (userOpenId or userUnionId)</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of User ID:  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: The default User ID identity.  </description></item>
            /// <item><description>UNION_ID: The User ID identity at the organization dimension. This is available only after an organization has been requested on the Maojing Skill Application Open Platform.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID; Required if IdType is UNION_ID</para>
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
