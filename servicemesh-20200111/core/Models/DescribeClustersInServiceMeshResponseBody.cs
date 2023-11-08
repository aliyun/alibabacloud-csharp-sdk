// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClustersInServiceMeshResponseBody : TeaModel {
        /// <summary>
        /// The list of the clusters in the ASM instance.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersInServiceMeshResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersInServiceMeshResponseBodyClusters : TeaModel {
            /// <summary>
            /// The configurations of access log collection.
            /// </summary>
            [NameInMap("AccessLogDashboards")]
            [Validation(Required=false)]
            public List<DescribeClustersInServiceMeshResponseBodyClustersAccessLogDashboards> AccessLogDashboards { get; set; }
            public class DescribeClustersInServiceMeshResponseBodyClustersAccessLogDashboards : TeaModel {
                /// <summary>
                /// The name of the dashboard for access logs.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The URL of the dashboard for access logs.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The domain name of the cluster.
            /// </summary>
            [NameInMap("ClusterDomain")]
            [Validation(Required=false)]
            public string ClusterDomain { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The type of the cluster.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// Indicates whether the Logtail component is installed in the cluster. Valid values:
            /// 
            /// *   `logtail_installed`: The Logtail component is installed.
            /// 
            /// \-`logtail_uninstalled`: The Logtail component is not installed.
            /// 
            /// *   `logtail_state_get_error`: The Logtail component failed to be installed.
            /// </summary>
            [NameInMap("LogtailInstalledState")]
            [Validation(Required=false)]
            public string LogtailInstalledState { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the region in which the cluster resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the security group.
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// The status of the cluster.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the cluster was last modified.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// The version number of the cluster.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
