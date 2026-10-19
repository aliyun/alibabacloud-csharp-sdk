// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeSlowLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time, and the time range cannot exceed 1 day. The recommended time range is 1 hour. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-10T15:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID in the instance. Specify this parameter to query the slow query logs of a specific node.</para>
        /// <remarks>
        /// <para>This parameter is available only when the instance uses the read/write splitting or cluster architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The field based on which the returned results are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>execution_time</b>: sorts the results based on the start time of request execution. This is the default value.</description></item>
        /// <item><description><b>latency</b>: sorts the results based on the execution duration of requests.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>execution_time</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort order of the returned results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: ascending order.</description></item>
        /// <item><description><b>DESC</b>: descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the INTEGER data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword used to search the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword1</para>
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The slow log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>proxy</b>: Slow query logs on proxy nodes.</description></item>
        /// <item><description><b>db</b>: Slow query logs on data nodes. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>proxy</para>
        /// </summary>
        [NameInMap("SlowLogRecordType")]
        [Validation(Required=false)]
        public string SlowLogRecordType { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-10T14:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
