// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetUserByAccessKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public GetUserByAccessKeyResponseBodyUserInfo UserInfo { get; set; }
        public class GetUserByAccessKeyResponseBodyUserInfo : TeaModel {
            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The Dataphin user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30011210</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The email address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xx@aliyun.com">xx@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Mail")]
            [Validation(Required=false)]
            public string Mail { get; set; }

            /// <summary>
            /// <para>The nickname of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The account source type, such as ALIYUN_OAUTH2, PUBLICCLOUD_OAUTH2, BUC, or APSARA.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_OAUTH2</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The source account ID of the user during SSO integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public string SourceUserId { get; set; }

            /// <summary>
            /// <para>The tenant member status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: Normal.</description></item>
            /// <item><description>DEACTIVATE: Deactivated.</description></item>
            /// <item><description>DELETE: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tenant-level roles assigned to the AK/SK owner in the current tenant.</para>
            /// </summary>
            [NameInMap("TenantRoles")]
            [Validation(Required=false)]
            public List<GetUserByAccessKeyResponseBodyUserInfoTenantRoles> TenantRoles { get; set; }
            public class GetUserByAccessKeyResponseBodyUserInfoTenantRoles : TeaModel {
                /// <summary>
                /// <para>The role identifier, such as SUPER_ADMIN or COMMON_USER.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUPER_ADMIN</para>
                /// </summary>
                [NameInMap("RoleKey")]
                [Validation(Required=false)]
                public string RoleKey { get; set; }

                /// <summary>
                /// <para>The role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tenant Administrator</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

            /// <summary>
            /// <para>The username of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
