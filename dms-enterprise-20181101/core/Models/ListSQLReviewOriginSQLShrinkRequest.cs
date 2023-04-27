// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the file.
        /// </summary>
        [NameInMap("OrderActionDetail")]
        [Validation(Required=false)]
        public string OrderActionDetailShrink { get; set; }

        /// <summary>
        /// The information about the parsed SQL statements.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

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
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
