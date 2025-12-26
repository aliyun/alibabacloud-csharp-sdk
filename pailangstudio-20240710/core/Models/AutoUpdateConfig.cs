// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class AutoUpdateConfig : TeaModel {
        /// <summary>
        /// <para>运行资源配置</para>
        /// </summary>
        [NameInMap("EcsSpecs")]
        [Validation(Required=false)]
        public List<AutoUpdateConfigEcsSpecs> EcsSpecs { get; set; }
        public class AutoUpdateConfigEcsSpecs : TeaModel {
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
        public AutoUpdateConfigEmbeddingConfig EmbeddingConfig { get; set; }
        public class AutoUpdateConfigEmbeddingConfig : TeaModel {
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

}
