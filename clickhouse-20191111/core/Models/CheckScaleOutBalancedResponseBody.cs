// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CheckScaleOutBalancedResponseBody : TeaModel {
        /// <summary>
        /// The check result. Valid values:
        /// 
        /// *   **400**: The cluster failed the check.
        /// *   **200**: The cluster passed the check.
        /// </summary>
        [NameInMap("CheckCode")]
        [Validation(Required=false)]
        public string CheckCode { get; set; }

        /// <summary>
        /// The total number of returned pages.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The error information returned for a check failure.
        /// </summary>
        [NameInMap("TableDetails")]
        [Validation(Required=false)]
        public CheckScaleOutBalancedResponseBodyTableDetails TableDetails { get; set; }
        public class CheckScaleOutBalancedResponseBodyTableDetails : TeaModel {
            [NameInMap("TableDetail")]
            [Validation(Required=false)]
            public List<CheckScaleOutBalancedResponseBodyTableDetailsTableDetail> TableDetail { get; set; }
            public class CheckScaleOutBalancedResponseBodyTableDetailsTableDetail : TeaModel {
                /// <summary>
                /// The cluster. The value is fixed as **default**.
                /// </summary>
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The error details. Valid values:
                /// 
                /// *   **1**: The unique distributed table is missing.
                /// *   **2**: More than one distributed table exists for the local table.
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public int? Detail { get; set; }

                /// <summary>
                /// The name of the local table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// The amount of time that is required for the migration and scale-out. Unit: minutes.
        /// </summary>
        [NameInMap("TimeDuration")]
        [Validation(Required=false)]
        public string TimeDuration { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
