// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLExecAuditLogRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <remarks>
        /// <para> The end time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format. We recommend that you use the StartTime and EndTime parameters to specify a time range that does not exceed one day. The returned entries can be displayed by page to improve query efficiency.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-08 11:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The execution status of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FAIL</b>: The SQL statement fails to be executed.</description></item>
        /// <item><description><b>NOEXE</b>: The SQL statement has not been executed.</description></item>
        /// <item><description><b>RUNNING</b>: The SQL statement is being executed.</description></item>
        /// <item><description><b>CANCEL</b>: The execution of the SQL statement is canceled.</description></item>
        /// <item><description><b>SUCCESS</b>: The SQL statement is executed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("ExecState")]
        [Validation(Required=false)]
        public string ExecState { get; set; }

        /// <summary>
        /// <para>The nickname of the user who wrote the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_OpUserName</para>
        /// </summary>
        [NameInMap("OpUserName")]
        [Validation(Required=false)]
        public string OpUserName { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The value cannot exceed 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the database or instance based on which you want to query SQL statements.</para>
        /// <remarks>
        /// <para> If the SQL statements to be queried are at the instance level, you can set this parameter to an instance name. If the SQL statements to be queried are at the database level, you can set this parameter to a database name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_SearchName</para>
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SELECT</b>: the SQL statement that is used to query data.</description></item>
        /// <item><description><b>INSERT</b>: the SQL statement that is used to insert data.</description></item>
        /// <item><description><b>DELETE</b>: the SQL statement that is used to delete data.</description></item>
        /// <item><description><b>CREATE_TABLE</b>: the SQL statement that is used to create tables.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To view more types of SQL statements, log on to the DMS console and click Security and Specifications. In the left-side navigation pane, click <b>Operation Audit</b>. Then, you can view all supported types of SQL statements from the <b>SQL type</b> drop-down list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <remarks>
        /// <para> The start time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-08 11:04:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
