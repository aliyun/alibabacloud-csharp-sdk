// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListNetworkInterfacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListNetworkInterfacesResponseBodyContent Content { get; set; }
        public class ListNetworkInterfacesResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The response parameters.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListNetworkInterfacesResponseBodyContentData> Data { get; set; }
            public class ListNetworkInterfacesResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>The time when the activation code was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1669734207000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The port number of the AD server.</para>
                /// </summary>
                [NameInMap("Ethernet")]
                [Validation(Required=false)]
                public List<string> Ethernet { get; set; }

                /// <summary>
                /// <para>The gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.253</para>
                /// </summary>
                [NameInMap("Gateway")]
                [Validation(Required=false)]
                public string Gateway { get; set; }

                /// <summary>
                /// <para>The IP address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.13</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The NC type.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM_LNI_INTEGRATION: two-network one-in-one architecture Lingjun hosting network interface controller.</description></item>
                /// <item><description>CPU: CPU machine.</description></item>
                /// <item><description>ELASTIC_6.2: Machine</description></item>
                /// <item><description>GPU: GPU machine.</description></item>
                /// <item><description>DEFAULT: the old CPU machine.</description></item>
                /// <item><description>CUSTOM_LNI: two network separation architecture Lingjun hosting network interface controller.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GPU</para>
                /// </summary>
                [NameInMap("NcType")]
                [Validation(Required=false)]
                public string NcType { get; set; }

                /// <summary>
                /// <para>Lingjun network interface controller ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lni-2ze50voovmtswn328ogm</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The port name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bond0</para>
                /// </summary>
                [NameInMap("NetworkInterfaceName")]
                [Validation(Required=false)]
                public string NetworkInterfaceName { get; set; }

                /// <summary>
                /// <para>The ID of the machine to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2d53f5c204e7476dae69177e7fa6f19c</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Secondary Private IP\&amp;MAC Address Collection</para>
                /// </summary>
                [NameInMap("PrivateIpAddressMacGroup")]
                [Validation(Required=false)]
                public List<ListNetworkInterfacesResponseBodyContentDataPrivateIpAddressMacGroup> PrivateIpAddressMacGroup { get; set; }
                public class ListNetworkInterfacesResponseBodyContentDataPrivateIpAddressMacGroup : TeaModel {
                    /// <summary>
                    /// <para>The instance description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Secondary private MAC address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:25:9d:00:20:20</para>
                    /// </summary>
                    [NameInMap("IpAddressMac")]
                    [Validation(Required=false)]
                    public string IpAddressMac { get; set; }

                    /// <summary>
                    /// <para>The unique IP identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sip-1asjd3xg</para>
                    /// </summary>
                    [NameInMap("IpName")]
                    [Validation(Required=false)]
                    public string IpName { get; set; }

                    /// <summary>
                    /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The secondary private IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.14</para>
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public string PrivateIpAddress { get; set; }

                    /// <summary>
                    /// <para>The status of the cache reserve instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>network interface controller private secondary IP quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Quota")]
                [Validation(Required=false)]
                public int? Quota { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The address of the service network interface controller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00-ff-84-15-ba-67</para>
                /// </summary>
                [NameInMap("ServiceMac")]
                [Validation(Required=false)]
                public string ServiceMac { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Lingjun subnet (Subnet) basic information.</para>
                /// </summary>
                [NameInMap("SubnetBaseInfo")]
                [Validation(Required=false)]
                public ListNetworkInterfacesResponseBodyContentDataSubnetBaseInfo SubnetBaseInfo { get; set; }
                public class ListNetworkInterfacesResponseBodyContentDataSubnetBaseInfo : TeaModel {
                    /// <summary>
                    /// <para>The network segment of the Subnet.</para>
                    /// <list type="bullet">
                    /// <item><description>The network segment of the subnet must be a proper subset of the network segment of Lingjun to which it belongs, and the mask must be between 16 bits and 29 bits, which can provide 8 to 65536 addresses. For example, the CIDR block of the Lingjun CIDR block is 192.168.0.0/16, and the CIDR blocks of the subnets under the Lingjun CIDR block are 192.168.0.0/17 to 192.168.0.0/29.</description></item>
                    /// <item><description>The first and last three IP addresses of each subnet segment are reserved by the system. For example, the CIDR blocks of the subnet are 192.168.1.0/24,192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255.</description></item>
                    /// </list>
                    /// <para>For more information about CIDR blocks, see the <a href="https://www.alibabacloud.com/help/doc-detail/40637.htm#title-gu4-uzk-12r">What is CIDR?</a> section in the &quot;Network FAQ&quot; topic.</para>
                    /// <para>This parameter is left empty by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.0/24</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The time when the activation code was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1623656472000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the Subnet instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-yjnqn5ef</para>
                    /// </summary>
                    [NameInMap("SubnetId")]
                    [Validation(Required=false)]
                    public string SubnetId { get; set; }

                    /// <summary>
                    /// <para>The name of the Subnet instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-1</para>
                    /// </summary>
                    [NameInMap("SubnetName")]
                    [Validation(Required=false)]
                    public string SubnetName { get; set; }

                }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166279</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>Lingjun network segment (VPD) basic information.</para>
                /// </summary>
                [NameInMap("VpdBaseInfo")]
                [Validation(Required=false)]
                public ListNetworkInterfacesResponseBodyContentDataVpdBaseInfo VpdBaseInfo { get; set; }
                public class ListNetworkInterfacesResponseBodyContentDataVpdBaseInfo : TeaModel {
                    /// <summary>
                    /// <para>The network segment of Lingjun network segment (VPD).</para>
                    /// <list type="bullet">
                    /// <item><description>We recommend that you use an RFC private endpoint as the Lingjun CIDR block, such as 10.0.0.0/8,172.16.0.0/12,192.168.0.0/16. In scenarios where the Doringjun CIDR block is connected to each other or where the Lingjun CIDR block is connected to a VPC, make sure that the addresses do not conflict with each other.</description></item>
                    /// <item><description>You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 and their subnets as the primary IPv4 CIDR block of the VPD. This parameter is left empty by default.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.0.0/16</para>
                    /// </summary>
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    /// <summary>
                    /// <para>The time when the activation code was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1668158213000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPD instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpd-d3isyds4</para>
                    /// </summary>
                    [NameInMap("VpdId")]
                    [Validation(Required=false)]
                    public string VpdId { get; set; }

                    /// <summary>
                    /// <para>The name of the VPD instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpd-1</para>
                    /// </summary>
                    [NameInMap("VpdName")]
                    [Validation(Required=false)]
                    public string VpdName { get; set; }

                }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>039C3C3A-3C37-5672-80D5-D8CD48C676D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
