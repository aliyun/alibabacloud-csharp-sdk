// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyBasedRoutesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// <para>You can specify up to 5 filter conditions at a time.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyBasedRoutesRequestFilter> Filter { get; set; }
        public class DescribeTransitRouterPolicyBasedRoutesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PolicyBasedRouteId</b>: the instance ID of the policy-based routing rule.</description></item>
            /// </list>
            /// <para>By default, multiple filter conditions are evaluated by using the <b>AND</b> operator. A resource is considered a match only if it meets all the filter conditions.</para>
            /// <para>You can specify up to 5 filter conditions at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyBasedRouteId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// <para>Specify the filter value based on <b>Key</b>. You can specify multiple filter values for a single <b>Key</b>. Multiple filter values are evaluated by using the <b>OR</b> operator. A resource is considered a match if it meets any of the filter values.</para>
            /// <para>You can specify up to 5 filter values for a single filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is available.</description></item>
        /// <item><description>If <b>NextToken</b> returns a value, the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The instance ID of the policy-based routing table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptbl-abc123xyz</para>
        /// </summary>
        [NameInMap("PolicyTableId")]
        [Validation(Required=false)]
        public string PolicyTableId { get; set; }

    }

}
