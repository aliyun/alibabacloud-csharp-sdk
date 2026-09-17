// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternCompareReportsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-2ze1234567890****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The number of rows per page for token-based pagination. Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you use <c>NextToken</c> for pagination, keep this parameter unchanged.</description></item>
        /// <item><description>This parameter does not take effect when you use <c>PageNumber</c> and <c>PageSize</c> for pagination.</description></item>
        /// <item><description>We recommend that you use <c>PageNumber</c> and <c>PageSize</c> for pagination.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Do not specify this parameter for the first query. For subsequent queries, pass in the <c>NextToken</c> value returned by the previous query.</description></item>
        /// <item><description>Do not use this parameter together with <c>PageNumber</c> or <c>PageSize</c>.</description></item>
        /// <item><description>Use <c>PageNumber</c> and <c>PageSize</c> for pagination.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>djE6Mjo1MA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Sorts the query results by a specified field. The value is a JSON array string, for example, <c>[{&quot;Field&quot;:&quot;CreatedAt&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</c>. The array can contain only one object. Fields:</para>
        /// <list type="bullet">
        /// <item><description><c>Field</c>: the field by which to sort. Valid values:<list type="bullet">
        /// <item><description><c>CreatedAt</c>: the time when the report was created.</description></item>
        /// <item><description><c>StartTime</c>: the start time of time range 1.</description></item>
        /// <item><description><c>CompareStartTime</c>: the start time of time range 2.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>Type</c>: the sort order. This value is case-insensitive. Valid values:<list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the results are sorted by <c>CreatedAt</c> in descending order by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;CreatedAt&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// <para>Default value: 1.</para>
        /// <remarks>
        /// <para>Use this parameter together with <c>PageSize</c>. If you specify this parameter, <c>NextToken</c> must be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
        /// <remarks>
        /// <para>Use this parameter together with <c>PageNumber</c>. If you specify this parameter, <c>NextToken</c> must be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
