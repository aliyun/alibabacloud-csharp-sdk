// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class PullCashierRequest : TeaModel {
        /// <summary>
        /// <para>device ID information</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public PullCashierRequestDeviceInfo DeviceInfo { get; set; }
        public class PullCashierRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILL_ID, the value is the Skill ID of the application.</description></item>
            /// <item><description>When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device ID of Tmall Genie, and each method corresponds to a different encoding type.  </para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used in the Android application customer flow.  </description></item>
            /// <item><description>SKILL_ID: Skill ID, used in the cloud-based flow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to deviceOpenId or deviceUnionId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID  </para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: The default device ID.  </description></item>
            /// <item><description>UNION_ID: Organization-level device ID. This value is available only after an organization has been requested on the Tmall Genie skill application Open Platform.</description></item>
            /// </list>
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
        /// <para>Business parameters</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public PullCashierRequestPayload Payload { get; set; }
        public class PullCashierRequestPayload : TeaModel {
            /// <summary>
            /// <para>Plaintext UUID</para>
            /// 
            /// <b>Example:</b>
            /// <para>731D5F********DC3B</para>
            /// </summary>
            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

        }

        /// <summary>
        /// <para>User identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public PullCashierRequestUserInfo UserInfo { get; set; }
        public class PullCashierRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <list type="bullet">
            /// <item><description>When the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID.</description></item>
            /// <item><description>When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</description></item>
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
            /// <para>Encoding type. There are multiple ways to obtain the user identifier from Tmall Genie, and each method corresponds to a different encoding type.</para>
            /// <list type="bullet">
            /// <item><description>PACKAGE_NAME: APK package name, used for the Android application customer ingest endpoint.</description></item>
            /// <item><description>SKILL_ID: Skill ID, used for the cloud-based ingest endpoint.</description></item>
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
            /// <para>Type of the User ID.</para>
            /// <list type="bullet">
            /// <item><description>OPEN_ID: The default User ID identity.</description></item>
            /// <item><description>UNION_ID: Organization-dimension User ID identity. This value is available only after an organization has been requested on the Tmall Genie Skill Application Platform.</description></item>
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
