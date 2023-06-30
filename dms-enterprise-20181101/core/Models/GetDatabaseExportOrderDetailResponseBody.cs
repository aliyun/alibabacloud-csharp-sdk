// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDatabaseExportOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the database export ticket.
        /// </summary>
        [NameInMap("DatabaseExportOrderDetail")]
        [Validation(Required=false)]
        public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetail DatabaseExportOrderDetail { get; set; }
        public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetail : TeaModel {
            /// <summary>
            /// The business background information of the database export ticket.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The user who submitted the ticket.
            /// </summary>
            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            /// <summary>
            /// The ID of the user who submitted the ticket. This ID is a user ID and is not the ID of an Alibaba Cloud account.
            /// </summary>
            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public string CommitterId { get; set; }

            /// <summary>
            /// The ticket ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The key information about the ticket.
            /// </summary>
            [NameInMap("KeyInfo")]
            [Validation(Required=false)]
            public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfo KeyInfo { get; set; }
            public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfo : TeaModel {
                /// <summary>
                /// The time when the ticket was submitted.
                /// </summary>
                [NameInMap("AuditDate")]
                [Validation(Required=false)]
                public string AuditDate { get; set; }

                /// <summary>
                /// The configuration information about the ticket.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfig Config { get; set; }
                public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfig : TeaModel {
                    /// <summary>
                    /// The database name.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The type of data that was exported. Valid values:
                    /// 
                    /// *   **DATA**: The data of the database was exported.
                    /// *   **STRUCT**: The schema of the database was exported.
                    /// *   **DATA_STRUCT**: The data and schema of the database were exported.
                    /// </summary>
                    [NameInMap("ExportContent")]
                    [Validation(Required=false)]
                    public string ExportContent { get; set; }

                    /// <summary>
                    /// The type of schema that was exported.
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
                    /// The extension options of the SQL script.
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
                    /// The tables that were exported from the database.
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
                    /// The format in which the database was exported. Valid values:
                    /// 
                    /// *   **SQL**
                    /// *   **CSV**
                    /// *   **XLSX**
                    /// </summary>
                    [NameInMap("TargetOption")]
                    [Validation(Required=false)]
                    public string TargetOption { get; set; }

                }

                /// <summary>
                /// The database ID.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The URL that is used to download the export result.
                /// </summary>
                [NameInMap("DownloadURL")]
                [Validation(Required=false)]
                public string DownloadURL { get; set; }

            }

            /// <summary>
            /// The execution logs.
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// The name that is used to search for the database.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            /// <summary>
            /// The status description of the ticket.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The status description of the workflow.
            /// </summary>
            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
