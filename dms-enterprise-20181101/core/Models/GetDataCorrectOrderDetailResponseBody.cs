// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The information about the data change ticket.
        /// </summary>
        [NameInMap("DataCorrectOrderDetail")]
        [Validation(Required=false)]
        public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetail DataCorrectOrderDetail { get; set; }
        public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetail : TeaModel {
            /// <summary>
            /// The information about the database in which data is changed.
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
                    /// The ID of the database.
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public int? DbId { get; set; }

                    /// <summary>
                    /// The engine of the database.
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// The type of the environment to which the database belongs. Valid values:
                    /// 
                    /// - product: production environment
                    /// - dev: development environment
                    /// - pre: staging environment
                    /// - test: test environment
                    /// - sit: system integration testing (SIT) environment
                    /// - uat: user acceptance testing (UAT) environment
                    /// - pet: stress testing environment
                    /// - stag: STAG environment
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// Indicates whether the database is a logical database. Valid values:
                    /// 
                    /// - **true**: The database is a logical database.
                    /// - **false**: The database is a physical database.
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    /// <summary>
                    /// The name that is used to search for the database.
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }

            }

            /// <summary>
            /// The execution mode of the ticket after the ticket is approved. Valid values:
            /// 
            /// - **COMMITOR**: The data change is performed by the user who submits the ticket.
            /// - **AUTO**: The data change is automatically performed after the ticket is approved.
            /// - **LAST_AUDITOR**: The data change is performed by the last approver of the ticket.
            /// </summary>
            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            /// <summary>
            /// The details of the ticket.
            /// </summary>
            [NameInMap("OrderDetail")]
            [Validation(Required=false)]
            public GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailOrderDetail OrderDetail { get; set; }
            public class GetDataCorrectOrderDetailResponseBodyDataCorrectOrderDetailOrderDetail : TeaModel {
                /// <summary>
                /// The number of affected rows that is obtained by the precheck.
                /// </summary>
                [NameInMap("ActualAffectRows")]
                [Validation(Required=false)]
                public long? ActualAffectRows { get; set; }

                /// <summary>
                /// The name of the attachment that contains the SQL statements used to change data.
                /// </summary>
                [NameInMap("AttachmentName")]
                [Validation(Required=false)]
                public string AttachmentName { get; set; }

                /// <summary>
                /// The category of the reason for the data change.
                /// </summary>
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                /// <summary>
                /// The estimated number of affected rows.
                /// </summary>
                [NameInMap("EstimateAffectRows")]
                [Validation(Required=false)]
                public long? EstimateAffectRows { get; set; }

                /// <summary>
                /// The executed SQL statements.
                /// </summary>
                [NameInMap("ExeSQL")]
                [Validation(Required=false)]
                public string ExeSQL { get; set; }

                /// <summary>
                /// Indicates whether the precheck result is ignored. Valid values:
                /// 
                /// - **true**: The precheck result is ignored.
                /// - **false**: The precheck result is not ignored.
                /// </summary>
                [NameInMap("IgnoreAffectRows")]
                [Validation(Required=false)]
                public bool? IgnoreAffectRows { get; set; }

                /// <summary>
                /// The reason why the precheck result is ignored.
                /// </summary>
                [NameInMap("IgnoreAffectRowsReason")]
                [Validation(Required=false)]
                public string IgnoreAffectRowsReason { get; set; }

                /// <summary>
                /// The name of the attachment that contains the SQL statements used to roll back the data change.
                /// </summary>
                [NameInMap("RbAttachmentName")]
                [Validation(Required=false)]
                public string RbAttachmentName { get; set; }

                /// <summary>
                /// The SQL statements used to roll back the data change.
                /// </summary>
                [NameInMap("RbSQL")]
                [Validation(Required=false)]
                public string RbSQL { get; set; }

                /// <summary>
                /// The format of the SQL statements used to roll back the data change. Valid values:
                /// 
                /// - **TEXT**: text
                /// - **ATTACHMENT**: attachment
                /// </summary>
                [NameInMap("RbSQLType")]
                [Validation(Required=false)]
                public string RbSQLType { get; set; }

                /// <summary>
                /// The format of the SQL statements used to change data. Valid values:
                /// 
                /// - **TEXT**: text
                /// - **ATTACHMENT**: attachment
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

            }

            /// <summary>
            /// The precheck details of the ticket.
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
                    /// The status of the precheck. Valid values:
                    /// 
                    /// *   **WAITING**: The ticket is pending precheck.
                    /// *   **RUNNING**: The ticket is being prechecked.
                    /// *   **SUCCESS**: The ticket passes the precheck.
                    /// *   **FAIL**: The ticket fails the precheck.
                    /// </summary>
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    /// <summary>
                    /// The check step of the precheck. Valid values:
                    /// 
                    /// *   **SQL_PARSE**: The system checks the syntax of the SQL statement.
                    /// *   **SQL_TYPE_CHECK**: The system checks the type of the SQL statement.
                    /// *   **PERMISSION_CHECK**: The system checks the permissions required for the data change.
                    /// *   **ROW_CHECK**: The system checks the number of affected rows.
                    /// </summary>
                    [NameInMap("CheckStep")]
                    [Validation(Required=false)]
                    public string CheckStep { get; set; }

                    /// <summary>
                    /// The message that indicates a check step.
                    /// </summary>
                    [NameInMap("UserTip")]
                    [Validation(Required=false)]
                    public string UserTip { get; set; }

                }

            }

            /// <summary>
            /// The status of the ticket. Valid values:
            /// 
            /// - **new**: The ticket is created.
            /// - **precheck**: The ticket is being prechecked.
            /// - **precheck_fail**: The ticket fails the precheck.
            /// - **precheck_success**: The ticket passes the precheck and waits to be submitted for approval.
            /// - **toaudit**: The ticket is being reviewed.
            /// - **Approved**: The ticket is approved.
            /// - **reject**: The ticket is rejected.
            /// - **waiting**: The ticket is submitted and waits to be scheduled.
            /// - **processing**: The ticket is being executed.
            /// - **success**: The ticket is executed.
            /// - **closed**: The ticket is closed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// - **true**: The request is successful.
        /// - **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
