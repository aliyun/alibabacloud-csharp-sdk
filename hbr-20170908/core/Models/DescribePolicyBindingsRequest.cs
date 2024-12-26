// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePolicyBindingsRequest : TeaModel {
        /// <summary>
        /// <para>List of data source IDs.</para>
        /// </summary>
        [NameInMap("DataSourceIds")]
        [Validation(Required=false)]
        public List<string> DataSourceIds { get; set; }

        /// <summary>
        /// <para>Query filters.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribePolicyBindingsRequestFilters> Filters { get; set; }
        public class DescribePolicyBindingsRequestFilters : TeaModel {
            /// <summary>
            /// <para>Key in the query filter. Possible values include:</para>
            /// <list type="bullet">
            /// <item><description><b>PolicyId</b>: Backup policy ID</description></item>
            /// <item><description><b>DataSourceId</b>: ECS instance ID</description></item>
            /// <item><description><b>DataSourceType</b>: Data source type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataSourceType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Matching method. Default is IN. This refers to the matching operation (Operator) supported by the Key and Value in the filter. Possible values include:</para>
            /// <list type="bullet">
            /// <item><description><b>EQUAL</b>: Equal to</description></item>
            /// <item><description><b>NOT_EQUAL</b>: Not equal to</description></item>
            /// <item><description><b>GREATER_THAN</b>: Greater than</description></item>
            /// <item><description><b>GREATER_THAN_OR_EQUAL</b>: Greater than or equal to</description></item>
            /// <item><description><b>LESS_THAN</b>: Less than</description></item>
            /// <item><description><b>LESS_THAN_OR_EQUAL</b>: Less than or equal to</description></item>
            /// <item><description><b>BETWEEN</b>: Range, where value is a JSON array <c>[lower_bound, upper_bound]</c>.</description></item>
            /// <item><description><b>IN</b>: In the set, where value is an array.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>Values to be matched in the query filter.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>Number of results per query.</para>
        /// <para>Range: 10~100. Default: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token required to fetch the next page of policy and data source associations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************hky</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Data source type. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: Indicates ECS full machine backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UDM_ECS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
