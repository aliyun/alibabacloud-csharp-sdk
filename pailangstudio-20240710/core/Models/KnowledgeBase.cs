// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class KnowledgeBase : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("AutoUpdateConfig")]
        [Validation(Required=false)]
        public KnowledgeBaseAutoUpdateConfig AutoUpdateConfig { get; set; }
        public class KnowledgeBaseAutoUpdateConfig : TeaModel {
            /// <summary>
            /// <para>运行资源配置</para>
            /// </summary>
            [NameInMap("EcsSpecs")]
            [Validation(Required=false)]
            public List<KnowledgeBaseAutoUpdateConfigEcsSpecs> EcsSpecs { get; set; }
            public class KnowledgeBaseAutoUpdateConfigEcsSpecs : TeaModel {
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
            public KnowledgeBaseAutoUpdateConfigEmbeddingConfig EmbeddingConfig { get; set; }
            public class KnowledgeBaseAutoUpdateConfigEmbeddingConfig : TeaModel {
                /// <summary>
                /// <para>Embedding分批大小</para>
                /// </summary>
                [NameInMap("BatchSize")]
                [Validation(Required=false)]
                public int? BatchSize { get; set; }

                /// <summary>
                /// <para>Embedding并发数</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public int? Concurrency { get; set; }

            }

            /// <summary>
            /// <para>任务最大运行时间</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public int? MaxRunningTimeInSeconds { get; set; }

            /// <summary>
            /// <para>资源组ID</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>知识库自动更新状态</para>
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
        public KnowledgeBaseChunkConfig ChunkConfig { get; set; }
        public class KnowledgeBaseChunkConfig : TeaModel {
            /// <summary>
            /// <para>分块时长</para>
            /// </summary>
            [NameInMap("ChunkDuration")]
            [Validation(Required=false)]
            public int? ChunkDuration { get; set; }

            /// <summary>
            /// <para>分块重叠大小</para>
            /// </summary>
            [NameInMap("ChunkOverlap")]
            [Validation(Required=false)]
            public int? ChunkOverlap { get; set; }

            /// <summary>
            /// <para>分块大小</para>
            /// </summary>
            [NameInMap("ChunkSize")]
            [Validation(Required=false)]
            public int? ChunkSize { get; set; }

            /// <summary>
            /// <para>分块策略</para>
            /// </summary>
            [NameInMap("ChunkStrategy")]
            [Validation(Required=false)]
            public string ChunkStrategy { get; set; }

        }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<KnowledgeBaseDataSources> DataSources { get; set; }
        public class KnowledgeBaseDataSources : TeaModel {
            /// <summary>
            /// <para>统一资源识别码</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EmbeddingConfig")]
        [Validation(Required=false)]
        public KnowledgeBaseEmbeddingConfig EmbeddingConfig { get; set; }
        public class KnowledgeBaseEmbeddingConfig : TeaModel {
            /// <summary>
            /// <para>Embedding连接ID</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>Embedding连接名称</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            /// <summary>
            /// <para>模型</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

        }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("IndexColumnConfig")]
        [Validation(Required=false)]
        public KnowledgeBaseIndexColumnConfig IndexColumnConfig { get; set; }
        public class KnowledgeBaseIndexColumnConfig : TeaModel {
            /// <summary>
            /// <para>所有列名</para>
            /// </summary>
            [NameInMap("ColumnDefinitions")]
            [Validation(Required=false)]
            public List<KnowledgeBaseIndexColumnConfigColumnDefinitions> ColumnDefinitions { get; set; }
            public class KnowledgeBaseIndexColumnConfigColumnDefinitions : TeaModel {
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
            public List<KnowledgeBaseIndexColumnConfigContentColumns> ContentColumns { get; set; }
            public class KnowledgeBaseIndexColumnConfigContentColumns : TeaModel {
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
            public List<KnowledgeBaseIndexColumnConfigEmbeddingColumns> EmbeddingColumns { get; set; }
            public class KnowledgeBaseIndexColumnConfigEmbeddingColumns : TeaModel {
                /// <summary>
                /// <para>列Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

        }

        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        [NameInMap("KnowledgeBaseType")]
        [Validation(Required=false)]
        public string KnowledgeBaseType { get; set; }

        [NameInMap("MetaDataConfig")]
        [Validation(Required=false)]
        public KnowledgeBaseMetaDataConfig MetaDataConfig { get; set; }
        public class KnowledgeBaseMetaDataConfig : TeaModel {
            /// <summary>
            /// <para>自定义元数据</para>
            /// </summary>
            [NameInMap("CustomMetaData")]
            [Validation(Required=false)]
            public List<KnowledgeBaseMetaDataConfigCustomMetaData> CustomMetaData { get; set; }
            public class KnowledgeBaseMetaDataConfigCustomMetaData : TeaModel {
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

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OutputDir")]
        [Validation(Required=false)]
        public string OutputDir { get; set; }

        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        [NameInMap("VectorDBConfig")]
        [Validation(Required=false)]
        public KnowledgeBaseVectorDBConfig VectorDBConfig { get; set; }
        public class KnowledgeBaseVectorDBConfig : TeaModel {
            /// <summary>
            /// <para>Collectioin名称</para>
            /// </summary>
            [NameInMap("CollectionName")]
            [Validation(Required=false)]
            public string CollectionName { get; set; }

            /// <summary>
            /// <para>Embedding连接ID</para>
            /// </summary>
            [NameInMap("ConnectionId")]
            [Validation(Required=false)]
            public string ConnectionId { get; set; }

            /// <summary>
            /// <para>VectorDB连接名称</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            /// <summary>
            /// <para>VectorDB类型</para>
            /// </summary>
            [NameInMap("VectorDBType")]
            [Validation(Required=false)]
            public string VectorDBType { get; set; }

        }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
