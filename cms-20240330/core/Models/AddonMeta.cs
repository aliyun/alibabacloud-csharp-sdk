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

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
                [NameInMap("group")]
                [Validation(Required=false)]
                public string Group { get; set; }

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

            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("policies")]
            [Validation(Required=false)]
            public AddonMetaEnvironmentsPolicies Policies { get; set; }
            public class AddonMetaEnvironmentsPolicies : TeaModel {
                [NameInMap("alertDefaultStatus")]
                [Validation(Required=false)]
                public string AlertDefaultStatus { get; set; }

                [NameInMap("bindDefaultPolicy")]
                [Validation(Required=false)]
                public bool? BindDefaultPolicy { get; set; }

                [NameInMap("bindEntity")]
                [Validation(Required=false)]
                public AddonMetaEnvironmentsPoliciesBindEntity BindEntity { get; set; }
                public class AddonMetaEnvironmentsPoliciesBindEntity : TeaModel {
                    [NameInMap("entityGroupMode")]
                    [Validation(Required=false)]
                    public bool? EntityGroupMode { get; set; }

                    [NameInMap("entityType")]
                    [Validation(Required=false)]
                    public string EntityType { get; set; }

                    [NameInMap("singleEntityMode")]
                    [Validation(Required=false)]
                    public bool? SingleEntityMode { get; set; }

                    [NameInMap("vpcIdFieldKey")]
                    [Validation(Required=false)]
                    public string VpcIdFieldKey { get; set; }

                }

                [NameInMap("defaultInstall")]
                [Validation(Required=false)]
                public bool? DefaultInstall { get; set; }

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

                    [NameInMap("icon")]
                    [Validation(Required=false)]
                    public string Icon { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("targetAddonName")]
                [Validation(Required=false)]
                public string TargetAddonName { get; set; }

            }

            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("keywords")]
        [Validation(Required=false)]
        public List<string> Keywords { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("latestReleaseCreateTime")]
        [Validation(Required=false)]
        public string LatestReleaseCreateTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("once")]
        [Validation(Required=false)]
        public bool? Once { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
