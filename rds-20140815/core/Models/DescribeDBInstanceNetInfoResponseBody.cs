// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the endpoints of the instance.
        /// </summary>
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos : TeaModel {
            [NameInMap("DBInstanceNetInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfo> DBInstanceNetInfo { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfo : TeaModel {
                /// <summary>
                /// The Tabular Data Stream (TDS) port of the instance for which Babelfish is enabled.
                /// 
                /// > This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see [Introduction to Babelfish](~~428613~~).
                /// </summary>
                [NameInMap("BabelfishPort")]
                [Validation(Required=false)]
                public string BabelfishPort { get; set; }

                /// <summary>
                /// The endpoints of the instance.
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// The types of the endpoints. Valid values:
                /// 
                /// *   **Normal**: regular endpoints
                /// *   **ReadWriteSplitting**: read/write splitting endpoints
                /// </summary>
                [NameInMap("ConnectionStringType")]
                [Validation(Required=false)]
                public string ConnectionStringType { get; set; }

                /// <summary>
                /// The information about the instance weight.
                /// 
                /// > This parameter is returned only for instances that have read/write splitting endpoints.
                /// </summary>
                [NameInMap("DBInstanceWeights")]
                [Validation(Required=false)]
                public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights DBInstanceWeights { get; set; }
                public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeights : TeaModel {
                    [NameInMap("DBInstanceWeight")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight> DBInstanceWeight { get; set; }
                    public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoDBInstanceWeightsDBInstanceWeight : TeaModel {
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
                        /// The role of the instance. Valid values:
                        /// 
                        /// *   **Master**: primary instance
                        /// *   **Readonly**: read-only instance
                        /// </summary>
                        [NameInMap("DBInstanceType")]
                        [Validation(Required=false)]
                        public string DBInstanceType { get; set; }

                        /// <summary>
                        /// A deprecated parameter.
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// The weight of the instance.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// The policy that is used to assign read weights. This parameter is returned only for a read/write splitting endpoint. Valid values:
                /// 
                /// *   **Standard**: The system automatically assigns read weights to the instance and its read-only instances based on the specifications of these instances.
                /// *   **Custom**: You must manually assign read weights to the instance and its read-only instances.
                /// </summary>
                [NameInMap("DistributionType")]
                [Validation(Required=false)]
                public string DistributionType { get; set; }

                /// <summary>
                /// The remaining validity period of the instance in the classic network in hybrid access mode. Unit: seconds.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The network type.
                /// 
                /// *   Valid values when the instance resides in the classic network:
                /// 
                ///     *   **Inner:**: internal network
                ///     *   **Public**: Internet
                /// 
                /// *   Valid values when the instance resides in a virtual private cloud (VPC):
                /// 
                ///     *   **Private**: internal network
                ///     *   **Public**: Internet
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// The latency threshold. This parameter is returned only for a read/write splitting endpoint. Unit: seconds.
                /// 
                /// > If the latency on a read-only instance exceeds the specified threshold, the system no longer forwards read requests to the read-only instance.
                /// </summary>
                [NameInMap("MaxDelayTime")]
                [Validation(Required=false)]
                public string MaxDelayTime { get; set; }

                /// <summary>
                /// The PgBouncer port.
                /// 
                /// > This parameter is returned only when PgBouncer is enabled for the instance that runs PostgreSQL.
                /// </summary>
                [NameInMap("PGBouncerPort")]
                [Validation(Required=false)]
                public string PGBouncerPort { get; set; }

                /// <summary>
                /// The port that is used to connect to the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The details of the IP address whitelist.
                /// </summary>
                [NameInMap("SecurityIPGroups")]
                [Validation(Required=false)]
                public DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups SecurityIPGroups { get; set; }
                public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroups : TeaModel {
                    [NameInMap("securityIPGroup")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup> SecurityIPGroup { get; set; }
                    public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosDBInstanceNetInfoSecurityIPGroupsSecurityIPGroup : TeaModel {
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
                /// Indicates whether the IP version can be updated. Valid values:
                /// 
                /// *   **Enable**: The IP version can be updated.
                /// *   **Disabled**: The IP version cannot be updated.
                /// 
                /// > The IP version can be updated from IPv4 to IPv6.
                /// </summary>
                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The vSwitch ID.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **Classic**: classic network
        /// *   **VPC**: virtual private cloud (VPC)
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

        /// <summary>
        /// The whitelist mode of the instance. Valid values:
        /// 
        /// *   **normal**: standard whitelist mode
        /// *   **safety**: enhanced whitelist mode
        /// </summary>
        [NameInMap("SecurityIPMode")]
        [Validation(Required=false)]
        public string SecurityIPMode { get; set; }

    }

}
