// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOpLogRequest : TeaModel {
        /// <summary>
        /// DatabaseName.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the yyyy-MM-DD HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The functional module for which you want to query operation logs. If you do not specify this parameter, operation logs for all functional modules are returned. Valid values:
        /// 
        /// *   **PERMISSION**: permissions
        /// *   **OWNER**: data owner
        /// *   **SQL_CONSOLE**: data query
        /// *   **SQL_CONSOLE_EXPORT**: query result export
        /// *   **DATA_CHANGE**: data change
        /// *   **DATA_EXPORT**: data export
        /// *   **SQL_REVIEW**: SQL review
        /// *   **DT_SYNC**: database and table synchronization
        /// *   **DT_DETAIL**: database and table details
        /// *   **DB_TASK**: task management
        /// *   **INSTANCE_MANAGE**: instance management
        /// *   **USER_MANAGE**: user management
        /// *   **SECURITY_RULE**: security rules
        /// *   **CONFIG_MANAGE**: configuration management
        /// *   **RESOURCE_AUTH**: resource authorization
        /// *   **ACCESS_WHITE_IP**: access IP address whitelist
        /// *   **NDDL**: schema design
        /// *   **DSQL_CONSOLE**: cross-database data query
        /// *   **DSQL_CONSOLE_EXPORT**: cross-database query result export
        /// *   **DATA_TRACT**: data tracking
        /// *   **DATA_QUALITY**: data quality
        /// *   **DATALINK_MANAGE** :DBLink management
        /// *   **DATASEC_MANAGE**: sensitive data management
        /// *   **SELL**: sales
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   30
        /// *   50
        /// *   100
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-DD HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// UserNick.
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
