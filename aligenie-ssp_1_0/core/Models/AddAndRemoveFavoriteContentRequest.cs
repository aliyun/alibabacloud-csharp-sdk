// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AddAndRemoveFavoriteContentRequest : TeaModel {
        /// <summary>
        /// <para>Device identification information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public AddAndRemoveFavoriteContentRequestDeviceInfo DeviceInfo { get; set; }
        public class AddAndRemoveFavoriteContentRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type</para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the Skill ID of the application. When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
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
            /// <para><c>PACKAGE_NAME</c>: APK package name, used for the Android application customer link. <c>SKILL_ID</c>: Skill ID, used for the cloud-based link.</para>
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
            /// <para><c>OPEN_ID</c>: Default device ID identifier. <c>UNION_ID</c>: Device ID identifier at the organization dimension. This value is available only after an organization has been registered on the Tmall Genie Skill Application Open Platform.</para>
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
        [NameInMap("OpenAddAndRemoveFavoriteContentRequest")]
        [Validation(Required=false)]
        public AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequest OpenAddAndRemoveFavoriteContentRequest { get; set; }
        public class AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequest : TeaModel {
            /// <summary>
            /// <para>Operation Type</para>
            /// <para>ADD for collect; REMOVE for remove from favorites</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADD</para>
            /// </summary>
            [NameInMap("FavoriteCmd")]
            [Validation(Required=false)]
            public string FavoriteCmd { get; set; }

            /// <summary>
            /// <para>Object to collect or remove from favorites</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("OpenSourceRawIdPair")]
            [Validation(Required=false)]
            public AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequestOpenSourceRawIdPair OpenSourceRawIdPair { get; set; }
            public class AddAndRemoveFavoriteContentRequestOpenAddAndRemoveFavoriteContentRequestOpenSourceRawIdPair : TeaModel {
                /// <summary>
                /// <para>Extension information</para>
                /// </summary>
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendInfo { get; set; }

                /// <summary>
                /// <para>Third-party ID</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2105818057</para>
                /// </summary>
                [NameInMap("RawId")]
                [Validation(Required=false)]
                public string RawId { get; set; }

                /// <summary>
                /// <para>Source</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xiami</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <para>Content type</para>
            /// <para>Content: CONTENT; Album: ALBUM; Playlist: COLLECT.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTENT</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

        }

        /// <summary>
        /// <para>User identification information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public AddAndRemoveFavoriteContentRequestUserInfo UserInfo { get; set; }
        public class AddAndRemoveFavoriteContentRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the Skill ID of the application. When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>Encoding type. There are multiple ways to obtain the user identifier for Tmall Genie, and each method corresponds to a different encoding type.</para>
            /// <para><c>PACKAGE_NAME</c>: APK package name, used for the Android application customer link. <c>SKILL_ID</c>: Skill ID, used for the cloud-based link.</para>
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
            /// <para>The type of User ID.</para>
            /// <para><c>OPEN_ID</c>: The default User ID identity. <c>UNION_ID</c>: The organization-dimension User ID identity. This value is available only after an organization has been requested on the Tmall Genie Skills Open Platform.</para>
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
