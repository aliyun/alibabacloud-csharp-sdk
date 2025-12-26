// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class UpdateKnowledgeBaseRequest : TeaModel {
        [NameInMap("AutoUpdateConfig")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseRequestAutoUpdateConfig AutoUpdateConfig { get; set; }
        public class UpdateKnowledgeBaseRequestAutoUpdateConfig : TeaModel {
            /// <summary>
            /// <para>运行资源配置</para>
            /// </summary>
            [NameInMap("EcsSpecs")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeBaseRequestAutoUpdateConfigEcsSpecs> EcsSpecs { get; set; }
            public class UpdateKnowledgeBaseRequestAutoUpdateConfigEcsSpecs : TeaModel {
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
            public UpdateKnowledgeBaseRequestAutoUpdateConfigEmbeddingConfig EmbeddingConfig { get; set; }
            public class UpdateKnowledgeBaseRequestAutoUpdateConfigEmbeddingConfig : TeaModel {
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
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
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

        [NameInMap("BindRuntime")]
        [Validation(Required=false)]
        public bool? BindRuntime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("MetaDataConfig")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseRequestMetaDataConfig MetaDataConfig { get; set; }
        public class UpdateKnowledgeBaseRequestMetaDataConfig : TeaModel {
            /// <summary>
            /// <para>自定义元数据</para>
            /// </summary>
            [NameInMap("CustomMetaData")]
            [Validation(Required=false)]
            public List<UpdateKnowledgeBaseRequestMetaDataConfigCustomMetaData> CustomMetaData { get; set; }
            public class UpdateKnowledgeBaseRequestMetaDataConfigCustomMetaData : TeaModel {
                /// <summary>
                /// <para>元数据Key</para>
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

        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
