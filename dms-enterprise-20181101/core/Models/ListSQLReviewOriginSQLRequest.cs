// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLRequest : TeaModel {
        /// <summary>
        /// The parameters that are used to filter SQL statements involved in the ticket.
        /// </summary>
        [NameInMap("OrderActionDetail")]
        [Validation(Required=false)]
        public ListSQLReviewOriginSQLRequestOrderActionDetail OrderActionDetail { get; set; }
        public class ListSQLReviewOriginSQLRequestOrderActionDetail : TeaModel {
            /// <summary>
            /// The review status of the SQL statement. Valid values:
            /// 
            /// *   **new**: The SQL statement is pending for analysis.
            /// *   **unknown**: The SQL statement failed to be parsed.
            /// *   **check_not_pass**: The SQL statement failed the review.
            /// *   **check_pass**: The SQL statement passed the review.
            /// *   **force_pass**: The SQL statement passed the review by manual effort.
            /// *   **force_not_pass**: The SQL statement failed the review by manual effort.
            /// </summary>
            [NameInMap("CheckStatusResult")]
            [Validation(Required=false)]
            public string CheckStatusResult { get; set; }

            /// <summary>
            /// The ID of the file.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// The paging settings.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListSQLReviewOriginSQLRequestOrderActionDetailPage Page { get; set; }
            public class ListSQLReviewOriginSQLRequestOrderActionDetailPage : TeaModel {
                /// <summary>
                /// The number of the page to return.
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// The number of entries to return on each page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            /// <summary>
            /// The optimization suggestion for the SQL statement. Valid values:
            /// 
            /// *   **MUST_IMPROVE**: The SQL statement must be improved.
            /// *   **POTENTIAL_ISSUE**: The SQL statement contains potential issues.
            /// *   **SUGGEST_IMPROVE**: We recommend that you improve the SQL statement.
            /// *   **USE_DMS_TOOLKIT**: We recommend that you change schemas without locking tables.
            /// *   **USE_DMS_DML_UNLOCK**: We recommend that you change data without locking tables.
            /// *   **TABLE_INDEX_SUGGEST**: We recommend that you use SQL statements that use indexes.
            /// </summary>
            [NameInMap("SQLReviewResult")]
            [Validation(Required=false)]
            public string SQLReviewResult { get; set; }

        }

        /// <summary>
        /// The ID of the ticket for the SQL review. You can call the [CreateSQLReviewOrder](~~257777~~) operation to query the ID of the ticket.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://www.alibabacloud.com/help/en/data-management-service/latest/getuseractivetenant) or [ListUserTenants](https://www.alibabacloud.com/help/en/data-management-service/latest/listusertenants) operation to query the ID of the tenant.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
