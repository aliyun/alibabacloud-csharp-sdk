// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PlayModeControlRequest : TeaModel {
        /// <summary>
        /// <para>Device identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public PlayModeControlRequestDeviceInfo DeviceInfo { get; set; }
        public class PlayModeControlRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type</para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID. When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the device ID for Tmall Genie, and each method corresponds to a different encoding type.</para>
            /// <para><c>PACKAGE_NAME</c>: APK package name, used for Android application customer journeys. <c>SKILL_ID</c>: Skill ID, used for cloud-based journeys.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to deviceOpenId or deviceUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rV/XSgPuxZjx/hN3iw8U+e8ouRjKOX95tn1a0kwb2+Ao6Q1CAxASJUZDWtlk1r43LWcVW6fvY1Rr4sEPFodpnA==</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID</para>
            /// <para><c>OPEN_ID</c>: Default device ID identity. <c>UNION_ID</c>: Organization-dimension device ID identity, available only after an organization has been requested on the Tmall Genie Skill Application Open Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required when IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Business parameters</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OpenPlayModeControlRequest")]
        [Validation(Required=false)]
        public PlayModeControlRequestOpenPlayModeControlRequest OpenPlayModeControlRequest { get; set; }
        public class PlayModeControlRequestOpenPlayModeControlRequest : TeaModel {
            /// <summary>
            /// <para>Playback mode</para>
            /// <para>List loop: Repeat; Shuffle: Shuffle; Single track loop: RepeatOne; NAT mode: Normal;</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OpenPlayMode")]
            [Validation(Required=false)]
            public string OpenPlayMode { get; set; }

        }

        /// <summary>
        /// <para>User Identifier information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public PlayModeControlRequestUserInfo UserInfo { get; set; }
        public class PlayModeControlRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type.</para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID. When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the User Identifier for Tmall Genie, and each method corresponds to a different encoding type.</para>
            /// <para><c>PACKAGE_NAME</c>: APK package name, used for the Android application customer ingest endpoint. <c>SKILL_ID</c>: Skill ID, used for the cloud-side ingest endpoint.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>User Identifier, set to userOpenId or userUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rV/XSgPuxZjx/hN3iw8U+e8ouRjKOX95tn1a0kwb2+Ao6Q1CAxASJUZDWtlk1r43LWcVW6fvY1Rr4sEPFodpnA==</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of User ID</para>
            /// <para><c>OPEN_ID</c>: The default User ID identity. <c>UNION_ID</c>: Organization-dimension User ID identity. This value is available only after an organization has been requested on the Tmall Genie Skill Application Open Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required when IdType is UNION_ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
