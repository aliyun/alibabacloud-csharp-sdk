// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class GetKnowledgeBaseJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project name pass the check</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<GetKnowledgeBaseJobResponseBodyEcsSpecs> EcsSpecs { get; set; }
        public class GetKnowledgeBaseJobResponseBodyEcsSpecs : TeaModel {
            /// <summary>
            /// <para>CPU核数</para>
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
        public GetKnowledgeBaseJobResponseBodyEmbeddingConfig EmbeddingConfig { get; set; }
        public class GetKnowledgeBaseJobResponseBodyEmbeddingConfig : TeaModel {
            /// <summary>
            /// <para>Embedding分批大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// <para>Embedding并发数</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-09-24T07:33:53Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-08T15:45:12Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-06-11T08:58:35.438Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UpdateScheduleConfig</para>
        /// </summary>
        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d-nacr******sxd2</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kbjob-9m******54</para>
        /// </summary>
        [NameInMap("KnowledgeBaseJobId")]
        [Validation(Required=false)]
        public string KnowledgeBaseJobId { get; set; }

        [NameInMap("KnowledgeBaseJobResult")]
        [Validation(Required=false)]
        public GetKnowledgeBaseJobResponseBodyKnowledgeBaseJobResult KnowledgeBaseJobResult { get; set; }
        public class GetKnowledgeBaseJobResponseBodyKnowledgeBaseJobResult : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("MaxRunningTimeInSeconds")]
        [Validation(Required=false)]
        public int? MaxRunningTimeInSeconds { get; set; }

        [NameInMap("PipelineRunInfo")]
        [Validation(Required=false)]
        public GetKnowledgeBaseJobResponseBodyPipelineRunInfo PipelineRunInfo { get; set; }
        public class GetKnowledgeBaseJobResponseBodyPipelineRunInfo : TeaModel {
            /// <summary>
            /// <para>PaiFlow工作流运行ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow-fi8z******g4gy</para>
            /// </summary>
            [NameInMap("PipelineRunId")]
            [Validation(Required=false)]
            public string PipelineRunId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C25324E3-18E6-50D8-9026-16D74AAEEB26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>discovering</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetKnowledgeBaseJobResponseBodyUserVpc UserVpc { get; set; }
        public class GetKnowledgeBaseJobResponseBodyUserVpc : TeaModel {
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
        /// <b>Example:</b>
        /// <para>478***</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
