// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SyncOrgStructureShrinkRequest : TeaModel {
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
        public string DepartmentsShrink { get; set; }

        /// <summary>
        /// <para>成员列表（syncMembers=true 时必须提供）</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public string MembersShrink { get; set; }

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
