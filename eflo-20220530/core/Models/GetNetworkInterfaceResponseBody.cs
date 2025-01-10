// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetNetworkInterfaceResponseBody : TeaModel {
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
        /// <para>The response data. (If a resource has dependent resources, the existing dependent resources are returned.)</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetNetworkInterfaceResponseBodyContent Content { get; set; }
        public class GetNetworkInterfaceResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The time when the data address was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678273219000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Port</para>
            /// </summary>
            [NameInMap("Ethernet")]
            [Validation(Required=false)]
            public List<string> Ethernet { get; set; }

            /// <summary>
            /// <para>Gateway</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.24.20.254</para>
            /// </summary>
            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public string Gateway { get; set; }

            /// <summary>
            /// <para>The IP address of the BE cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.60.69</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>NC Type</para>
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
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("NcType")]
            [Validation(Required=false)]
            public string NcType { get; set; }

            /// <summary>
            /// <para>Lingjun network interface controller ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>lni-f8z4scmfh0u4ewv6vdd8</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>ENI Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>bond0</para>
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>masterintranett2fdth5fkoocg</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Secondary Private IP\&amp;MAC Address Collection</para>
            /// </summary>
            [NameInMap("PrivateIpAddressMacGroup")]
            [Validation(Required=false)]
            public List<GetNetworkInterfaceResponseBodyContentPrivateIpAddressMacGroup> PrivateIpAddressMacGroup { get; set; }
            public class GetNetworkInterfaceResponseBodyContentPrivateIpAddressMacGroup : TeaModel {
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
                /// <para>Secondary private MAC address</para>
                /// 
                /// <b>Example:</b>
                /// <para>01-00-5e-00-00-16</para>
                /// </summary>
                [NameInMap("IpAddressMac")]
                [Validation(Required=false)]
                public string IpAddressMac { get; set; }

                /// <summary>
                /// <para>IP unique identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-xxxx</para>
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
                /// <para>Secondary private IP address</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.23.161.57</para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                /// <summary>
                /// <para>The state of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>network interface controller private secondary IP limit</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>Service network interface controller address</para>
            /// 
            /// <b>Example:</b>
            /// <para>01-00-5e-00-00-16</para>
            /// </summary>
            [NameInMap("ServiceMac")]
            [Validation(Required=false)]
            public string ServiceMac { get; set; }

            /// <summary>
            /// <para>The status of the intervention entry. Valid value:</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Lingjun subnet (Subnet) basic information</para>
            /// </summary>
            [NameInMap("SubnetBaseInfo")]
            [Validation(Required=false)]
            public GetNetworkInterfaceResponseBodyContentSubnetBaseInfo SubnetBaseInfo { get; set; }
            public class GetNetworkInterfaceResponseBodyContentSubnetBaseInfo : TeaModel {
                /// <summary>
                /// <para>Network address segment</para>
                /// 
                /// <b>Example:</b>
                /// <para>116.233.21.57/32</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678273219000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the Subnet instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-urb01blo</para>
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
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655449505171</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>Basic information of Lingjun network segment (VPD)</para>
            /// </summary>
            [NameInMap("VpdBaseInfo")]
            [Validation(Required=false)]
            public GetNetworkInterfaceResponseBodyContentVpdBaseInfo VpdBaseInfo { get; set; }
            public class GetNetworkInterfaceResponseBodyContentVpdBaseInfo : TeaModel {
                /// <summary>
                /// <para>The network segment of the Lingjun subnet.</para>
                /// <list type="bullet">
                /// <item><description>The network segment of the subnet must be a proper subset of the network segment of Lingjun to which it belongs, and the mask must be between 16 bits and 29 bits, which can provide 8 to 65536 addresses. For example, the CIDR block of the Lingjun CIDR block is 192.168.0.0/16, and the CIDR blocks of the subnets under the Lingjun CIDR block are 192.168.0.0/17 to 192.168.0.0/29.</description></item>
                /// <item><description>The first and last three IP addresses of each subnet segment are reserved by the system. For example, the CIDR blocks of the subnet are 192.168.1.0/24,192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255.</description></item>
                /// </list>
                /// <para>For more information about CIDR blocks, see the <a href="https://www.alibabacloud.com/help/doc-detail/40637.htm#title-gu4-uzk-12r">What is CIDR?</a> section in the &quot;Network FAQ&quot; topic.</para>
                /// <para>This parameter is left empty by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.18.0.0/24</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678273219000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the VPD instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-ppdunxzc</para>
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
        /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A88DFED5-24B7-5A3E-87DE-380BF06F3C90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
