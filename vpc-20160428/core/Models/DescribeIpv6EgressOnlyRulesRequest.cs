// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6EgressOnlyRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance that is associated with the IPv6 address to which the egress-only rule is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6gw-bp1rhhs9zjlxukc5e****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance to which you want to apply the egress-only rule. Set the value to</para>
        /// <para><b>Ipv6Address</b>, which specifies that the egress-only rule applies to an IPv6 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ipv6Address</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the egress-only rule that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6py-bp1rr7fq1md8pbb3k****</para>
        /// </summary>
        [NameInMap("Ipv6EgressOnlyRuleId")]
        [Validation(Required=false)]
        public string Ipv6EgressOnlyRuleId { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6gw-bp1rhhs9zjlxukc5e****</para>
        /// </summary>
        [NameInMap("Ipv6GatewayId")]
        [Validation(Required=false)]
        public string Ipv6GatewayId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rulename</para>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the IPv6 gateway is deployed. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
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

    }

}
