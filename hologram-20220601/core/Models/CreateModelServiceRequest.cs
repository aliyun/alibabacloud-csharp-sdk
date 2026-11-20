// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateModelServiceRequest : TeaModel {
        /// <summary>
        /// <para>The API key for Alibaba Cloud Model Studio. Log on to the Model Studio console or use the API to obtain the key. This parameter is required only for Alibaba Cloud Model Studio models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-key-xxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The CPU specifications. This parameter is required only for Hologres AI nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The GPU specifications. This parameter is required only for Hologres AI nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        /// <summary>
        /// <para>The GPU memory specifications. This parameter is required only for Hologres AI nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("gpuMemory")]
        [Validation(Required=false)]
        public long? GpuMemory { get; set; }

        /// <summary>
        /// <para>The memory specifications. This parameter is required only for Hologres AI nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <para>The model parameters. Refer to the default parameters returned by ListModelCatalog. You can pass the parameters directly or modify them as needed before passing. This parameter is required only for Alibaba Cloud Model Studio models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;timeout&quot;:600,&quot;max_retries&quot;:10,&quot;max_retry_delay&quot;:8,&quot;initial_retry_delay&quot;:0.5}</para>
        /// </summary>
        [NameInMap("modelParams")]
        [Validation(Required=false)]
        public string ModelParams { get; set; }

        /// <summary>
        /// <para>The custom service name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_model</para>
        /// </summary>
        [NameInMap("modelServiceName")]
        [Validation(Required=false)]
        public string ModelServiceName { get; set; }

        /// <summary>
        /// <para>The model name. To query Alibaba Cloud Model Studio models, call ListModelCatalog. To query Hologres AI nodes, call GetAvailableModelsResource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3.5-plus</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The underlying model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The number of service replicas. This parameter is required only for Hologres AI nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("serviceCount")]
        [Validation(Required=false)]
        public long? ServiceCount { get; set; }

        /// <summary>
        /// <para>The model type, such as chat/completions or embedding. Refer to the types returned by ListModelCatalog and create the model as needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>embedding</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
