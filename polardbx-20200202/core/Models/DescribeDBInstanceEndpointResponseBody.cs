// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceEndpointResponseBodyData Data { get; set; }
        public class DescribeDBInstanceEndpointResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The internal connection type. The value is fixed as 1, which indicates the classic network.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceEndpointResponseBodyDataItems> Items { get; set; }
            public class DescribeDBInstanceEndpointResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public DescribeDBInstanceEndpointResponseBodyDataItemsEndpoint Endpoint { get; set; }
                public class DescribeDBInstanceEndpointResponseBodyDataItemsEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.21.1.82</para>
                    /// </summary>
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The instance specification type (specification code).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mdb.shard.4x.large.d</para>
                    /// </summary>
                    [NameInMap("Class")]
                    [Validation(Required=false)]
                    public string Class { get; set; }

                    /// <summary>
                    /// <para>The ID of the endpoint group to which the endpoint belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>epg-bp14wgzai7flglwdtkxfa</para>
                    /// </summary>
                    [NameInMap("EndpointGroupId")]
                    [Validation(Required=false)]
                    public long? EndpointGroupId { get; set; }

                    /// <summary>
                    /// <para>The logical node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2899</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether this is the default vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <para>The payload type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>agentTurn: agent conversation.</description></item>
                    /// <item><description>systemEvent: system event.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instance</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    /// <summary>
                    /// <para>The network type of the endpoint. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Public</b>: public endpoint.</description></item>
                    /// <item><description><b>Private</b>: private endpoint.</description></item>
                    /// <item><description><b>Inner</b>: private endpoint (classic network).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("NetType")]
                    [Validation(Required=false)]
                    public string NetType { get; set; }

                    /// <summary>
                    /// <para>The read/write type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ReadWrite: row store read/write.</description></item>
                    /// <item><description>ColumnarRead: column store read-only.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ReadType")]
                    [Validation(Required=false)]
                    public string ReadType { get; set; }

                    /// <summary>
                    /// <para>The object name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sas-app</para>
                    /// </summary>
                    [NameInMap("TargetName")]
                    [Validation(Required=false)]
                    public string TargetName { get; set; }

                    /// <summary>
                    /// <para>The tunnel ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3522367</para>
                    /// </summary>
                    [NameInMap("TunnelId")]
                    [Validation(Required=false)]
                    public long? TunnelId { get; set; }

                    /// <summary>
                    /// <para>The instance type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ReadWrite</b>: primary instance.</description></item>
                    /// <item><description><b>ReadOnly</b>: read-only instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TXT</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the endpoint is visible to the user.</para>
                    /// </summary>
                    [NameInMap("UserVisible")]
                    [Validation(Required=false)]
                    public bool? UserVisible { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-2ze51hh6s8tsjgy19g5eu</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance protected by the policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://100.100.100.200/latest/meta-data">http://100.100.100.200/latest/meta-data</a></para>
                    /// </summary>
                    [NameInMap("Vip")]
                    [Validation(Required=false)]
                    public string Vip { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC in which the endpoint resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1s9j8s4h4uqejp9k2z3</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The VIP port, such as 80, 8080, or 443.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vport</para>
                    /// </summary>
                    [NameInMap("Vport")]
                    [Validation(Required=false)]
                    public long? Vport { get; set; }

                    /// <summary>
                    /// <para>The zone ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>curl uUys2ThR.popscan.xaliyun.com</c></para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <para>The addresses of the origin server.</para>
                /// </summary>
                [NameInMap("RealServer")]
                [Validation(Required=false)]
                public List<DescribeDBInstanceEndpointResponseBodyDataItemsRealServer> RealServer { get; set; }
                public class DescribeDBInstanceEndpointResponseBodyDataItemsRealServer : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the node is enabled. For the compute layer, only the primary zone node is enabled. After a primary/secondary switchover, the standby compute node becomes the primary node. All storage layer nodes are enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("Activated")]
                    [Validation(Required=false)]
                    public bool? Activated { get; set; }

                    /// <summary>
                    /// <para>The instance specification type (specification code).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dds.cs.mid</para>
                    /// </summary>
                    [NameInMap("Class")]
                    [Validation(Required=false)]
                    public string Class { get; set; }

                    /// <summary>
                    /// <para>The IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.29.32.166</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <para>The port number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The replica ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>节点id</para>
                    /// </summary>
                    [NameInMap("ReplicaId")]
                    [Validation(Required=false)]
                    public long? ReplicaId { get; set; }

                    /// <summary>
                    /// <para>The weight of the destination route.</para>
                    /// <list type="bullet">
                    /// <item><description>For VPN gateway instances that support the dual-tunnel mode for IPsec-VPN connections, the weight of the destination route is <b>100</b> by default and has no practical significance.</description></item>
                    /// <item><description>For VPN gateway instances that support the single-tunnel mode for IPsec-VPN connections, the weight represents the priority of the destination route:<list type="bullet">
                    /// <item><description><b>100</b>: high priority. If multiple destination routes have the same destination CIDR block, the IPsec-VPN connection associated with this route serves as the active link.</description></item>
                    /// <item><description><b>0</b>: low priority. If multiple destination routes have the same destination CIDR block, the IPsec-VPN connection associated with this route serves as the standby link.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public long? Weight { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: 100. Default value: If the value is not specified or is less than 10, the default value is 10. If the value is greater than 100, the default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxdds</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
