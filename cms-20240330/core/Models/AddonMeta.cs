// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddonMeta : TeaModel {
        /// <summary>
        /// <para>The component alias and display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS monitoring</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The component category information.</para>
        /// </summary>
        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// <para>The list of component diagrams.</para>
        /// </summary>
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<AddonMetaDashboards> Dashboards { get; set; }
        public class AddonMetaDashboards : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description information</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The diagram name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS monitoring overview dashboard</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The diagram URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>assets/dashboards/ecs.png</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The out-of-the-box and comprehensive ECS observe dashboards and alarm rules. Based on AliYun CloudMonitor agentless metrics, exporter agent metrics, host audit logs, host events and other data.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of supported environment types.</para>
        /// </summary>
        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<AddonMetaEnvironments> Environments { get; set; }
        public class AddonMetaEnvironments : TeaModel {
            /// <summary>
            /// <para>The list of associated CommonSchemas.</para>
            /// </summary>
            [NameInMap("commonSchemaRefs")]
            [Validation(Required=false)]
            public List<AddonMetaEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
            public class AddonMetaEnvironmentsCommonSchemaRefs : TeaModel {
                /// <summary>
                /// <para>The group name of the CommonSchema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs-ecs</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The group version of the CommonSchema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The dependency description.</para>
            /// </summary>
            [NameInMap("dependencies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsDependencies Dependencies { get; set; }
            public class AddonMetaEnvironmentsDependencies : TeaModel {
                /// <summary>
                /// <para>The supported cluster types.</para>
                /// </summary>
                [NameInMap("clusterTypes")]
                [Validation(Required=false)]
                public List<string> ClusterTypes { get; set; }

                /// <summary>
                /// <para>The probe dependency description and component name. This field is replaced by the collectors field in the new version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;metric-agent&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, bool?> Features { get; set; }

                /// <summary>
                /// <para>The list of dependent services.</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<string> Services { get; set; }

            }

            /// <summary>
            /// <para>The description of the environment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Supports workload coverage monitoring for container clusters</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether it is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The display name of the environment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Container environment</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The environment type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS/ECS/Cloud/Client</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The control policy combination information of the component.</para>
            /// </summary>
            [NameInMap("policies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsPolicies Policies { get; set; }
            public class AddonMetaEnvironmentsPolicies : TeaModel {
                /// <summary>
                /// <para>Specifies whether alert rules are enabled after default installation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("alertDefaultStatus")]
                [Validation(Required=false)]
                public string AlertDefaultStatus { get; set; }

                /// <summary>
                /// <para>The default mode, which is an integration mode that does not require binding entities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("bindDefaultPolicy")]
                [Validation(Required=false)]
                public bool? BindDefaultPolicy { get; set; }

                /// <summary>
                /// <para>The bound target entity information.</para>
                /// </summary>
                [NameInMap("bindEntity")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesBindEntity BindEntity { get; set; }
                public class AddonMetaEnvironmentsPoliciesBindEntity : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether it is in group mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("entityGroupMode")]
                    [Validation(Required=false)]
                    public bool? EntityGroupMode { get; set; }

                    /// <summary>
                    /// <para>The entity type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs.ecs.instance</para>
                    /// </summary>
                    [NameInMap("entityType")]
                    [Validation(Required=false)]
                    public string EntityType { get; set; }

                    /// <summary>
                    /// <para>Specifies whether it is in single-entity mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("singleEntityMode")]
                    [Validation(Required=false)]
                    public bool? SingleEntityMode { get; set; }

                    /// <summary>
                    /// <para>The field used to extract the VPC ID information from the entity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpcId</para>
                    /// </summary>
                    [NameInMap("vpcIdFieldKey")]
                    [Validation(Required=false)]
                    public string VpcIdFieldKey { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to install by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("defaultInstall")]
                [Validation(Required=false)]
                public bool? DefaultInstall { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable internal authorization token allocation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableServiceAccount")]
                [Validation(Required=false)]
                public bool? EnableServiceAccount { get; set; }

                /// <summary>
                /// <para>The data check rule after the component is integrated.</para>
                /// </summary>
                [NameInMap("metricCheckRule")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                public class AddonMetaEnvironmentsPoliciesMetricCheckRule : TeaModel {
                    /// <summary>
                    /// <para>The PromQL for the check rule.</para>
                    /// </summary>
                    [NameInMap("promQL")]
                    [Validation(Required=false)]
                    public List<string> PromQL { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether to prompt to restart the workload after integration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("needRestartAfterIntegration")]
                [Validation(Required=false)]
                public bool? NeedRestartAfterIntegration { get; set; }

                /// <summary>
                /// <para>The list of supported client protocol information.</para>
                /// </summary>
                [NameInMap("protocols")]
                [Validation(Required=false)]
                public List<AddonMetaEnvironmentsPoliciesProtocols> Protocols { get; set; }
                public class AddonMetaEnvironmentsPoliciesProtocols : TeaModel {
                    /// <summary>
                    /// <para>The protocol description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Use the Prometheus protocol to write metric data</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The protocol display icon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>assets/logos/ecs.svg</para>
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    /// <summary>
                    /// <para>The protocol display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prometheus protocol</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The protocol name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prometheus</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The name of the target component to navigate to.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud-acs-ecs</para>
                /// </summary>
                [NameInMap("targetAddonName")]
                [Validation(Required=false)]
                public string TargetAddonName { get; set; }

            }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The component icon.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assets/logos/ecs.svg</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>The list of keywords.</para>
        /// </summary>
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <para>The language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese (default).</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The last integration time of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-25 09:12:12</para>
        /// </summary>
        [NameInMap("latestReleaseCreateTime")]
        [Validation(Required=false)]
        public string LatestReleaseCreateTime { get; set; }

        /// <summary>
        /// <para>The component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud-acs-ecs</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether the component can be installed only once under the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("once")]
        [Validation(Required=false)]
        public bool? Once { get; set; }

        /// <summary>
        /// <para>The scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The component sorting weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
