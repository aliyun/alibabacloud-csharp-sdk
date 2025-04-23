// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListClustersMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clusters.</para>
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
                /// <para>The server type of the account. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>nis</description></item>
                /// <item><description>ldap</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The version of the client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.64</para>
                /// </summary>
                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                /// <summary>
                /// <para>The mode in which the cluster is deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: An account node, a scheduling node, a logon node, and multiple compute nodes are separately deployed.</description></item>
                /// <item><description>Advanced: Two high availability (HA) account nodes, two HA scheduler nodes, one logon node, and multiple compute nodes are separately deployed.</description></item>
                /// <item><description>Simple: A management node, a logon node, and multiple compute nodes are deployed. The management node consists of an account node and a scheduling node. The logon node and compute nodes are separately deployed.</description></item>
                /// <item><description>Tiny: A management node and multiple compute nodes are deployed. The management node consists of an account node, a scheduling node, and a logon node. The compute nodes are separately deployed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <para>The description of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>clusterdescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The version of E-HPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("EhpcVersion")]
                [Validation(Required=false)]
                public string EhpcVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the cluster uses a plug-in. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: false</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasPlugin")]
                [Validation(Required=false)]
                public bool? HasPlugin { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ehpc-hz-jeJki6****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether a scaling group is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: A scaling group is enabled.</description></item>
                /// <item><description>false: No scaling group is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsComputeEss")]
                [Validation(Required=false)]
                public bool? IsComputeEss { get; set; }

                /// <summary>
                /// <para>The location where the cluster is deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OnPremise: The cluster is deployed on a hybrid cloud.</description></item>
                /// <item><description>PublicCloud: The cluster is deployed on a public cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PublicCloud</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cluster1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The image tag of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <para>The type of the scheduler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>pbs</description></item>
                /// <item><description>slurm</description></item>
                /// <item><description>opengridscheduler</description></item>
                /// <item><description>deadline</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pbs</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <para>The status of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>uninit: The cluster is not initialized.</description></item>
                /// <item><description>creating: The cluster is being created.</description></item>
                /// <item><description>init: The cluster is being initialized.</description></item>
                /// <item><description>running: The cluster is running.</description></item>
                /// <item><description>exception: The cluster encounters an exception.</description></item>
                /// <item><description>releasing: The cluster is being released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-b3f3edefefeep0760yju****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD517102-B314-4665-BDAC-A32DE7834D02</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
