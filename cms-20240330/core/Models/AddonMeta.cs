// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddonMeta : TeaModel {
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<AddonMetaDashboards> Dashboards { get; set; }
        public class AddonMetaDashboards : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>assets/dashboards/ecs.png</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The out-of-the-box and comprehensive ECS observe dashboards and alarm rules. Based on AliYun CloudMonitor agentless metrics, exporter agent metrics, host audit logs, host events and other data.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("environments")]
        [Validation(Required=false)]
        public List<AddonMetaEnvironments> Environments { get; set; }
        public class AddonMetaEnvironments : TeaModel {
            [NameInMap("commonSchemaRefs")]
            [Validation(Required=false)]
            public List<AddonMetaEnvironmentsCommonSchemaRefs> CommonSchemaRefs { get; set; }
            public class AddonMetaEnvironmentsCommonSchemaRefs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs-ecs</para>
                /// </summary>
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("dependencies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsDependencies Dependencies { get; set; }
            public class AddonMetaEnvironmentsDependencies : TeaModel {
                [NameInMap("clusterTypes")]
                [Validation(Required=false)]
                public List<string> ClusterTypes { get; set; }

                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, bool?> Features { get; set; }

                [NameInMap("services")]
                [Validation(Required=false)]
                public List<string> Services { get; set; }

            }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS/ECS/Cloud/Client</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("policies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsPolicies Policies { get; set; }
            public class AddonMetaEnvironmentsPolicies : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("alertDefaultStatus")]
                [Validation(Required=false)]
                public string AlertDefaultStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("bindDefaultPolicy")]
                [Validation(Required=false)]
                public bool? BindDefaultPolicy { get; set; }

                [NameInMap("bindEntity")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesBindEntity BindEntity { get; set; }
                public class AddonMetaEnvironmentsPoliciesBindEntity : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("entityGroupMode")]
                    [Validation(Required=false)]
                    public bool? EntityGroupMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>acs.ecs.instance</para>
                    /// </summary>
                    [NameInMap("entityType")]
                    [Validation(Required=false)]
                    public string EntityType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true/false</para>
                    /// </summary>
                    [NameInMap("singleEntityMode")]
                    [Validation(Required=false)]
                    public bool? SingleEntityMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vpcId</para>
                    /// </summary>
                    [NameInMap("vpcIdFieldKey")]
                    [Validation(Required=false)]
                    public string VpcIdFieldKey { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("defaultInstall")]
                [Validation(Required=false)]
                public bool? DefaultInstall { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("enableServiceAccount")]
                [Validation(Required=false)]
                public bool? EnableServiceAccount { get; set; }

                [NameInMap("metricCheckRule")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesMetricCheckRule MetricCheckRule { get; set; }
                public class AddonMetaEnvironmentsPoliciesMetricCheckRule : TeaModel {
                    [NameInMap("promQL")]
                    [Validation(Required=false)]
                    public List<string> PromQL { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("needRestartAfterIntegration")]
                [Validation(Required=false)]
                public bool? NeedRestartAfterIntegration { get; set; }

                [NameInMap("protocols")]
                [Validation(Required=false)]
                public List<AddonMetaEnvironmentsPoliciesProtocols> Protocols { get; set; }
                public class AddonMetaEnvironmentsPoliciesProtocols : TeaModel {
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>assets/logos/ecs.svg</para>
                    /// </summary>
                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Prometheus</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud-acs-ecs</para>
                /// </summary>
                [NameInMap("targetAddonName")]
                [Validation(Required=false)]
                public string TargetAddonName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assets/logos/ecs.svg</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-10-25 09:12:12</para>
        /// </summary>
        [NameInMap("latestReleaseCreateTime")]
        [Validation(Required=false)]
        public string LatestReleaseCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud-acs-ecs</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("once")]
        [Validation(Required=false)]
        public bool? Once { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>feature</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
