// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateModelServiceRequest : TeaModel {
        /// <summary>
        /// <para>The API key for Alibaba Cloud Model Studio. This parameter is required only for Model Studio models. You can obtain this key from the Model Studio console or by calling an API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-key-xxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The number of vCPUs. This parameter is required only for a Hologres AI node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The number of GPUs. This parameter is required only for a Hologres AI node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        /// <summary>
        /// <para>The GPU memory size in GB. This parameter is required only for a Hologres AI node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("gpuMemory")]
        [Validation(Required=false)]
        public long? GpuMemory { get; set; }

        /// <summary>
        /// <para>The memory size in GB. This parameter is required only for a Hologres AI node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <para>The model parameters, required only for Model Studio models. You can provide the default parameters returned by the <c>ListModelCatalog</c> operation or a modified version of them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;timeout&quot;:600,&quot;max_retries&quot;:10,&quot;max_retry_delay&quot;:8,&quot;initial_retry_delay&quot;:0.5}</para>
        /// </summary>
        [NameInMap("modelParams")]
        [Validation(Required=false)]
        public string ModelParams { get; set; }

        /// <summary>
        /// <para>A custom name for the model service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_model</para>
        /// </summary>
        [NameInMap("modelServiceName")]
        [Validation(Required=false)]
        public string ModelServiceName { get; set; }

        /// <summary>
        /// <para>The name of the model. To find the name, call <c>ListModelCatalog</c> for a model from Alibaba Cloud Model Studio, or <c>GetAvailableModelsResource</c> for a model on a Hologres AI node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.5-plus</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The provider of the underlying model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The number of replicas. This parameter is required only for a Hologres AI node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("serviceCount")]
        [Validation(Required=false)]
        public long? ServiceCount { get; set; }

        /// <summary>
        /// <para>The type of task the model performs, such as <c>chat/completions</c> or <c>embedding</c>. To find the supported task types, see the output of the <c>ListModelCatalog</c> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>embedding</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
