// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// The ID of the physical database. You can call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation to obtain the ID of the physical database.
        /// </summary>
        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

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

        /// <summary>
        /// Specifies whether to return the GUID of a table. Valid values:
        /// 
        /// *   **true**: returns the GUID of a table.
        /// *   **false**: does not return the GUID of a table.
        /// </summary>
        [NameInMap("ReturnGuid")]
        [Validation(Required=false)]
        public bool? ReturnGuid { get; set; }

        /// <summary>
        /// The name used to search for tables. Fuzzy search is supported.
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
