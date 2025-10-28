// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster data that is returned by page.</para>
        /// </summary>
        [NameInMap("ClusterPage")]
        [Validation(Required=false)]
        public GetK8sClusterResponseBodyClusterPage ClusterPage { get; set; }
        public class GetK8sClusterResponseBodyClusterPage : TeaModel {
            /// <summary>
            /// <para>The list of clusters.</para>
            /// </summary>
            [NameInMap("ClusterList")]
            [Validation(Required=false)]
            public GetK8sClusterResponseBodyClusterPageClusterList ClusterList { get; set; }
            public class GetK8sClusterResponseBodyClusterPageClusterList : TeaModel {
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public List<GetK8sClusterResponseBodyClusterPageClusterListCluster> Cluster { get; set; }
                public class GetK8sClusterResponseBodyClusterPageClusterListCluster : TeaModel {
                    /// <summary>
                    /// <para>The ID of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>81453e4b-4df0-4592-<b><b>-b835a2ee</b></b></para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>The import state of the cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: The cluster is not imported.</description></item>
                    /// <item><description>1: The cluster is imported.</description></item>
                    /// <item><description>2: The cluster fails to be imported.</description></item>
                    /// <item><description>3: The cluster is being imported.</description></item>
                    /// <item><description>4: The cluster is deleted.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ClusterImportStatus")]
                    [Validation(Required=false)]
                    public int? ClusterImportStatus { get; set; }

                    /// <summary>
                    /// <para>The name of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    /// <summary>
                    /// <para>The status of the cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: The cluster runs as expected.</description></item>
                    /// <item><description>2: The cluster does not run as expected.</description></item>
                    /// <item><description>3: The cluster is offline.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ClusterStatus")]
                    [Validation(Required=false)]
                    public int? ClusterStatus { get; set; }

                    /// <summary>
                    /// <para>The type of the cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>2: Elastic Compute Service (ECS) cluster</description></item>
                    /// <item><description>5: ACK cluster or Serverless Kubernetes cluster</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public int? ClusterType { get; set; }

                    /// <summary>
                    /// <para>The total number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACK cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2ce62869f4d4466b920312315f05****</para>
                    /// </summary>
                    [NameInMap("CsClusterId")]
                    [Validation(Required=false)]
                    public string CsClusterId { get; set; }

                    /// <summary>
                    /// <para>The state of the ACK cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>initial: The cluster is being initialized.</description></item>
                    /// <item><description>failed: The cluster fails to be created.</description></item>
                    /// <item><description>running: The cluster is running.</description></item>
                    /// <item><description>updating: The cluster is being updated.</description></item>
                    /// <item><description>scaling: The cluster is being scaled out.</description></item>
                    /// <item><description>removing: Nodes are being removed from the cluster.</description></item>
                    /// <item><description>upgrading: The cluster is being upgraded.</description></item>
                    /// <item><description>deleting: The cluster is being deleted.</description></item>
                    /// <item><description>delete_failed: The cluster fails to be deleted.</description></item>
                    /// <item><description>deleted: The cluster is deleted. The deleted cluster is invisible to users.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>running</para>
                    /// </summary>
                    [NameInMap("CsClusterStatus")]
                    [Validation(Required=false)]
                    public string CsClusterStatus { get; set; }

                    /// <summary>
                    /// <para>The description of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The total size of memory. Unit: MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    /// <summary>
                    /// <para>The network type of the cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: classic network</description></item>
                    /// <item><description>2: VPC</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("NetworkMode")]
                    [Validation(Required=false)]
                    public int? NetworkMode { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("NodeNum")]
                    [Validation(Required=false)]
                    public int? NodeNum { get; set; }

                    /// <summary>
                    /// <para>The ID of the namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The subtype of the cluster. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Ask: Serverless Kubernetes cluster</description></item>
                    /// <item><description>ManagedKubernetes: ACK cluster</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ask</para>
                    /// </summary>
                    [NameInMap("SubClusterType")]
                    [Validation(Required=false)]
                    public string SubClusterType { get; set; }

                    /// <summary>
                    /// <para>The CIDR block of the subnet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.20.0.0/16</para>
                    /// </summary>
                    [NameInMap("SubNetCidr")]
                    [Validation(Required=false)]
                    public string SubNetCidr { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-<b>z1mlwpbjx3e9m</b></para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1uf97<b><b>xjxgip</b></b></para>
                    /// </summary>
                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of the returned page. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3CE915C-0C83-4AA5-8D66-E8BEED62939E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
