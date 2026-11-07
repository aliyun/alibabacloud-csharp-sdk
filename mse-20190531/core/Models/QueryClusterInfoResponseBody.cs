// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryClusterInfoResponseBodyData Data { get; set; }
        public class QueryClusterInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The public network whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;127.0.0.0/32&quot;]</para>
            /// </summary>
            [NameInMap("AclEntryList")]
            [Validation(Required=false)]
            public string AclEntryList { get; set; }

            /// <summary>
            /// <para>The instance ID of the Internet whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-bp144q24cgqvzckmxxxx</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>The cluster version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.1.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster has a minor version available for upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanUpdate")]
            [Validation(Required=false)]
            public bool? CanUpdate { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values: subscription and pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The alias of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Development environment</para>
            /// </summary>
            [NameInMap("ClusterAliasName")]
            [Validation(Required=false)]
            public string ClusterAliasName { get; set; }

            /// <summary>
            /// <para>The full name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-74355150-xxxxxxx</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The engine specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE_SC_2_4_60_c</para>
            /// </summary>
            [NameInMap("ClusterSpecification")]
            [Validation(Required=false)]
            public string ClusterSpecification { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values: ZooKeeper, Nacos-Ans, and Eureka.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Nacos-Ans</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The order version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NACOS_2_0_0</para>
            /// </summary>
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }

            /// <summary>
            /// <para>The deprecated field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ConnectionType")]
            [Validation(Required=false)]
            public string ConnectionType { get; set; }

            /// <summary>
            /// <para>The deprecated field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-15 10:02:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The deprecated field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public long? DiskCapacity { get; set; }

            /// <summary>
            /// <para>The deprecated field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The instance ID of the elastic IP address (EIP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1uujshd5funmyy8rcl9</para>
            /// </summary>
            [NameInMap("EipInstanceId")]
            [Validation(Required=false)]
            public string EipInstanceId { get; set; }

            /// <summary>
            /// <para>The expiration time for subscription instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-01 00:00:00</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The list of zones to which the current cluster can be distributed.</para>
            /// </summary>
            [NameInMap("ExpectZones")]
            [Validation(Required=false)]
            public List<string> ExpectZones { get; set; }

            /// <summary>
            /// <para>The cluster status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT_SUCCESS</para>
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// <para>The time taken to initialize the cluster, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53353</para>
            /// </summary>
            [NameInMap("InitCostTime")]
            [Validation(Required=false)]
            public long? InitCostTime { get; set; }

            /// <summary>
            /// <para>The initialization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT_SUCCESS</para>
            /// </summary>
            [NameInMap("InitStatus")]
            [Validation(Required=false)]
            public string InitStatus { get; set; }

            /// <summary>
            /// <para>The number of instances in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-st21ri2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The reserved structure.</para>
            /// </summary>
            [NameInMap("InstanceModels")]
            [Validation(Required=false)]
            public List<QueryClusterInfoResponseBodyDataInstanceModels> InstanceModels { get; set; }
            public class QueryClusterInfoResponseBodyDataInstanceModels : TeaModel {
                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("CreationTimestamp")]
                [Validation(Required=false)]
                public string CreationTimestamp { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SingleTunnelVip")]
                [Validation(Required=false)]
                public string SingleTunnelVip { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// <para>The reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// <para>The public domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-xxxxxx-p.nacos-ans.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// <para>The open ports for the Internet cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8848,6443,9848,8761</para>
            /// </summary>
            [NameInMap("InternetPort")]
            [Validation(Required=false)]
            public string InternetPort { get; set; }

            /// <summary>
            /// <para>The reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The internal domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-xxxxx-nacos-ans.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <para>The internal network port opened for the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8848,6443,9848,8761</para>
            /// </summary>
            [NameInMap("IntranetPort")]
            [Validation(Required=false)]
            public string IntranetPort { get; set; }

            /// <summary>
            /// <para>The O&amp;M time window.</para>
            /// </summary>
            [NameInMap("MaintenancePeriod")]
            [Validation(Required=false)]
            public QueryClusterInfoResponseBodyDataMaintenancePeriod MaintenancePeriod { get; set; }
            public class QueryClusterInfoResponseBodyDataMaintenancePeriod : TeaModel {
                /// <summary>
                /// <para>The start time of the O&amp;M time window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The end time of the O&amp;M time window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>06:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The deprecated field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public long? MemoryCapacity { get; set; }

            /// <summary>
            /// <para>The cluster version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse_pro</para>
            /// </summary>
            [NameInMap("MseVersion")]
            [Validation(Required=false)]
            public string MseVersion { get; set; }

            /// <summary>
            /// <para>The network connectivity type of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>privatenet</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("PayInfo")]
            [Validation(Required=false)]
            public string PayInfo { get; set; }

            /// <summary>
            /// <para>The Internet bandwidth. Unit: Mbit/s. Valid values: 0 to 5000. A value of 0 indicates that the cluster is not connected to the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PubNetworkFlow")]
            [Validation(Required=false)]
            public string PubNetworkFlow { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the security group for ENI network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-uf6hgwe067prhg68agfa</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The type of the security group for ENI network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("SecurityGroupType")]
            [Validation(Required=false)]
            public string SecurityGroupType { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1egfakxxxxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The current version code of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NACOS_2_1_0_1</para>
            /// </summary>
            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public string VersionCode { get; set; }

            /// <summary>
            /// <para>The version lifecycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STABLE</para>
            /// </summary>
            [NameInMap("VersionLifecycle")]
            [Validation(Required=false)]
            public string VersionLifecycle { get; set; }

            /// <summary>
            /// <para>The ID of the VPC where the cluster is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1v5nbauzh8xxxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, a success message is returned.</description></item>
        /// <item><description>If the request fails, the cause of the failure is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Request processed successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>415088B3-A7BE-56F6-9CD9-C42DE895CD41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
