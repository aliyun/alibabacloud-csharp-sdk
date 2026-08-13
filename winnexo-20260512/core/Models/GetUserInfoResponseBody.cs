// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>用户头像URL</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/avatar.png">https://example.com/avatar.png</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>CRM 类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("crmType")]
        [Validation(Required=false)]
        public string CrmType { get; set; }

        /// <summary>
        /// <para>是否为超级管理员</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <para>当前登录租户是否为系统租户（tenantId=10000）</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isSystemTenant")]
        [Validation(Required=false)]
        public bool? IsSystemTenant { get; set; }

        /// <summary>
        /// <para>用户语言偏好</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("languagePreference")]
        [Validation(Required=false)]
        public string LanguagePreference { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>用户服务描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("offering")]
        [Validation(Required=false)]
        public string Offering { get; set; }

        /// <summary>
        /// <para>用户服务解析结果（JSON格式）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("parsedOffering")]
        [Validation(Required=false)]
        public string ParsedOffering { get; set; }

        /// <summary>
        /// <para>用户角色</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("profileRole")]
        [Validation(Required=false)]
        public string ProfileRole { get; set; }

        /// <summary>
        /// <para>用户角色描述（当profileRole为Others时使用）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("profileRoleInfo")]
        [Validation(Required=false)]
        public string ProfileRoleInfo { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>用户自我介绍</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("selfIntroduction")]
        [Validation(Required=false)]
        public string SelfIntroduction { get; set; }

        /// <summary>
        /// <para>当前租户ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("tenantList")]
        [Validation(Required=false)]
        public List<GetUserInfoResponseBodyTenantList> TenantList { get; set; }
        public class GetUserInfoResponseBodyTenantList : TeaModel {
            /// <summary>
            /// <para>CRM 类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("crmType")]
            [Validation(Required=false)]
            public string CrmType { get; set; }

            /// <summary>
            /// <para>租户ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>租户名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("tenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>租户类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("tenantType")]
            [Validation(Required=false)]
            public string TenantType { get; set; }

        }

        /// <summary>
        /// <para>当前租户名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("tenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// <para>租户类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("tenantType")]
        [Validation(Required=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// <para>用户代码</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("userCode")]
        [Validation(Required=false)]
        public string UserCode { get; set; }

        /// <summary>
        /// <para>用户ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
