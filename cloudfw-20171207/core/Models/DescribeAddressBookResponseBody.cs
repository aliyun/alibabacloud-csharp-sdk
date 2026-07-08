// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of address books.</para>
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<DescribeAddressBookResponseBodyAcls> Acls { get; set; }
        public class DescribeAddressBookResponseBodyAcls : TeaModel {
            /// <summary>
            /// <para>The ID of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-7c1bad6c3cc84c33baab</para>
            /// </summary>
            [NameInMap("AckClusterConnectorId")]
            [Validation(Required=false)]
            public string AckClusterConnectorId { get; set; }

            /// <summary>
            /// <para>The name of the ACK cluster connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-cluster-connector-name</para>
            /// </summary>
            [NameInMap("AckClusterConnectorName")]
            [Validation(Required=false)]
            public string AckClusterConnectorName { get; set; }

            /// <summary>
            /// <para>The list of pod labels in the ACK cluster.</para>
            /// </summary>
            [NameInMap("AckLabels")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsAckLabels> AckLabels { get; set; }
            public class DescribeAddressBookResponseBodyAclsAckLabels : TeaModel {
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
            /// </summary>
            [NameInMap("AckNamespaces")]
            [Validation(Required=false)]
            public List<string> AckNamespaces { get; set; }

            /// <summary>
            /// <para>The address list of the address book.</para>
            /// </summary>
            [NameInMap("AddressList")]
            [Validation(Required=false)]
            public List<string> AddressList { get; set; }

            /// <summary>
            /// <para>The number of addresses in the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AddressListCount")]
            [Validation(Required=false)]
            public int? AddressListCount { get; set; }

            /// <summary>
            /// <para>The address list of the address book that includes descriptions for individual addresses.</para>
            /// </summary>
            [NameInMap("Addresses")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsAddresses> Addresses { get; set; }
            public class DescribeAddressBookResponseBodyAclsAddresses : TeaModel {
                /// <summary>
                /// <para>The address information of the address book.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.1/32</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The description of the individual address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Single Address Description</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

            }

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
            public List<DescribeAddressBookResponseBodyAclsAssetRegionResourceTypes> AssetRegionResourceTypes { get; set; }
            public class DescribeAddressBookResponseBodyAclsAssetRegionResourceTypes : TeaModel {
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
                public DescribeAddressBookResponseBodyAclsAssetRegionResourceTypesResourceType ResourceType { get; set; }
                public class DescribeAddressBookResponseBodyAclsAssetRegionResourceTypesResourceType : TeaModel {
                    /// <summary>
                    /// <para>The IPv4 asset type.</para>
                    /// </summary>
                    [NameInMap("Ipv4")]
                    [Validation(Required=false)]
                    public DescribeAddressBookResponseBodyAclsAssetRegionResourceTypesResourceTypeIpv4 Ipv4 { get; set; }
                    public class DescribeAddressBookResponseBodyAclsAssetRegionResourceTypesResourceTypeIpv4 : TeaModel {
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
                    public DescribeAddressBookResponseBodyAclsAssetRegionResourceTypesResourceTypeIpv6 Ipv6 { get; set; }
                    public class DescribeAddressBookResponseBodyAclsAssetRegionResourceTypesResourceTypeIpv6 : TeaModel {
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
            /// <para>Indicates whether the public IP addresses of ECS instances that match new tags are automatically added to the address book. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The public IP addresses are not automatically added.</description></item>
            /// <item><description><b>1</b>: The public IP addresses are automatically added.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoAddTagEcs")]
            [Validation(Required=false)]
            public int? AutoAddTagEcs { get; set; }

            /// <summary>
            /// <para>The description of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_address_book</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The unique ID of the address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f04ac7ce-628b-4cb7-be61-310222b7****</para>
            /// </summary>
            [NameInMap("GroupUuid")]
            [Validation(Required=false)]
            public string GroupUuid { get; set; }

            /// <summary>
            /// <para>The number of times the address book is referenced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            /// <summary>
            /// <para>The region of the ACK cluster connector to which the address book belongs when GroupType is an ACK address book.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The list of ECS tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeAddressBookResponseBodyAclsTagList> TagList { get; set; }
            public class DescribeAddressBookResponseBodyAclsTagList : TeaModel {
                /// <summary>
                /// <para>The key of the ECS tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>company</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the ECS tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL VALUE</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The relationship between multiple ECS tags. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>or</b>: The relationship between multiple tags is OR. The public IP address of an ECS instance that matches any tag is added to the address book.</description></item>
            /// <item><description><b>and</b>: The relationship between multiple tags is AND. The public IP address of an ECS instance that matches all tags is added to the address book.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("TagRelation")]
            [Validation(Required=false)]
            public string TagRelation { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of address books on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B36F150A-1E27-43AA-B72C-D2AC712F09DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of address books.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
