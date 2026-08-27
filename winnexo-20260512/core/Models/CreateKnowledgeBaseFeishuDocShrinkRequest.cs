// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateKnowledgeBaseFeishuDocShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise policy document</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The folder ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir_tenant_kb_child</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The document URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.feishu.cn/docx/doxcnExample">https://example.feishu.cn/docx/doxcnExample</a></para>
        /// </summary>
        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        /// <summary>
        /// <para>The mirror name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise Policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The meeting notes content (optional). Used for auxiliary analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Extract applicable scope and key clauses</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The object bindings.</para>
        /// </summary>
        [NameInMap("objectBindings")]
        [Validation(Required=false)]
        public string ObjectBindingsShrink { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name, optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enterprise Knowledge Assistant</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The resource tags (optional, a JSON string list such as [&quot;tagA&quot;,&quot;tagB&quot;]).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;policy&quot;]</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The synchronization settings.</para>
        /// </summary>
        [NameInMap("syncConfig")]
        [Validation(Required=false)]
        public string SyncConfigShrink { get; set; }

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
