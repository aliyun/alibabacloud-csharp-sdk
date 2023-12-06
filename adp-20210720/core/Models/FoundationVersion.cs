// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class FoundationVersion : TeaModel {
        [NameInMap("clusterConfigSchema")]
        [Validation(Required=false)]
        public string ClusterConfigSchema { get; set; }

        [NameInMap("clusterEngines")]
        [Validation(Required=false)]
        public List<FoundationVersionClusterEngines> ClusterEngines { get; set; }
        public class FoundationVersionClusterEngines : TeaModel {
            [NameInMap("infrastructureStatements")]
            [Validation(Required=false)]
            public List<FoundationVersionClusterEnginesInfrastructureStatements> InfrastructureStatements { get; set; }
            public class FoundationVersionClusterEnginesInfrastructureStatements : TeaModel {
                [NameInMap("default")]
                [Validation(Required=false)]
                public bool? Default { get; set; }

                [NameInMap("distroName")]
                [Validation(Required=false)]
                public string DistroName { get; set; }

                [NameInMap("distroVersion")]
                [Validation(Required=false)]
                public string DistroVersion { get; set; }

                [NameInMap("platform")]
                [Validation(Required=false)]
                public Platform Platform { get; set; }

            }

            [NameInMap("networkList")]
            [Validation(Required=false)]
            public List<FoundationVersionClusterEnginesNetworkList> NetworkList { get; set; }
            public class FoundationVersionClusterEnginesNetworkList : TeaModel {
                [NameInMap("ipFamilies")]
                [Validation(Required=false)]
                public List<string> IpFamilies { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("packageTools")]
            [Validation(Required=false)]
            public List<FoundationVersionClusterEnginesPackageTools> PackageTools { get; set; }
            public class FoundationVersionClusterEnginesPackageTools : TeaModel {
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("installToolPackages")]
                [Validation(Required=false)]
                public List<FoundationVersionClusterEnginesPackageToolsInstallToolPackages> InstallToolPackages { get; set; }
                public class FoundationVersionClusterEnginesPackageToolsInstallToolPackages : TeaModel {
                    [NameInMap("architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    [NameInMap("os")]
                    [Validation(Required=false)]
                    public string Os { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("packageFormat")]
                [Validation(Required=false)]
                public string PackageFormat { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("packages")]
            [Validation(Required=false)]
            public List<FoundationVersionClusterEnginesPackages> Packages { get; set; }
            public class FoundationVersionClusterEnginesPackages : TeaModel {
                [NameInMap("architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                [NameInMap("os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                [NameInMap("platforms")]
                [Validation(Required=false)]
                public List<Platform> Platforms { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("defaultClusterConfig")]
        [Validation(Required=false)]
        public string DefaultClusterConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("documents")]
        [Validation(Required=false)]
        public string Documents { get; set; }

        [NameInMap("driver")]
        [Validation(Required=false)]
        public FoundationVersionDriver Driver { get; set; }
        public class FoundationVersionDriver : TeaModel {
            [NameInMap("components")]
            [Validation(Required=false)]
            public List<FoundationVersionDriverComponents> Components { get; set; }
            public class FoundationVersionDriverComponents : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        [NameInMap("isDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("packageTools")]
        [Validation(Required=false)]
        public List<FoundationVersionPackageTools> PackageTools { get; set; }
        public class FoundationVersionPackageTools : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("platforms")]
        [Validation(Required=false)]
        public List<Platform> Platforms { get; set; }

        [NameInMap("specName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tools")]
        [Validation(Required=false)]
        public FoundationVersionTools Tools { get; set; }
        public class FoundationVersionTools : TeaModel {
            [NameInMap("siteSurvey")]
            [Validation(Required=false)]
            public FoundationVersionToolsSiteSurvey SiteSurvey { get; set; }
            public class FoundationVersionToolsSiteSurvey : TeaModel {
                [NameInMap("clusterCheckerURL")]
                [Validation(Required=false)]
                public string ClusterCheckerURL { get; set; }

                [NameInMap("clusterInfoBrief")]
                [Validation(Required=false)]
                public string ClusterInfoBrief { get; set; }

            }

        }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("userWhiteList")]
        [Validation(Required=false)]
        public List<string> UserWhiteList { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
