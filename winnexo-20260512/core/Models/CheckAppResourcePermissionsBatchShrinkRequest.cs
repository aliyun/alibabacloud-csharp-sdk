// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CheckAppResourcePermissionsBatchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>检查项</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("checks")]
        [Validation(Required=false)]
        public string ChecksShrink { get; set; }

        /// <summary>
        /// <para>资源所属租户 ID；省略为调用人当前租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("resourceTenantId")]
        [Validation(Required=false)]
        public string ResourceTenantId { get; set; }

        /// <summary>
        /// <para>目标平台用户 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public long? TargetUserId { get; set; }

        /// <summary>
        /// <para>目标用户所属租户；跨租户目标必填</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("targetUserTenantId")]
        [Validation(Required=false)]
        public string TargetUserTenantId { get; set; }

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
