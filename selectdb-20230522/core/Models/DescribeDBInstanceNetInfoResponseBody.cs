// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The network information about the backend (BE) clusters.</para>
        /// </summary>
        [NameInMap("DBClustersNetInfos")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfos> DBClustersNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfos : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-be</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The connection string of the BE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-fe.selectdbfe.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The IP address of the BE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.131.<em><b>.</b></em></para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The network type of the BE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC/PUBLIC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfosPortList> PortList { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfosPortList : TeaModel {
                /// <summary>
                /// <para>The port that is used to connect to the BE cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQLPort/HttpPort</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol of the port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9030/8080</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the network information is visible to users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("UserVisible")]
            [Validation(Required=false)]
            public bool? UserVisible { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-fe-20230816101006</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The network information about the instance.</para>
        /// </summary>
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos> DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-be</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The connection string of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-h033cnd****-fe.selectdbfe.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The network type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: indicates a virtual private cloud (VPC)-connected instance.</description></item>
            /// <item><description><b>PUBLIC</b>: indicates an Internet-connected instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The ports.</para>
            /// </summary>
            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosPortList> PortList { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosPortList : TeaModel {
                /// <summary>
                /// <para>The port that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQLPort</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The protocol of the port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HttpPort</b>: HTTP port.</description></item>
                /// <item><description><b>MySQLPort</b>: MySQL port.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>9030</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the network information is visible to users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UserVisible")]
            [Validation(Required=false)]
            public bool? UserVisible { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz90scxq6ods388ft****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC-connected instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-h033cnd****-fe-20230816101006</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6mlqti065rer6m0****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF42B18-43FD-5100-83A9-BE81AB70C863</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
