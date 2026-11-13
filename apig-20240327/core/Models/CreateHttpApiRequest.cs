// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The list of protocols supported by the agent. This parameter is required when type is set to Agent. For other types, you do not need to specify this parameter.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The list of AI API protocols. This parameter is required and only one protocol can be specified when type is set to LLM. This parameter is required and multiple protocols can be specified when type is set to Ai. For other types, this parameter is not required. Example: OpenAI/v1.</para>
        /// </summary>
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        /// <summary>
        /// <para>The permission authentication configuration. This parameter is required when enableAuth is set to true.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The base path of the API. It must start with a forward slash (/), be up to 256 bytes in length, and contain no spaces. This parameter is required when type is set to Rest. When type is set to LLM, Ai, or Agent, this parameter is optional and defaults to /.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The ID of the associated gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-abc123xyz789</para>
        /// </summary>
        [NameInMap("belongGatewayId")]
        [Validation(Required=false)]
        public string BelongGatewayId { get; set; }

        /// <summary>
        /// <para>The list of deployment configurations for the HTTP API. This parameter is required and only one deployment configuration can be specified when type is set to LLM or Ai. For other types, this parameter is not validated at the request layer.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The description of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test API for integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to only preview the operation without executing it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable permission authentication. This parameter is validated when type is set to LLM, Ai, or Agent. When type is set to Rest, this parameter is not validated at the request layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The timeout period for waiting for the backend to return the first byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("firstByteTimeout")]
        [Validation(Required=false)]
        public int? FirstByteTimeout { get; set; }

        /// <summary>
        /// <para>The configuration information of the HTTP Ingress API. This parameter is required and cannot be null when type is set to HttpIngress. For other types, you do not need to specify this parameter.</para>
        /// </summary>
        [NameInMap("ingressConfig")]
        [Validation(Required=false)]
        public CreateHttpApiRequestIngressConfig IngressConfig { get; set; }
        public class CreateHttpApiRequestIngressConfig : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k7v5eobfzttudni2pw***</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cq146allhtgk***</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The Ingress class to listen on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse</para>
            /// </summary>
            [NameInMap("ingressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>Specifies whether to update the address in the Ingress status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("overrideIngressIp")]
            [Validation(Required=false)]
            public bool? OverrideIngressIp { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src-crdddallhtgtr***</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            [Obsolete]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The namespace to watch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("watchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The AI model category. This parameter is optional when type is set to LLM or Ai. For other types, you do not need to specify this parameter. Valid values: Text (text generation), Image (image generation), Audio (audio processing), Video (video generation), MultiModal (multimodal), Embedding (vector embedding), Rerank (reranking), and Others (others).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The name of the HTTP API, which is used to identify the current API resource, such as test-api.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of API access protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the base path when forwarding requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("removeBasePathOnForward")]
        [Validation(Required=false)]
        public bool? RemoveBasePathOnForward { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The conflict merging strategy for import.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The type of the HTTP API. Valid values: Http (common HTTP API), Rest (RESTful API), WebSocket (WebSocket API), HttpIngress (HTTP API accessed through Ingress), LLM (large language model API), and Agent (agent API).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The API versioning configuration.</para>
        /// </summary>
        [NameInMap("versionConfig")]
        [Validation(Required=false)]
        public HttpApiVersionConfig VersionConfig { get; set; }

        /// <summary>
        /// <para>The idempotency token. A globally unique value generated by the caller (a UUID is recommended). The value can be up to 64 characters in length. If you make a repeated request with the same ClientToken and identical request parameters within approximately 24 hours after the initial request succeeds, the system directly returns the httpApiId created by the initial request and does not create a duplicate HTTP API. If a repeated request has the same ClientToken but different request parameters, the system returns the IdempotentParameterMismatch error. If the initial request is still being processed, the system returns the IdempotentProcessing error. If this parameter is not specified, idempotency control is disabled, and the behavior remains the same as in previous versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f7a2c1e-9b3d-4e8f-a1c6-0d2b8e4f7a13</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
