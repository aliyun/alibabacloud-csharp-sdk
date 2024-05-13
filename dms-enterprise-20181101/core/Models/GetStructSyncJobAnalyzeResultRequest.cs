// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobAnalyzeResultRequest : TeaModel {
        /// <summary>
        /// The type of the comparison. Valid values:
        /// 
        /// *   **CREATE_TABLE**: compares the created tables.
        /// *   **ALTER_TABLE**: compares the modified tables.
        /// *   **EQUAL_TABLE**: compares the identical tables.
        /// *   **PASS_TABLE**: compares the tables that are skipped during schema synchronization.
        /// *   **NOT_COMPARE**: does not compare tables.
        /// </summary>
        [NameInMap("CompareType")]
        [Validation(Required=false)]
        public string CompareType { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see [Manage DMS tenants](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
