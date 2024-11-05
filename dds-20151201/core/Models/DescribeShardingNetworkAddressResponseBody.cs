// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeShardingNetworkAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoints of DynamoDB-compatible instances.</para>
        /// </summary>
        [NameInMap("CompatibleConnections")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyCompatibleConnections CompatibleConnections { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyCompatibleConnections : TeaModel {
            [NameInMap("CompatibleConnection")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyCompatibleConnectionsCompatibleConnection> CompatibleConnection { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyCompatibleConnectionsCompatibleConnection : TeaModel {
                /// <summary>
                /// <para>The remaining duration of the classic network endpoint. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2591963</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.140.xxx.xx</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bpxxxxxxxxxxxxxx.mongodb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("NetworkAddress")]
                [Validation(Required=false)]
                public string NetworkAddress { get; set; }

                /// <summary>
                /// <para>The network type of the instance.</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: virtual private cloud</description></item>
                /// <item><description><b>Classic</b>: classic network</description></item>
                /// <item><description><b>Public</b>: the Internet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The port that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3717</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// <remarks>
                /// <para> This parameter is returned when the network type is <b>VPC</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bpxxxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the Virtual Private Cloud (VPC).</para>
                /// <remarks>
                /// <para> This parameter is returned when the network type is <b>VPC</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bpxxxxxxxx</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The endpoints of ApsaraDB for MongoDB instances.</para>
        /// </summary>
        [NameInMap("NetworkAddresses")]
        [Validation(Required=false)]
        public DescribeShardingNetworkAddressResponseBodyNetworkAddresses NetworkAddresses { get; set; }
        public class DescribeShardingNetworkAddressResponseBodyNetworkAddresses : TeaModel {
            [NameInMap("NetworkAddress")]
            [Validation(Required=false)]
            public List<DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress> NetworkAddress { get; set; }
            public class DescribeShardingNetworkAddressResponseBodyNetworkAddressesNetworkAddress : TeaModel {
                [NameInMap("ConnectionType")]
                [Validation(Required=false)]
                public string ConnectionType { get; set; }

                /// <summary>
                /// <para>The remaining duration of the classic network endpoint. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2591963</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.140.xxx.xx</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The connection string of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bpxxxxxxxx.mongodb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("NetworkAddress")]
                [Validation(Required=false)]
                public string NetworkAddress { get; set; }

                /// <summary>
                /// <para>The network type of the instance.</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: virtual private cloud</description></item>
                /// <item><description><b>Classic</b>: classic network</description></item>
                /// <item><description><b>Public</b>: the Internet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The ID of the mongos node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bpxxxxxxxx</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mongos</b>: mongos node</description></item>
                /// <item><description><b>shard</b>: shard node</description></item>
                /// <item><description><b>configserver</b>: Configserver node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>mongos</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The port that is used to connect to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3717</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The role of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Primary</description></item>
                /// <item><description>Secondary</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("TxtRecord")]
                [Validation(Required=false)]
                public string TxtRecord { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// <remarks>
                /// <para> This parameter is returned when the network type is <b>VPC</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bpxxxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch in the VPC.</para>
                /// <remarks>
                /// <para> This parameter is returned when the network type is <b>VPC</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bpxxxxxxxx</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18D8AAFD-6BEB-420F-8164-810CB0C0AA39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
