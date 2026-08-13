// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SyncOrgStructureRequest : TeaModel {
        /// <summary>
        /// <para>企业标识（必须与 listAvailableConfigs 返回的 corpId 一致）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCorpId</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>部门列表（至少包含一个根部门）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("departments")]
        [Validation(Required=false)]
        public List<SyncOrgStructureRequestDepartments> Departments { get; set; }
        public class SyncOrgStructureRequestDepartments : TeaModel {
            /// <summary>
            /// <para>部门 ID（外部标识，客户端自行保证唯一性）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleDeptId</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <para>部门名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <para>排序号（数值越小越靠前）</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            /// <summary>
            /// <para>父部门 ID（null 表示一级部门/根部门）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleParentDeptId</para>
            /// </summary>
            [NameInMap("parentDeptId")]
            [Validation(Required=false)]
            public string ParentDeptId { get; set; }

        }

        /// <summary>
        /// <para>成员列表（syncMembers=true 时必须提供）</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<SyncOrgStructureRequestMembers> Members { get; set; }
        public class SyncOrgStructureRequestMembers : TeaModel {
            /// <summary>
            /// <para>用户标识（SAML 场景为邮箱/UPN，需与 rbj_user_account.account_id 匹配）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleAccountId</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>所属部门 ID（必须与 departments 中的 deptId 对应）</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleDeptId</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <para>用户姓名（展示用，可选）</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>平台类型: saml / oauth2 / custom</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>saml</para>
        /// </summary>
        [NameInMap("platformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        /// <summary>
        /// <para>SSO 配置 ID（SAML/OAuth2 可选：不传时按 corpId 自动推导；若存在多个 IdP 使用相同 corpId 则必须显式传入，否则报 AMBIGUOUS 错误；custom 不需要）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSsoSettingsId</para>
        /// </summary>
        [NameInMap("ssoSettingsId")]
        [Validation(Required=false)]
        public string SsoSettingsId { get; set; }

        /// <summary>
        /// <para>是否同步成员关系（custom 模式强制为 false）</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("syncMembers")]
        [Validation(Required=false)]
        public bool? SyncMembers { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
