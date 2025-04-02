// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryClusterDetailResponseBodyData Data { get; set; }
        public class QueryClusterDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("AclEntryList")]
            [Validation(Required=false)]
            public string AclEntryList { get; set; }

            /// <summary>
            /// <para>The ID of the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-bp17020kiqvzutwwj****</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>The application version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.1</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The billing method, such as subscription or pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The alias of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-7413****</para>
            /// </summary>
            [NameInMap("ClusterAliasName")]
            [Validation(Required=false)]
            public string ClusterAliasName { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-bc1a29b0-160230875****</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The engine specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MSE_SC_1_2_200_c</para>
            /// </summary>
            [NameInMap("ClusterSpecification")]
            [Validation(Required=false)]
            public string ClusterSpecification { get; set; }

            /// <summary>
            /// <para>The type of the instance. Valid values: ZooKeeper, Nacos-Ans, and Eureka.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Nacos-Ans</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.1</para>
            /// </summary>
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }

            /// <summary>
            /// <para>The network connection type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>slb</description></item>
            /// <item><description>eni</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ConnectionType")]
            [Validation(Required=false)]
            public string ConnectionType { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-31 11:36:08</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The capacity of the disk. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public long? DiskCapacity { get; set; }

            /// <summary>
            /// <para>The type of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud-disk-ssd-multi-zone</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The health status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESTART_SUCCESS</para>
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// <para>The amount of time taken to create the instance. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98408</para>
            /// </summary>
            [NameInMap("InitCostTime")]
            [Validation(Required=false)]
            public long? InitCostTime { get; set; }

            /// <summary>
            /// <para>The creation status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RESTART_SUCCESS</para>
            /// </summary>
            [NameInMap("InitStatus")]
            [Validation(Required=false)]
            public string InitStatus { get; set; }

            /// <summary>
            /// <para>The number of instance nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-cn-st21ri2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of instance nodes.</para>
            /// </summary>
            [NameInMap("InstanceModels")]
            [Validation(Required=false)]
            public List<QueryClusterDetailResponseBodyDataInstanceModels> InstanceModels { get; set; }
            public class QueryClusterDetailResponseBodyDataInstanceModels : TeaModel {
                /// <summary>
                /// <para>The timestamp when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1578575377732</para>
                /// </summary>
                [NameInMap("CreationTimestamp")]
                [Validation(Required=false)]
                public string CreationTimestamp { get; set; }

                /// <summary>
                /// <para>The health status of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>The public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.98.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>The IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.12.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The name of the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mse-7413****-159616656****-reg-center-0-0</para>
                /// </summary>
                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                /// <summary>
                /// <para>The role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Peer</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The single-thread IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("SingleTunnelVip")]
                [Validation(Required=false)]
                public string SingleTunnelVip { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai-f</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.98.XX.XX</para>
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// <para>The public endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-7413****-p.eureka.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// <para>The private port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8761</para>
            /// </summary>
            [NameInMap("InternetPort")]
            [Validation(Required=false)]
            public string InternetPort { get; set; }

            /// <summary>
            /// <para>The internal IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse-7413****-eureka.mse.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// <para>The private port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8761</para>
            /// </summary>
            [NameInMap("IntranetPort")]
            [Validation(Required=false)]
            public string IntranetPort { get; set; }

            /// <summary>
            /// <para>The size of the memory. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public long? MemoryCapacity { get; set; }

            /// <summary>
            /// <para>The edition of Microservices Engine (MSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse_basic</para>
            /// </summary>
            [NameInMap("MseVersion")]
            [Validation(Required=false)]
            public string MseVersion { get; set; }

            /// <summary>
            /// <para>The network type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>privatenet</c>: VPC</description></item>
            /// <item><description><c>pubnet</c>: Internet</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>privatenet</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The version number of the original order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.0</para>
            /// </summary>
            [NameInMap("OrderClusterVersion")]
            [Validation(Required=false)]
            public string OrderClusterVersion { get; set; }

            /// <summary>
            /// <para>The billing method, such as subscription or pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("PayInfo")]
            [Validation(Required=false)]
            public string PayInfo { get; set; }

            /// <summary>
            /// <para>The public bandwidth. Unit: Mbit/s.\
            /// Valid values: 0 to 5000. The value 0 indicates no access to the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
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
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2dhgysj*****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags that are attached to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx-xxxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VersionLifecycle")]
            [Validation(Required=false)]
            public string VersionLifecycle { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1hcg467ekqsv0zr****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9515ACA4-E94D-440D-989E-C379FCED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
