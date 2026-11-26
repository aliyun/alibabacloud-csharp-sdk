// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateKnowledgeBaseSmartIndexConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The platform application credential. Pass this parameter when using the application proxy mode, and specify the operator by using opsUserId or opsUserCode based on the application configuration. Do not use real credentials in logs or public examples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>The automatic execution schedule. Use a five-part cron expression where the minute field must be 0. For example, 0 2 * * * indicates execution at 02:00 every day based on the timezone. Omitting this parameter, setting it to null, or using a blank string indicates manual execution and clears the old automatic schedule, but does not disable the smart index. Maximum length: 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 2 * * *</para>
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The business ID of the root directory for the standard enterprise knowledge base of the current tenant. You can obtain this ID from the response of the CreateTenantDirectory operation. You cannot use the internal primary key of the directory, or the IDs of personal spaces, group knowledge bases, subdirectories, or special knowledge bases.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-example</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the LLM Wiki smart index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled. Switching from disabled to enabled creates an asynchronous full build task and a bill.</description></item>
        /// <item><description>false: Disabled. If artifacts exist, asynchronous cleanup is initiated.
        /// You cannot toggle the switch during task execution, and you cannot re-enable it until cleanup is complete.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The revision obtained from the most recent configuration read. This value must be a non-negative integer. The value is 0 when not configured, and increments by 1 after a successful save. If the version does not match, ERR.SmartIndex.Conflict is returned. You must read the configuration again before saving. This field is not an idempotency key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("expectedRevision")]
        [Validation(Required=false)]
        public long? ExpectedRevision { get; set; }

        /// <summary>
        /// <para>The unique code of the proxied user within the tenant. This parameter is used only when the identity mapping mode of the application credential is source_uid. You cannot use this parameter to bypass tenant or knowledge base permission verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>The ID of the proxied WINNEXO platform user. This parameter is used only when the identity mapping mode of the application credential is winnexo_uid. You cannot use this parameter to bypass tenant or knowledge base permission verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The ID of the target tenant. This parameter is used for tenant routing in public requests. The server-side authentication chain verifies access permissions based on this parameter. You cannot use this parameter to access unauthorized tenants.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The IANA time zone name used for the execution schedule. Default value: Asia/Shanghai. If this parameter is omitted, set to null, or left as a blank string, the default value is used. The length of a non-empty value must be 1 to 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
