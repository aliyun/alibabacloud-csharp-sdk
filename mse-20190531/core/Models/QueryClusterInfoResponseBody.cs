// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterInfoResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryClusterInfoResponseBodyData Data { get; set; }
        public class QueryClusterInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The public IP address whitelist.
            /// </summary>
            [NameInMap("AclEntryList")]
            [Validation(Required=false)]
            public string AclEntryList { get; set; }

            /// <summary>
            /// The ID of the instance in the public IP address whitelist.
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// The version of the instance.
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
            /// The alias of the instance.
            /// </summary>
            [NameInMap("ClusterAliasName")]
            [Validation(Required=false)]
            public string ClusterAliasName { get; set; }

            /// <summary>
            /// The full name of the instance.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The engine specifications.
            /// </summary>
            [NameInMap("ClusterSpecification")]
            [Validation(Required=false)]
            public string ClusterSpecification { get; set; }

            /// <summary>
            /// The type of the instance. Valid values: ZooKeeper, Nacos-Ans, and Eureka.
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The version of the order.
            /// </summary>
            [NameInMap("ClusterVersion")]
            [Validation(Required=false)]
            public string ClusterVersion { get; set; }

            /// <summary>
            /// A deprecated parameter.
            /// </summary>
            [NameInMap("ConnectionType")]
            [Validation(Required=false)]
            public string ConnectionType { get; set; }

            /// <summary>
            /// A deprecated parameter.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// A deprecated parameter.
            /// </summary>
            [NameInMap("DiskCapacity")]
            [Validation(Required=false)]
            public long? DiskCapacity { get; set; }

            /// <summary>
            /// A deprecated parameter.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The status of the instance.
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// The time that is required to initialize the instance. Unit: milliseconds.
            /// </summary>
            [NameInMap("InitCostTime")]
            [Validation(Required=false)]
            public long? InitCostTime { get; set; }

            /// <summary>
            /// The initial status of the instance.
            /// </summary>
            [NameInMap("InitStatus")]
            [Validation(Required=false)]
            public string InitStatus { get; set; }

            /// <summary>
            /// The number of instance nodes.
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
            /// The reserved structure.
            /// </summary>
            [NameInMap("InstanceModels")]
            [Validation(Required=false)]
            public List<QueryClusterInfoResponseBodyDataInstanceModels> InstanceModels { get; set; }
            public class QueryClusterInfoResponseBodyDataInstanceModels : TeaModel {
                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("CreationTimestamp")]
                [Validation(Required=false)]
                public string CreationTimestamp { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("SingleTunnelVip")]
                [Validation(Required=false)]
                public string SingleTunnelVip { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// The public endpoint.
            /// </summary>
            [NameInMap("InternetDomain")]
            [Validation(Required=false)]
            public string InternetDomain { get; set; }

            /// <summary>
            /// The instance port that is accessible over the Internet.
            /// </summary>
            [NameInMap("InternetPort")]
            [Validation(Required=false)]
            public string InternetPort { get; set; }

            /// <summary>
            /// A reserved parameter.
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// The internal endpoint.
            /// </summary>
            [NameInMap("IntranetDomain")]
            [Validation(Required=false)]
            public string IntranetDomain { get; set; }

            /// <summary>
            /// The instance port that is accessible over an internal network.
            /// </summary>
            [NameInMap("IntranetPort")]
            [Validation(Required=false)]
            public string IntranetPort { get; set; }

            /// <summary>
            /// A deprecated parameter.
            /// </summary>
            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public long? MemoryCapacity { get; set; }

            /// <summary>
            /// The version of the instance.
            /// </summary>
            [NameInMap("MseVersion")]
            [Validation(Required=false)]
            public string MseVersion { get; set; }

            /// <summary>
            /// The network connection type of the instance.
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// The billing method. Valid values:
            /// </summary>
            [NameInMap("PayInfo")]
            [Validation(Required=false)]
            public string PayInfo { get; set; }

            /// <summary>
            /// The public bandwidth. Unit: Mbit/s.\
            /// Valid values: 0 to 5000. The value 0 indicates no access to the Internet.
            /// </summary>
            [NameInMap("PubNetworkFlow")]
            [Validation(Required=false)]
            public string PubNetworkFlow { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The tag.
            /// </summary>
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
            /// The ID of the VPC where the instance resides.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
        /// 
        /// *   If the request is successful, a success message is returned.
        /// *   If the request fails, an error message is returned.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
