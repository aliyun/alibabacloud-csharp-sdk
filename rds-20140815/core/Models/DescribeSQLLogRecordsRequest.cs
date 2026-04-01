// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database. You can enter only one database name. If you specify this parameter, this operation returns the logs that are generated only for the specified database. If you do not specify this parameter, this operation returns the logs that are generated for all databases on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Database</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. The time span between the start time and the end time must be less than 15 days. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-11T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate an SQL audit log file or return SQL audit logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>File</b>: If you set this parameter to File, this operation generates an SQL audit log file and returns only common response parameters. After you call this operation, you must call the DescribeSQLLogFiles operation to obtain the download URL of the SQL audit log file.</description></item>
        /// <item><description><b>Stream</b> (default): If you set this parameter to Stream, this operation returns SQL audit logs.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>File</b>, only ApsaraDB RDS for MySQL instances that use local disks and ApsaraDB RDS for SQL Server instances are supported, and a maximum of 1 million logs are returned.</para>
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
        /// <para>The page number. Pages start from 1.</para>
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
        /// <para>The keyword that is used for the query.</para>
        /// <list type="bullet">
        /// <item><description>When you call this operation and set the <b>Form</b> parameter to <b>File</b> to generate an audit file, you cannot filter log entries by keyword.</description></item>
        /// <item><description>You can specify up to 10 keywords. The keywords are evaluated by using the <b>AND</b> operator. Separate multiple keywords with spaces.</description></item>
        /// <item><description>If a field name in the specified SQL statement is enclosed in grave accents (\<c>) and you want to use the field name as a keyword, you must enter the grave accents (\\</c>) as part of the field name. For example, if the field name is \<c>id\\</c>, enter \<c>id\\</c> instead of id.</description></item>
        /// </list>
        /// <remarks>
        /// <para> After you enter a keyword, the system matches the keyword based on the <b>Database</b>, <b>User</b>, and <b>QueryKeywords</b> parameters. The parameters are evaluated by using the <b>AND</b> operator.</para>
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
        /// <para>The unique ID of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25623548</para>
        /// </summary>
        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public long? SQLId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. You can query data in the last 15 days before the current date. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-01T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username of the account. You can enter only one username. If you specify this parameter, this operation returns the logs that are generated only for the specified account. If you do not specify this parameter, this operation returns the logs that are generated for all accounts on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
