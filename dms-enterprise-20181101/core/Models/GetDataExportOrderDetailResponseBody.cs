// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the data export ticket.
        /// </summary>
        [NameInMap("DataExportOrderDetail")]
        [Validation(Required=false)]
        public GetDataExportOrderDetailResponseBodyDataExportOrderDetail DataExportOrderDetail { get; set; }
        public class GetDataExportOrderDetailResponseBodyDataExportOrderDetail : TeaModel {
            /// <summary>
            /// The status information of the data export ticket.
            /// </summary>
            [NameInMap("KeyInfo")]
            [Validation(Required=false)]
            public GetDataExportOrderDetailResponseBodyDataExportOrderDetailKeyInfo KeyInfo { get; set; }
            public class GetDataExportOrderDetailResponseBodyDataExportOrderDetailKeyInfo : TeaModel {
                /// <summary>
                /// The status of the data export ticket. Valid values:
                /// 
                /// *   PRE_CHECKING: The ticket is being prechecked.
                /// *   PRE_CHECK_SUCCESS: The ticket passes the precheck.
                /// *   PRE_CHECK_FAIL: The ticket fails to pass the precheck.
                /// *   WAITING_APPLY_AUDIT: The ticket is to be submitted for approval.
                /// *   APPLY_AUDIT_SUCESS: The ticket is submitted for approval.
                /// *   ENABLE_EXPORT: The ticket is approved. Data can be exported.
                /// *   WAITING_EXPORT: Data is to be scheduled for export.
                /// *   DOING_EXPORT: Data is being exported.
                /// *   EXPORT_FAIL: Data fails to be exported.
                /// *   EXPORT_SUCCESS: Data is exported.
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// The ID of the precheck.
                /// </summary>
                [NameInMap("PreCheckId")]
                [Validation(Required=false)]
                public long? PreCheckId { get; set; }

            }

            /// <summary>
            /// The details of the ticket.
            /// </summary>
            [NameInMap("OrderDetail")]
            [Validation(Required=false)]
            public GetDataExportOrderDetailResponseBodyDataExportOrderDetailOrderDetail OrderDetail { get; set; }
            public class GetDataExportOrderDetailResponseBodyDataExportOrderDetailOrderDetail : TeaModel {
                /// <summary>
                /// The number of rows that are affected by the system check.
                /// </summary>
                [NameInMap("ActualAffectRows")]
                [Validation(Required=false)]
                public long? ActualAffectRows { get; set; }

                /// <summary>
                /// The category of the reason for the data export.
                /// </summary>
                [NameInMap("Classify")]
                [Validation(Required=false)]
                public string Classify { get; set; }

                /// <summary>
                /// The database from which data is exported.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The ID of the database from which you want to export data.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                /// <summary>
                /// The type of the environment to which the database belongs.
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The SQL statement that is executed to export data.
                /// </summary>
                [NameInMap("ExeSQL")]
                [Validation(Required=false)]
                public string ExeSQL { get; set; }

                /// <summary>
                /// Indicates whether the affected rows are skipped.
                /// </summary>
                [NameInMap("IgnoreAffectRows")]
                [Validation(Required=false)]
                public bool? IgnoreAffectRows { get; set; }

                /// <summary>
                /// The reason why the affected rows are skipped.
                /// </summary>
                [NameInMap("IgnoreAffectRowsReason")]
                [Validation(Required=false)]
                public string IgnoreAffectRowsReason { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
