// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchTableRequest : TeaModel {
        /// <summary>
        /// The type of database. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// *   **PostgreSQL**
        /// *   **Oracle**
        /// *   **DRDS**
        /// *   **OceanBase**
        /// *   **Mongo**
        /// *   **Redis**
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The type of the environment to which databases belong. For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

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
        /// Specifies whether to return the GUID of each table.
        /// </summary>
        [NameInMap("ReturnGuid")]
        [Validation(Required=false)]
        public bool? ReturnGuid { get; set; }

        /// <summary>
        /// The keyword that is used to query tables.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The scope of tables that you want to query. Valid values:
        /// 
        /// *   **HAS_PERMSSION**: the tables on which the current account has permissions.
        /// *   **OWNER**: the tables owned by the current account.
        /// *   **MY_FOCUS**: the tables that the current account follows.
        /// *   **UNKNOWN**: all tables.
        /// </summary>
        [NameInMap("SearchRange")]
        [Validation(Required=false)]
        public string SearchRange { get; set; }

        /// <summary>
        /// The type of table that you want to query. Valid values:
        /// 
        /// *   **TABLE**: physical and logical tables
        /// *   **SINGLE_TABLE**: physical tables
        /// *   **LOGIC_TABLE**: logical tables
        /// </summary>
        [NameInMap("SearchTarget")]
        [Validation(Required=false)]
        public string SearchTarget { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the [View information about the current tenant](https://help.aliyun.com/document_detail/181330.html) section of the "Manage DMS tenants" topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
