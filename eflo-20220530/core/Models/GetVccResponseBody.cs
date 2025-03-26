// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetVccResponseBody : TeaModel {
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
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetVccResponseBodyContent Content { get; set; }
        public class GetVccResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Express Connect circuit access point ID:</para>
            /// <list type="bullet">
            /// <item><description><b>ap-cn-wulanchabu-jn-ts-A</b>: Ulanqab-Jining-A</description></item>
            /// <item><description><b>ap-cn-heyuan-yc-ts-SA127</b>: Heyuan-Yuancheng-A</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ap-cn-wulanchabu-jn-ts-A</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud route information list</para>
            /// </summary>
            [NameInMap("AliyunRouterInfo")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentAliyunRouterInfo> AliyunRouterInfo { get; set; }
            public class GetVccResponseBodyContentAliyunRouterInfo : TeaModel {
                /// <summary>
                /// <para>IPv4 address of Alibaba Cloud-side interconnection</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.248.30</para>
                /// </summary>
                [NameInMap("LocalGatewayIp")]
                [Validation(Required=false)]
                public string LocalGatewayIp { get; set; }

                /// <summary>
                /// <para>Masking</para>
                /// 
                /// <b>Example:</b>
                /// <para>255.255.255.248</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <para>Express Connect circuit ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-0jlof4bphlsnxbdztkvad</para>
                /// </summary>
                [NameInMap("PcId")]
                [Validation(Required=false)]
                public string PcId { get; set; }

                /// <summary>
                /// <para>Lingjun Side Interconnection IPv4 Address</para>
                /// 
                /// <b>Example:</b>
                /// <para>169.254.248.28</para>
                /// </summary>
                [NameInMap("PeerGatewayIp")]
                [Validation(Required=false)]
                public string PeerGatewayIp { get; set; }

                /// <summary>
                /// <para>The ID of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-2ze4i85p6vb9nwcan5xt0</para>
                /// </summary>
                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

                /// <summary>
                /// <para>VLAN ID of the VBR</para>
                /// 
                /// <b>Example:</b>
                /// <para>1042</para>
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

            }

            /// <summary>
            /// <para>Whether Lingjun HUB has been bound to a network instance</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Bound</description></item>
            /// <item><description><b>false</b>: unbound</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AttachErStatus")]
            [Validation(Required=false)]
            public bool? AttachErStatus { get; set; }

            /// <summary>
            /// <para>bandwidth</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The bandwidth of the port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1G</para>
            /// </summary>
            [NameInMap("BandwidthStr")]
            [Validation(Required=false)]
            public string BandwidthStr { get; set; }

            /// <summary>
            /// <para>BGP AS number</para>
            /// 
            /// <b>Example:</b>
            /// <para>45644</para>
            /// </summary>
            [NameInMap("BgpAsn")]
            [Validation(Required=false)]
            public string BgpAsn { get; set; }

            /// <summary>
            /// <para>BGP CIDR block</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.4.0.0/24</para>
            /// </summary>
            [NameInMap("BgpCidr")]
            [Validation(Required=false)]
            public string BgpCidr { get; set; }

            /// <summary>
            /// <para>The ID of the CEN instance; <a href="https://help.aliyun.com/document_detail/181681.html">What is the CEN?</a></para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/468215.htm">DescribeCens</a> to query the information of CEN instances under the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-m2iskbojlvda5w65fp</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>Account to which the CEN belongs</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620939556166279</para>
            /// </summary>
            [NameInMap("CenOwnerId")]
            [Validation(Required=false)]
            public string CenOwnerId { get; set; }

            /// <summary>
            /// <para>Lingjun Network Routing Information List</para>
            /// </summary>
            [NameInMap("CisRouterInfo")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentCisRouterInfo> CisRouterInfo { get; set; }
            public class GetVccResponseBodyContentCisRouterInfo : TeaModel {
                /// <summary>
                /// <para>Leased Line Information List</para>
                /// </summary>
                [NameInMap("CcInfos")]
                [Validation(Required=false)]
                public List<GetVccResponseBodyContentCisRouterInfoCcInfos> CcInfos { get; set; }
                public class GetVccResponseBodyContentCisRouterInfoCcInfos : TeaModel {
                    /// <summary>
                    /// <para>Leased Line ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cc-73aeex5o</para>
                    /// </summary>
                    [NameInMap("CcId")]
                    [Validation(Required=false)]
                    public string CcId { get; set; }

                    /// <summary>
                    /// <para>Lingjun Side Interconnection IPv4 Address</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.248.26</para>
                    /// </summary>
                    [NameInMap("LocalGatewayIp")]
                    [Validation(Required=false)]
                    public string LocalGatewayIp { get; set; }

                    /// <summary>
                    /// <para>Lingjun Side Interconnection IPv4 Address</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.248.30</para>
                    /// </summary>
                    [NameInMap("RemoteGatewayIp")]
                    [Validation(Required=false)]
                    public string RemoteGatewayIp { get; set; }

                    /// <summary>
                    /// <para>The state of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Established</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Subnet mask</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>255.255.255.248</para>
                    /// </summary>
                    [NameInMap("SubnetMask")]
                    [Validation(Required=false)]
                    public string SubnetMask { get; set; }

                    /// <summary>
                    /// <para>Vlan ID of the leased line</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ethernet1042</para>
                    /// </summary>
                    [NameInMap("VlanId")]
                    [Validation(Required=false)]
                    public string VlanId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the on-cloud router instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccr-1ms84am0</para>
                /// </summary>
                [NameInMap("CcrId")]
                [Validation(Required=false)]
                public string CcrId { get; set; }

            }

            /// <summary>
            /// <para>Commodity code</para>
            /// 
            /// <b>Example:</b>
            /// <para>bccluster_cloudconnectionpre_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The connection mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b></description></item>
            /// <item><description><b>CENTR</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CENTR</para>
            /// </summary>
            [NameInMap("ConnectionType")]
            [Validation(Required=false)]
            public string ConnectionType { get; set; }

            /// <summary>
            /// <para>The time when the data address was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Current Node</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxx-node-x</para>
            /// </summary>
            [NameInMap("CurrentNode")]
            [Validation(Required=false)]
            public string CurrentNode { get; set; }

            /// <summary>
            /// <para>Cycle</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>List of bound Lingjun HUB information</para>
            /// </summary>
            [NameInMap("ErInfos")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentErInfos> ErInfos { get; set; }
            public class GetVccResponseBodyContentErInfos : TeaModel {
                /// <summary>
                /// <para>Connections</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678379917000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>this is test.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Lingjun HUB ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-p68b0jwn</para>
                /// </summary>
                [NameInMap("ErId")]
                [Validation(Required=false)]
                public string ErId { get; set; }

                /// <summary>
                /// <para>Lingjun HUB Instance Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>er-1</para>
                /// </summary>
                [NameInMap("ErName")]
                [Validation(Required=false)]
                public string ErName { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1678379917000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Primary Zone</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu-b</para>
                /// </summary>
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }

                /// <summary>
                /// <para>The message that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test message</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Lingjun HUB Region Information</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Number of routing policy</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RouteMaps")]
                [Validation(Required=false)]
                public long? RouteMaps { get; set; }

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
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1620939556166277</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            /// <summary>
            /// <para>The time when the application expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678379917000</para>
            /// </summary>
            [NameInMap("ExpirationDate")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// <para>The time when the agent was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1648085472000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The billing method for network usage.</para>
            /// <list type="bullet">
            /// <item><description><b>PayByTraffic</b>: pay-by-traffic</description></item>
            /// <item><description><b>PayByBandwidth</b>: pay-by-bandwidth</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The connectivity provider of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CO</b>: other connectivity providers in the Chinese mainland</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CO</para>
            /// </summary>
            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            /// <summary>
            /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>You don\&quot;t have the permission of this operation, action=eflo:GetVcc, arn=acs:eflo:cn-heyuan:1263399219805497:vcc/vcc-cn-fhh3yxjwe01, resourceGroup=null</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: subscription</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePay</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The port type of the Express Connect circuit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>100GBase-LR</b>: 100,000 megabytes of single-mode optical port (10 km)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100GBase-LR</para>
            /// </summary>
            [NameInMap("PortType")]
            [Validation(Required=false)]
            public string PortType { get; set; }

            /// <summary>
            /// <para>The billing cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Month</b>: Billed on a monthly basis</description></item>
            /// <item><description><b>Year</b>: Billed on an annual basis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

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
            /// <para>The ID of your Alibaba Cloud resource group.</para>
            /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.htm">Resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2l4sq6l7unhi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Specification; value:</para>
            /// <list type="bullet">
            /// <item><description><b>Large</b>: Large</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Large</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The status of the cache reserve instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: Normal.</description></item>
            /// <item><description><b>Not Available</b>: Not available.</description></item>
            /// <item><description><b>Executing</b>: The task is being executed.</description></item>
            /// <item><description><b>Deleting</b>: The account is being deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag information.</para>
            /// <para>You can specify up to 20 tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentTags> Tags { get; set; }
            public class GetVccResponseBodyContentTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
                /// <para>You can specify at most 20 tag keys in each call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-vcc</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag that is added to the resource.</para>
                /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// <para>Each key-value pair must be unique. You can specify values for at most 20 tag keys in each call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-group-1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620939556166279</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch. <a href="https://help.aliyun.com/document_detail/100380.html">Virtual Private Cloud VSwitch</a>.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query created vSwitches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6u8473r84e6n1n19he5</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>Information list of border routers</para>
            /// </summary>
            [NameInMap("VbrInfos")]
            [Validation(Required=false)]
            public List<GetVccResponseBodyContentVbrInfos> VbrInfos { get; set; }
            public class GetVccResponseBodyContentVbrInfos : TeaModel {
                /// <summary>
                /// <para>CEN ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-cx0qua8q6cm4z9****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1683250981000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1673578603000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The status of the VBR. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>unconfirmed</description></item>
                /// <item><description>active: The VPN gateway is in a normal state.</description></item>
                /// <item><description>terminating: The connection is being terminated.</description></item>
                /// <item><description>terminated: The connection is terminated.</description></item>
                /// <item><description>recovering: The task is being recovered.</description></item>
                /// <item><description>deleting: The GDN is being deleted.</description></item>
                /// <item><description>Available: The service is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>BGP neighbor information list</para>
                /// </summary>
                [NameInMap("VbrBgpPeers")]
                [Validation(Required=false)]
                public List<GetVccResponseBodyContentVbrInfosVbrBgpPeers> VbrBgpPeers { get; set; }
                public class GetVccResponseBodyContentVbrInfosVbrBgpPeers : TeaModel {
                    /// <summary>
                    /// <para>BGP Group ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bgpg-2ze2sit2vakrkapvy****</para>
                    /// </summary>
                    [NameInMap("BgpGroupId")]
                    [Validation(Required=false)]
                    public string BgpGroupId { get; set; }

                    /// <summary>
                    /// <para>BGP peer ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bgp-uf6heugif9enu48rj****</para>
                    /// </summary>
                    [NameInMap("BgpPeerId")]
                    [Validation(Required=false)]
                    public string BgpPeerId { get; set; }

                    /// <summary>
                    /// <para>Peer AS No.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>98765****</para>
                    /// </summary>
                    [NameInMap("PeerAsn")]
                    [Validation(Required=false)]
                    public string PeerAsn { get; set; }

                    /// <summary>
                    /// <para>BGP peer IP address</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>169.254.****</para>
                    /// </summary>
                    [NameInMap("PeerIpAddress")]
                    [Validation(Required=false)]
                    public string PeerIpAddress { get; set; }

                    /// <summary>
                    /// <para>The status of the BGP peer. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Pending: pending</description></item>
                    /// <item><description>Available: The route is available.</description></item>
                    /// <item><description>Modifying: being modified</description></item>
                    /// <item><description>Deleting: The IPv4 gateway is being deleted.</description></item>
                    /// <item><description>Deleted</description></item>
                    /// <item><description>Not Available</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The ID of the border router.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-wz96agu9h3d50z****</para>
                /// </summary>
                [NameInMap("VbrId")]
                [Validation(Required=false)]
                public string VbrId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Lingjun connection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcc-cn-cqf2xh40101</para>
            /// </summary>
            [NameInMap("VccId")]
            [Validation(Required=false)]
            public string VccId { get; set; }

            /// <summary>
            /// <para>The name of the Lingjun connection instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcc-heyuan-backup</para>
            /// </summary>
            [NameInMap("VccName")]
            [Validation(Required=false)]
            public string VccName { get; set; }

            /// <summary>
            /// <para>Virtual Private Cloud IDs; <a href="https://help.aliyun.com/document_detail/34217.html">What is Virtual Private Cloud</a></para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35739.html#demo-0">DescribeVpcs</a> operation to query the specified VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-j6ctp4n75306phv5tmpsm</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Lingjun network segment information (applicable to the scene where the old version of Lingjun connection is directly bound to Lingjun network segment)</para>
            /// </summary>
            [NameInMap("VpdBaseInfo")]
            [Validation(Required=false)]
            public GetVccResponseBodyContentVpdBaseInfo VpdBaseInfo { get; set; }
            public class GetVccResponseBodyContentVpdBaseInfo : TeaModel {
                /// <summary>
                /// <para>Network address segment</para>
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
                /// <para>1678379917000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Lingjun CIDR block instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-ppdunxzc</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>Lingjun CIDR block instance name</para>
                /// 
                /// <b>Example:</b>
                /// <para>yzp-rg-test3</para>
                /// </summary>
                [NameInMap("VpdName")]
                [Validation(Required=false)]
                public string VpdName { get; set; }

            }

            /// <summary>
            /// <para>Lingjun CIDR block instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-d3isyds4</para>
            /// </summary>
            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

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
        /// <para>CAD09E47-B651-5206-B2DC-3AB78C8EB446</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
