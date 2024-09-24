// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the endpoints of the instance.</para>
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
                /// <para>The Tabular Data Stream (TDS) port of the instance for which Babelfish is enabled.</para>
                /// <remarks>
                /// <para> This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/428613.html">Introduction to Babelfish</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1433</para>
                /// </summary>
                [NameInMap("BabelfishPort")]
                [Validation(Required=false)]
                public string BabelfishPort { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6w*****.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The type of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: a regular endpoint</description></item>
                /// <item><description><b>ReadWriteSplitting</b>: a read/write splitting endpoint</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("ConnectionStringType")]
                [Validation(Required=false)]
                public string ConnectionStringType { get; set; }

                /// <summary>
                /// <para>The information about the instance weight.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the read/write splitting feature is enabled for the instance.</para>
                /// </remarks>
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
                        /// <para>The availability of the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Unavailable</b></description></item>
                        /// <item><description><b>Available</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Unavailable</para>
                        /// </summary>
                        [NameInMap("Availability")]
                        [Validation(Required=false)]
                        public string Availability { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rm-uf6wjk5*****</para>
                        /// </summary>
                        [NameInMap("DBInstanceId")]
                        [Validation(Required=false)]
                        public string DBInstanceId { get; set; }

                        /// <summary>
                        /// <para>The type of the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Master</b>: primary instance</description></item>
                        /// <item><description><b>Readonly</b>: read-only instance</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Master</para>
                        /// </summary>
                        [NameInMap("DBInstanceType")]
                        [Validation(Required=false)]
                        public string DBInstanceType { get; set; }

                        /// <summary>
                        /// <para>A deprecated parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>None</para>
                        /// </summary>
                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <para>The weight of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>The policy that is used to assign read weights. This parameter is returned only for a read/write splitting endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: The system automatically allocates read weights to the instance and its read-only instances based on the specifications of the instances.</description></item>
                /// <item><description><b>Custom</b>: You must manually allocate read weights to the instance and its read-only instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("DistributionType")]
                [Validation(Required=false)]
                public string DistributionType { get; set; }

                /// <summary>
                /// <para>The remaining validity period of the instance in the classic network in hybrid access mode. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1209534</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// <list type="bullet">
                /// <item><description><para>Valid values when the instance resides in the classic network:</para>
                /// <list type="bullet">
                /// <item><description><b>Inner</b></description></item>
                /// <item><description><b>Public</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Valid values when the instance resides in a virtual private cloud (VPC):</para>
                /// <list type="bullet">
                /// <item><description><b>Private</b></description></item>
                /// <item><description><b>Public</b></description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Public</para>
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// <para>The latency threshold. This parameter is returned only for a read/write splitting endpoint. Unit: seconds.</para>
                /// <remarks>
                /// <para> If the latency on a read-only instance exceeds the specified threshold, ApsaraDB RDS no longer forwards read requests to the read-only instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MaxDelayTime")]
                [Validation(Required=false)]
                public string MaxDelayTime { get; set; }

                /// <summary>
                /// <para>The PgBouncer port.</para>
                /// <remarks>
                /// <para> This parameter is returned only when PgBouncer is enabled for the instance that runs PostgreSQL.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>6432</para>
                /// </summary>
                [NameInMap("PGBouncerPort")]
                [Validation(Required=false)]
                public string PGBouncerPort { get; set; }

                /// <summary>
                /// <para>The port that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The IP addresses in the whitelist for the instance.</para>
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
                        /// <para>The name of the IP address whitelist.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Default</para>
                        /// </summary>
                        [NameInMap("SecurityIPGroupName")]
                        [Validation(Required=false)]
                        public string SecurityIPGroupName { get; set; }

                        /// <summary>
                        /// <para>The IP address in the whitelist.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>127.0.XX.XX</para>
                        /// </summary>
                        [NameInMap("SecurityIPs")]
                        [Validation(Required=false)]
                        public string SecurityIPs { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the IP version can be updated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enable</b></description></item>
                /// <item><description><b>Disabled</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> The IP version can be updated from IPv4 to IPv6.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("Upgradeable")]
                [Validation(Required=false)]
                public string Upgradeable { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6f7l4fg90*****</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6adz52c2p*****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b>: classic network</description></item>
        /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>777C4593-8053-427B-99E2-105593277CAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The whitelist mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: standard whitelist mode</description></item>
        /// <item><description><b>safety</b>: enhanced whitelist mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>safety</para>
        /// </summary>
        [NameInMap("SecurityIPMode")]
        [Validation(Required=false)]
        public string SecurityIPMode { get; set; }

    }

}
