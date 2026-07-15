// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The list of protocols supported by the agent. This parameter is required when type is set to Agent. This parameter is not required for other types.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The AI API protocols. This parameter is required when type is set to LLM, and only one protocol can be specified. This parameter is required when type is set to Ai, and multiple protocols can be specified. This parameter is not required for other types.</para>
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
        /// <para>The API base path. The path must start with a forward slash (/), cannot exceed 256 bytes in length, and cannot contain spaces. This parameter is required when type is set to Rest. When type is set to LLM, Ai, or Agent, this parameter is optional and defaults to /.</para>
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
        /// <para>The API deployment configurations. This parameter is required when type is set to LLM or Ai, and only one deployment configuration can be specified. This parameter is not validated at the request level for other types.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The API description.</para>
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
        /// <para>The HTTP Ingress API configuration. This parameter is required and cannot be nil when type is set to HttpIngress. This parameter is not required for other types.</para>
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
            /// <para>The Ingress Class to listen on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse</para>
            /// </summary>
            [NameInMap("ingressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>Specifies whether to update the address in the Ingress Status.</para>
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
        /// <para>The model category. This parameter is optional when type is set to LLM or Ai. This parameter is not required for other types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The API name.</para>
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
        /// <para>The type of the HTTP API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Http</description></item>
        /// <item><description>Rest</description></item>
        /// <item><description>WebSocket</description></item>
        /// <item><description>HttpIngress</description></item>
        /// <item><description>LLM</description></item>
        /// <item><description>Agent</description></item>
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

    }

}
