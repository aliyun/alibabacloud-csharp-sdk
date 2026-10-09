// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The list of pod labels in the ACK cluster.</para>
        /// <remarks>
        /// <para>A maximum of 10 labels are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckLabels")]
        [Validation(Required=false)]
        public List<ModifyAddressBookRequestAckLabels> AckLabels { get; set; }
        public class ModifyAddressBookRequestAckLabels : TeaModel {
            /// <summary>
            /// <para>The key of the pod label in the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the pod label in the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>storage-operator</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of pod namespaces in the ACK cluster.</para>
        /// <remarks>
        /// <para>A maximum of 10 namespaces are supported.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AckNamespaces")]
        [Validation(Required=false)]
        public List<string> AckNamespaces { get; set; }

        /// <summary>
        /// <para>The list of addresses in the address book. Separate multiple addresses with commas (,). For each address element, separate the address and the description with a space. You must specify this parameter when GroupType is set to <b>ip</b>, <b>port</b>, or <b>domain</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If GroupType is set to <b>ip</b>, enter IP addresses in the address list. Example: 1.2.XX.XX/32 Development CIDR block,10.0.0.X/24,1.2.XX.XX/24 Test CIDR block.</para>
        /// </description></item>
        /// <item><description><para>If GroupType is set to <b>port</b>, enter ports or port ranges in the address list. Example: 80/80 HTTP port,100/200,3306 Database port.</para>
        /// </description></item>
        /// <item><description><para>If GroupType is set to <b>domain</b>, enter domain names in the address list. Example: demo1.aliyun.com Test domain name,demo2.aliyun.com,<a href="http://www.aliyun.com">www.aliyun.com</a> Alibaba Cloud official website.</para>
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
        /// <para>The list of member accounts in the asset address book.</para>
        /// </summary>
        [NameInMap("AssetMemberUids")]
        [Validation(Required=false)]
        public List<long?> AssetMemberUids { get; set; }

        /// <summary>
        /// <para>The asset address book, region, and resource type list.</para>
        /// </summary>
        [NameInMap("AssetRegionResourceTypes")]
        [Validation(Required=false)]
        public List<ModifyAddressBookRequestAssetRegionResourceTypes> AssetRegionResourceTypes { get; set; }
        public class ModifyAddressBookRequestAssetRegionResourceTypes : TeaModel {
            /// <summary>
            /// <para>The asset region ID.</para>
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
            public ModifyAddressBookRequestAssetRegionResourceTypesResourceType ResourceType { get; set; }
            public class ModifyAddressBookRequestAssetRegionResourceTypesResourceType : TeaModel {
                /// <summary>
                /// <para>The IPv4 asset type.</para>
                /// </summary>
                [NameInMap("Ipv4")]
                [Validation(Required=false)]
                public ModifyAddressBookRequestAssetRegionResourceTypesResourceTypeIpv4 Ipv4 { get; set; }
                public class ModifyAddressBookRequestAssetRegionResourceTypesResourceTypeIpv4 : TeaModel {
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
                public ModifyAddressBookRequestAssetRegionResourceTypesResourceTypeIpv6 Ipv6 { get; set; }
                public class ModifyAddressBookRequestAssetRegionResourceTypesResourceTypeIpv6 : TeaModel {
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
        /// <para>Specifies if the automatic addition of the public IP addresses of Elastic Compute Service (ECS) instances that match the new labels to the address book is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoAddTagEcs")]
        [Validation(Required=false)]
        public string AutoAddTagEcs { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddadxefexxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj-001</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The dry run mode.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the address book.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj-001</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The UUID of the address book.</para>
        /// <remarks>
        /// <para>To obtain the value, call the <a href="~~DescribeAddressBook~~">DescribeAddressBook</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0657ab9d-fe8b-4174-b2a6-6baf358e****</para>
        /// </summary>
        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// <para>The language type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The modification mode.</para>
        /// <remarks>
        /// <para>If GroupType is set to <b>ip</b>, <b>ipv6</b>, <b>port</b>, or <b>domain</b> and this parameter is not specified, the <b>Cover</b> mode is used by default to modify the address book.
        /// Notice: If GroupType is set to <b>tag</b>, this parameter must be left empty.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The list of ECS tags.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ModifyAddressBookRequestTagList> TagList { get; set; }
        public class ModifyAddressBookRequestTagList : TeaModel {
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
        /// <para>The relationship between multiple ECS tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("TagRelation")]
        [Validation(Required=false)]
        public string TagRelation { get; set; }

    }

}
