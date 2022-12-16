// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryClusterDetailResponseBodyData Data { get; set; }
        public class QueryClusterDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The whitelist of the cluster.
            /// </summary>
            [NameInMap("AclEntryList")]
            [Validation(Required=false)]
            public string AclEntryList { get; set; }

            /// <summary>
            /// The ID of the whitelist.
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// The version of the application.
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// The billing method, such as subscription or pay-as-you-go.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The alias of the cluster.
            /// </summary>
            [NameInMap("ClusterAliasName")]
            [Validation(Required=false)]
            public string ClusterAliasName { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The specifications of the engine.
            /// </summary>
            [NameInMap("ClusterSpecification")]
            [Validation(Required=false)]
            public string ClusterSpecification { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values: ZooKeeper, Nacos-Ans, and Eureka.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The version of the cluster.
            /// </summary>
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }

            /// <summary>
            /// The connection type. Valid values:
            /// 
            /// - slb
            /// - eni
            /// </summary>
            [NameInMap("ConnectionType")]
            [Validation(Required=false)]
            public string ConnectionType { get; set; }

            /// <summary>
            /// The number of CPUs.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the cluster was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The capacity of the disk. Unit: GB.
            /// </summary>
            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public long? DiskCapacity { get; set; }

            /// <summary>
            /// The type of the disk.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The health status of the cluster.
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// The amount of time taken to create the cluster. Unit: milliseconds.
            /// </summary>
            [NameInMap("InitCostTime")]
            [Validation(Required=false)]
            public long? InitCostTime { get; set; }

            /// <summary>
            /// The creation status of the cluster.
            /// </summary>
            [NameInMap("InitStatus")]
            [Validation(Required=false)]
            public string InitStatus { get; set; }

            /// <summary>
            /// The number of nodes.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The information about nodes.
            /// </summary>
            [NameInMap("InstanceModels")]
            [Validation(Required=false)]
            public List<QueryClusterDetailResponseBodyDataInstanceModels> InstanceModels { get; set; }
            public class QueryClusterDetailResponseBodyDataInstanceModels : TeaModel {
                /// <summary>
                /// The timestamp when the node was created.
                /// </summary>
                [NameInMap("CreationTimestamp")]
                [Validation(Required=false)]
                public string CreationTimestamp { get; set; }

                /// <summary>
                /// The health status of the node.
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// The public IP address.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The name of the pod.
                /// </summary>
                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                /// <summary>
                /// The role of the node.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The single-thread IP address.
                /// </summary>
                [NameInMap("SingleTunnelVip")]
                [Validation(Required=false)]
                public string SingleTunnelVip { get; set; }

                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// The public IP address.
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// The public domain name.
            /// </summary>
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// The private port.
            /// </summary>
            [NameInMap("InternetPort")]
            [Validation(Required=false)]
            public string InternetPort { get; set; }

            /// <summary>
            /// The private IP address.
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// The private domain name.
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// The private port.
            /// </summary>
            [NameInMap("IntranetPort")]
            [Validation(Required=false)]
            public string IntranetPort { get; set; }

            /// <summary>
            /// The size of the memory. Unit: GB.
            /// </summary>
            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public long? MemoryCapacity { get; set; }

            /// <summary>
            /// The version category of the cluster.
            /// </summary>
            [NameInMap("MseVersion")]
            [Validation(Required=false)]
            public string MseVersion { get; set; }

            /// <summary>
            /// The network type of the cluster. Valid values:
            /// 
            /// - `privatenet`: private network 
            /// - `pubnet`: the Internet
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            [NameInMap("OrderClusterVersion")]
            [Validation(Required=false)]
            public string OrderClusterVersion { get; set; }

            /// <summary>
            /// The billing method, such as subscription or pay-as-you-go.
            /// </summary>
            [NameInMap("PayInfo")]
            [Validation(Required=false)]
            public string PayInfo { get; set; }

            /// <summary>
            /// The public bandwidth. Unit: Mbit/s.    
            /// Valid values: 0 to 5000. A value of 0 indicates no access to the Internet.
            /// </summary>
            [NameInMap("PubNetworkFlow")]
            [Validation(Required=false)]
            public string PubNetworkFlow { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// The ID of the vSwitch.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// VPC ID.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
