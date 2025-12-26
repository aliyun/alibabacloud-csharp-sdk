// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class GetKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("AutoUpdateConfig")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyAutoUpdateConfig AutoUpdateConfig { get; set; }
        public class GetKnowledgeBaseResponseBodyAutoUpdateConfig : TeaModel {
            /// <summary>
            /// <para>运行资源配置</para>
            /// </summary>
            [NameInMap("EcsSpecs")]
            [Validation(Required=false)]
            public List<GetKnowledgeBaseResponseBodyAutoUpdateConfigEcsSpecs> EcsSpecs { get; set; }
            public class GetKnowledgeBaseResponseBodyAutoUpdateConfigEcsSpecs : TeaModel {
                /// <summary>
                /// <para>CPU核数</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public int? CPU { get; set; }

                /// <summary>
                /// <para>驱动版本</para>
                /// </summary>
                [NameInMap("Driver")]
                [Validation(Required=false)]
                public string Driver { get; set; }

                /// <summary>
                /// <para>GPU卡数</para>
                /// </summary>
                [NameInMap("GPU")]
                [Validation(Required=false)]
                public int? GPU { get; set; }

                /// <summary>
                /// <para>GPU类型</para>
                /// </summary>
                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }

                /// <summary>
                /// <para>机型名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>内存大小</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>副本数量</para>
                /// </summary>
                [NameInMap("PodCount")]
                [Validation(Required=false)]
                public int? PodCount { get; set; }

                /// <summary>
                /// <para>共享内存容量</para>
                /// </summary>
                [NameInMap("SharedMemory")]
                [Validation(Required=false)]
                public int? SharedMemory { get; set; }

                /// <summary>
                /// <para>节点类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>Worker</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Embedding配置</para>
            /// </summary>
            [NameInMap("EmbeddingConfig")]
            [Validation(Required=false)]
            public GetKnowledgeBaseResponseBodyAutoUpdateConfigEmbeddingConfig EmbeddingConfig { get; set; }
            public class GetKnowledgeBaseResponseBodyAutoUpdateConfigEmbeddingConfig : TeaModel {
                /// <summary>
                /// <para>Embedding分批大小</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("BatchSize")]
                [Validation(Required=false)]
                public int? BatchSize { get; set; }

                /// <summary>
                /// <para>Embedding并发数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public int? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>任务最大运行时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunningTimeInSeconds { get; set; }

            /// <summary>
            /// <para>资源组ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>public-cluster</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>知识库自动更新状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>用户VPC配置</para>
            /// </summary>
            [NameInMap("UserVpc")]
            [Validation(Required=false)]
            public UserVpc UserVpc { get; set; }

        }

        [NameInMap("ChunkConfig")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyChunkConfig ChunkConfig { get; set; }
        public class GetKnowledgeBaseResponseBodyChunkConfig : TeaModel {
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
        /// <b>Example:</b>
        /// <para>2485765****023475</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<GetKnowledgeBaseResponseBodyDataSources> DataSources { get; set; }
        public class GetKnowledgeBaseResponseBodyDataSources : TeaModel {
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
        /// <para>d-cupbwkk5us9xpjz870</para>
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a description of the knowledge base.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EmbeddingConfig")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyEmbeddingConfig EmbeddingConfig { get; set; }
        public class GetKnowledgeBaseResponseBodyEmbeddingConfig : TeaModel {
            /// <summary>
            /// <para>Embedding连接ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>conn-r3o7******38bh</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>Embedding连接名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>myEmbeddingConn</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            /// <summary>
            /// <para>模型</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-12-15T14:46:23Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-18T19:32:58Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("IndexColumnConfig")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyIndexColumnConfig IndexColumnConfig { get; set; }
        public class GetKnowledgeBaseResponseBodyIndexColumnConfig : TeaModel {
            /// <summary>
            /// <para>所有列名</para>
            /// </summary>
            [NameInMap("ColumnDefinitions")]
            [Validation(Required=false)]
            public List<GetKnowledgeBaseResponseBodyIndexColumnConfigColumnDefinitions> ColumnDefinitions { get; set; }
            public class GetKnowledgeBaseResponseBodyIndexColumnConfigColumnDefinitions : TeaModel {
                /// <summary>
                /// <para>列Key</para>
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
            public List<GetKnowledgeBaseResponseBodyIndexColumnConfigContentColumns> ContentColumns { get; set; }
            public class GetKnowledgeBaseResponseBodyIndexColumnConfigContentColumns : TeaModel {
                /// <summary>
                /// <para>列Key</para>
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
            public List<GetKnowledgeBaseResponseBodyIndexColumnConfigEmbeddingColumns> EmbeddingColumns { get; set; }
            public class GetKnowledgeBaseResponseBodyIndexColumnConfigEmbeddingColumns : TeaModel {
                /// <summary>
                /// <para>列Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d-ksicx823d</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("KnowledgeBaseType")]
        [Validation(Required=false)]
        public string KnowledgeBaseType { get; set; }

        [NameInMap("MetaDataConfig")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyMetaDataConfig MetaDataConfig { get; set; }
        public class GetKnowledgeBaseResponseBodyMetaDataConfig : TeaModel {
            /// <summary>
            /// <para>自定义元数据</para>
            /// </summary>
            [NameInMap("CustomMetaData")]
            [Validation(Required=false)]
            public List<GetKnowledgeBaseResponseBodyMetaDataConfigCustomMetaData> CustomMetaData { get; set; }
            public class GetKnowledgeBaseResponseBodyMetaDataConfigCustomMetaData : TeaModel {
                /// <summary>
                /// <para>元数据Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>引用次数</para>
                /// </summary>
                [NameInMap("ReferenceCount")]
                [Validation(Required=false)]
                public int? ReferenceCount { get; set; }

                /// <summary>
                /// <para>值的个数</para>
                /// </summary>
                [NameInMap("ValueCount")]
                [Validation(Required=false)]
                public int? ValueCount { get; set; }

                /// <summary>
                /// <para>元数据Value类型</para>
                /// </summary>
                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/langstudio/output/</para>
        /// </summary>
        [NameInMap("OutputDir")]
        [Validation(Required=false)]
        public string OutputDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>963BD7F9-0C02-5594-9550-BCC6DD43E3C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rtime-apje******beaz</para>
        /// </summary>
        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        [NameInMap("VectorDBConfig")]
        [Validation(Required=false)]
        public GetKnowledgeBaseResponseBodyVectorDBConfig VectorDBConfig { get; set; }
        public class GetKnowledgeBaseResponseBodyVectorDBConfig : TeaModel {
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
            /// <para>VectorDB连接名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>myVectorConn</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            /// <summary>
            /// <para>VectorDB类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>Milvus</para>
            /// </summary>
            [NameInMap("VectorDBType")]
            [Validation(Required=false)]
            public string VectorDBType { get; set; }

        }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>478**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
