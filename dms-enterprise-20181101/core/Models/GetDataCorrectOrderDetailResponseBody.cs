// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the data change ticket.</para>
        /// </summary>
        [NameInMap("DataCorrectOrderDetail")]
        [Validation(Required=false)]
        public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetail DataCorrectOrderDetail { get; set; }
        public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetail : TeaModel {
            /// <summary>
            /// <para>The configurations of the ticket. This parameter is used to store the configuration information specific to a data change ticket type.</para>
            /// </summary>
            [NameInMap("ConfigDetail")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailConfigDetail ConfigDetail { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailConfigDetail : TeaModel {
                /// <summary>
                /// <para>Indicates whether the task is a scheduled task for historical data cleanup. This parameter is a reserved parameter and is valid only if the value of DetailType is CRON_CLEAR_DATA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Cron")]
                [Validation(Required=false)]
                public bool? Cron { get; set; }

                /// <summary>
                /// <para>The number of times the scheduled task is run. This parameter is valid only if the value of DetailType is CRON_CLEAR_DATA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CronCallTimes")]
                [Validation(Required=false)]
                public int? CronCallTimes { get; set; }

                /// <summary>
                /// <para>The additional configuration information about historical data cleanup. This parameter is valid only if the value of DetailType is CRON_CLEAR_DATA.</para>
                /// </summary>
                [NameInMap("CronExtConfig")]
                [Validation(Required=false)]
                public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailConfigDetailCronExtConfig CronExtConfig { get; set; }
                public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailConfigDetailCronExtConfig : TeaModel {
                    /// <summary>
                    /// <para>The number of times defragmentation is performed. This parameter is valid only if the value of OptimizeTableAfterEveryClearTimes is greater than 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CurrentClearTaskCount")]
                    [Validation(Required=false)]
                    public int? CurrentClearTaskCount { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the Periodically Optimize Table feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b> (default): The feature is disabled.</description></item>
                    /// <item><description><b>A value greater than 0</b>: The feature is enabled. The value indicates the number of cleanups after which the system performs defragmentation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OptimizeTableAfterEveryClearTimes")]
                    [Validation(Required=false)]
                    public int? OptimizeTableAfterEveryClearTimes { get; set; }

                }

                /// <summary>
                /// <para>The CRON expression of the scheduled task. This parameter is valid only if the value of DetailType is CRON_CLEAR_DATA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 2 * * ?</para>
                /// </summary>
                [NameInMap("CronFormat")]
                [Validation(Required=false)]
                public string CronFormat { get; set; }

                /// <summary>
                /// <para>The time when the task was last run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-19 02:00:00.0</para>
                /// </summary>
                [NameInMap("CronLastCallStartTime")]
                [Validation(Required=false)]
                public string CronLastCallStartTime { get; set; }

                /// <summary>
                /// <para>The time when the task is run next time. This parameter is returned only if the value of CronStatus is SUCCESS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-19 02:00:00</para>
                /// </summary>
                [NameInMap("CronNextCallTime")]
                [Validation(Required=false)]
                public string CronNextCallTime { get; set; }

                /// <summary>
                /// <para>The state of the scheduled task. If this parameter is empty, the task is not run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PAUSE: The task is suspended.</description></item>
                /// <item><description>WAITING: The task is waiting to be run.</description></item>
                /// <item><description>SUCCESS: The task is run.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("CronStatus")]
                [Validation(Required=false)]
                public string CronStatus { get; set; }

                /// <summary>
                /// <para>The name of the table to which data is to be imported. This parameter is valid only if the value of DetailType is BIG_FILE. If the value of FileType is SQL, this parameter is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tb_import_tb_name</para>
                /// </summary>
                [NameInMap("CsvTableName")]
                [Validation(Required=false)]
                public string CsvTableName { get; set; }

                /// <summary>
                /// <para>The ID of the current data change task. This is a reserved parameter and can be ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13***</para>
                /// </summary>
                [NameInMap("CurrentTaskId")]
                [Validation(Required=false)]
                public long? CurrentTaskId { get; set; }

                /// <summary>
                /// <para>The type of the ticket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMMON: regular data change.</description></item>
                /// <item><description>CHUNK_DML: lock-free data change.</description></item>
                /// <item><description>BIG_FILE: large data import.</description></item>
                /// <item><description>CRON_CLEAR_DATA: historical data cleanup.</description></item>
                /// <item><description>PROCEDURE: programmable object change.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BIG_FILE</para>
                /// </summary>
                [NameInMap("DetailType")]
                [Validation(Required=false)]
                public string DetailType { get; set; }

                /// <summary>
                /// <para>The execution duration of the scheduled task. Unit: hour. This parameter is valid only if the value of DetailType is CRON_CLEAR_DATA. If the value is greater than 0, an execution duration is set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The encoding method of the file. This parameter may be empty, which indicates the value of AUTO. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AUTO</b>: automatic identification.</description></item>
                /// <item><description><b>UTF-8</b>: UTF-8 encoding.</description></item>
                /// <item><description><b>GBK</b>: GBK encoding.</description></item>
                /// <item><description><b>ISO-8859-1</b>: ISO-8859-1 encoding.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UTF-8</para>
                /// </summary>
                [NameInMap("FileEncoding")]
                [Validation(Required=false)]
                public string FileEncoding { get; set; }

                /// <summary>
                /// <para>The type of the file to be imported. This parameter is valid if the value of DetailType is BIG_FILE. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SQL</b>: an SQL file.</description></item>
                /// <item><description><b>CSV</b>: a CSV file.</description></item>
                /// <item><description><b>EXCEL</b>: an Excel file.</description></item>
                /// <item><description><b>JSON</b>: a JSON file, which is supported only by MongoDB databases.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CSV</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>The additional configuration information about data import. This parameter is valid if the value of DetailType is BIG_FILE.</para>
                /// </summary>
                [NameInMap("ImportExtConfig")]
                [Validation(Required=false)]
                public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailConfigDetailImportExtConfig ImportExtConfig { get; set; }
                public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailConfigDetailImportExtConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the first row of the CSV file contains field names. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The first row in the CSV file contains field names.</description></item>
                    /// <item><description><b>false</b>: The first row in the CSV file contains data.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter is valid if the value of <b>FileType</b> is <b>CSV</b> or <b>EXCEL</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CsvFirstRowIsColumnDef")]
                    [Validation(Required=false)]
                    public bool? CsvFirstRowIsColumnDef { get; set; }

                    /// <summary>
                    /// <para>Indicates whether an error that occurs is ignored. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: If an error occurs when SQL statements are being executed, DMS skips the current SQL statement and continues to execute subsequent SQL statements.</description></item>
                    /// <item><description><b>false</b>: If an error occurs when SQL statements are being executed, DMS stops executing subsequent SQL statements.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IgnoreError")]
                    [Validation(Required=false)]
                    public bool? IgnoreError { get; set; }

                    /// <summary>
                    /// <para>The import mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>FAST_MODE</b>: fast mode. In the Execute step, the uploaded file is read and SQL statements are executed to import data to the specified destination database. Compared with the security mode, this mode can be used to import data in a less secure but more efficient manner.</description></item>
                    /// <item><description><b>SAFE_MODE</b>: security mode. In the Precheck step, the uploaded file is parsed, and SQL statements or CSV file data is cached. In the Execute step, the cached SQL statements are read and executed to import data, or the cached CSV file data is read and imported to the specified destination database. Compared with the fast mode, this mode can be used to import data in a more secure but less efficient manner.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FAST_MODE</para>
                    /// </summary>
                    [NameInMap("ImportMode")]
                    [Validation(Required=false)]
                    public string ImportMode { get; set; }

                    /// <summary>
                    /// <para>The mode in which data is to be imported to the destination table. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>INSERT</b>: The database checks the primary key during data insertion. If the primary key is duplicated, an error is reported.</description></item>
                    /// <item><description><b>INSERT_IGNORE</b>: If the imported data contains data records that are the same as those in the destination table, the new data records are ignored.</description></item>
                    /// <item><description><b>REPLACE_INTO</b>: If the imported data contains a row that has the same value for the primary key or unique index as an existing row in the destination table, the system deletes the existing row and inserts the new row into the destination table.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter is valid if the value of FileType is CSV or EXCEL.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INSERT</para>
                    /// </summary>
                    [NameInMap("InsertType")]
                    [Validation(Required=false)]
                    public string InsertType { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the database in which data is changed.</para>
            /// </summary>
            [NameInMap("DatabaseList")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseList DatabaseList { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseList : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public List<GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseListDatabase> Database { get; set; }
                public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailDatabaseListDatabase : TeaModel {
                    /// <summary>
                    /// <para>The database ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1860****</para>
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public int? DbId { get; set; }

                    /// <summary>
                    /// <para>The engine of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// <para>The type of the environment to which the database belongs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>product: production environment.</description></item>
                    /// <item><description>dev: development environment.</description></item>
                    /// <item><description>pre: pre-release environment.</description></item>
                    /// <item><description>test: test environment.</description></item>
                    /// <item><description>sit: system integration testing (SIT) environment</description></item>
                    /// <item><description>uat: user acceptance testing (UAT) environment.</description></item>
                    /// <item><description>pet: stress testing environment.</description></item>
                    /// <item><description>stag: staging environment.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>product</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the database is a logical database. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true.</b>: The database is a logical database.</description></item>
                    /// <item><description><b>false</b>: The database is a physical database.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    /// <summary>
                    /// <para>The name that is used to search for the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx@xxx:3306</para>
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }

            }

            /// <summary>
            /// <para>The execution mode of the ticket after the ticket is approved. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMMITOR</b>: The data change is performed by the user who submits the ticket.</description></item>
            /// <item><description><b>AUTO</b>: The data change is automatically performed after the ticket is approved.</description></item>
            /// <item><description><b>LAST_AUDITOR</b>: The data change is performed by the last approver of the ticket.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMMITOR</para>
            /// </summary>
            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// <para>The details of the ticket.</para>
            /// </summary>
            [NameInMap("OrderDetail")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailOrderDetail OrderDetail { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailOrderDetail : TeaModel {
                /// <summary>
                /// <para>The number of affected rows that is obtained by the precheck.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ActualAffectRows")]
                [Validation(Required=false)]
                public long? ActualAffectRows { get; set; }

                /// <summary>
                /// <para>The name of the attachment that contains the SQL statements used to change data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("AttachmentName")]
                [Validation(Required=false)]
                public string AttachmentName { get; set; }

                /// <summary>
                /// <para>The category of the reason for the data change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                /// <summary>
                /// <para>The estimated number of affected rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("EstimateAffectRows")]
                [Validation(Required=false)]
                public long? EstimateAffectRows { get; set; }

                /// <summary>
                /// <para>The executed SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>update t1 set name = \&quot;xxx\&quot; where id &lt;= 100</para>
                /// </summary>
                [NameInMap("ExeSQL")]
                [Validation(Required=false)]
                public string ExeSQL { get; set; }

                /// <summary>
                /// <para>Indicates whether the precheck result is ignored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The precheck result is ignored.</description></item>
                /// <item><description><b>false</b>: The precheck result is not ignored.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IgnoreAffectRows")]
                [Validation(Required=false)]
                public bool? IgnoreAffectRows { get; set; }

                /// <summary>
                /// <para>The reason why the precheck result is ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("IgnoreAffectRowsReason")]
                [Validation(Required=false)]
                public string IgnoreAffectRowsReason { get; set; }

                /// <summary>
                /// <para>The name of the attachment that contains the SQL statements used to roll back the data change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RbAttachmentName")]
                [Validation(Required=false)]
                public string RbAttachmentName { get; set; }

                /// <summary>
                /// <para>The SQL statements used to roll back the data change.</para>
                /// 
                /// <b>Example:</b>
                /// <para>empty</para>
                /// </summary>
                [NameInMap("RbSQL")]
                [Validation(Required=false)]
                public string RbSQL { get; set; }

                /// <summary>
                /// <para>The format of the SQL statements used to roll back the data change. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TEXT</b>: text</description></item>
                /// <item><description><b>ATTACHMENT</b>: attachment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("RbSQLType")]
                [Validation(Required=false)]
                public string RbSQLType { get; set; }

                /// <summary>
                /// <para>The format of the SQL statements used to change data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TEXT</b>: text</description></item>
                /// <item><description><b>ATTACHMENT</b>: attachment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

            }

            /// <summary>
            /// <para>The precheck details of the ticket.</para>
            /// </summary>
            [NameInMap("PreCheckDetail")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetail PreCheckDetail { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetail : TeaModel {
                [NameInMap("TaskCheckDO")]
                [Validation(Required=false)]
                public List<GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetailTaskCheckDO> TaskCheckDO { get; set; }
                public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailPreCheckDetailTaskCheckDO : TeaModel {
                    /// <summary>
                    /// <para>The state of the precheck. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>WAITING</b>: The ticket is pending precheck.</description></item>
                    /// <item><description><b>RUNNING</b>: The ticket is being prechecked.</description></item>
                    /// <item><description><b>SUCCESS</b>: The ticket passes the precheck.</description></item>
                    /// <item><description><b>FAIL</b>: The ticket fails the precheck.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    /// <summary>
                    /// <para>The check step of the precheck. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>SQL_PARSE</b>: The system checks the syntax of the SQL statement.</description></item>
                    /// <item><description><b>SQL_TYPE_CHECK</b>: The system checks the type of the SQL statement.</description></item>
                    /// <item><description><b>PERMISSION_CHECK</b>: The system checks the permissions required for the data change.</description></item>
                    /// <item><description><b>ROW_CHECK</b>: The system checks the number of affected rows.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PERMISSION_CHECK</para>
                    /// </summary>
                    [NameInMap("CheckStep")]
                    [Validation(Required=false)]
                    public string CheckStep { get; set; }

                    /// <summary>
                    /// <para>The message that appears when a check step is executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tip messsage</para>
                    /// </summary>
                    [NameInMap("UserTip")]
                    [Validation(Required=false)]
                    public string UserTip { get; set; }

                }

            }

            /// <summary>
            /// <para>The specific state of the data change ticket. Valid values:</para>
            /// <remarks>
            /// <para> The state of the ticket is not exactly equivalent to the status code for the ticket. To query the status code of the ticket, you can call the <a href="https://help.aliyun.com/document_detail/465868.html">GetOrderBaseInfo</a> operation and check the value of StatusCode in the response.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><b>new</b>: The ticket is created.</description></item>
            /// <item><description><b>precheck</b>: The ticket is in the pre-check phase.</description></item>
            /// <item><description><b>precheckFailed</b>: The ticket failed to pass the precheck.</description></item>
            /// <item><description><b>precheck_success</b>: The ticket passes the precheck and waits to be submitted for approval.</description></item>
            /// <item><description><b>toaudit</b>: The ticket is being reviewed.</description></item>
            /// <item><description><b>Approved</b>: The ticket is approved.</description></item>
            /// <item><description><b>reject</b>: The ticket is rejected.</description></item>
            /// <item><description><b>waiting</b>: The task is submitted and waits to be scheduled.</description></item>
            /// <item><description><b>processing</b>: The task is being executed.</description></item>
            /// <item><description><b>Success</b>: The task is successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>approved</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>427688B8-ADFB-4C4E-9D45-EF5C1FD6E23D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
