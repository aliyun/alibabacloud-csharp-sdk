// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RegisterAIDBClusterCustomModelRequest : TeaModel {
        /// <summary>
        /// <para>The container startup environment variables. Variable names cannot be empty or contain whitespace. Variable values can be empty strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;HF_HOME&quot;:&quot;/cache/hf&quot;,&quot;EMPTY_VALUE&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("ContainerEnv")]
        [Validation(Required=false)]
        public Dictionary<string, string> ContainerEnv { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-model-bucket</para>
        /// </summary>
        [NameInMap("CustomOssBucketName")]
        [Validation(Required=false)]
        public string CustomOssBucketName { get; set; }

        /// <summary>
        /// <para>The model path in the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>models/qwen3</para>
        /// </summary>
        [NameInMap("CustomOssBucketPath")]
        [Validation(Required=false)]
        public string CustomOssBucketPath { get; set; }

        /// <summary>
        /// <para>The GPU instance type used for model deployment. Required when configuring deployment parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb.gpu.gn8is.4xlarge</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The direct startup command for the model container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python -m vllm.entrypoints.openai.api_server</para>
        /// </summary>
        [NameInMap("DirectCommand")]
        [Validation(Required=false)]
        public string DirectCommand { get; set; }

        /// <summary>
        /// <para>The display name in the candidate list and the initial invocation name for clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-qwen3</para>
        /// </summary>
        [NameInMap("DisplayModelName")]
        [Validation(Required=false)]
        public string DisplayModelName { get; set; }

        /// <summary>
        /// <para>The full reference of the customer-owned inference image, in the format of registry/repository:tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.example.com/customer/model:v1</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The inference engine. Required when configuring deployment parameters. Valid values: vllm and sglang.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vllm</para>
        /// </summary>
        [NameInMap("InferenceEngine")]
        [Validation(Required=false)]
        public string InferenceEngine { get; set; }

        /// <summary>
        /// <para>The custom model registration key and model directory name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-32B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model startup parameters. Parameter keys must start with --.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;--max-model-len&quot;:&quot;32768&quot;}</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ModelParams { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The password or temporary token for the customer image repository. Required when ImageName is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temporary-token</para>
        /// </summary>
        [NameInMap("RegistryPassword")]
        [Validation(Required=false)]
        public string RegistryPassword { get; set; }

        /// <summary>
        /// <para>The username for the customer image repository. Required when ImageName is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temporary-user</para>
        /// </summary>
        [NameInMap("RegistryUsername")]
        [Validation(Required=false)]
        public string RegistryUsername { get; set; }

    }

}
