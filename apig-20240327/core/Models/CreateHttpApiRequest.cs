// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The list of protocols supported by the agent. This parameter is required when type is set to Agent. You do not need to specify this parameter for other types.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The list of AI API protocols. This parameter is required when type is set to LLM, and only one protocol can be specified. This parameter is required when type is set to Ai, and multiple protocols can be specified. You do not need to specify this parameter for other types. Example protocol entry: OpenAI/v1.</para>
        /// </summary>
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        /// <summary>
        /// <para>The authentication configuration. This parameter is required when enableAuth is set to true.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The base path of the API. The value must start with a forward slash (/), cannot exceed 256 bytes in length, and cannot contain spaces. This parameter is required when type is set to Rest. When type is set to LLM, Ai, or Agent, this parameter is optional and defaults to /.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The ID of the gateway to which the API belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-abc123xyz789</para>
        /// </summary>
        [NameInMap("belongGatewayId")]
        [Validation(Required=false)]
        public string BelongGatewayId { get; set; }

        /// <summary>
        /// <para>The list of deployment configurations for the HTTP API. This parameter is required when type is set to LLM or Ai, and only one deployment configuration can be specified. This parameter is not validated at the request level for other types.</para>
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
        /// <para>Specifies whether to perform a dry run without executing the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication. This parameter is validated when type is set to LLM, Ai, or Agent. This parameter is not validated at the request level when type is set to Rest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The timeout period for waiting for the first byte from the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("firstByteTimeout")]
        [Validation(Required=false)]
        public int? FirstByteTimeout { get; set; }

        /// <summary>
        /// <para>The HTTP Ingress API configuration. This parameter is required and cannot be nil when type is set to HttpIngress. You do not need to specify this parameter for other types.</para>
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
            /// <para>The namespace to listen on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("watchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The AI model category. This parameter is optional when type is set to LLM or Ai. You do not need to specify this parameter for other types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Text: text generation.</description></item>
        /// <item><description>Image: image generation.</description></item>
        /// <item><description>Audio: audio processing.</description></item>
        /// <item><description>Video: AI video generation.</description></item>
        /// <item><description>MultiModal: multimodal.</description></item>
        /// <item><description>Embedding: embedding.</description></item>
        /// <item><description>Rerank: reranking.</description></item>
        /// <item><description>Others: other.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The name of the HTTP API, which identifies the API resource. Example: test-api.</para>
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
        /// <para>The conflict merge strategy for import.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExistFirst</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The HTTP API type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Http: a standard HTTP API.</description></item>
        /// <item><description>Rest: a RESTful API.</description></item>
        /// <item><description>WebSocket: a WebSocket API.</description></item>
        /// <item><description>HttpIngress: an HTTP API accessed through Ingress.</description></item>
        /// <item><description>LLM: a large language model API.</description></item>
        /// <item><description>Agent: an agent proxy API.</description></item>
        /// </list>
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
        /// <para>The idempotency token, which is a globally unique value generated by the caller. We recommend that you use a UUID. The value cannot exceed 64 characters in length. Within approximately 24 hours after the first successful request, a duplicate request that carries the same ClientToken and identical request parameters directly returns the httpApiId created by the first request without creating a duplicate HTTP API. If the same ClientToken is carried but the request parameters are different, the IdempotentParameterMismatch error is returned. If the first request is still being processed, the IdempotentProcessing error is returned. If this parameter is not specified, idempotency control is not enabled, and the behavior is consistent with the existing version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f7a2c1e-9b3d-4e8f-a1c6-0d2b8e4f7a13</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
