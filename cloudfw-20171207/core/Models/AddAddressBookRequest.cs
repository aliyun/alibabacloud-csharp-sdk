// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The ACK cluster connector ID. You can obtain the value from the following operation:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a>: Lists ACK cluster connectors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ac-7c1bad6c3cc84c33baab1</para>
        /// </summary>
        [NameInMap("AckClusterConnectorId")]
        [Validation(Required=false)]
        public string AckClusterConnectorId { get; set; }

        /// <summary>
        /// <para>The list of ACK cluster pod labels.</para>
        /// <remarks>
        /// <para>A maximum of 10 labels are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckLabels")]
        [Validation(Required=false)]
        public List<AddAddressBookRequestAckLabels> AckLabels { get; set; }
        public class AddAddressBookRequestAckLabels : TeaModel {
            /// <summary>
            /// <para>The key of the ACK cluster pod label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the ACK cluster pod label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage-operator</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of ACK cluster pod namespaces.</para>
        /// <remarks>
        /// <para>A maximum of 10 namespaces are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckNamespaces")]
        [Validation(Required=false)]
        public List<string> AckNamespaces { get; set; }

        /// <summary>
        /// <para>The addresses in the address book. Separate multiple addresses with commas (,). Use a space to separate an address from its description within a single address element.</para>
        /// <remarks>
        /// <para>This parameter is required when GroupType is set to <c>ip</c>, <c>port</c>, or <c>domain</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When GroupType is set to <c>ip</c>, enter IP addresses in the address list. Example: 192.0.XX.XX/32 Development CIDR block,10.0.0.X/24,192.0.XX.XX/24 Test CIDR block.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is set to <c>port</c>, enter ports or port ranges in the address list. Example: 80 HTTP port,100/200,3306 Database port.</para>
        /// </description></item>
        /// <item><description><para>When GroupType is set to <c>domain</c>, enter domain names in the address list. Example: example.com Test domain name,aliyundoc.com,<a href="http://www.aliyun.com">www.aliyun.com</a> Alibaba Cloud official website.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX/32 ,192.0.XX.XX/24</para>
        /// </summary>
        [NameInMap("AddressList")]
        [Validation(Required=false)]
        public string AddressList { get; set; }

        /// <summary>
        /// <para>The list of member accounts for the asset address book.</para>
        /// </summary>
        [NameInMap("AssetMemberUids")]
        [Validation(Required=false)]
        public List<long?> AssetMemberUids { get; set; }

        /// <summary>
        /// <para>The list of regions and resource types for the asset address book.</para>
        /// </summary>
        [NameInMap("AssetRegionResourceTypes")]
        [Validation(Required=false)]
        public List<AddAddressBookRequestAssetRegionResourceTypes> AssetRegionResourceTypes { get; set; }
        public class AddAddressBookRequestAssetRegionResourceTypes : TeaModel {
            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("AssetRegionId")]
            [Validation(Required=false)]
            public string AssetRegionId { get; set; }

            /// <summary>
            /// <para>The asset type.</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public AddAddressBookRequestAssetRegionResourceTypesResourceType ResourceType { get; set; }
            public class AddAddressBookRequestAssetRegionResourceTypesResourceType : TeaModel {
                /// <summary>
                /// <para>The IPv4 asset type.</para>
                /// </summary>
                [NameInMap("Ipv4")]
                [Validation(Required=false)]
                public AddAddressBookRequestAssetRegionResourceTypesResourceTypeIpv4 Ipv4 { get; set; }
                public class AddAddressBookRequestAssetRegionResourceTypesResourceTypeIpv4 : TeaModel {
                    /// <summary>
                    /// <para>The asset type: AIGatewayEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AiGatewayEIP")]
                    [Validation(Required=false)]
                    public bool? AiGatewayEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: AlbEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AlbEIP")]
                    [Validation(Required=false)]
                    public bool? AlbEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: ApigEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ApiGatewayEIP")]
                    [Validation(Required=false)]
                    public bool? ApiGatewayEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: BastionHostEgressIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BastionHostEgressIP")]
                    [Validation(Required=false)]
                    public bool? BastionHostEgressIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: BastionHostIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BastionHostIP")]
                    [Validation(Required=false)]
                    public bool? BastionHostIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: BastionHostIngressIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BastionHostIngressIP")]
                    [Validation(Required=false)]
                    public bool? BastionHostIngressIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: EIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EIP")]
                    [Validation(Required=false)]
                    public bool? EIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: EcsEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EcsEIP")]
                    [Validation(Required=false)]
                    public bool? EcsEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: EcsPublicIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EcsPublicIP")]
                    [Validation(Required=false)]
                    public bool? EcsPublicIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: EniEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EniEIP")]
                    [Validation(Required=false)]
                    public bool? EniEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: GaEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("GaEIP")]
                    [Validation(Required=false)]
                    public bool? GaEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: HAVIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HAVIP")]
                    [Validation(Required=false)]
                    public bool? HAVIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: NatEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NatEIP")]
                    [Validation(Required=false)]
                    public bool? NatEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: NatPublicIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NatPublicIP")]
                    [Validation(Required=false)]
                    public bool? NatPublicIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: NlbEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NlbEIP")]
                    [Validation(Required=false)]
                    public bool? NlbEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: SlbEIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SlbEIP")]
                    [Validation(Required=false)]
                    public bool? SlbEIP { get; set; }

                    /// <summary>
                    /// <para>The asset type: SlbPublicIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SlbPublicIP")]
                    [Validation(Required=false)]
                    public bool? SlbPublicIP { get; set; }

                }

                /// <summary>
                /// <para>The IPv6 asset type.</para>
                /// </summary>
                [NameInMap("Ipv6")]
                [Validation(Required=false)]
                public AddAddressBookRequestAssetRegionResourceTypesResourceTypeIpv6 Ipv6 { get; set; }
                public class AddAddressBookRequestAssetRegionResourceTypesResourceTypeIpv6 : TeaModel {
                    /// <summary>
                    /// <para>The asset type: AIGatewayEIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AiGatewayEIPv6")]
                    [Validation(Required=false)]
                    public bool? AiGatewayEIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: AlbIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AlbIPv6")]
                    [Validation(Required=false)]
                    public bool? AlbIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: ApigEIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ApiGatewayEIPv6")]
                    [Validation(Required=false)]
                    public bool? ApiGatewayEIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: EcsIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EcsIPv6")]
                    [Validation(Required=false)]
                    public bool? EcsIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: EniEIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EniEIPv6")]
                    [Validation(Required=false)]
                    public bool? EniEIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: GaEIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("GaEIPv6")]
                    [Validation(Required=false)]
                    public bool? GaEIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: NlbIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NlbIPv6")]
                    [Validation(Required=false)]
                    public bool? NlbIPv6 { get; set; }

                    /// <summary>
                    /// <para>The asset type: SlbIPv6.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SlbIPv6")]
                    [Validation(Required=false)]
                    public bool? SlbIPv6 { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether to automatically add the public IP addresses of Elastic Compute Service (ECS) instances that match the specified tags to the address book.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoAddTagEcs")]
        [Validation(Required=false)]
        public string AutoAddTagEcs { get; set; }

        /// <summary>
        /// <para>The description of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sz-001</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sz-001</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The type of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The language type of the address book description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ECS tag list.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<AddAddressBookRequestTagList> TagList { get; set; }
        public class AddAddressBookRequestTagList : TeaModel {
            /// <summary>
            /// <para>The key of the ECS tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TXY</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The value of the ECS tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The logical relationship among multiple ECS tags to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
