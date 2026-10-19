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
        /// <para>The DPI engine version.</para>
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
            /// <para>The container startup environment variables registered for the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;HF_HOME&quot;:&quot;/cache/hf&quot;}</para>
            /// </summary>
            [NameInMap("ContainerEnv")]
            [Validation(Required=false)]
            public Dictionary<string, string> ContainerEnv { get; set; }

            /// <summary>
            /// <para>The source image address registered by the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry.example.com/customer/model:v1</para>
            /// </summary>
            [NameInMap("CustomImageSource")]
            [Validation(Required=false)]
            public string CustomImageSource { get; set; }

            /// <summary>
            /// <para>The registration key of the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen3-32B</para>
            /// </summary>
            [NameInMap("CustomModelName")]
            [Validation(Required=false)]
            public string CustomModelName { get; set; }

            /// <summary>
            /// <para>The deployment specifications registered for the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb.gpu.gn8is.4xlarge</para>
            /// </summary>
            [NameInMap("DBInstanceClass")]
            [Validation(Required=false)]
            public string DBInstanceClass { get; set; }

            /// <summary>
            /// <para>The direct startup command registered for the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>python -m vllm.entrypoints.openai.api_server</para>
            /// </summary>
            [NameInMap("DirectCommand")]
            [Validation(Required=false)]
            public string DirectCommand { get; set; }

            /// <summary>
            /// <para>The display name of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My Qwen3 32B</para>
            /// </summary>
            [NameInMap("DisplayModelName")]
            [Validation(Required=false)]
            public string DisplayModelName { get; set; }

            /// <summary>
            /// <para>The time when the registration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-07 20:57:20</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The supported GPU models.</para>
            /// </summary>
            [NameInMap("GpuRequired")]
            [Validation(Required=false)]
            public List<DescribeAvailableModelsResponseBodyItemsGpuRequired> GpuRequired { get; set; }
            public class DescribeAvailableModelsResponseBodyItemsGpuRequired : TeaModel {
                /// <summary>
                /// <para>The minimum number of GPUs.</para>
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
            /// <para>The image import status. Valid values: Importing, Available, and Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("ImageImportStatus")]
            [Validation(Required=false)]
            public string ImageImportStatus { get; set; }

            /// <summary>
            /// <para>The model service image address registered by the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry.example.com/customer/model:v1</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The inference engine registered for the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vllm</para>
            /// </summary>
            [NameInMap("InferenceEngine")]
            [Validation(Required=false)]
            public string InferenceEngine { get; set; }

            /// <summary>
            /// <para>The minimum CPU requirement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinimumCpu")]
            [Validation(Required=false)]
            public long? MinimumCpu { get; set; }

            /// <summary>
            /// <para>The minimum memory requirement.</para>
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
            /// <para>The startup parameters registered for the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;--max-model-len&quot;:&quot;32768&quot;}</para>
            /// </summary>
            [NameInMap("ModelParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> ModelParams { get; set; }

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
            /// <para>The model type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The OSS path of the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/my-model-bucket/models</para>
            /// </summary>
            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }

            /// <summary>
            /// <para>The supported GPU models.</para>
            /// </summary>
            [NameInMap("SupportedGpuModels")]
            [Validation(Required=false)]
            public List<string> SupportedGpuModels { get; set; }

            /// <summary>
            /// <para>The model fine-tuning architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swift</para>
            /// </summary>
            [NameInMap("TuneArch")]
            [Validation(Required=false)]
            public string TuneArch { get; set; }

        }

        /// <summary>
        /// <para>The model type corresponding to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA69096-757C-4647-B36C-29EBC2******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The model fine-tuning architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>swift</para>
        /// </summary>
        [NameInMap("TuneArch")]
        [Validation(Required=false)]
        public string TuneArch { get; set; }

    }

}
