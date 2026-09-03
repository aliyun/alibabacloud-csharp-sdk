// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class AddDocumentsRequest : TeaModel {
        /// <summary>
        /// <para>The deduplication configuration.</para>
        /// </summary>
        [NameInMap("Dedup")]
        [Validation(Required=false)]
        public AddDocumentsRequestDedup Dedup { get; set; }
        public class AddDocumentsRequestDedup : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable content deduplication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContentDedup")]
            [Validation(Required=false)]
            public bool? ContentDedup { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable document name deduplication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DocNameDedup")]
            [Validation(Required=false)]
            public bool? DocNameDedup { get; set; }

        }

        /// <summary>
        /// <para>The list of documents.</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<AddDocumentsRequestDocuments> Documents { get; set; }
        public class AddDocumentsRequestDocuments : TeaModel {
            /// <summary>
            /// <para>The document name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHANGELOG.md</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The document path. This is the file name or relative path used during upload, which must be consistent with the pre-signed URL request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026_06_23_17_49_52WwGSUezpG2u2iHWxyYGzkf9KtormhkxN/CHANGELOG.md</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The processing strategy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-strategy-7043984ca395eabd</para>
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

        }

        /// <summary>
        /// <para>The import type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOCAL_UPLOAD</para>
        /// </summary>
        [NameInMap("ImportType")]
        [Validation(Required=false)]
        public string ImportType { get; set; }

        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-3bd02617e9be335f</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The batch label configuration. The key must be a label field that is already defined in the knowledge base. The value supports string, int64, float32, bool, and list types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;department&quot;:&quot;legal&quot;,&quot;topics&quot;:[&quot;policy&quot;,&quot;contract&quot;],&quot;reviewed&quot;:true}</para>
        /// </summary>
        [NameInMap("MetaFields")]
        [Validation(Required=false)]
        public object MetaFields { get; set; }

        /// <summary>
        /// <para>The processing strategy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-strategy-7043984ca395eabd</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>Not supported. Ignore this parameter.</para>
        /// </summary>
        [NameInMap("dingTalkConfiguration")]
        [Validation(Required=false)]
        public AddDocumentsRequestDingTalkConfiguration DingTalkConfiguration { get; set; }
        public class AddDocumentsRequestDingTalkConfiguration : TeaModel {
            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("appPassword")]
            [Validation(Required=false)]
            public string AppPassword { get; set; }

            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("dingDocMcpLink")]
            [Validation(Required=false)]
            public string DingDocMcpLink { get; set; }

            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("dingTableMcpLink")]
            [Validation(Required=false)]
            public string DingTableMcpLink { get; set; }

            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("knowledgeId")]
            [Validation(Required=false)]
            public string KnowledgeId { get; set; }

            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("knowledgeType")]
            [Validation(Required=false)]
            public string KnowledgeType { get; set; }

            /// <summary>
            /// <para>Not supported. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Defaults to root when omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

    }

}
