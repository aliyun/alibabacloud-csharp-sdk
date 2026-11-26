// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogCountRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specified region, including instance IDs.</para>
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
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end time of the query. The format is <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC time).</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the time interval between the start time and the end time cannot exceed seven days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-14T11:22Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The execution duration, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ExecuteCost")]
        [Validation(Required=false)]
        public string ExecuteCost { get; set; }

        /// <summary>
        /// <para>The execution status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Success.</description></item>
        /// <item><description>0: Failure.</description></item>
        /// <item><description>0,1 or 1,0: All.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecuteState")]
        [Validation(Required=false)]
        public string ExecuteState { get; set; }

        /// <summary>
        /// <para>The maximum execution duration of slow SQL queries. The value must be greater than or equal to 0, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxExecuteCost")]
        [Validation(Required=false)]
        public string MaxExecuteCost { get; set; }

        /// <summary>
        /// <para>The minimum execution duration of slow SQL queries. The value must be greater than or equal to 0, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinExecuteCost")]
        [Validation(Required=false)]
        public string MinExecuteCost { get; set; }

        /// <summary>
        /// <para>The operation class. Valid values:</para>
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
        /// <para>The type of the executed SQL statement.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the <b>OperationClass</b> parameter is specified, the value of <b>OperationType</b> must belong to the corresponding language type. For example, if the value of <b>OperationClass</b> is <b>DQL</b>, the value of <b>OperationType</b> must be a <b>DQL</b> SQL statement, such as <b>SELECT</b>.</description></item>
        /// <item><description>If the <b>OperationClass</b> parameter is not specified, the value of <b>OperationType</b> can be any type of SQL statement.</description></item>
        /// <item><description>If neither the <b>OperationClass</b> nor the <b>OperationType</b> parameter is specified, all types of SQL statements are returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The query keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QueryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywords { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.<b>.</b>.13</para>
        /// </summary>
        [NameInMap("SourceIP")]
        [Validation(Required=false)]
        public string SourceIP { get; set; }

        /// <summary>
        /// <para>The start time of the query. The format is <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC time).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-12T11:22Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The database username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpgadmin</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
