// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateModelApiRequest : TeaModel {
        /// <summary>
        /// <para>The API access prefix. The default value is / during creation. If omitted during an update, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/beta</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The description of the model API. If omitted during an update, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model API for service integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable direct supply fallback. If omitted during creation, the default value is false, which does not implicitly generate pay-as-you-go tail charges. Only an explicit true value is allowed.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("directSupplyFallbackEnabled")]
        [Validation(Required=false)]
        public bool? DirectSupplyFallbackEnabled { get; set; }

        /// <summary>
        /// <para>The IDs of the selected custom or default domain names of the instance. This parameter must be explicitly specified and non-empty during creation. If omitted during an update, the original value is retained. Submitted values replace the entire list and cannot be empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable API key authentication for consumers. If omitted during an update, the original value is retained. The type is fixed to Apikey or Custom.</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The time to first byte timeout.</para>
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
        /// <para>Specifies whether to explicitly perform the initial configuration. If omitted or set to false, standard multi-API creation is retained. If set to true, name=default, basePath=/, and a non-empty clientToken are required. Additionally, multi-API management must be disabled and the number of complete new-version APIs must be zero when saving.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("initialConfiguration")]
        [Validation(Required=false)]
        public bool? InitialConfiguration { get; set; }

        /// <summary>
        /// <para>The model selection. This parameter is required during creation. If omitted during an update, the original value is retained. Submitted values replace the entire configuration.</para>
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
        /// <para>The configurations for AI request logging and AI security protection. If omitted during an update, the original value is retained. Submitted values replace the two types of inline policies entirely. An empty array clears both types. Independent token quotas are not affected.</para>
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
        /// <para>The idempotency identity. It is a globally unique value generated by the invoker, such as a UUID, and cannot exceed 64 characters in length. Within approximately 24 hours after the initial request succeeds, repeated requests with the same clientToken and identical request parameters return the result of the initial creation. If the request parameters are inconsistent or the initial request is still being processed, a corresponding idempotency error is returned. If this parameter is omitted, the default creation behavior applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create-model-api-client-token-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
