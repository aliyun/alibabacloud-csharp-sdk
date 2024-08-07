// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDatabaseRequest : TeaModel {
        /// <summary>
        /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](https://help.aliyun.com/document_detail/198106.html).
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The environment type of the database. For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
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
        /// The keyword that is used to search for databases.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The query range based on permissions. Valid values:
        /// 
        /// *   **HAS_PERMSSION**: searches for databases on which the current user has permissions.
        /// *   **OWNER**: searches for databases owned by the current user.
        /// *   **MY_FOCUS**: searches for databases that the current user follows.
        /// *   **UNKNOWN**: searches for all databases.
        /// </summary>
        [NameInMap("SearchRange")]
        [Validation(Required=false)]
        public string SearchRange { get; set; }

        /// <summary>
        /// The category of the database. Valid values:
        /// 
        /// *   **DB**: single database or logical database.
        /// *   **SINGLE_DB**: single database.
        /// *   **LOGIC_DB**: logical database.
        /// </summary>
        [NameInMap("SearchTarget")]
        [Validation(Required=false)]
        public string SearchTarget { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
