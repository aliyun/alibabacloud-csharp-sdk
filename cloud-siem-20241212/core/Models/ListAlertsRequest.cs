// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListAlertsRequest : TeaModel {
        /// <summary>
        /// <para>The threat level of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: critical.</description></item>
        /// <item><description>4: high-risk.</description></item>
        /// <item><description>3: medium-risk.</description></item>
        /// <item><description>2: low-risk.</description></item>
        /// <item><description>1: informational.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public List<string> AlertLevel { get; set; }

        /// <summary>
        /// <para>The alert ID associated with the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas_71e24437d2797ce8fc59692905a4****</para>
        /// </summary>
        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        /// <summary>
        /// <para>The end time of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1766801904000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
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
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. You do not need to specify this parameter for the first request or if no more results exist. If more results exist, set this parameter to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b> (default): ascending order.</description></item>
        /// <item><description><b>desc</b>: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreate: creation time.</description></item>
        /// <item><description>GmtModified: update time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderFieldName")]
        [Validation(Required=false)]
        public string OrderFieldName { get; set; }

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
        /// <para>The query filter condition in JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;, &quot;Value&quot;:&quot;100&quot;}</c>: the top 100 queries with the longest execution duration.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;finished&quot;}</c>: completed queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;running&quot;}</c>: running queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;cost&quot;,&quot;Min&quot;:&quot;30&quot;,&quot;Max&quot;:&quot;50&quot;}</c>: queries with a custom execution duration range. You can specify the minimum and maximum execution duration. <b>Min</b> specifies the minimum execution duration. <b>Max</b> specifies the maximum execution duration. Unit: milliseconds (ms).<list type="bullet">
        /// <item><description>If only <b>Min</b> is specified, queries with an execution duration greater than this value are returned.</description></item>
        /// <item><description>If only <b>Max</b> is specified, queries with an execution duration less than this value are returned.</description></item>
        /// <item><description>If both <b>Min</b> and <b>Max</b> are specified, queries with an execution duration greater than or equal to <b>Min</b> and less than or equal to <b>Max</b> are returned.</description></item>
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
        /// <para>The region where the threat analysis data management center is located. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets are located in the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Your assets are located outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts in the resource folder.</para>
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
        /// <item><description>0: the view of the current Alibaba Cloud account.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
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
        /// <para>2025-09-30T02:23:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
