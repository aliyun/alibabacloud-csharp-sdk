// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyTablesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// <para>You can specify up to 5 filter conditions at a time.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyTablesRequestFilter> Filter { get; set; }
        public class DescribeTransitRouterPolicyTablesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <para>PolicyTableId: the ID of the Cloud Enterprise Network (CEN) instance.
            /// By default, multiple filter conditions are combined with the AND operator. A resource is considered a match only if it meets all the filter conditions.</para>
            /// <para>You can specify up to 5 filter conditions at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyTableId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// <para>Specify the filter value based on the key. You can specify multiple values for a single key. Multiple values are combined with the OR operator. A resource is considered a match if it meets any of the values.</para>
            /// <para>You can specify up to 5 values for each filter condition.</para>
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
        /// <item><description>If this is the first query or no subsequent query is required, you do not need to specify this parameter.</description></item>
        /// <item><description>If a subsequent query is required, set the value to the NextToken value returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-uf654ttymmljlvh2x****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
