// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The network type of the cluster. Only the Virtual Private Cloud (VPC) network type is supported. <b>VPC</b> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The queried network information about the cluster.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeClusterNetInfoResponseBodyItemsAddress : TeaModel {
                /// <summary>
                /// <para>The endpoint of the cluster.</para>
                /// <list type="bullet">
                /// <item><description>If NetType is set to VPC, the VPC endpoint of the cluster is returned.</description></item>
                /// <item><description>If NetType is set to Public, the public endpoint of the cluster is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>amv-wz9dqvn0o7****.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The prefix of the endpoint.</para>
                /// <list type="bullet">
                /// <item><description>If NetType is set to VPC, the prefix of the VPC endpoint is returned.</description></item>
                /// <item><description>If NetType is set to Public, the prefix of the public endpoint is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>amv-wz9dqvn0o7****</para>
                /// </summary>
                [NameInMap("ConnectionStringPrefix")]
                [Validation(Required=false)]
                public string ConnectionStringPrefix { get; set; }

                /// <summary>
                /// <para>The IP address of the endpoint.</para>
                /// <list type="bullet">
                /// <item><description>If NetType is set to VPC, the private IP address of the cluster is returned.</description></item>
                /// <item><description>If NetType is set to Public, the public IP address of the cluster is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.xx.xx</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: Internet.</description></item>
                /// <item><description><b>VPC</b>: VPC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the cluster. <b>3306</b> is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The ports.</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public DescribeClusterNetInfoResponseBodyItemsAddressPorts Ports { get; set; }
                public class DescribeClusterNetInfoResponseBodyItemsAddressPorts : TeaModel {
                    [NameInMap("ports")]
                    [Validation(Required=false)]
                    public List<DescribeClusterNetInfoResponseBodyItemsAddressPortsPorts> Ports { get; set; }
                    public class DescribeClusterNetInfoResponseBodyItemsAddressPortsPorts : TeaModel {
                        /// <summary>
                        /// <para>The port.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3306</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        /// <summary>
                        /// <para>The type of the protocol. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>tcp</b></description></item>
                        /// <item><description><b>http</b></description></item>
                        /// <item><description><b>https</b></description></item>
                        /// <item><description><b>mysql</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mysql</para>
                        /// </summary>
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// <remarks>
                /// <para> If NetType is set to Public, an empty string is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbhucmd5b****</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the cluster.</para>
                /// <remarks>
                /// <para> If NetType is set to Public, an empty string is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1syh8vvw8yec****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69A29B65-CD0C-52B1-BE42-8B454569747F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
