// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database. By default, all databases are queried. You can also enter a database name to query. Only one database name can be entered at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Database</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time, and the interval between the start time and end time must be 7 days or less. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>If DAS Enterprise Edition V3 is activated and you use the SQL Explorer and Audit feature it provides, you can query data within the hot data storage duration. You can call <a href="https://help.aliyun.com/document_detail/2778837.html">DescribeSqlLogConfig</a> to query the activated Enterprise Edition information.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-06T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate an audit file or return a list of SQL records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>File</b>: If you set this parameter to File, an audit file is generated. Only common parameters are returned. You must call the DescribeSQLLogFiles operation to obtain the download URL of the file.</description></item>
        /// <item><description><b>Stream</b>: This is the default value. A list of SQL records is returned.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to <b>File</b>, only MySQL (with Premium Local SSDs) and SQL Server instances are supported, and a maximum of 1,000,000 log entries are recorded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stream</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public string Form { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b> to <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keywords that are used for the query.</para>
        /// <list type="bullet">
        /// <item><description><para>When you generate an audit file by calling this operation (the <b>Form</b> request parameter is set to <b>File</b>), keyword-based filtering is not supported.</para>
        /// </description></item>
        /// <item><description><para>Separate multiple keywords with spaces. You can specify up to 10 keywords. The logical relationship among keywords is <b>and</b>.</para>
        /// </description></item>
        /// <item><description><para>If a field name in the SQL statement uses backticks (\<c>), you must also include the backticks when using the field name as a keyword. For example, if the field name is \\</c>id\<c>, enter \\</c>id\` instead of id.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you enter keywords, the system matches the keywords against the <b>Database</b>, <b>User</b>, and <b>QueryKeywords</b> parameters simultaneously. The logical relationship among the three request parameters is <b>and</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("QueryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywords { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public long? SQLId { get; set; }

        /// <summary>
        /// <para>The start time of the query. You can query data within the last 7 days from the current date. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>If DAS Enterprise Edition V3 is activated and you use the SQL Explorer and Audit feature it provides, you can query data within the hot data storage duration. You can call <a href="https://help.aliyun.com/document_detail/2778837.html">DescribeSqlLogConfig</a> to query the activated Enterprise Edition information.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-01T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username. By default, all users are queried. You can also enter a username to query. Only one username can be entered at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
