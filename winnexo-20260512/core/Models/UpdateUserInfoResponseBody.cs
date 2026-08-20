// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The current zone list is illegal.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user information.</para>
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public UpdateUserInfoResponseBodyUser User { get; set; }
        public class UpdateUserInfoResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The user profile picture URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/avatar.png">https://example.com/avatar.png</a></para>
            /// </summary>
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is a super administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isAdmin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }

            /// <summary>
            /// <para>Indicates whether the current logged-in tenant is a system tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isSystemTenant")]
            [Validation(Required=false)]
            public bool? IsSystemTenant { get; set; }

            /// <summary>
            /// <para>The user language preference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("languagePreference")]
            [Validation(Required=false)]
            public string LanguagePreference { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user service description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("offering")]
            [Validation(Required=false)]
            public string Offering { get; set; }

            /// <summary>
            /// <para>The parsed user service result in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("parsedOffering")]
            [Validation(Required=false)]
            public string ParsedOffering { get; set; }

            /// <summary>
            /// <para>The user role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("profileRole")]
            [Validation(Required=false)]
            public string ProfileRole { get; set; }

            /// <summary>
            /// <para>The user role description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("profileRoleInfo")]
            [Validation(Required=false)]
            public string ProfileRoleInfo { get; set; }

            /// <summary>
            /// <para>The user self-introduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("selfIntroduction")]
            [Validation(Required=false)]
            public string SelfIntroduction { get; set; }

            /// <summary>
            /// <para>The current tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The list of tenants to which the user belongs.</para>
            /// </summary>
            [NameInMap("tenantList")]
            [Validation(Required=false)]
            public List<UpdateUserInfoResponseBodyUserTenantList> TenantList { get; set; }
            public class UpdateUserInfoResponseBodyUserTenantList : TeaModel {
                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

                /// <summary>
                /// <para>The tenant name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("tenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            /// <summary>
            /// <para>The current tenant name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("tenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The user code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("userCode")]
            [Validation(Required=false)]
            public string UserCode { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
