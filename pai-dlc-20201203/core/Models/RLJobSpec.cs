// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobSpec : TeaModel {
        /// <summary>
        /// <para>接受 tag 或 sha256 摘要。未指定配方且已提供所需资源池时，可省略镜像并使用平台为该资源池配置的默认镜像；无唯一默认镜像时须显式指定。</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/rls/verl@sha256:0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>该资源条目的工作节点数量，默认 1，必须为正整数；不包括平台管理的辅助节点。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public int? PodCount { get; set; }

        /// <summary>
        /// <para>资源池配额 ID；省略时使用作业级 ResourceId。不同资源池可指定不同配额；使用多个配额时每个池必须显式指定，train 池的配额为作业主配额。各配额均须已在作业工作空间授权且属于同一 VPC</para>
        /// 
        /// <b>Example:</b>
        /// <para>quotag2uo09dyp40</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>每个 Pod 的资源规格，所有值均为字符串。CPU、Memory 必须为正值；GPU 省略时为 CPU 资源池，提供时必须为正整数。GPUType 可省略，并可从已解析的作业或配额信息中确定；若配额存在多种 GPU 类型且尚未确定目标类型，必须显式指定。SharedMemory 可选。最终资源组合还须满足所选框架、入口与 TrainerMode 的拓扑约束。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// <para>资源角色，必填，使用小写 train 或 rollout，在 JobSpecs 内唯一。文档中的 rollout/train 表示二选一，不是可直接提交的字面值</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
