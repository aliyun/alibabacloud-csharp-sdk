// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNatGatewayAssociateNetworkInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the value of <b>RequestId</b> is used.**** The <b>RequestId</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The filter information. You can specify a filter key and a filter value.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeNatGatewayAssociateNetworkInterfacesRequestFilter> Filter { get; set; }
        public class DescribeNatGatewayAssociateNetworkInterfacesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key.</para>
            /// <list type="bullet">
            /// <item><description>ResourceId</description></item>
            /// </list>
            /// <remarks>
            /// <para> Specify the service resource ID in the Value field.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>NetworkInterfaceId</description></item>
            /// </list>
            /// <remarks>
            /// <para> Specify the ENI ID in the Value field.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>ResourceOwnerId</description></item>
            /// </list>
            /// <remarks>
            /// <para> Specify the UID of the account to which the service resource belongs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Separate multiple values with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep-8psre8c8936596cd****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for NetToken, you do not need to specify this parameter.</description></item>
        /// <item><description>If a value is returned for NextToken, you must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Internet NAT gateway.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazdjdhd****</para>
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
        /// <para>The information about resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeNatGatewayAssociateNetworkInterfacesRequestTag> Tag { get; set; }
        public class DescribeNatGatewayAssociateNetworkInterfacesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key You can specify at most 20 tag keys. It cannot be an empty string,</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag key. You can specify at most 20 tag keys. It cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
