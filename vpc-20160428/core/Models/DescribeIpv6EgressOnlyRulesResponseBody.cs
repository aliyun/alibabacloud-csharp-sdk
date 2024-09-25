// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6EgressOnlyRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the egress-only rules.</para>
        /// </summary>
        [NameInMap("Ipv6EgressOnlyRules")]
        [Validation(Required=false)]
        public DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRules Ipv6EgressOnlyRules { get; set; }
        public class DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRules : TeaModel {
            [NameInMap("Ipv6EgressOnlyRule")]
            [Validation(Required=false)]
            public List<DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRulesIpv6EgressOnlyRule> Ipv6EgressOnlyRule { get; set; }
            public class DescribeIpv6EgressOnlyRulesResponseBodyIpv6EgressOnlyRulesIpv6EgressOnlyRule : TeaModel {
                /// <summary>
                /// <para>The description of the egress-only rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ruledescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the egress-only rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6gw-bp1rhhs9zjlxukc5e****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the instance to which the egress-only rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ipv6Address</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the egress-only rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6py-bp1rr7fq1md8pbb3k****</para>
                /// </summary>
                [NameInMap("Ipv6EgressOnlyRuleId")]
                [Validation(Required=false)]
                public string Ipv6EgressOnlyRuleId { get; set; }

                /// <summary>
                /// <para>The name of the egress-only rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rulename</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the egress-only rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E16671B7-DEA6-48E0-8E9C-41913DAD44DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
