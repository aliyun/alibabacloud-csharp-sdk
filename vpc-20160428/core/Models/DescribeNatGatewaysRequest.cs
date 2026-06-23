// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewaysRequest : TeaModel {
        [NameInMap("AvailabilityMode")]
        [Validation(Required=false)]
        public string AvailabilityMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without querying resource status. The check items include whether the AccessKey pair is valid, whether the RAM user is authorized, and whether required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a normal request. After the check succeeds, a 2xx HTTP status code is returned and the resource status is queried directly.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The billing method of the NAT gateway instance to query. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>PrePaid</b>: the legacy subscription billing method. The subscription billing method is no longer available for new purchases.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;The billing method of the NAT gateway instance to query. Valid value: <b>PostPaid</b> (pay-as-you-go).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the NAT gateway to query.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway. Valid value: <b>Enhanced</b> (enhanced NAT gateway).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enhanced</para>
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// <para>The type of the NAT gateway to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: Internet NAT gateway.</description></item>
        /// <item><description><b>intranet</b>: VPC NAT gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paginated queries. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway to query.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the NAT gateway to query belongs.</para>
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
        /// <para>&lt;props=&quot;china&quot;&gt;The specification of the Internet NAT gateway. Only when <b>InstanceChargeType</b> is <b>PrePaid</b> (legacy subscription Internet NAT gateway), creating a NAT gateway by fixed specification is supported. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>Small</b> (default): small.</description></item>
        /// <item><description><b>Middle</b>: medium.</description></item>
        /// <item><description><b>Large</b>: large.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;The specification of the NAT gateway. Leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国站示例值：Small，国际站示例值：无需填写</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The status of the NAT gateway to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: Creating a NAT gateway is an asynchronous operation. The status is <b>Creating</b> before the creation is complete.</para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: The status after the NAT gateway is created. This is a stable status.</para>
        /// </description></item>
        /// <item><description><para><b>Modifying</b>: Modifying a NAT gateway is an asynchronous operation. The status is <b>Modifying</b> during the modification process.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: Deleting a NAT gateway is an asynchronous operation. The status is <b>Deleting</b> during the deletion process.</para>
        /// </description></item>
        /// <item><description><para><b>Converting</b>: Converting a standard NAT gateway to an enhanced NAT gateway is an asynchronous operation. The status is <b>Converting</b> during the conversion process.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeNatGatewaysRequestTag> Tag { get; set; }
        public class DescribeNatGatewaysRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the NAT gateway instance. You can specify up to 20 tag keys.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the NAT gateway instance. You can specify up to 20 tag values.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the NAT gateway to query belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72z****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the NAT gateway is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
