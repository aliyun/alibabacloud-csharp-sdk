// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The API access prefix. The default value is / for creation. If this parameter is omitted during an update, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/beta</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The description of the model API. If this parameter is omitted during an update, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model API for service integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the direct supply fallback. If this parameter is omitted during creation, the default value is false. This does not implicitly generate paid fallback traffic. Only an explicit value of true is allowed to enable this feature.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("directSupplyFallbackEnabled")]
        [Validation(Required=false)]
        public bool? DirectSupplyFallbackEnabled { get; set; }

        /// <summary>
        /// <para>The IDs of the selected custom or default instance domain names. This parameter must be explicitly specified and cannot be empty during creation. If this parameter is omitted during an update, the original value is retained. If this parameter is submitted, it replaces the entire list and cannot be empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable consumer API key authentication. If this parameter is omitted during an update, the original value is retained. The type is fixed to Apikey or Custom.</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The time to first byte (TTFB) timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("firstByteTimeout")]
        [Validation(Required=false)]
        public int? FirstByteTimeout { get; set; }

        /// <summary>
        /// <para>The instance ID of the target dedicated gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d00000000000000000000</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to explicitly perform the initial configuration. If this parameter is omitted or set to false, the standard multi-API creation is retained. If this parameter is set to true, the name must be explicitly set to default, the basePath must be set to /, and the clientToken must not be empty. Additionally, when saving, multi-API management must be disabled and the number of complete new-version APIs must be zero.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("initialConfiguration")]
        [Validation(Required=false)]
        public bool? InitialConfiguration { get; set; }

        /// <summary>
        /// <para>The model selection. This parameter is required for creation. If this parameter is omitted during an update, the original value is retained. If this parameter is submitted, it replaces the entire configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("modelSelection")]
        [Validation(Required=false)]
        public ModelSelection ModelSelection { get; set; }

        /// <summary>
        /// <para>The name of the model API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations for AI request logging and AI security protection. If this parameter is omitted during an update, the original value is retained. If this parameter is submitted, it replaces the inline policies of both types. An empty array clears both types. Independent token quotas are not affected.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<ModelApiPolicyConfig> PolicyConfigs { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acf0000000000000000</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The idempotency token. It is a globally unique value generated by the caller, such as a UUID, and can be up to 64 characters in length. If a repeated request with the same client token and identical request parameters is sent within 24 hours after the first request succeeds, the system directly returns the result of the first creation. If the parameters are inconsistent or the first request is still being processed, the system returns a corresponding idempotency error. If this parameter is not specified, the original creation behavior is maintained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create-model-api-client-token-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
