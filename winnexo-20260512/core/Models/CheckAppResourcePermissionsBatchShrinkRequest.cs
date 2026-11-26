// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CheckAppResourcePermissionsBatchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The platform application token issued by the console. If specified, the operation is performed as the user specified by opsUserId or opsUserCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>The check item.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("checks")]
        [Validation(Required=false)]
        public string ChecksShrink { get; set; }

        /// <summary>
        /// <para>The proxy user code, which is unique within the tenant. This parameter is used only when the application credential is configured as source_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>The proxy user ID, which is the WINNEXO platform user ID. This parameter is used only when the application credential is configured as winnexo_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The ID of the target platform user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("resourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>The tenant to which the target user belongs. This parameter is required for cross-tenant targets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// <para>The check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("targetUserTenantId")]
        [Validation(Required=false)]
        public string TargetUserTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to which the resource belongs. If not specified, the current tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
