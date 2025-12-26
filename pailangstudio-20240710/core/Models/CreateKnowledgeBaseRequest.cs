// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class CreateKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChunkConfig")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestChunkConfig ChunkConfig { get; set; }
        public class CreateKnowledgeBaseRequestChunkConfig : TeaModel {
            /// <summary>
            /// <para>分块时长</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ChunkDuration")]
            [Validation(Required=false)]
            public int? ChunkDuration { get; set; }

            /// <summary>
            /// <para>分块重叠大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ChunkOverlap")]
            [Validation(Required=false)]
            public int? ChunkOverlap { get; set; }

            /// <summary>
            /// <para>分块大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ChunkSize")]
            [Validation(Required=false)]
            public int? ChunkSize { get; set; }

            /// <summary>
            /// <para>分块策略</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("ChunkStrategy")]
            [Validation(Required=false)]
            public string ChunkStrategy { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<CreateKnowledgeBaseRequestDataSources> DataSources { get; set; }
        public class CreateKnowledgeBaseRequestDataSources : TeaModel {
            /// <summary>
            /// <para>统一资源识别码</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/langstudio/source/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a description of the knowledge base.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EmbeddingConfig")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestEmbeddingConfig EmbeddingConfig { get; set; }
        public class CreateKnowledgeBaseRequestEmbeddingConfig : TeaModel {
            /// <summary>
            /// <para>Embedding连接ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conn-r3o7******38bh</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>模型</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

        }

        [NameInMap("IndexColumnConfig")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestIndexColumnConfig IndexColumnConfig { get; set; }
        public class CreateKnowledgeBaseRequestIndexColumnConfig : TeaModel {
            /// <summary>
            /// <para>所有列名</para>
            /// </summary>
            [NameInMap("ColumnDefinitions")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseRequestIndexColumnConfigColumnDefinitions> ColumnDefinitions { get; set; }
            public class CreateKnowledgeBaseRequestIndexColumnConfigColumnDefinitions : TeaModel {
                /// <summary>
                /// <para>列Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>内容检索列</para>
            /// </summary>
            [NameInMap("ContentColumns")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseRequestIndexColumnConfigContentColumns> ContentColumns { get; set; }
            public class CreateKnowledgeBaseRequestIndexColumnConfigContentColumns : TeaModel {
                /// <summary>
                /// <para>列Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>Embedding列</para>
            /// </summary>
            [NameInMap("EmbeddingColumns")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseRequestIndexColumnConfigEmbeddingColumns> EmbeddingColumns { get; set; }
            public class CreateKnowledgeBaseRequestIndexColumnConfigEmbeddingColumns : TeaModel {
                /// <summary>
                /// <para>列Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("KnowledgeBaseType")]
        [Validation(Required=false)]
        public string KnowledgeBaseType { get; set; }

        [NameInMap("MetaDataConfig")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestMetaDataConfig MetaDataConfig { get; set; }
        public class CreateKnowledgeBaseRequestMetaDataConfig : TeaModel {
            /// <summary>
            /// <para>自定义元数据</para>
            /// </summary>
            [NameInMap("CustomMetaData")]
            [Validation(Required=false)]
            public List<CreateKnowledgeBaseRequestMetaDataConfigCustomMetaData> CustomMetaData { get; set; }
            public class CreateKnowledgeBaseRequestMetaDataConfigCustomMetaData : TeaModel {
                /// <summary>
                /// <para>元数据Key</para>
                /// 
                /// <b>Example:</b>
                /// <para>author</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>元数据Value类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>String</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/langstudio/output/</para>
        /// </summary>
        [NameInMap("OutputDir")]
        [Validation(Required=false)]
        public string OutputDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rtime-apje******beaz</para>
        /// </summary>
        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VectorDBConfig")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseRequestVectorDBConfig VectorDBConfig { get; set; }
        public class CreateKnowledgeBaseRequestVectorDBConfig : TeaModel {
            /// <summary>
            /// <para>Collectioin名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_collection</para>
            /// </summary>
            [NameInMap("CollectionName")]
            [Validation(Required=false)]
            public string CollectionName { get; set; }

            /// <summary>
            /// <para>Embedding连接ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>conn-7y5y******jja7</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>VectorDB类型</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Milvus</para>
            /// </summary>
            [NameInMap("VectorDBType")]
            [Validation(Required=false)]
            public string VectorDBType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
