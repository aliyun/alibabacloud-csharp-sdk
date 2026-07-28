// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorsRequest : TeaModel {
        /// <summary>
        /// <para>The IPv4 address allocated to the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.99.XX.XX</para>
        /// </summary>
        [NameInMap("AllocateIpv4Addr")]
        [Validation(Required=false)]
        public string AllocateIpv4Addr { get; set; }

        /// <summary>
        /// <para>The IPv6 address allocated to the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2400:3200:1600::XXXX</para>
        /// </summary>
        [NameInMap("AllocateIpv6Addr")]
        [Validation(Required=false)]
        public string AllocateIpv6Addr { get; set; }

        /// <summary>
        /// <para>The business status of the IPv6 Translation Service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: normal.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: locked.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6trans-bp1858ys****</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorId { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in paging query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing transform type of the IPv6 Translation Service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Prepay</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>Postpay</b>: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region of the IPv6 Translation Service instance. You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The specification of the IPv6 Translation Service instance. Valid values: <b>small</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>small</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The status of the IPv6 Translation Service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>init</b>: initializing.</para>
        /// </description></item>
        /// <item><description><para><b>provisioning</b>: being provisioned.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: available.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: being updated.</para>
        /// </description></item>
        /// <item><description><para><b>upgrading</b>: being upgraded.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>deleted</b>: deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
