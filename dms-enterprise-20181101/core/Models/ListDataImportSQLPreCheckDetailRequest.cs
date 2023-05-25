// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataImportSQLPreCheckDetailRequest : TeaModel {
        /// <summary>
        /// The ticket ID. You can call the [ListOrders](~~144643~~) operation to query the ticket ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumer")]
        [Validation(Required=false)]
        public long? PageNumer { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The type of the SQL statement. Valid values:
        /// 
        /// *   **SELECT**
        /// *   **INSERT**
        /// *   **DELETE**
        /// *   **CREATE_TABLE**
        /// 
        /// > You can log on to the Data Management (DMS) console and choose **Security and Specifications** > **Operation Audit** in the top navigation bar to view more types of SQL statements.
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// The state of the ticket. If you leave this parameter empty, all the states are queried by default. Valid values:
        /// 
        /// *   **INIT**: The ticket is being initialized.
        /// *   **RUNNING**: The ticket is in progress.
        /// *   **SUCCESS**: The ticket is complete.
        /// *   **TIMEOUT**: The ticket is skipped due to timeout.
        /// *   **FAIL**: The ticket fails.
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// The tenant ID. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
