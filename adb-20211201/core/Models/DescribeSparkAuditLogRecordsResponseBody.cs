// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkAuditLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if Resource Access Management (RAM) permission verification failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1**<em><b><b><b><b><b><b><b>7&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcKwyhk62IeYly4hQ+5IpXjkh1GQXuDRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;2</b></b></b></b></b></b></b></em>9&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1j7******78j8i</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The list of SQL audit logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSparkAuditLogRecordsResponseBodyItems> Items { get; set; }
        public class DescribeSparkAuditLogRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The Spark application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s202411061011hzc5d6476000****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The SQL execution error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>notFoundIp</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The SQL execution error stack trace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>notFoundIpException</para>
            /// </summary>
            [NameInMap("ErrorTrace")]
            [Validation(Required=false)]
            public string ErrorTrace { get; set; }

            /// <summary>
            /// <para>The start time of the SQL statement. The time is in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-23T16:05:08Z</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            /// <summary>
            /// <para>The ID of the query executed within the Spark application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InnerQueryId")]
            [Validation(Required=false)]
            public string InnerQueryId { get; set; }

            /// <summary>
            /// <para>Whether it can be diagnosed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDiagnosable")]
            [Validation(Required=false)]
            public bool? IsDiagnosable { get; set; }

            /// <summary>
            /// <para>The query ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>999f2439-6b10-xxxx-a5d3-daf3b35c****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The resource group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_job</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM adb_hdfs_import_source</para>
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// <para>The ID of the statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fbd22066-1c03-xxxx-aa16-6ae28288****</para>
            /// </summary>
            [NameInMap("StatementId")]
            [Validation(Required=false)]
            public string StatementId { get; set; }

            /// <summary>
            /// <para>The source from which the query was initiated.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SQL_EDITOR: SQL_EDITOR.</description></item>
            /// <item><description>JDBC: JDBC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL_EDITOR</para>
            /// </summary>
            [NameInMap("StatementSource")]
            [Validation(Required=false)]
            public string StatementSource { get; set; }

            /// <summary>
            /// <para>The execution status of the SQL statement.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cancel: The task is canceled .</description></item>
            /// <item><description>finished: The execution succeeds .</description></item>
            /// <item><description>error: The execution fails .</description></item>
            /// <item><description>timeout: The execution of the command timed out.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The duration of the SQL statement. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("TotalTime")]
            [Validation(Required=false)]
            public long? TotalTime { get; set; }

            /// <summary>
            /// <para>The username that is used to execute SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D5867CF-423F-559F-BBB1-199A289E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
