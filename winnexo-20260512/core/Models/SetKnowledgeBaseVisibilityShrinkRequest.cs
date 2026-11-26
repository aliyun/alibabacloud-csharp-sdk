// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SetKnowledgeBaseVisibilityShrinkRequest : TeaModel {
        /// <summary>
        /// <para>token</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>Specifies how to handle subfolders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CURRENT_ONLY</para>
        /// </summary>
        [NameInMap("cascadeMode")]
        [Validation(Required=false)]
        public string CascadeMode { get; set; }

        /// <summary>
        /// <para>The user code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The target ID, which varies based on the target type.</para>
        /// <list type="bullet">
        /// <item><description>If the type is period, specify the period ID.</description></item>
        /// <item><description>If the type is objective, specify the objective ID.</description></item>
        /// <item><description>If the type is kr, specify the keyResult ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb_001</para>
        /// </summary>
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the current permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>period: period type</description></item>
        /// <item><description>objective: objective type</description></item>
        /// <item><description>kr: keyResult type</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KB</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the resource belongs. If this parameter is not specified, the current tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The collection of user groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;group-1&quot;]</para>
        /// </summary>
        [NameInMap("userGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIdsShrink { get; set; }

        /// <summary>
        /// <para>The collection of user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10001&quot;]</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIdsShrink { get; set; }

        /// <summary>
        /// <para>The visibility scope mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPECIFIED</para>
        /// </summary>
        [NameInMap("visibilityMode")]
        [Validation(Required=false)]
        public string VisibilityMode { get; set; }

    }

}
