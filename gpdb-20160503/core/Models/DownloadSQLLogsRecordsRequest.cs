// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DownloadSQLLogsRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The end time must be later than the start time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-08T06:59Z</para>
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
        /// <para>The execution status of the SQL statement.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: successful.</description></item>
        /// <item><description><b>0</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecuteState")]
        [Validation(Required=false)]
        public string ExecuteState { get; set; }

        /// <summary>
        /// <para>The language of the file that contains the query diagnostic information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum amount of time consumed by a slow query. Unit: seconds. Minimum value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>999</para>
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
        /// <para>The type of the query language. Example: DQL, DML, or DDL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DQL</para>
        /// </summary>
        [NameInMap("OperationClass")]
        [Validation(Required=false)]
        public string OperationClass { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Example: SELECT.</para>
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
        /// <para>The keywords that are used for query.</para>
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
        /// <para>100.XX.XX.90</para>
        /// </summary>
        [NameInMap("SourceIP")]
        [Validation(Required=false)]
        public string SourceIP { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-07T06:59Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
