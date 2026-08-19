// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePolicyBindingsRequest : TeaModel {
        /// <summary>
        /// <para>The list of data source IDs.</para>
        /// </summary>
        [NameInMap("DataSourceIds")]
        [Validation(Required=false)]
        public List<string> DataSourceIds { get; set; }

        /// <summary>
        /// <para>The query filters.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribePolicyBindingsRequestFilters> Filters { get; set; }
        public class DescribePolicyBindingsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key in the query filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PolicyId</b>: backup policy ID</description></item>
            /// <item><description><b>DataSourceId</b>: ECS instance ID</description></item>
            /// <item><description><b>DataSourceType</b>: data source type</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataSourceType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method. Default value: IN. The matching operation (Operator) supported by the Key and Value in the filter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EQUAL</b>: equal to</description></item>
            /// <item><description><b>NOT_EQUAL</b>: not equal to</description></item>
            /// <item><description><b>GREATER_THAN</b>: greater than</description></item>
            /// <item><description><b>GREATER_THAN_OR_EQUAL</b>: greater than or equal to</description></item>
            /// <item><description><b>LESS_THAN</b>: less than</description></item>
            /// <item><description><b>LESS_THAN_OR_EQUAL</b>: less than or equal to</description></item>
            /// <item><description><b>BETWEEN</b>: range. The value is a JSON array <c>[lower bound, upper bound]</c>.</description></item>
            /// <item><description><b>IN</b>: in a set. The value is an array.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The values to match in the query filter.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token required to obtain the next page of policy-data source associations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************hky</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: ECS instance backup.</description></item>
        /// <item><description><b>OSS</b>: OSS backup.</description></item>
        /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup.</description></item>
        /// <item><description><b>COMMON_NAS</b>: On-premises NAS backup.</description></item>
        /// <item><description><b>ECS_FILE</b>: ECS File Backup Essential Edition.</description></item>
        /// <item><description><b>File</b>: On-premises file backup.</description></item>
        /// <item><description><b>COMMON_FILE_SYSTEM</b>: CPFS backup.</description></item>
        /// <item><description><b>OTS</b>: Tablestore backup.</description></item>
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
