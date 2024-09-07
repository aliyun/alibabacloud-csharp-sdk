// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<ListClustersResponseBodyClusters> Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("AdditionalPackages")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersAdditionalPackages> AdditionalPackages { get; set; }
            public class ListClustersResponseBodyClustersAdditionalPackages : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("Addons")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersAddons> Addons { get; set; }
            public class ListClustersResponseBodyClustersAddons : TeaModel {
                [NameInMap("AddonId")]
                [Validation(Required=false)]
                public string AddonId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ResourcesSpec")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersAddonsResourcesSpec ResourcesSpec { get; set; }
                public class ListClustersResponseBodyClustersAddonsResourcesSpec : TeaModel {
                    [NameInMap("EcsInstanceId")]
                    [Validation(Required=false)]
                    public string EcsInstanceId { get; set; }

                    [NameInMap("EipInstanceId")]
                    [Validation(Required=false)]
                    public string EipInstanceId { get; set; }

                }

                [NameInMap("ServicesSpec")]
                [Validation(Required=false)]
                public List<ListClustersResponseBodyClustersAddonsServicesSpec> ServicesSpec { get; set; }
                public class ListClustersResponseBodyClustersAddonsServicesSpec : TeaModel {
                    [NameInMap("ServiceAccessType")]
                    [Validation(Required=false)]
                    public string ServiceAccessType { get; set; }

                    [NameInMap("ServiceAccessUrl")]
                    [Validation(Required=false)]
                    public string ServiceAccessUrl { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("ClusterCategory")]
            [Validation(Required=false)]
            public string ClusterCategory { get; set; }

            [NameInMap("ClusterCreateTime")]
            [Validation(Required=false)]
            public string ClusterCreateTime { get; set; }

            [NameInMap("ClusterCredentials")]
            [Validation(Required=false)]
            public List<string> ClusterCredentials { get; set; }

            [NameInMap("ClusterCustomConfiguration")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
            public class ListClustersResponseBodyClustersClusterCustomConfiguration : TeaModel {
                [NameInMap("Args")]
                [Validation(Required=false)]
                public string Args { get; set; }

                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

            }

            [NameInMap("ClusterDescription")]
            [Validation(Required=false)]
            public string ClusterDescription { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public string ClusterMode { get; set; }

            [NameInMap("ClusterModifyTime")]
            [Validation(Required=false)]
            public string ClusterModifyTime { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            [NameInMap("ClusterUsedCoreTime")]
            [Validation(Required=false)]
            public float? ClusterUsedCoreTime { get; set; }

            [NameInMap("ClusterVSwitchId")]
            [Validation(Required=false)]
            public string ClusterVSwitchId { get; set; }

            [NameInMap("ClusterVpcId")]
            [Validation(Required=false)]
            public string ClusterVpcId { get; set; }

            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            [NameInMap("EhpcVersion")]
            [Validation(Required=false)]
            public string EhpcVersion { get; set; }

            [NameInMap("Manager")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersManager Manager { get; set; }
            public class ListClustersResponseBodyClustersManager : TeaModel {
                [NameInMap("DNS")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersManagerDNS DNS { get; set; }
                public class ListClustersResponseBodyClustersManagerDNS : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("DirectoryService")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersManagerDirectoryService DirectoryService { get; set; }
                public class ListClustersResponseBodyClustersManagerDirectoryService : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("Scheduler")]
                [Validation(Required=false)]
                public ListClustersResponseBodyClustersManagerScheduler Scheduler { get; set; }
                public class ListClustersResponseBodyClustersManagerScheduler : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            [NameInMap("MaxCoreCount")]
            [Validation(Required=false)]
            public long? MaxCoreCount { get; set; }

            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public long? MaxCount { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersNodes Nodes { get; set; }
            public class ListClustersResponseBodyClustersNodes : TeaModel {
                [NameInMap("AbnormalCounts")]
                [Validation(Required=false)]
                public int? AbnormalCounts { get; set; }

                [NameInMap("CreatingCounts")]
                [Validation(Required=false)]
                public int? CreatingCounts { get; set; }

                [NameInMap("RunningCounts")]
                [Validation(Required=false)]
                public int? RunningCounts { get; set; }

            }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public ListClustersResponseBodyClustersUsers Users { get; set; }
            public class ListClustersResponseBodyClustersUsers : TeaModel {
                [NameInMap("NormalCounts")]
                [Validation(Required=false)]
                public int? NormalCounts { get; set; }

                [NameInMap("SudoCounts")]
                [Validation(Required=false)]
                public int? SudoCounts { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
