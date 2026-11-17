// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the IPv6 address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv6Address (default): queries an IPv6 instance that has a single IPv6 address.</description></item>
        /// <item><description>IPv6Prefix: queries an IPv6 instance that has an IPv6 prefix.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv6Address</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The instance ID associated with the IPv6 address to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-2ze72wuqj4y3jl4f****</para>
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance associated with the IPv6 address to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EcsInstance</b>: an ECS instance in a VPC.</description></item>
        /// <item><description><b>NetworkInterface</b>: elastic network interface controller (NIC).</description></item>
        /// </list>
        /// <para>This parameter must be used together with AssociatedInstanceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NetworkInterface</para>
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to include inactive order data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): does not include inactive order data.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: includes inactive order data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The IPv6 address to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:153:3921:851c:c435:7b12:1c5f</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 address to query. You can enter up to 20 IPv6 address IDs in each call. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6-2zen5j4axcp5l5qyy****</para>
        /// </summary>
        [NameInMap("Ipv6AddressId")]
        [Validation(Required=false)]
        public string Ipv6AddressId { get; set; }

        /// <summary>
        /// <para>The Internet bandwidth instance ID corresponding to the IPv6 address to query after Internet bandwidth is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6bw-uf6hcyzu65v98v3du****</para>
        /// </summary>
        [NameInMap("Ipv6InternetBandwidthId")]
        [Validation(Required=false)]
        public string Ipv6InternetBandwidthId { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 address to query.</para>
        /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the IPv6 address to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Private</b>: internal network.</para>
        /// </description></item>
        /// <item><description><para><b>Public</b>: Internet.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the IPv6 addresses to query. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the IPv6 gateway belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a managed instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The instance is a managed instance.</description></item>
        /// <item><description><b>false</b>: The instance is not a managed instance.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all instances are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The list of tags. Maximum number of elements: 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeIpv6AddressesRequestTag> Tag { get; set; }
        public class DescribeIpv6AddressesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, you cannot enter an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It must start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunke</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the IPv6 address to query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25navfgbue4g****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the IPv6 address to query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
