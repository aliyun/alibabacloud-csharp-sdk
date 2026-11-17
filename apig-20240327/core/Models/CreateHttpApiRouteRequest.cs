// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRouteRequest : TeaModel {
        /// <summary>
        /// <para>The backend service configuration of the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public CreateHttpApiRouteRequestBackendConfig BackendConfig { get; set; }
        public class CreateHttpApiRouteRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>The backend service scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SingleService: single service.</description></item>
            /// <item><description>MultiServiceByRatio: canary release for multiple services by ratio.</description></item>
            /// <item><description>Mock: mock service.</description></item>
            /// <item><description>Redirect: redirect service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The list of backend services.</para>
            /// </summary>
            [NameInMap("services")]
            [Validation(Required=false)]
            public List<CreateHttpApiRouteRequestBackendConfigServices> Services { get; set; }
            public class CreateHttpApiRouteRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>The group of the service. This parameter is used in HTTP-to-Dubbo conversion scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The HTTP-to-Dubbo protocol conversion configuration. This parameter is supported only for SingleService MSE_NACOS DUBBO backends of HTTP APIs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;dubboServiceName&quot;:&quot;com.alibaba.nacos.example.dubbo.service.DemoService&quot;,&quot;dubboServiceVersion&quot;:&quot;1.0.0&quot;,&quot;dubboServiceGroup&quot;:&quot;DEV&quot;,&quot;methodMapList&quot;:[{&quot;dubboMethodName&quot;:&quot;sayName&quot;,&quot;httpMethod&quot;:&quot;ALL_GET&quot;,&quot;methodPath&quot;:&quot;/dubbo/sayName&quot;,&quot;passThroughAllHeaders&quot;:&quot;PASS_ALL&quot;}]}</para>
                /// </summary>
                [NameInMap("httpDubboTranscoder")]
                [Validation(Required=false)]
                public HttpDubboTranscoder HttpDubboTranscoder { get; set; }

                /// <summary>
                /// <para>The name of the target model. This field is shared by multiple existing model backend scenarios. The specific routing or model rewriting semantics are determined by backendConfig.scene. This field is required for the SemanticRouter scenario. If this field is not configured for the AiAutoRouter scenario, the default model of the AI service is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The namespace of the service. This parameter is used in HTTP-to-Dubbo conversion scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The service port. Do not pass this parameter for dynamic ports.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The service protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HTTP.</description></item>
                /// <item><description>HTTPS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The ID of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-crbgq0dlhtgr***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The source type of the service. This parameter is used in HTTP-to-Dubbo conversion scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MSE_NACOS</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The service version. This parameter is valid only in the tag-based scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The percentage value of the traffic ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The API deployment configuration.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        [Obsolete]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The description of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User login route</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The combination configuration of fixed dynamic forwarding and ExtProc. When you use this parameter, specify only serviceId, and do not specify environmentId or backendConfig.</para>
        /// </summary>
        [NameInMap("dfpConfig")]
        [Validation(Required=false)]
        public CreateHttpApiRouteRequestDfpConfig DfpConfig { get; set; }
        public class CreateHttpApiRouteRequestDfpConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the imported ExtProc gRPC service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-cr8k0udlhtgt80sh7png</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

        /// <summary>
        /// <para>The domain name IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cpqnr6tlhtgubcv***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        [Obsolete]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway. This parameter replaces the deprecated environment ID to specify the gateway to which the route belongs. If only this parameter is passed, the server uses the unique valid default environment of the gateway. If this parameter and environmentId are passed at the same time, the environment must belong to this gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The match rules of the route.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        /// <summary>
        /// <para>The MCP route configuration.</para>
        /// </summary>
        [NameInMap("mcpRouteConfig")]
        [Validation(Required=false)]
        public CreateHttpApiRouteRequestMcpRouteConfig McpRouteConfig { get; set; }
        public class CreateHttpApiRouteRequestMcpRouteConfig : TeaModel {
            /// <summary>
            /// <para>The exposed URI path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("exposedUriPath")]
            [Validation(Required=false)]
            public string ExposedUriPath { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable MCP observability. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("mcpStatisticsEnable")]
            [Validation(Required=false)]
            public bool? McpStatisticsEnable { get; set; }

            /// <summary>
            /// <para>The service protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP.</description></item>
            /// <item><description>HTTP.</description></item>
            /// <item><description>DUBBO.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP,HTTPS</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The name of the route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy types.</para>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<HttpApiPolicyConfigs> PolicyConfigs { get; set; }

    }

}
