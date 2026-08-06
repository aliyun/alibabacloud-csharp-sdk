// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class AddDocumentsRequest : TeaModel {
        [NameInMap("Dedup")]
        [Validation(Required=false)]
        public AddDocumentsRequestDedup Dedup { get; set; }
        public class AddDocumentsRequestDedup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContentDedup")]
            [Validation(Required=false)]
            public bool? ContentDedup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DocNameDedup")]
            [Validation(Required=false)]
            public bool? DocNameDedup { get; set; }

        }

        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<AddDocumentsRequestDocuments> Documents { get; set; }
        public class AddDocumentsRequestDocuments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CHANGELOG.md</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>本地上传时为预签名上传使用的批次相对路径；不同 ImportType 下含义由导入类型定义。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026_06_23_17_49_52WwGSUezpG2u2iHWxyYGzkf9KtormhkxN/CHANGELOG.md</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>当前支持 LOCAL_UPLOAD；OSS_IMPORT 和 PUBLIC_URL 为后续导入方式预留。</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOCAL_UPLOAD</para>
        /// </summary>
        [NameInMap("ImportType")]
        [Validation(Required=false)]
        public string ImportType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kb-3bd02617e9be335f</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>导入时批量设置到本批次所有知识数据的标签键值。Key 必须为知识库已定义标签字段；Value 支持 string、int64、float32、bool、list。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;department&quot;:&quot;legal&quot;,&quot;topics&quot;:[&quot;policy&quot;,&quot;contract&quot;],&quot;reviewed&quot;:true}</para>
        /// </summary>
        [NameInMap("MetaFields")]
        [Validation(Required=false)]
        public object MetaFields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kb-strategy-7043984ca395eabd</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        [NameInMap("dingTalkConfiguration")]
        [Validation(Required=false)]
        public AddDocumentsRequestDingTalkConfiguration DingTalkConfiguration { get; set; }
        public class AddDocumentsRequestDingTalkConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("appPassword")]
            [Validation(Required=false)]
            public string AppPassword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("dingDocMcpLink")]
            [Validation(Required=false)]
            public string DingDocMcpLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("dingTableMcpLink")]
            [Validation(Required=false)]
            public string DingTableMcpLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("knowledgeId")]
            [Validation(Required=false)]
            public string KnowledgeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("knowledgeType")]
            [Validation(Required=false)]
            public string KnowledgeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
