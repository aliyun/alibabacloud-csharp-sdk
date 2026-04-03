// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AccessDeniedDetail : TeaModel {
        /// <summary>
        /// <para>被拒绝的 RAM action，如 agentrun:ListTemplates</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("authAction")]
        [Validation(Required=false)]
        public string AuthAction { get; set; }

        /// <summary>
        /// <para>鉴权主体展示名</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("authPrincipalDisplayName")]
        [Validation(Required=false)]
        public string AuthPrincipalDisplayName { get; set; }

        /// <summary>
        /// <para>鉴权主体所属账号 ID</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("authPrincipalOwnerId")]
        [Validation(Required=false)]
        public string AuthPrincipalOwnerId { get; set; }

        /// <summary>
        /// <para>鉴权主体类型，如 SubUser、AssumedRoleUser</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("authPrincipalType")]
        [Validation(Required=false)]
        public string AuthPrincipalType { get; set; }

        /// <summary>
        /// <para>Base64 编码的诊断信息，可用于 RAM 控制台自诊断</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("encodedDiagnosticInfo")]
        [Validation(Required=false)]
        public string EncodedDiagnosticInfo { get; set; }

        /// <summary>
        /// <para>无权限类型：ImplicitDeny 或 ExplicitDeny</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("noPermissionType")]
        [Validation(Required=false)]
        public string NoPermissionType { get; set; }

        /// <summary>
        /// <para>策略类型，如 ResourceBasedPolicy、IdentityBasedPolicy</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
