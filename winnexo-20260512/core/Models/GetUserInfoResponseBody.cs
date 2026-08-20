// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The profile picture URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/avatar.png">https://example.com/avatar.png</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

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
        /// <para>The CRM type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("crmType")]
        [Validation(Required=false)]
        public string CrmType { get; set; }

        /// <summary>
        /// <para>Indicates whether the user is an enterprise administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <para>Indicates whether the current logon tenant is the system tenant (tenantId=10000).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isSystemTenant")]
        [Validation(Required=false)]
        public bool? IsSystemTenant { get; set; }

        /// <summary>
        /// <para>The language preference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("languagePreference")]
        [Validation(Required=false)]
        public string LanguagePreference { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The user service description. Maximum length: 1000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("offering")]
        [Validation(Required=false)]
        public string Offering { get; set; }

        /// <summary>
        /// <para>The parsed result of the user service (JSON format).</para>
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
        /// <para>The personal profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("profileRoleInfo")]
        [Validation(Required=false)]
        public string ProfileRoleInfo { get; set; }

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
        /// <para>The user self-introduction. Maximum length: 1000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("selfIntroduction")]
        [Validation(Required=false)]
        public string SelfIntroduction { get; set; }

        /// <summary>
        /// <para>The effective tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>The tenant list.</para>
        /// </summary>
        [NameInMap("tenantList")]
        [Validation(Required=false)]
        public List<GetUserInfoResponseBodyTenantList> TenantList { get; set; }
        public class GetUserInfoResponseBodyTenantList : TeaModel {
            /// <summary>
            /// <para>The CRM type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("crmType")]
            [Validation(Required=false)]
            public string CrmType { get; set; }

            /// <summary>
            /// <para>The ID of the tenant to which the task belongs.</para>
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

            /// <summary>
            /// <para>The tenant type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: individual.</description></item>
            /// <item><description>org: enterprise.</description></item>
            /// <item><description>group: group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("tenantType")]
            [Validation(Required=false)]
            public string TenantType { get; set; }

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
        /// <para>The tenant type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user: individual.</description></item>
        /// <item><description>org: enterprise.</description></item>
        /// <item><description>group: group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("tenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

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
