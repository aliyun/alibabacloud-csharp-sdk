// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class CreatePlayingListRequest : TeaModel {
        /// <summary>
        /// <para>Device ID information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public CreatePlayingListRequestDeviceInfo DeviceInfo { get; set; }
        public class CreatePlayingListRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type.</para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID.<br>When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
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
            /// <para><c>PACKAGE_NAME</c>: APK package name, used as the encoding type for the Android application customer link.<br><c>SKILL_ID</c>: Skill ID, used as the encoding type for the cloud-based link.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to either deviceOpenId or deviceUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rV/XSgPuxZjx/hN3iw8U+e8ouRjKOX95tn1a0kwb2+Ao6Q1CAxASJUZDWtlk1r43LWcVW6fvY1Rr4sEPFodpnA==</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID.</para>
            /// <para><c>OPEN_ID</c>: Default device ID identity.<br><c>UNION_ID</c>: Organization-dimension device ID identity. This value is available only after an organization has been requested on the Tmall Genie skill application Open Platform.</para>
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
        [NameInMap("OpenCreatePlayingListRequest")]
        [Validation(Required=false)]
        public CreatePlayingListRequestOpenCreatePlayingListRequest OpenCreatePlayingListRequest { get; set; }
        public class CreatePlayingListRequestOpenCreatePlayingListRequest : TeaModel {
            /// <summary>
            /// <para>Playback content list.</para>
            /// <para>If the content type is &quot;content&quot;, multiple entries are supported. If it is &quot;album&quot;, only the first entry takes effect.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ContentList")]
            [Validation(Required=false)]
            public List<CreatePlayingListRequestOpenCreatePlayingListRequestContentList> ContentList { get; set; }
            public class CreatePlayingListRequestOpenCreatePlayingListRequestContentList : TeaModel {
                /// <summary>
                /// <para>Third-party ID.</para>
                /// <para>If the content type is &quot;content&quot;, this is the content ID. If it is &quot;album&quot;, this is the album ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
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
            /// <para>Content type for playback.</para>
            /// <para>Values: &quot;content&quot; for content, &quot;album&quot; for album, and &quot;collect&quot; for playlist.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>extension information</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            /// <summary>
            /// <para>Playback index.</para>
            /// <para>Can be empty. Default is 0, indicating playback starts from the beginning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>Whether to resume album playback. For example, if the user previously listened up to episode 5 of an album, whether to continue from episode 5. Default is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAlbumContinued")]
            [Validation(Required=false)]
            public bool? NeedAlbumContinued { get; set; }

            /// <summary>
            /// <para>Playback source, the UUID for configuring playback control capabilities.</para>
            /// <para>Can be empty. Default is &quot;default&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("PlayFrom")]
            [Validation(Required=false)]
            public string PlayFrom { get; set; }

            /// <summary>
            /// <para>Playback pattern.</para>
            /// <para>Repeat: list loop; Shuffle: random; RepeatOne: single track loop; Normal: sequential playback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Repeat</para>
            /// </summary>
            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

        }

        /// <summary>
        /// <para>User identity information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreatePlayingListRequestUserInfo UserInfo { get; set; }
        public class CreatePlayingListRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type.</para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID.<br>When the encoding type is <c>PACKAGE_NAME</c>, the value is the packageName of the corresponding client app.</para>
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
            /// <para><c>PACKAGE_NAME</c>: APK package name, used as the encoding type for the Android application customer link.<br><c>SKILL_ID</c>: Skill ID, used as the encoding type for the cloud-based link.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>User identifier, set to either userOpenId or userUnionId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rV/XSgPuxZjx/hN3iw8U+e8ouRjKOX95tn1a0kwb2+Ao6Q1CAxASJUZDWtlk1r43LWcVW6fvY1Rr4sEPFodpnA==</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of User ID.</para>
            /// <para><c>OPEN_ID</c>: Default User ID identity.<br><c>UNION_ID</c>: Organization-dimension User ID identity. This value is available only after an organization has been requested on the Tmall Genie skill application Open Platform.</para>
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

    }

}
