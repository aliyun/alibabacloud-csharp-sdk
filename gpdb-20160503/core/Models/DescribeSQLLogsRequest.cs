// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpgadmin</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The maximum time range that can be specified is seven days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-17T06:30Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The execution duration of the SQL statement. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecuteCost")]
        [Validation(Required=false)]
        public string ExecuteCost { get; set; }

        /// <summary>
        /// <para>The execution status of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: successful.</description></item>
        /// <item><description><b>0</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ExecuteState")]
        [Validation(Required=false)]
        public string ExecuteState { get; set; }

        /// <summary>
        /// <para>The maximum amount of time consumed by a slow query. Unit: seconds. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxExecuteCost")]
        [Validation(Required=false)]
        public string MaxExecuteCost { get; set; }

        /// <summary>
        /// <para>The minimum amount of time consumed by a slow query. Unit: seconds. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinExecuteCost")]
        [Validation(Required=false)]
        public string MinExecuteCost { get; set; }

        /// <summary>
        /// <para>The type of the query language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DQL</b></description></item>
        /// <item><description><b>DML</b></description></item>
        /// <item><description><b>DDL</b></description></item>
        /// <item><description><b>DCL</b></description></item>
        /// <item><description><b>TCL</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DQL</para>
        /// </summary>
        [NameInMap("OperationClass")]
        [Validation(Required=false)]
        public string OperationClass { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If <b>OperationClass</b> is specified, the value of <b>OperationType</b> must belong to the corresponding query language. For example, if <b>OperationClass</b> is set to <b>DQL</b>, the value of <b>OperationType</b> must be a <b>DQL</b> statement such as <b>SELECT</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>OperationClass</b> is not specified, the value of <b>OperationType</b> can be an SQL statement of any query language.</para>
        /// </description></item>
        /// <item><description><para>If <b>OperationClass</b> and <b>OperationType</b> are not specified, all types of SQL statements are returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
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
        /// <para>The keywords of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select 1</para>
        /// </summary>
        [NameInMap("QueryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywords { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.<b>.</b>.90</para>
        /// </summary>
        [NameInMap("SourceIP")]
        [Validation(Required=false)]
        public string SourceIP { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-10T06:30Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testadmin</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
