// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalAlidingKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>目标个人目录 ID；不传时自动绑定到用户默认根目录，传入时必须是当前用户的已有个人目录（PERSONAL）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>知识库显示名称；不传时由后台从远程拉取的根节点名称回填</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("kbName")]
        [Validation(Required=false)]
        public string KbName { get; set; }

        /// <summary>
        /// <para>阿里钉知识库的可公开访问 URL</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("kbUrl")]
        [Validation(Required=false)]
        public string KbUrl { get; set; }

        [NameInMap("objectBindings")]
        [Validation(Required=false)]
        public List<CreatePersonalAlidingKnowledgeBaseRequestObjectBindings> ObjectBindings { get; set; }
        public class CreatePersonalAlidingKnowledgeBaseRequestObjectBindings : TeaModel {
            /// <summary>
            /// <para>绑定对象 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>绑定对象类型，例如 CUSTOMER / OPPORTUNITY</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>Agent 命名空间标识，可选</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        [NameInMap("syncConfig")]
        [Validation(Required=false)]
        public CreatePersonalAlidingKnowledgeBaseRequestSyncConfig SyncConfig { get; set; }
        public class CreatePersonalAlidingKnowledgeBaseRequestSyncConfig : TeaModel {
            /// <summary>
            /// <para>cron 表达式；enabled=true 时必填，enabled=false 时忽略</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>是否启用定时同步</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
