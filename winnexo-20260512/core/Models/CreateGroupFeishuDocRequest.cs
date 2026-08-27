// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateGroupFeishuDocRequest : TeaModel {
        /// <summary>
        /// <para>The description of the AI assistant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group collaboration document</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The folder ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir_group_child</para>
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
        /// <para>The project group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_delivery</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project Plan</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The meeting notes content (optional). The notes are used for auxiliary analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Extract decisions and to-do items</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The object bindings.</para>
        /// </summary>
        [NameInMap("objectBindings")]
        [Validation(Required=false)]
        public List<CreateGroupFeishuDocRequestObjectBindings> ObjectBindings { get; set; }
        public class CreateGroupFeishuDocRequestObjectBindings : TeaModel {
            /// <summary>
            /// <para>The name of the semantic graph to which the object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crm</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>The ID of the recommended item, which can be a <b>feedId</b> or a mini-app ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The advanced field type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>The name of the operating object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Assistant</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The resource tags (optional, a JSON string list, such as [&quot;tagA&quot;,&quot;tagB&quot;]).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;R&amp;D&quot;]</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The synchronization settings.</para>
        /// </summary>
        [NameInMap("syncConfig")]
        [Validation(Required=false)]
        public CreateGroupFeishuDocRequestSyncConfig SyncConfig { get; set; }
        public class CreateGroupFeishuDocRequestSyncConfig : TeaModel {
            /// <summary>
            /// <para>The cron expression for the timed scheduling task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 * * * *</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable or disable synchronization.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The preset mode (can be ignored).</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("preset")]
            [Validation(Required=false)]
            public string Preset { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass it explicitly with --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
