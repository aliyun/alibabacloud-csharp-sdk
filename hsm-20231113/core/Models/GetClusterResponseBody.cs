// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cluster.</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public GetClusterResponseBodyCluster Cluster { get; set; }
        public class GetClusterResponseBodyCluster : TeaModel {
            /// <summary>
            /// <para>The cluster certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----
            /// MIIDfTCCAmWgAwIBAgIJAMRqQMr5if66MA0GCSqGSIb3DQEBCwUAMFUxCzAJBgNV
            /// BAYTAmNuMQswCQYDVQQIDAJ6ajELMAkGA1UEBwwCaHoxFjAUBgNVBAoMDUFsaWJh
            /// YmEgQ2xvdWQxFDA****
            /// -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("ClusterCertificate")]
            [Validation(Required=false)]
            public string ClusterCertificate { get; set; }

            /// <summary>
            /// <para>The certificate signing request (CSR) file of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE REQUEST-----\nMIIC5TCCAc0CAQAwgZ8xWTAJBgNVBAYTAlVTMAkGA1UECAwCQ0EwDQYDVQQKDAZD\nYXZpdW0wDQYDVQQLDAZOM0ZJUFMwDgYDVQQHDAdTYW5Kb3NlMBMGA1UdEQwMMTk****
            /// -----END CERTIFICATE REQUEST-----</para>
            /// </summary>
            [NameInMap("ClusterCsr")]
            [Validation(Required=false)]
            public string ClusterCsr { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-p94y1dud9ts****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public int? ClusterMode { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_polar_****</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The self-signed certificate of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>----BEGIN CERTIFICATE-----
            /// MIIDaTCCAlECAQEwDQYJKoZIhvcNAQELBQAwVTELMAkGA1UEBhMCY24xCzAJBgNV
            /// BAgMAnpqMQswCQYDVQQHDAJoejEWMBQGA1UECgwNQWxpYmFiYSBDbG91ZDEUMBIG
            /// A1UECwwLU2VjQ2xvdWRIc20wHhcNMjQwNzAzM****
            /// -----END CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("ClusterOwnerCertificate")]
            [Validation(Required=false)]
            public string ClusterOwnerCertificate { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created. Unit: milliseconds. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641275680000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The type of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jnta</para>
            /// </summary>
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            /// <summary>
            /// <para>The HSMs in the cluster.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<GetClusterResponseBodyClusterInstances> Instances { get; set; }
            public class GetClusterResponseBodyClusterInstances : TeaModel {
                /// <summary>
                /// <para>The ID of the HSM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hsm-cn-g6z3v0uf****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the HSM is a master HSM. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Master")]
                [Validation(Required=false)]
                public bool? Master { get; set; }

                /// <summary>
                /// <para>The ID of the HSM in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public int? NodeId { get; set; }

            }

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
            /// <para>The number of hardware security modules (HSMs) in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NEW: The cluster is not initialized.</description></item>
            /// <item><description>INITIALIZED: The cluster is initialized.</description></item>
            /// <item><description>DELETED: The cluster is deleted.</description></item>
            /// <item><description>SYNCHRONIZING: The cluster is being synchronized.</description></item>
            /// <item><description>TO_DELETE: The cluster is pending deletion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-8vbt0fjdm29hofvbo****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The IP address whitelist of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130.176.XX.XX</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public string Whitelist { get; set; }

            /// <summary>
            /// <para>The information about the zones in which the cluster is deployed.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<GetClusterResponseBodyClusterZones> Zones { get; set; }
            public class GetClusterResponseBodyClusterZones : TeaModel {
                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf61s651p69bdgmki****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-j</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
