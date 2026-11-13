// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ModelApiApiInfo : TeaModel {
        /// <summary>
        /// <para>The collection of agent protocols for the model API.</para>
        /// </summary>
        [NameInMap("agentProtocols")]
        [Validation(Required=false)]
        public List<string> AgentProtocols { get; set; }

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
        /// <para>The read-only correlation identifier for creation requests. It is returned only when the association with the same instance is unique within approximately 24 hours after the first persistence following normal authentication. It is omitted for historical, expired, or ambiguous cases. This identifier cannot be used to determine the success of publishing or authorization, nor does it replace the creation of idempotent records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1907ca4-952c-4c5f-8d1f-0aa6ae339c96</para>
        /// </summary>
        [NameInMap("creationClientToken")]
        [Validation(Required=false)]
        public string CreationClientToken { get; set; }

        /// <summary>
        /// <para>The deletion status of the new version model API. This field is read-only and optional. Deleting indicates that the deletion request is accepted but not yet completed. DeleteFailed indicates that the background deletion failed, and you can use the original clientToken to retry the DeleteModelApi operation. This field is not returned for normal publishing and historical undeployment. The absence of this field does not indicate that the deletion is complete.</para>
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
        public Dictionary<string, ModelApiApiInfoDeployCntMapValue> DeployCntMap { get; set; }

        /// <summary>
        /// <para>The reason for the deployment or deletion failure. This field is read-only.</para>
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
        /// <para>The read-only domain name details and the default domain name flag.</para>
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
        /// <para>The default environment ID of the bound instance. This field is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-d00000000000000000000</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

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
        public ModelApiApiInfoIngressInfo IngressInfo { get; set; }
        public class ModelApiApiInfoIngressInfo : TeaModel {
            /// <summary>
            /// <para>The environment context.</para>
            /// </summary>
            [NameInMap("environmentInfo")]
            [Validation(Required=false)]
            public ModelApiApiInfoIngressInfoEnvironmentInfo EnvironmentInfo { get; set; }
            public class ModelApiApiInfoIngressInfoEnvironmentInfo : TeaModel {
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
            /// <para>The ingress class.</para>
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
            public ModelApiApiInfoIngressInfoK8sClusterInfo K8sClusterInfo { get; set; }
            public class ModelApiApiInfoIngressInfoK8sClusterInfo : TeaModel {
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
        /// <para>The model API public selection information.</para>
        /// </summary>
        [NameInMap("modelApiInfo")]
        [Validation(Required=false)]
        public ModelApiApiInfoModelApiInfo ModelApiInfo { get; set; }
        public class ModelApiApiInfoModelApiInfo : TeaModel {
            /// <summary>
            /// <para>The saved state of the direct supply fallback. A value of false indicates that it is disabled. This only reflects the saved configuration and does not indicate successful publishing or activation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("directSupplyFallbackEnabled")]
            [Validation(Required=false)]
            public bool? DirectSupplyFallbackEnabled { get; set; }

            /// <summary>
            /// <para>The model exposure mode. Only SELECTED is supported in Phase 1.</para>
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
            /// <para>The read-only collection of publicly exposed models for the current configuration. It retains the modelSelection edit source, but the successful online collection is still subject to publishedEndpoints.</para>
            /// </summary>
            [NameInMap("resolvedModelSelection")]
            [Validation(Required=false)]
            public ModelApiApiInfoModelApiInfoResolvedModelSelection ResolvedModelSelection { get; set; }
            public class ModelApiApiInfoModelApiInfoResolvedModelSelection : TeaModel {
                /// <summary>
                /// <para>Indicates whether the expanded collection of the current configuration is fully read. A fully empty group returns true and an empty array. Missing, invalid groups, or read failures return false. This does not reflect the online publishing or consumer permission status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("complete")]
                [Validation(Required=false)]
                public bool? Complete { get; set; }

                /// <summary>
                /// <para>The identities of the models selected for public exposure in the current configuration, stably sorted and deduplicated. Logical models retain their own IDs and do not include fallback-only targets or underlying execution cards of logical models. If complete is false, this is an empty array and must not be interpreted as zero models.</para>
                /// </summary>
                [NameInMap("modelCardIds")]
                [Validation(Required=false)]
                public List<string> ModelCardIds { get; set; }

            }

            /// <summary>
            /// <para>The routing mode. Only Direct is supported in Phase 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Direct</para>
            /// </summary>
            [NameInMap("routingMode")]
            [Validation(Required=false)]
            public string RoutingMode { get; set; }

        }

        /// <summary>
        /// <para>The read-only runtime diagnostic information for model cards, derived from the original markers of the deployment configuration. It is used only for the readability and diagnostics of abnormal drafts.</para>
        /// </summary>
        [NameInMap("modelCardRuntimeDiagnostics")]
        [Validation(Required=false)]
        public List<ModelApiApiInfoModelCardRuntimeDiagnostics> ModelCardRuntimeDiagnostics { get; set; }
        public class ModelApiApiInfoModelCardRuntimeDiagnostics : TeaModel {
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
        /// <para>The collection of successfully published per-path executable models. This field is read-only. It is empty when a snapshot is missing, which does not represent consumer permission.</para>
        /// </summary>
        [NameInMap("publishedEndpoints")]
        [Validation(Required=false)]
        public List<ModelApiApiInfoPublishedEndpoints> PublishedEndpoints { get; set; }
        public class ModelApiApiInfoPublishedEndpoints : TeaModel {
            /// <summary>
            /// <para>The name of the successfully published built-in endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model-responses</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The collection of executable ModelCard IDs successfully published for this path.</para>
            /// </summary>
            [NameInMap("modelCardIds")]
            [Validation(Required=false)]
            public List<string> ModelCardIds { get; set; }

        }

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
        /// <para>The publishing status on the bound instance. In the new version, the status is Undeploying when a deletion is in progress, and UndeployFailed when a deletion fails. To determine whether an operation is a deletion, refer to the deleteStatus field.</para>
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
