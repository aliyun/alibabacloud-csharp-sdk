// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class CreateKnowledgeBaseJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a description of the knowledge base job.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<CreateKnowledgeBaseJobRequestEcsSpecs> EcsSpecs { get; set; }
        public class CreateKnowledgeBaseJobRequestEcsSpecs : TeaModel {
            /// <summary>
            /// <para>CPU核数</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>驱动版本</para>
            /// 
            /// <b>Example:</b>
            /// <para>535.161.08</para>
            /// </summary>
            [NameInMap("Driver")]
            [Validation(Required=false)]
            public string Driver { get; set; }

            /// <summary>
            /// <para>GPU卡数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>副本数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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

        [NameInMap("EmbeddingConfig")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseJobRequestEmbeddingConfig EmbeddingConfig { get; set; }
        public class CreateKnowledgeBaseJobRequestEmbeddingConfig : TeaModel {
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

        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("MaxRunningTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunningTimeInSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>public-cluster</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateKnowledgeBaseJobRequestUserVpc UserVpc { get; set; }
        public class CreateKnowledgeBaseJobRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>安全组ID</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>交换机ID</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
