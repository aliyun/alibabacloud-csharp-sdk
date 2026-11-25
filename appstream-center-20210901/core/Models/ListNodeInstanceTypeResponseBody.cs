// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListNodeInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resource specifications.</para>
        /// </summary>
        [NameInMap("NodeInstanceTypeModels")]
        [Validation(Required=false)]
        public List<ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels> NodeInstanceTypeModels { get; set; }
        public class ListNodeInstanceTypeResponseBodyNodeInstanceTypeModels : TeaModel {
            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49152</para>
            /// </summary>
            [NameInMap("EcsGpuMemory")]
            [Validation(Required=false)]
            public int? EcsGpuMemory { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public string Gpu { get; set; }

            /// <summary>
            /// <para>The GPU memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("GpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RTX 5880</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent sessions, which is the number of sessions that can be simultaneously connected to a single resource. If too many sessions are connected at the same time, the application experience may degrade. The valid values vary depending on the resource specification. The valid values for each resource specification are as follows:</para>
            /// <list type="bullet">
            /// <item><description>appstreaming.general.2c4g: 1</description></item>
            /// <item><description>appstreaming.general.4c8g: 1 to 2</description></item>
            /// <item><description>appstreaming.general.8c16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 7</description></item>
            /// <item><description>appstreaming.vgpu.4c10g.2gt4: 1 to 2</description></item>
            /// <item><description>appstreaming.vgpu.4c16g.2ga10: 1 to 2</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c31g.16g: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c16g.4gt4: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.8c32g.4ga10: 1 to 4</description></item>
            /// <item><description>appstreaming.vgpu.12c46g.11g28: 1 to 6</description></item>
            /// <item><description>appstreaming.vgpu.14c93g.12g: 1 to 7</description></item>
            /// <item><description>appstreaming.vgpu.16c32g.8g: 1 to 8</description></item>
            /// <item><description>appstreaming.vgpu.16c62g.8ga10: 1 to 8</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public int? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The resource specification type ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu.4c8g.2g</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <para>The resource specification family.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.vgpu</para>
            /// </summary>
            [NameInMap("NodeInstanceTypeFamily")]
            [Validation(Required=false)]
            public string NodeInstanceTypeFamily { get; set; }

            /// <summary>
            /// <para>The resource specification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WUYING-General-purpose_4vCPU8GB</para>
            /// </summary>
            [NameInMap("NodeTypeName")]
            [Validation(Required=false)]
            public string NodeTypeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("WuyingServerModelMetaInfo")]
            [Validation(Required=false)]
            public ListNodeInstanceTypeResponseBodyNodeInstanceTypeModelsWuyingServerModelMetaInfo WuyingServerModelMetaInfo { get; set; }
            public class ListNodeInstanceTypeResponseBodyNodeInstanceTypeModelsWuyingServerModelMetaInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vLLM</para>
                /// </summary>
                [NameInMap("DefaultInferenceEngine")]
                [Validation(Required=false)]
                public string DefaultInferenceEngine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>支持文本生成</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("FirstTokenLatencySeconds")]
                [Validation(Required=false)]
                public double? FirstTokenLatencySeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m-example-image</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;]</para>
                /// </summary>
                [NameInMap("InputModalities")]
                [Validation(Required=false)]
                public List<string> InputModalities { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MachineInputTokensPerSecond")]
                [Validation(Required=false)]
                public long? MachineInputTokensPerSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("MachineOutputTokensPerSecond")]
                [Validation(Required=false)]
                public long? MachineOutputTokensPerSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32768</para>
                /// </summary>
                [NameInMap("MaxModelLen")]
                [Validation(Required=false)]
                public long? MaxModelLen { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>65536</para>
                /// </summary>
                [NameInMap("MaxModelLenMax")]
                [Validation(Required=false)]
                public long? MaxModelLenMax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("MaxModelLenMin")]
                [Validation(Required=false)]
                public long? MaxModelLenMin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MaxNumSeqsMax")]
                [Validation(Required=false)]
                public int? MaxNumSeqsMax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxNumSeqsMin")]
                [Validation(Required=false)]
                public int? MaxNumSeqsMin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo-model</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例模型</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;]</para>
                /// </summary>
                [NameInMap("OutputModalities")]
                [Validation(Required=false)]
                public List<string> OutputModalities { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Recommended")]
                [Validation(Required=false)]
                public bool? Recommended { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("RecommendedMaxNumSeqs")]
                [Validation(Required=false)]
                public int? RecommendedMaxNumSeqs { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the query results currently displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of query results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
