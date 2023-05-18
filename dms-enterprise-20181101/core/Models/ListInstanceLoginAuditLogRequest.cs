// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstanceLoginAuditLogRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// 
        /// >  The end time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format. We recommend that you use the StartTime and EndTime parameters to specify a time range that does not exceed one day. This way, the returned entries can be displayed by page to increase query efficiency.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The alias of the user.
        /// </summary>
        [NameInMap("OpUserName")]
        [Validation(Required=false)]
        public string OpUserName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the database or instance whose logon records you want to query.
        /// 
        /// >  If SQL statements are executed at the instance level, you can set this parameter to an instance name. If SQL statements are executed at the database level, you can set this parameter to a database name.
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// >  The start time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
