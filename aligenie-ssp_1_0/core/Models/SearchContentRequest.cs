// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class SearchContentRequest : TeaModel {
        /// <summary>
        /// <para>Device identification information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public SearchContentRequestDeviceInfo DeviceInfo { get; set; }
        public class SearchContentRequestDeviceInfo : TeaModel {
            /// <summary>
            /// <para>Value corresponding to the encoding type.  </para>
            /// <para>When the encoding type is <c>SKILL_ID</c>, the value is the application\&quot;s Skill ID.<br>When the encoding type is <c>PACKAGE_NAME</c>, the value is the <c>packageName</c> of the corresponding client app.</para>
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
            /// <para><c>PACKAGE_NAME</c>: APK package name, used for the Android application customer link.<br><c>SKILL_ID</c>: Skill ID, used for the cloud-based link.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>Device ID, set to either <c>deviceOpenId</c> or <c>deviceUnionId</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAFE****ce3ej=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Type of device ID.  </para>
            /// <para><c>OPEN_ID</c>: Default device ID identity.<br><c>UNION_ID</c>: Organization-dimension device ID identity. This value is available only after an organization has been registered on the Tmall Genie Skill Application Open Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required when <c>IdType</c> is <c>UNION_ID</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**2</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Request Parameters</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Request")]
        [Validation(Required=false)]
        public SearchContentRequestRequest Request { get; set; }
        public class SearchContentRequestRequest : TeaModel {
            /// <summary>
            /// <para>The search scope: music or audio.<br>Input parameter enumeration: music | program</para>
            /// 
            /// <b>Example:</b>
            /// <para>music</para>
            /// </summary>
            [NameInMap("Cate")]
            [Validation(Required=false)]
            public string Cate { get; set; }

            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Number of records per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Query keyword</para>
            /// 
            /// <b>Example:</b>
            /// <para>周杰伦</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>Whether to query albums</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("QueryAlbum")]
            [Validation(Required=false)]
            public bool? QueryAlbum { get; set; }

            /// <summary>
            /// <para>When <c>cate</c> is <c>music</c>, <c>subCate</c> can be omitted.<br>If <c>subCate</c> is provided, it can be one of the following:<br><c>song</c> (Song), <c>singer</c> (Artist), <c>album</c> (Album).  </para>
            /// <para>When <c>cate</c> is <c>program</c>, <c>subCate</c> can be omitted.<br>If <c>subCate</c> is provided, it can be one of the following:<br><c>album</c> (Album), <c>audio</c> (Program Audio), <c>radio</c> (Radio Station).</para>
            /// 
            /// <b>Example:</b>
            /// <para>singer</para>
            /// </summary>
            [NameInMap("SubCate")]
            [Validation(Required=false)]
            public string SubCate { get; set; }

        }

        /// <summary>
        /// <para>User identification information</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public SearchContentRequestUserInfo UserInfo { get; set; }
        public class SearchContentRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The value corresponding to the encoding type.</para>
            /// <para>When the encoding type is SKILL_ID, the value is the Skill ID of the application.<br>When the encoding type is PACKAGE_NAME, the value is the packageName of the corresponding client app.</para>
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
            /// <para><c>PACKAGE_NAME</c>: APK package name, used for the Android application customer link.<br><c>SKILL_ID</c>: Skill ID, used for the cloud-based link.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PACKAGE_NAME</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>User identifier, set to either <c>userOpenId</c> or <c>userUnionId</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOFF****my7Iw=</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Type of the User ID.</para>
            /// <para>OPEN_ID: The default User ID identity.<br>UNION_ID: The organization-dimension User ID identity. This value is available only after an organization has been requested on the Tmall Genie Skills Open Platform.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPEN_ID</para>
            /// </summary>
            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            /// <summary>
            /// <para>Organization ID. Required when <c>IdType</c> is <c>UNION_ID</c>.</para>
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
