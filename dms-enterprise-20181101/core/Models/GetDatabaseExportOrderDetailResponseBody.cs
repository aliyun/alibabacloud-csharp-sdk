// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDatabaseExportOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the database export ticket.</para>
        /// </summary>
        [NameInMap("DatabaseExportOrderDetail")]
        [Validation(Required=false)]
        public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetail DatabaseExportOrderDetail { get; set; }
        public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetail : TeaModel {
            /// <summary>
            /// <para>The business background information of the database export ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The user who submitted the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dmsuser</para>
            /// </summary>
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            /// <summary>
            /// <para>The ID of the user who submitted the ticket. This ID is a user ID and is not the ID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12***</para>
            /// </summary>
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public string CommitterId { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>821****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The key information about the ticket.</para>
            /// </summary>
            [NameInMap("KeyInfo")]
            [Validation(Required=false)]
            public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfo KeyInfo { get; set; }
            public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfo : TeaModel {
                /// <summary>
                /// <para>The time when the ticket was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-13 13:44:59</para>
                /// </summary>
                [NameInMap("AuditDate")]
                [Validation(Required=false)]
                public string AuditDate { get; set; }

                /// <summary>
                /// <para>The configuration information about the ticket.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfig Config { get; set; }
                public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfig : TeaModel {
                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dmstest</para>
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// <para>The type of data that was exported. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>DATA</b>: The data of the database was exported.</description></item>
                    /// <item><description><b>STRUCT</b>: The schema of the database was exported.</description></item>
                    /// <item><description><b>DATA_STRUCT</b>: The data and schema of the database were exported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DATA</para>
                    /// </summary>
                    [NameInMap("ExportContent")]
                    [Validation(Required=false)]
                    public string ExportContent { get; set; }

                    /// <summary>
                    /// <para>The type of schema that was exported.</para>
                    /// </summary>
                    [NameInMap("ExportTypes")]
                    [Validation(Required=false)]
                    public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigExportTypes ExportTypes { get; set; }
                    public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigExportTypes : TeaModel {
                        [NameInMap("ExportTypes")]
                        [Validation(Required=false)]
                        public List<string> ExportTypes { get; set; }

                    }

                    /// <summary>
                    /// <para>The extension options of the SQL script.</para>
                    /// </summary>
                    [NameInMap("SQLExtOption")]
                    [Validation(Required=false)]
                    public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSQLExtOption SQLExtOption { get; set; }
                    public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSQLExtOption : TeaModel {
                        [NameInMap("SQLExtOption")]
                        [Validation(Required=false)]
                        public List<string> SQLExtOption { get; set; }

                    }

                    /// <summary>
                    /// <para>The tables that were exported from the database.</para>
                    /// </summary>
                    [NameInMap("SelectedTables")]
                    [Validation(Required=false)]
                    public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSelectedTables SelectedTables { get; set; }
                    public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSelectedTables : TeaModel {
                        [NameInMap("SelectedTables")]
                        [Validation(Required=false)]
                        public List<string> SelectedTables { get; set; }

                    }

                    /// <summary>
                    /// <para>The format in which the database was exported. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>SQL</b></description></item>
                    /// <item><description><b>CSV</b></description></item>
                    /// <item><description><b>XLSX</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SQL</para>
                    /// </summary>
                    [NameInMap("TargetOption")]
                    [Validation(Required=false)]
                    public string TargetOption { get; set; }

                }

                /// <summary>
                /// <para>The database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2583****</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the export result.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oss.xxx.com">https://oss.xxx.com</a></para>
                /// </summary>
                [NameInMap("DownloadURL")]
                [Validation(Required=false)]
                public string DownloadURL { get; set; }

            }

            /// <summary>
            /// <para>The execution logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-12 14:58:32:015 Database Dump Start.
            /// 2023-04-12 14:58:32:096 set server side query timeout, sql : set max_execution_time = 0</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// <para>The name that is used to search for the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@xxx.xxx.xxx.xxx">test@xxx.xxx.xxx.xxx</a>:3306</para>
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// <para>The status description of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ticket approval</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The status description of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ticket approval</para>
            /// </summary>
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFD8FE00-36D9-4C1B-940D-65A7B73D9066</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
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
