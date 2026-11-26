// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateShareShrinkRequest : TeaModel {
        /// <summary>
        /// <para>平台应用 Token（控制台签发）。传入后将以 opsUserId 或 opsUserCode 指定的用户身份执行</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>代理用户编码（租户内唯一），仅当应用凭证配置为 source_uid 时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>代理用户ID（WINNEXO 平台用户ID），仅当应用凭证配置为 winnexo_uid 时使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The output item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleOutputItemId</para>
        /// </summary>
        [NameInMap("outputItemId")]
        [Validation(Required=false)]
        public string OutputItemId { get; set; }

        /// <summary>
        /// <para>The name of the output item. This parameter must be used together with sessionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly Review.pptx</para>
        /// </summary>
        [NameInMap("outputItemName")]
        [Validation(Required=false)]
        public string OutputItemName { get; set; }

        /// <summary>
        /// <para>Specifies whether to refresh the sharing link. This is supported only for output items that have sharing enabled or are being enabled in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("refreshShareLink")]
        [Validation(Required=false)]
        public bool? RefreshShareLink { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The sharing scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Accessible to all users.</description></item>
        /// <item><description>SPECIFIED: Accessible to specified users or user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SPECIFIED</para>
        /// </summary>
        [NameInMap("shareAccessType")]
        [Validation(Required=false)]
        public string ShareAccessType { get; set; }

        /// <summary>
        /// <para>Specifies whether sharing is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("shareEnabled")]
        [Validation(Required=false)]
        public bool? ShareEnabled { get; set; }

        /// <summary>
        /// <para>The list of user group IDs within the specified scope. Pass an empty array to clear the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;group-1&quot;]</para>
        /// </summary>
        [NameInMap("shareUserGroupIds")]
        [Validation(Required=false)]
        public string ShareUserGroupIdsShrink { get; set; }

        /// <summary>
        /// <para>The list of platform user IDs within the specified scope. Pass an empty array to clear the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[10001]</para>
        /// </summary>
        [NameInMap("shareUserIds")]
        [Validation(Required=false)]
        public string ShareUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the current permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>period: Period type.</description></item>
        /// <item><description>objective: Objective type.</description></item>
        /// <item><description>kr: Key result type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outputItem</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
