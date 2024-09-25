// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesRequest : TeaModel {
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the instance that is assigned the IPv6 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze72wuqj4y3jl4f****</para>
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of instance associated with the IPv6 address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EcsInstance</b>: Elastic Compute Service (ECS) instance in a virtual private cloud (VPC)</description></item>
        /// <item><description><b>NetworkInterface</b>: secondary elastic network interface (ENI)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about pending orders. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// <para>The IPv6 address that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:153:3921:851c:c435:7b12:1c5f</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 address that you want to query. You can enter at most 20 IPv6 address IDs in each API request. Separate IPv6 address IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6-2zen5j4axcp5l5qyy****</para>
        /// </summary>
        [NameInMap("Ipv6AddressId")]
        [Validation(Required=false)]
        public string Ipv6AddressId { get; set; }

        /// <summary>
        /// <para>The ID of the Internet bandwidth that you purchased for the IPv6 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6bw-uf6hcyzu65v98v3du****</para>
        /// </summary>
        [NameInMap("Ipv6InternetBandwidthId")]
        [Validation(Required=false)]
        public string Ipv6InternetBandwidthId { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 address that you want to query.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of communication supported by the IPv6 address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Private</b></description></item>
        /// <item><description><b>Public</b></description></item>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you want to query IPv6 addresses. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>Indicates whether the instance is managed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeIpv6AddressesRequestTag> Tag { get; set; }
        public class DescribeIpv6AddressesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N.</para>
            /// <para>The tag value can be up to 128 characters in length. It can be an empty string. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify at most 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunke</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the IPv6 address belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25navfgbue4g****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the IPv6 address belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
