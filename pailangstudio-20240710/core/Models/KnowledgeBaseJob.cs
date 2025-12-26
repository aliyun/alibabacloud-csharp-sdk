// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class KnowledgeBaseJob : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<KnowledgeBaseJobEcsSpecs> EcsSpecs { get; set; }
        public class KnowledgeBaseJobEcsSpecs : TeaModel {
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

        [NameInMap("EmbeddingConfig")]
        [Validation(Required=false)]
        public KnowledgeBaseJobEmbeddingConfig EmbeddingConfig { get; set; }
        public class KnowledgeBaseJobEmbeddingConfig : TeaModel {
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

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        [NameInMap("KnowledgeBaseJobId")]
        [Validation(Required=false)]
        public string KnowledgeBaseJobId { get; set; }

        [NameInMap("KnowledgeBaseJobResult")]
        [Validation(Required=false)]
        public KnowledgeBaseJobKnowledgeBaseJobResult KnowledgeBaseJobResult { get; set; }
        public class KnowledgeBaseJobKnowledgeBaseJobResult : TeaModel {
            /// <summary>
            /// <para>增加Chunk数量</para>
            /// </summary>
            [NameInMap("AddChunkCount")]
            [Validation(Required=false)]
            public int? AddChunkCount { get; set; }

            /// <summary>
            /// <para>删除Chunk数量</para>
            /// </summary>
            [NameInMap("DeleteChunkCount")]
            [Validation(Required=false)]
            public int? DeleteChunkCount { get; set; }

            /// <summary>
            /// <para>总处理文件数</para>
            /// </summary>
            [NameInMap("TotalFileCount")]
            [Validation(Required=false)]
            public int? TotalFileCount { get; set; }

        }

        [NameInMap("MaxRunningTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunningTimeInSeconds { get; set; }

        [NameInMap("PipelineRunInfo")]
        [Validation(Required=false)]
        public KnowledgeBaseJobPipelineRunInfo PipelineRunInfo { get; set; }
        public class KnowledgeBaseJobPipelineRunInfo : TeaModel {
            /// <summary>
            /// <para>PaiFlow工作流运行ID</para>
            /// </summary>
            [NameInMap("PipelineRunId")]
            [Validation(Required=false)]
            public string PipelineRunId { get; set; }

        }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public KnowledgeBaseJobUserVpc UserVpc { get; set; }
        public class KnowledgeBaseJobUserVpc : TeaModel {
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
            /// <para>VPC ID</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
