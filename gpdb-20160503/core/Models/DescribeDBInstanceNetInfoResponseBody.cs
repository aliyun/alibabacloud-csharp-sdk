// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The connection information of the instance.</para>
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
                /// <para>The type of the endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Intranet</para>
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-xxxxxxx.gpdb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The type of the IP address.</para>
                /// <list type="bullet">
                /// <item><description>Valid values for instances in the classic network: Inner and Public.</description></item>
                /// <item><description>Valid values for instances in a virtual private cloud (VPC): Private and Public.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Inner</para>
                /// </summary>
                [NameInMap("IPType")]
                [Validation(Required=false)]
                public string IPType { get; set; }

                /// <summary>
                /// <para>The port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3432</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID. Multiple IDs are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the instance that is deployed in a VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxxx</para>
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Classic: classic network.</description></item>
        /// <item><description>VPC: VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Classic</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7565770E-7C45-462D-BA4A-8A5396F2CAD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
