// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Network list of BE instances.</para>
        /// </summary>
        [NameInMap("DBClustersNetInfos")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfos> DBClustersNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfos : TeaModel {
            /// <summary>
            /// <para>Cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-be</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Connection address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-fe.selectdbfe.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.131.<em><b>.</b></em></para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC/PUBLIC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>Port list.</para>
            /// </summary>
            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfosPortList> PortList { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBClustersNetInfosPortList : TeaModel {
                /// <summary>
                /// <para>Connection port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9030/8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Port type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQLPort/HttpPort</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the information is visible to users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("UserVisible")]
            [Validation(Required=false)]
            public bool? UserVisible { get; set; }

            /// <summary>
            /// <para>VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>VPC instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-fe-20230816101006</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>Instance network information.</para>
        /// </summary>
        [NameInMap("DBInstanceNetInfos")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos> DBInstanceNetInfos { get; set; }
        public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfos : TeaModel {
            /// <summary>
            /// <para>Cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-****-be</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Connection address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-h033cnd****-fe.selectdbfe.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

            /// <summary>
            /// <para>IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Network type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>VPC</b>: Virtual Private Cloud (VPC).</para>
            /// </description></item>
            /// <item><description><para><b>PUBLIC</b>: Internet.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>Port object.</para>
            /// </summary>
            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosPortList> PortList { get; set; }
            public class DescribeDBInstanceNetInfoResponseBodyDBInstanceNetInfosPortList : TeaModel {
                /// <summary>
                /// <para>Connection port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQLPort</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Port type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>HttpPort</b>: HTTP protocol port.</para>
                /// </description></item>
                /// <item><description><para><b>MySQLPort</b>: MySQL protocol port.</para>
                /// </description></item>
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
            /// <para>Indicates whether the information is visible to users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Visible to users.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not visible to users.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UserVisible")]
            [Validation(Required=false)]
            public bool? UserVisible { get; set; }

            /// <summary>
            /// <para>VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz90scxq6ods388ft****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>VPC instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-h033cnd****-fe-20230816101006</para>
            /// </summary>
            [NameInMap("VpcInstanceId")]
            [Validation(Required=false)]
            public string VpcInstanceId { get; set; }

            /// <summary>
            /// <para>vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6mlqti065rer6m0****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADF42B18-43FD-5100-83A9-BE81AB70C863</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
