// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceNetInfoForChannelResponseBody : TeaModel {
        /// <summary>
        /// The information about the instance connection.
        /// </summary>
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfos DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfos : TeaModel {
            [NameInMap("DBInstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfo> DBInstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfo : TeaModel {
                /// <summary>
                /// The availability of the instance. Valid values:
                /// 
                /// *   **Unavailable**
                /// *   **Available**
                /// </summary>
                [NameInMap("Availability")]
                [Validation(Required=false)]
                public string Availability { get; set; }

                /// <summary>
                /// The endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The type of the endpoint. Valid values:
                /// 
                /// *   **Normal**: a regular endpoint
                /// *   **ReadWriteSplitting**: a read/write splitting endpoint that is assigned after the shared proxy feature is enabled.
                /// </summary>
                [NameInMap("ConnectionStringType")]
                [Validation(Required=false)]
                public string ConnectionStringType { get; set; }

                /// <summary>
                /// The information about read weights to implement read/write splitting after the shared proxy feature is enabled.
                /// </summary>
                [NameInMap("DBInstanceWeights")]
                [Validation(Required=false)]
                public DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights DBInstanceWeights { get; set; }
                public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights : TeaModel {
                    [NameInMap("DBInstanceWeight")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight> DBInstanceWeight { get; set; }
                    public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight : TeaModel {
                        /// <summary>
                        /// The availability of the instance. Valid values:
                        /// 
                        /// *   **Unavailable**
                        /// *   **Available**
                        /// </summary>
                        [NameInMap("Availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        /// <summary>
                        /// The instance ID.
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                        /// <summary>
                        /// The instance type. Valid values:
                        /// 
                        /// *   **Master**: primary instance
                        /// *   **Readonly**: read-only instance
                        /// </summary>
                        [NameInMap("DBInstanceType")]
                        [Validation(Required=false)]
                        public string DBInstanceType { get; set; }

                        /// <summary>
                        /// The weight of the instance.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// The policy that is used to assign read weights. This parameter is returned only for a read/write splitting endpoint that is assigned after the shared proxy feature is enabled. Valid values:
                /// 
                /// *   **Standard**: The system automatically allocates read weights to the instance and its read-only instances based on the specifications of the instances.
                /// *   **Custom**: You must manually allocate read weights to the instance and its read-only instances.
                /// </summary>
                [NameInMap("DistributionType")]
                [Validation(Required=false)]
                public string DistributionType { get; set; }

                /// <summary>
                /// The IP address of the instance.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type of the IP address. Valid values:
                /// 
                /// *   **Public**: the Internet
                /// *   **Inner**: the classic network
                /// *   **Private**: a virtual private cloud (VPC)
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// The latency threshold that is allowed for read/write splitting of the shared proxy feature. Unit: seconds.
                /// 
                /// >  This parameter is returned only when **ConnectionStringType** is set to **ReadWriteSplitting**.
                /// </summary>
                [NameInMap("MaxDelayTime")]
                [Validation(Required=false)]
                public string MaxDelayTime { get; set; }

                /// <summary>
                /// The port number of the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The details of the IP address whitelist.
                /// </summary>
                [NameInMap("SecurityIPGroups")]
                [Validation(Required=false)]
                public DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups SecurityIPGroups { get; set; }
                public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups : TeaModel {
                    [NameInMap("securityIPGroup")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup> SecurityIPGroup { get; set; }
                    public class DescribeDBInstanceNetInfoForChannelResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup : TeaModel {
                        /// <summary>
                        /// The name of the IP address whitelist.
                        /// </summary>
                        [NameInMap("SecurityIPGroupName")]
                        [Validation(Required=false)]
                        public string SecurityIPGroupName { get; set; }

                        /// <summary>
                        /// The IP addresses that is contained in the IP address whitelist.
                        /// </summary>
                        [NameInMap("SecurityIPs")]
                        [Validation(Required=false)]
                        public string SecurityIPs { get; set; }

                    }

                }

                /// <summary>
                /// An internal parameter. You do not need to specify this parameter.
                /// </summary>
                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                /// <summary>
                /// The VPC ID of the instance.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID of the instance.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The expiration time of the endpoint of the classic network type. Unit: seconds.
                /// </summary>
                [NameInMap("expiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

            }

        }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **VPC**: a virtual private cloud (VPC)
        /// *   **Classic**: classic network
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
