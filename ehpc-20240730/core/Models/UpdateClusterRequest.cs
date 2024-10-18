// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The client version. By default, the latest version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1.0</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The post-processing script of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public UpdateClusterRequestClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class UpdateClusterRequestClusterCustomConfiguration : TeaModel {
            /// <summary>
            /// <para>The arguments that are used to run the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E-HPC cn-hangzhou</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://*****</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// <para>The cluster description. The description must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-serverless-cluster-20240805</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name. The name must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-serverless-cluster-20240805</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the cluster. Deletion protection decides whether the cluster can be deleted in the console or by calling the DeleteCluster operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto scale-in for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto scale-out for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        /// <summary>
        /// <para>The interval at which the cluster is automatically scaled out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        /// <summary>
        /// <para>The idle duration of the compute nodes allowed by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        /// <summary>
        /// <para>The total maximum number of vCPUs for use by compute nodes in the cluster. Valid values: 0 to 100,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public int? MaxCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum number of compute nodes that the cluster can manage. Valid values: 0 to 5,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

    }

}
