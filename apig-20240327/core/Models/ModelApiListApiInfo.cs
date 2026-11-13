// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ModelApiListApiInfo : TeaModel {
        /// <summary>
        /// <para>The collection of agent protocols for the model API.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

        /// <summary>
        /// <para>The API protocols created by scenario. APIs created by selecting models provide open paths through modelApiInfo.</para>
        /// </summary>
        [NameInMap("aiProtocols")]
        [Validation(Required=false)]
        public List<string> AiProtocols { get; set; }

        /// <summary>
        /// <para>The API authentication configurations created by scenario.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The API base path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The read-only association identifier for the creation request. It is returned only within approximately 24 hours after the first persistence and when the association with the same instance is unique after normal authentication. It is omitted when the identifier is historical, expired, or ambiguous. You cannot use this identifier to determine whether publishing or authorization is successful, nor does it replace the creation idempotency record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1907ca4-952c-4c5f-8d1f-0aa6ae339c96</para>
        /// </summary>
        [NameInMap("creationClientToken")]
        [Validation(Required=false)]
        public string CreationClientToken { get; set; }

        /// <summary>
        /// <para>The optional read-only deletion status of the new model API. Deleting indicates that the deletion request is accepted but not completed. DeleteFailed indicates that the background deletion failed, and you can use the original clientToken to retry DeleteModelApi. This field is not returned for normal deployment and historical undeployment. The absence of this field does not indicate that the deletion is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deleting</para>
        /// </summary>
        [NameInMap("deleteStatus")]
        [Validation(Required=false)]
        public string DeleteStatus { get; set; }

        /// <summary>
        /// <para>The publish status of the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;example-scope&quot;:{&quot;deployedCnt&quot;:1,&quot;cnt&quot;:1}}</para>
        /// </summary>
        [NameInMap("deployCntMap")]
        [Validation(Required=false)]
        public Dictionary<string, ModelApiListApiInfoDeployCntMapValue> DeployCntMap { get; set; }

        /// <summary>
        /// <para>The API deployment configurations and associated services created by scenario, provided as read-only list information.</para>
        /// </summary>
        [NameInMap("deployConfigs")]
        [Validation(Required=false)]
        public List<HttpApiDeployConfig> DeployConfigs { get; set; }

        /// <summary>
        /// <para>The read-only reason for deployment or deletion failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The model configuration is unavailable</para>
        /// </summary>
        [NameInMap("deployErrorMessage")]
        [Validation(Required=false)]
        public string DeployErrorMessage { get; set; }

        /// <summary>
        /// <para>The API description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model API for business integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The selected domain IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>The read-only domain details and default domain flag.</para>
        /// </summary>
        [NameInMap("domainInfos")]
        [Validation(Required=false)]
        public List<ModelApiDomainInfo> DomainInfos { get; set; }

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
        /// <para>The read-only default environment ID of the bound instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-d00000000000000000000</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The publish environment context of the API.</para>
        /// </summary>
        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<ModelApiListApiInfoEnvironments> Environments { get; set; }
        public class ModelApiListApiInfoEnvironments : TeaModel {
            /// <summary>
            /// <para>The alias of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The release scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            /// <summary>
            /// <para>The backend type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service</para>
            /// </summary>
            [NameInMap("backendType")]
            [Validation(Required=false)]
            public string BackendType { get; set; }

            /// <summary>
            /// <para>The custom domain name information published by the user.</para>
            /// </summary>
            [NameInMap("customDomains")]
            [Validation(Required=false)]
            public List<HttpApiDomainInfo> CustomDomains { get; set; }

            /// <summary>
            /// <para>The read-only reason for the release failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The model configuration is unavailable</para>
            /// </summary>
            [NameInMap("deployErrorMessage")]
            [Validation(Required=false)]
            public string DeployErrorMessage { get; set; }

            /// <summary>
            /// <para>The release status of the API in the current environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The ID of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-xxx</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The gateway instance information to which the current environment belongs.</para>
            /// </summary>
            [NameInMap("gatewayInfo")]
            [Validation(Required=false)]
            public ModelApiListApiInfoEnvironmentsGatewayInfo GatewayInfo { get; set; }
            public class ModelApiListApiInfoEnvironmentsGatewayInfo : TeaModel {
                /// <summary>
                /// <para>The edition of the gateway instance. Valid values: Professional, Serverless, MultiTenantServerless, and Unknown.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MultiTenantServerless</para>
                /// </summary>
                [NameInMap("gatewayEdition")]
                [Validation(Required=false)]
                public string GatewayEdition { get; set; }

                /// <summary>
                /// <para>The gateway instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The name of the gateway instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The existing service configurations.</para>
            /// </summary>
            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<ModelApiListApiInfoEnvironmentsServiceConfigs> ServiceConfigs { get; set; }
            public class ModelApiListApiInfoEnvironmentsServiceConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gs-xxx</para>
                /// </summary>
                [NameInMap("gatewayServiceId")]
                [Validation(Required=false)]
                public string GatewayServiceId { get; set; }

                /// <summary>
                /// <para>The match conditions.</para>
                /// </summary>
                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo-service</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The service port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
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
                /// <para>svc-xxx</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The list of default domain names for the environment.</para>
            /// </summary>
            [NameInMap("subDomains")]
            [Validation(Required=false)]
            public List<ModelApiListApiInfoEnvironmentsSubDomains> SubDomains { get; set; }
            public class ModelApiListApiInfoEnvironmentsSubDomains : TeaModel {
                /// <summary>
                /// <para>The ID of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-xxx</para>
                /// </summary>
                [NameInMap("domainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internet</para>
                /// </summary>
                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The access protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the gateway instance to which the API belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d00000000000000000000</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The read-only information of the bound instance.</para>
        /// </summary>
        [NameInMap("gatewayInfo")]
        [Validation(Required=false)]
        public GatewayInfo GatewayInfo { get; set; }

        /// <summary>
        /// <para>The model API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxx</para>
        /// </summary>
        [NameInMap("httpApiId")]
        [Validation(Required=false)]
        public string HttpApiId { get; set; }

        /// <summary>
        /// <para>The HTTP ingress API information.</para>
        /// </summary>
        [NameInMap("ingressInfo")]
        [Validation(Required=false)]
        public ModelApiListApiInfoIngressInfo IngressInfo { get; set; }
        public class ModelApiListApiInfoIngressInfo : TeaModel {
            /// <summary>
            /// <para>The environment context.</para>
            /// </summary>
            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public ModelApiListApiInfoIngressInfoEnvironmentInfo EnvironmentInfo { get; set; }
            public class ModelApiListApiInfoIngressInfoEnvironmentInfo : TeaModel {
                /// <summary>
                /// <para>The environment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-d00000000000000000000</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

            }

            /// <summary>
            /// <para>The ingress class being listened to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apig</para>
            /// </summary>
            [NameInMap("ingressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>The Kubernetes cluster information.</para>
            /// </summary>
            [NameInMap("k8sClusterInfo")]
            [Validation(Required=false)]
            public ModelApiListApiInfoIngressInfoK8sClusterInfo K8sClusterInfo { get; set; }
            public class ModelApiListApiInfoIngressInfoK8sClusterInfo : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c00000000000000000000000000000001</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to update the address in the ingress status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("overrideIngressIp")]
            [Validation(Required=false)]
            public bool? OverrideIngressIp { get; set; }

            /// <summary>
            /// <para>The source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src-d00000000000000000000</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>The watched namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("watchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The public selection information of the model API.</para>
        /// </summary>
        [NameInMap("modelApiInfo")]
        [Validation(Required=false)]
        public ModelApiListApiInfoModelApiInfo ModelApiInfo { get; set; }
        public class ModelApiListApiInfoModelApiInfo : TeaModel {
            /// <summary>
            /// <para>The save state of the direct supply fallback. A value of false indicates that it is disabled. This only reflects the saved configuration and does not indicate successful release or activation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("directSupplyFallbackEnabled")]
            [Validation(Required=false)]
            public bool? DirectSupplyFallbackEnabled { get; set; }

            /// <summary>
            /// <para>The model exposure mode. Only SELECTED is supported in the first phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECTED</para>
            /// </summary>
            [NameInMap("exposureMode")]
            [Validation(Required=false)]
            public string ExposureMode { get; set; }

            /// <summary>
            /// <para>The model selection configuration.</para>
            /// </summary>
            [NameInMap("modelSelection")]
            [Validation(Required=false)]
            public ModelSelection ModelSelection { get; set; }

            /// <summary>
            /// <para>The read-only public model collection for the current configuration. If complete is false, the collection is unknown, and partial members must not be used as the full count.</para>
            /// </summary>
            [NameInMap("resolvedModelSelection")]
            [Validation(Required=false)]
            public ModelApiListApiInfoModelApiInfoResolvedModelSelection ResolvedModelSelection { get; set; }
            public class ModelApiListApiInfoModelApiInfoResolvedModelSelection : TeaModel {
                /// <summary>
                /// <para>Indicates whether the group expansion collection for the current configuration is completely read. A complete empty group returns true and an empty array. A missing, invalid group, or read failure returns false. This does not represent the online release or consumer permission status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("complete")]
                [Validation(Required=false)]
                public bool? Complete { get; set; }

                /// <summary>
                /// <para>The model card IDs of the publicly selected models for the current configuration, stably sorted and deduplicated. Logical models retain their own IDs, excluding fallback-only targets or underlying execution cards of logical models. If complete is false, this is an empty array and must not be interpreted as zero models.</para>
                /// </summary>
                [NameInMap("modelCardIds")]
                [Validation(Required=false)]
                public List<string> ModelCardIds { get; set; }

            }

            /// <summary>
            /// <para>The routing mode. Only Direct is supported in the first phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Direct</para>
            /// </summary>
            [NameInMap("routingMode")]
            [Validation(Required=false)]
            public string RoutingMode { get; set; }

        }

        /// <summary>
        /// <para>The read-only runtime diagnostics of the model card, derived from the original markers of the deployment configuration. This is used only for the readability and diagnosability of abnormal drafts.</para>
        /// </summary>
        [NameInMap("modelCardRuntimeDiagnostics")]
        [Validation(Required=false)]
        public List<ModelApiListApiInfoModelCardRuntimeDiagnostics> ModelCardRuntimeDiagnostics { get; set; }
        public class ModelApiListApiInfoModelCardRuntimeDiagnostics : TeaModel {
            /// <summary>
            /// <para>The index of the corresponding deployment configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("deployConfigIndex")]
            [Validation(Required=false)]
            public int? DeployConfigIndex { get; set; }

            /// <summary>
            /// <para>The gateway instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-d00000000000000000000</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>Indicates whether the marker of the deployment configuration is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("invalidConfiguration")]
            [Validation(Required=false)]
            public bool? InvalidConfiguration { get; set; }

            /// <summary>
            /// <para>The list of reasons for invalidity.</para>
            /// </summary>
            [NameInMap("reasons")]
            [Validation(Required=false)]
            public List<string> Reasons { get; set; }

        }

        /// <summary>
        /// <para>The model category of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("modelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The API name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The inline configurations for AI request logs and AI security protection.</para>
        /// </summary>
        [NameInMap("policyConfigs")]
        [Validation(Required=false)]
        public List<ModelApiPolicyConfig> PolicyConfigs { get; set; }

        /// <summary>
        /// <para>The list of API protocols.</para>
        /// </summary>
        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

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
        /// <para>The deployment status on the bound instance. In the new version, Undeploying indicates that the deletion is in progress, and UndeployFailed indicates that the deletion failed. Refer to deleteStatus to determine whether the operation is a deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The API type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The API versioning information.</para>
        /// </summary>
        [NameInMap("versionInfo")]
        [Validation(Required=false)]
        public HttpApiVersionInfo VersionInfo { get; set; }

    }

}
