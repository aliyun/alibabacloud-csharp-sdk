// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class UpdateAlarmRequest : TeaModel {
        /// <summary>
        /// <para>device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public UpdateAlarmRequestDeviceInfo DeviceInfo { get; set; }
        public class UpdateAlarmRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type. When the encoding type is SKILL_ID, the value is the Skill ID of the application. When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device ID for Maojing, and each method corresponds to a different encoding type: PACKAGE_NAME: APK package name, used in the Android application customer link; SKILL_ID: skill ID, used in the cloud link.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>device ID (deviceOpenId or deviceUnionId)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID: OPEN_ID: default device ID; UNION_ID: organization-dimension device ID, available only after an organization has been requested on the Maojing Skill Application Open Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>organization ID; required if IdType is UNION_ID</para>
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
        public UpdateAlarmRequestPayload Payload { get; set; }
        public class UpdateAlarmRequestPayload : TeaModel {
            /// <summary>
            /// <para>Alarm ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            /// <summary>
            /// <para>Ringtone information</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("MusicInfo")]
            [Validation(Required=false)]
            public UpdateAlarmRequestPayloadMusicInfo MusicInfo { get; set; }
            public class UpdateAlarmRequestPayloadMusicInfo : TeaModel {
                /// <summary>
                /// <para>Ringtone ID</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MusicId")]
                [Validation(Required=false)]
                public long? MusicId { get; set; }

                /// <summary>
                /// <para>Ringtone name</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx铃声</para>
                /// </summary>
                [NameInMap("MusicName")]
                [Validation(Required=false)]
                public string MusicName { get; set; }

                /// <summary>
                /// <para>Ringtone category ID</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MusicType")]
                [Validation(Required=false)]
                public long? MusicType { get; set; }

                /// <summary>
                /// <para>Ringtone category name</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx音乐</para>
                /// </summary>
                [NameInMap("MusicTypeName")]
                [Validation(Required=false)]
                public string MusicTypeName { get; set; }

                /// <summary>
                /// <para>Ringtone URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://music-url.mp3">http://music-url.mp3</a></para>
                /// </summary>
                [NameInMap("MusicUrl")]
                [Validation(Required=false)]
                public string MusicUrl { get; set; }

            }

            /// <summary>
            /// <para>Schedule information</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ScheduleInfo")]
            [Validation(Required=false)]
            public UpdateAlarmRequestPayloadScheduleInfo ScheduleInfo { get; set; }
            public class UpdateAlarmRequestPayloadScheduleInfo : TeaModel {
                /// <summary>
                /// <para>One-time: This property is active when the loop type is ONCE.</para>
                /// </summary>
                [NameInMap("Once")]
                [Validation(Required=false)]
                public UpdateAlarmRequestPayloadScheduleInfoOnce Once { get; set; }
                public class UpdateAlarmRequestPayloadScheduleInfoOnce : TeaModel {
                    /// <summary>
                    /// <para>Trigger time: day</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public int? Day { get; set; }

                    /// <summary>
                    /// <para>Trigger time: hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger time: minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                    /// <summary>
                    /// <para>Trigger time: Month</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    /// <summary>
                    /// <para>Trigger time: Year</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022</para>
                    /// </summary>
                    [NameInMap("Year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                /// <summary>
                /// <para>Statutory Working Day: This property is active when the loop Type is STATUTORY_WORKING_DAY.</para>
                /// </summary>
                [NameInMap("StatutoryWorkingDay")]
                [Validation(Required=false)]
                public UpdateAlarmRequestPayloadScheduleInfoStatutoryWorkingDay StatutoryWorkingDay { get; set; }
                public class UpdateAlarmRequestPayloadScheduleInfoStatutoryWorkingDay : TeaModel {
                    /// <summary>
                    /// <para>Trigger Time: Hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

                /// <summary>
                /// <para>Schedule Type / Loop Type:<br>ONCE -&gt; One-time, WEEKLY -&gt; Weekly loop, STATUTORY_WORKING_DAY -&gt; Statutory working day</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WEEKLY</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Weekly loop: This property is active when the loop Type is WEEKLY.</para>
                /// </summary>
                [NameInMap("Weekly")]
                [Validation(Required=false)]
                public UpdateAlarmRequestPayloadScheduleInfoWeekly Weekly { get; set; }
                public class UpdateAlarmRequestPayloadScheduleInfoWeekly : TeaModel {
                    /// <summary>
                    /// <para>Collection of days of the week to trigger: Numeric values between 1 and 7, where each number corresponds to a specific day of the week (1 for Monday, 2 for Tuesday, etc.). To trigger every day, include all values from 1 to 7.</para>
                    /// </summary>
                    [NameInMap("DaysOfWeek")]
                    [Validation(Required=false)]
                    public List<int?> DaysOfWeek { get; set; }

                    /// <summary>
                    /// <para>Trigger Time: Hour</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>Trigger time: minute</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Minute")]
                    [Validation(Required=false)]
                    public int? Minute { get; set; }

                }

            }

            /// <summary>
            /// <para>Ringtone volume</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public int? Volume { get; set; }

        }

        /// <summary>
        /// <para>User Identifier Information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public UpdateAlarmRequestUserInfo UserInfo { get; set; }
        public class UpdateAlarmRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type. If the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID. If the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding Type: There are multiple ways to obtain the User Identifier for Maojing, and each method corresponds to a different encoding Type:  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application Customer link  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud link</description></item>
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
            /// <para>User Identifier (userOpenId or userUnionId)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of the User ID: - OPEN_ID: default User ID identifier - UNION_ID: organization-dimension User ID identifier, available only after an organization has been requested on the Maojing Skill Application Open Platform</para>
            /// <para>This parameter is required.</para>
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

    }

}
