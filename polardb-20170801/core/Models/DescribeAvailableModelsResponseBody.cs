// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAvailableModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_ai</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The list of models.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAvailableModelsResponseBodyItems> Items { get; set; }
        public class DescribeAvailableModelsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The required GPU configurations.</para>
            /// </summary>
            [NameInMap("GpuRequired")]
            [Validation(Required=false)]
            public List<DescribeAvailableModelsResponseBodyItemsGpuRequired> GpuRequired { get; set; }
            public class DescribeAvailableModelsResponseBodyItemsGpuRequired : TeaModel {
                /// <summary>
                /// <para>The minimum number of GPUs required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("GpuMinCount")]
                [Validation(Required=false)]
                public string GpuMinCount { get; set; }

                /// <summary>
                /// <para>The GPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("GpuModel")]
                [Validation(Required=false)]
                public string GpuModel { get; set; }

            }

            /// <summary>
            /// <para>The minimum number of CPU cores required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinimumCpu")]
            [Validation(Required=false)]
            public long? MinimumCpu { get; set; }

            /// <summary>
            /// <para>The minimum memory required, in MiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16384</para>
            /// </summary>
            [NameInMap("MinimumMemory")]
            [Validation(Required=false)]
            public long? MinimumMemory { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen3-32B-GPTQ-Int4</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The model series.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BERT</para>
            /// </summary>
            [NameInMap("ModelSeries")]
            [Validation(Required=false)]
            public string ModelSeries { get; set; }

            /// <summary>
            /// <para>The supported GPU models.</para>
            /// </summary>
            [NameInMap("SupportedGpuModels")]
            [Validation(Required=false)]
            public List<string> SupportedGpuModels { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA69096-757C-4647-B36C-29EBC2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
