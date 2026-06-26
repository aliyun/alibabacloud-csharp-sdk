// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRequest : TeaModel {
        /// <summary>
        /// <para>The list of protocols supported by the agent.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The AI API protocols. The following protocols are supported:</para>
        /// <list type="bullet">
        /// <item><description>OpenAI/v1.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        /// <summary>
        /// <para>The authentication configuration.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The base path of the API. The value must start with a forward slash (/).</para>
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
        /// <para>The API deployment configurations. Currently, only AI APIs support deployment configurations, and only a single deployment configuration can be specified.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The API description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试专用API。</para>
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
        /// <para>Specifies whether to enable authentication.</para>
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
        /// <para>The HTTP Ingress API configuration.</para>
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
        /// <para>The model category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm/text-to-image</para>
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
        /// <para>The conflict merge strategy for the import.</para>
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
        /// <item><description>Agent.</description></item>
        /// </list>
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
