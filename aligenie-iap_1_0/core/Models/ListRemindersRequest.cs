// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class ListRemindersRequest : TeaModel {
        /// <summary>
        /// <para>List of device identity information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public ListRemindersRequestDeviceInfo DeviceInfo { get; set; }
        public class ListRemindersRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILLID, the value is the application\&quot;s Skill ID.  </description></item>
            /// <item><description>When the encoding type is PACKAGENAME, the value is the packageName of the corresponding client app.</description></item>
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
            /// <para>Encoding type. There are multiple ways to obtain the device ID for Tmall Genie, and each method corresponds to a different encoding type.  </para>
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
            /// <para>Device ID, either deviceOpenId or deviceUnionId.</para>
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
            /// <item><description>OPEN_ID: The default device ID.  </description></item>
            /// <item><description>UNION_ID: Organization-level device ID. This value is available only after an organization has been requested on the Tmall Genie Skill Application Open Platform.</description></item>
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
            /// <para>Organization ID. Required when <b>IdType</b> is set to <b>UNION_ID</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Input parameters for the service request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public ListRemindersRequestPayload Payload { get; set; }
        public class ListRemindersRequestPayload : TeaModel {
            /// <summary>
            /// <para>Indicates whether this invocation is for debug purposes.</para>
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
        /// <para>List of user identity information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ListRemindersRequestUserInfo UserInfo { get; set; }
        public class ListRemindersRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type:</para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILLID, the value is the application\&quot;s Skill ID.</description></item>
            /// <item><description>When the encoding type is PACKAGENAME, the value is the packageName of the corresponding client app.</description></item>
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
            /// <para>Encoding type. There are multiple ways to obtain the user identifier for Tmall Genie, and each method corresponds to a different encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application customer ingest endpoint.  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud-side ingest endpoint.</description></item>
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
            /// <para>User Identifier, either userOpenId or userUnionId.</para>
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
            /// <item><description>UNION_ID: The User ID identity at the organization dimension. This value is available only after an organization has been requested on the Tmall Genie Skill Application Open Platform.</description></item>
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
            /// <para>Organization ID. This parameter is required when <b>IdType</b> is configured as <b>UNION_ID</b>.</para>
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
