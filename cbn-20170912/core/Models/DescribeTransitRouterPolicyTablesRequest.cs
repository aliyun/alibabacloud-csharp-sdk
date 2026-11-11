// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyTablesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions. You can specify up to 5 filter conditions at a time.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyTablesRequestFilter> Filter { get; set; }
        public class DescribeTransitRouterPolicyTablesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <para>PolicyTableId: the ID of the Cloud Enterprise Network (CEN) instance.
            /// By default, multiple filter conditions are evaluated by using the AND operator. A result is returned only if all filter conditions are met.</para>
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
            /// <para>Specify the value based on the key. You can specify multiple values for a key. Multiple values are evaluated by using the OR operator. If one of the values is met, the filter condition is met.</para>
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
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <para>If this is your first query or no next query is to be sent, ignore this parameter.
        /// If a next query is to be sent, set the value to the NextToken value that is returned from the last API invocation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyTablesRequestTag> Tag { get; set; }
        public class DescribeTransitRouterPolicyTablesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
