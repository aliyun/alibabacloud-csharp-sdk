// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersMetaResponseBody : TeaModel {
        /// <summary>
        /// The list of clusters.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersMetaResponseBodyClusters Clusters { get; set; }
        public class ListClustersMetaResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfoSimple")]
            [Validation(Required=false)]
            public List<ListClustersMetaResponseBodyClustersClusterInfoSimple> ClusterInfoSimple { get; set; }
            public class ListClustersMetaResponseBodyClustersClusterInfoSimple : TeaModel {
                /// <summary>
                /// The server type of the account. Valid values:
                /// 
                /// *   nis
                /// *   ldap
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The version of the client.
                /// </summary>
                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                /// <summary>
                /// The mode in which the cluster is deployed. Valid values:
                /// 
                /// *   Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.
                /// *   Advanced: Two high availability (HA) account nodes, two HA scheduler nodes, one logon node, and multiple compute nodes are separately deployed.
                /// *   Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.
                /// *   Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// The description of the cluster.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The version of E-HPC.
                /// </summary>
                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                /// <summary>
                /// Indicates whether the cluster uses a plug-in. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// Default value: false
                /// </summary>
                [NameInMap("HasPlugin")]
                [Validation(Required=false)]
                public bool? HasPlugin { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Indicates whether a scaling group is enabled. Valid values:
                /// 
                /// *   true: A scaling group is enabled.
                /// *   false: No scaling group is enabled.
                /// </summary>
                [NameInMap("IsComputeEss")]
                [Validation(Required=false)]
                public bool? IsComputeEss { get; set; }

                /// <summary>
                /// The location where the cluster is deployed. Valid values:
                /// 
                /// *   OnPremise: The cluster is deployed on a hybrid cloud.
                /// *   PublicCloud: The cluster is deployed on a public cloud.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the cluster.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The image tag of the operating system.
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// The type of the scheduler. Valid values:
                /// 
                /// *   pbs
                /// *   slurm
                /// *   opengridscheduler
                /// *   deadline
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// The status of the cluster. Valid values:
                /// 
                /// *   uninit: The cluster is not initialized.
                /// *   creating: The cluster is being created.
                /// *   init: The cluster is being initialized.
                /// *   running: The cluster is running.
                /// *   exception: The cluster encounters an exception.
                /// *   releasing: The cluster is being released.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Valid values: 1 to 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
