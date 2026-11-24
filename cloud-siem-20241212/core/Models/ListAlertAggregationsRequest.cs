// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListAlertAggregationsRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avg</para>
        /// </summary>
        [NameInMap("AggregationType")]
        [Validation(Required=false)]
        public string AggregationType { get; set; }

        /// <summary>
        /// <para>The time when the alert ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1773936020000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. If this is the first query or no subsequent query is required, you do not need to specify this parameter. If a subsequent query is required, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query filter conditions in JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;, &quot;Value&quot;:&quot;100&quot;}</c>: The top 100 queries with the longest execution duration.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: Completed queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>: Running queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;30&quot;,&quot;Max&quot;:&quot;50&quot;}</c>: Custom execution duration queries. You can specify the minimum and maximum execution duration. <b>Min</b> specifies the minimum execution duration. <b>Max</b> specifies the maximum execution duration. Unit: milliseconds.<list type="bullet">
        /// <item><description>If only <b>Min</b> is specified, the system queries the queries whose execution duration is greater than the specified value.</description></item>
        /// <item><description>If only <b>Max</b> is specified, the system queries the queries whose execution duration is less than the specified value.</description></item>
        /// <item><description>If both <b>Min</b> and <b>Max</b> are specified, the system queries the queries whose execution duration is greater than or equal to the value of <b>Min</b> and less than or equal to the value of <b>Max</b>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Type\&quot;:\&quot;cost\&quot;,\&quot;Max\&quot;:\&quot;200\&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para>The unique identifier of the query view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qv-a1b2c3d4e5f6g7****</para>
        /// </summary>
        [NameInMap("QueryViewId")]
        [Validation(Required=false)]
        public string QueryViewId { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member whose view the administrator assumes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: The view of all accounts in the enterprise.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The time when the alert first occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1791709871476</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
