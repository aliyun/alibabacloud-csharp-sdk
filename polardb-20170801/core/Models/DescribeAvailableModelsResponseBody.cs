// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAvailableModelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb_ai</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAvailableModelsResponseBodyItems> Items { get; set; }
        public class DescribeAvailableModelsResponseBodyItems : TeaModel {
            [NameInMap("GpuRequired")]
            [Validation(Required=false)]
            public List<DescribeAvailableModelsResponseBodyItemsGpuRequired> GpuRequired { get; set; }
            public class DescribeAvailableModelsResponseBodyItemsGpuRequired : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("GpuMinCount")]
                [Validation(Required=false)]
                public string GpuMinCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("GpuModel")]
                [Validation(Required=false)]
                public string GpuModel { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinimumCpu")]
            [Validation(Required=false)]
            public long? MinimumCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16384</para>
            /// </summary>
            [NameInMap("MinimumMemory")]
            [Validation(Required=false)]
            public long? MinimumMemory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Qwen3-32B-GPTQ-Int4</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BERT</para>
            /// </summary>
            [NameInMap("ModelSeries")]
            [Validation(Required=false)]
            public string ModelSeries { get; set; }

            [NameInMap("SupportedGpuModels")]
            [Validation(Required=false)]
            public List<string> SupportedGpuModels { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA69096-757C-4647-B36C-29EBC2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
