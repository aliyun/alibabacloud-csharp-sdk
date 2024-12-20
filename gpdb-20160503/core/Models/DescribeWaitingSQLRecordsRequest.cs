// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the instance IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC. The end time must be later than the start time.</para>
        /// <para>If this parameter is not specified, all lock diagnostics records that are generated after the query start time are returned. If the query start time is not specified either, all lock diagnostics records are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-20T07:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The keyword used to filter queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The field used to sort lock diagnostics records and the sorting order.</para>
        /// <para>Default value: <c>{&quot;Field&quot;:&quot;StartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;}</c>, which indicates that lock diagnostics records are sorted by the start time in descending order. No other values are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Field&quot;:&quot;StartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;}</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The filter condition on queries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;10&quot;}</c>: filters the top 10 longest-waiting queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;LockWaiting&quot;}</c>: filters lock-waiting queries.</description></item>
        /// <item><description><c>{&quot;Type&quot;:&quot;status&quot;,&quot;Value&quot;:&quot;ResourceWaiting&quot;}</c>: filters resource-waiting queries.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;maxCost&quot;,&quot;Value&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// <para>If this parameter is not specified, all lock diagnostics records that are generated before the query end time are returned. If the query end time is not specified either, all lock diagnostics records are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-15T06:59Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the database account. If this parameter is not specified, the lock diagnostics records of all database accounts are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
