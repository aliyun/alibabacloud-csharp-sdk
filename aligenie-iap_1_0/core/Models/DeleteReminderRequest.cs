// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class DeleteReminderRequest : TeaModel {
        /// <summary>
        /// <para>device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public DeleteReminderRequestDeviceInfo DeviceInfo { get; set; }
        public class DeleteReminderRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type. When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID. When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>encoding type; there are multiple ways to obtain the Tmall Genie device ID, and each method corresponds to a different encoding type  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used in the Android application customer flow  </description></item>
            /// <item><description>SKILL_ID: skill ID, used in the cloud-based flow</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL_ID</para>
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
            /// <para>type of device ID  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: default device ID  </description></item>
            /// <item><description>UNION_ID: organization-level device ID; available only after an organization has been requested on the Tmall Genie Skill Application Open Platform</description></item>
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
            /// <para>organization ID; required if IdType is <c>UNION_ID</c></para>
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
        public DeleteReminderRequestPayload Payload { get; set; }
        public class DeleteReminderRequestPayload : TeaModel {
            /// <summary>
            /// <para>Unique ID of the reminder</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20****34</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Debug flag</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebug")]
            [Validation(Required=false)]
            public bool? IsDebug { get; set; }

        }

        /// <summary>
        /// <para>User identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DeleteReminderRequestUserInfo UserInfo { get; set; }
        public class DeleteReminderRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type. When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID. When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the user identifier for Maojing, and each method corresponds to a different encoding type:  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application customer ingest endpoint  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud service ingest endpoint</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL_ID</para>
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
            /// <para>Type of the User ID:</para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: The default User ID identity.</description></item>
            /// <item><description>UNION_ID: The User ID identity at the organization dimension. This is available only after an organization has been requested on the Maojing Skill Application Open Platform.</description></item>
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
            /// <para>Organization ID. Required when IdType is <c>UNION_ID</c>.</para>
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
