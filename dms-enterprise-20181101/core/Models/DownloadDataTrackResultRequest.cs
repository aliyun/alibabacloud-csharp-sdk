// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DownloadDataTrackResultRequest : TeaModel {
        /// <summary>
        /// The condition to filter columns.
        /// </summary>
        [NameInMap("ColumnFilter")]
        [Validation(Required=false)]
        public DownloadDataTrackResultRequestColumnFilter ColumnFilter { get; set; }
        public class DownloadDataTrackResultRequestColumnFilter : TeaModel {
            /// <summary>
            /// The end value of the range used in the filter condition. This parameter takes effect only when Operator is set to BETWEEN.
            /// </summary>
            [NameInMap("BetweenEnd")]
            [Validation(Required=false)]
            public string BetweenEnd { get; set; }

            /// <summary>
            /// The start value of the range used in the filter condition. This parameter takes effect only when Operator is set to BETWEEN.
            /// </summary>
            [NameInMap("BetweenStart")]
            [Validation(Required=false)]
            public string BetweenStart { get; set; }

            /// <summary>
            /// The name of the column.
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// The IN list used in the filter condition.
            /// </summary>
            [NameInMap("InList")]
            [Validation(Required=false)]
            public List<string> InList { get; set; }

            /// <summary>
            /// The type of the operator used to configure the filter condition. Valid values:
            /// 
            /// *   **EQUAL**: retrieves the column whose value is equal to the specified value.
            /// *   **NOT_EQUAL**: retrieves the column whose value is not equal to the specified value.
            /// *   **IN**: retrieves the column whose value is in the IN list.
            /// *   **BETWEEN**: retrieves the column whose value is in the specified range.
            /// *   **LESS**: retrieves the column whose value is less than the specified value.
            /// *   **MORE**: retrieves the column whose value is greater than the specified value.
            /// *   **NOT_IN**: retrieves the column whose value is not in the IN list.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The value used in the filter condition.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The IDs of the events.
        /// </summary>
        [NameInMap("EventIdList")]
        [Validation(Required=false)]
        public List<long?> EventIdList { get; set; }

        /// <summary>
        /// The end time of the time range in which you want to track data operations. The time must be specified in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("FilterEndTime")]
        [Validation(Required=false)]
        public string FilterEndTime { get; set; }

        /// <summary>
        /// The start time of the time range in which you want to track data operations. The time must be specified in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("FilterStartTime")]
        [Validation(Required=false)]
        public string FilterStartTime { get; set; }

        /// <summary>
        /// The names of the tables for which you want to track data operations.
        /// </summary>
        [NameInMap("FilterTableList")]
        [Validation(Required=false)]
        public List<string> FilterTableList { get; set; }

        /// <summary>
        /// The types of data operations that you want to track.
        /// </summary>
        [NameInMap("FilterTypeList")]
        [Validation(Required=false)]
        public List<string> FilterTypeList { get; set; }

        /// <summary>
        /// The ID of the ticket. You can call the [ListOrders](https://help.aliyun.com/document_detail/144643.html) operation to obtain the ticket ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The type of the SQL statement.
        /// 
        /// *   **REVERSE**: undoes or rolls back an executed SQL statement, which is equivalent to the UNDO SQL statement.
        /// *   **FORWARD**: redoes or re-executes an SQL statement that failed to be executed, which is equivalent to the REDO SQL statement.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RollbackSQLType")]
        [Validation(Required=false)]
        public string RollbackSQLType { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
