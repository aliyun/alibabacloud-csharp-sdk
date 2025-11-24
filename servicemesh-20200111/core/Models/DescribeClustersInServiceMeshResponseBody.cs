// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClustersInServiceMeshResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the clusters in the ASM instance.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersInServiceMeshResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersInServiceMeshResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The configurations of access log collection.</para>
            /// </summary>
            [NameInMap("AccessLogDashboards")]
            [Validation(Required=false)]
            public List<DescribeClustersInServiceMeshResponseBodyClustersAccessLogDashboards> AccessLogDashboards { get; set; }
            public class DescribeClustersInServiceMeshResponseBodyClustersAccessLogDashboards : TeaModel {
                /// <summary>
                /// <para>The name of the dashboard for access logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mesh-access-log_details_cn</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The URL of the dashboard for access logs.</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The domain name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("ClusterDomain")]
            [Validation(Required=false)]
            public string ClusterDomain { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c80f45444b3da447da60a911390c2****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The type of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ask</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-12T15:38:16+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>,</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("GuestClusterConfig")]
            [Validation(Required=false)]
            public DescribeClustersInServiceMeshResponseBodyClustersGuestClusterConfig GuestClusterConfig { get; set; }
            public class DescribeClustersInServiceMeshResponseBodyClustersGuestClusterConfig : TeaModel {
                [NameInMap("SMC")]
                [Validation(Required=false)]
                public DescribeClustersInServiceMeshResponseBodyClustersGuestClusterConfigSMC SMC { get; set; }
                public class DescribeClustersInServiceMeshResponseBodyClustersGuestClusterConfigSMC : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the Logtail component is installed in the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>logtail_installed</c>: The Logtail component is installed.</description></item>
            /// </list>
            /// <para>\-<c>logtail_uninstalled</c>: The Logtail component is not installed.</para>
            /// <list type="bullet">
            /// <item><description><c>logtail_state_get_error</c>: The Logtail component failed to be installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>logtail_installed</para>
            /// </summary>
            [NameInMap("LogtailInstalledState")]
            [Validation(Required=false)]
            public string LogtailInstalledState { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ask1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the cluster resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp197668l6iupljy****</para>
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// <para>The status of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the cluster was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-12T15:38:16+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version number of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.16.6-aliyun.1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zew0rajjkmxy2369****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
