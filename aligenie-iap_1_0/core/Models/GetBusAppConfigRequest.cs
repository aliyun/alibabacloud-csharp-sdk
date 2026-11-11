// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class GetBusAppConfigRequest : TeaModel {
        /// <summary>
        /// <para>Device ID information</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public GetBusAppConfigRequestDeviceInfo DeviceInfo { get; set; }
        public class GetBusAppConfigRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type. When the encoding type is SKILL_ID, the value is the application\&quot;s Skill ID. When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12**45</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device ID for Maojing, and each method corresponds to a different encoding type: PACKAGE_NAME: APK package name, used for Android application customer journeys; SKILL_ID: skill ID, used for cloud-based journeys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL_ID</para>
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
            /// <para>Type of device ID: OPEN_ID: default device ID; UNION_ID: organization-dimension device ID, available only after an organization has been requested on the Maojing Skill Application Open Platform.</para>
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
        public GetBusAppConfigRequestPayload Payload { get; set; }
        public class GetBusAppConfigRequestPayload : TeaModel {
            /// <summary>
            /// <para>Plaintext UUID</para>
            /// 
            /// <b>Example:</b>
            /// <para>731D5F********DC3B</para>
            /// </summary>
            [NameInMap("originUuid")]
            [Validation(Required=false)]
            public string OriginUuid { get; set; }

            /// <summary>
            /// <para>Phone number</para>
            /// 
            /// <b>Example:</b>
            /// <para>136****1111</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        /// <summary>
        /// <para>User identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public GetBusAppConfigRequestUserInfo UserInfo { get; set; }
        public class GetBusAppConfigRequestUserInfo : TeaModel {
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
            /// <para>Encoding type. There are multiple ways to obtain the user identifier for Maojing, and each method corresponds to a different encoding type: PACKAGE_NAME: APK package name, used for Android application customer ingest endpoints; SKILL_ID: skill ID, used for cloud-based ingest endpoints.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>User Identifier (UserOpenId or UserUnionId)</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of User ID: OPEN_ID: default User ID identity; UNION_ID: organization-dimension User ID identity, available only after an organization has been requested on the Maojing Skill Application Open Platform.</para>
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
