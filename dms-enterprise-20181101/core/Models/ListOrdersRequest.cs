// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListOrdersRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The scope of the tickets that you want to query. Valid values:
        /// 
        /// *   **AS_ADMIN**: all tickets.
        /// *   **AS_COMMITTER**: the tickets that are submitted by the current user.
        /// *   **AS_HANDLER**: the tickets to be processed by the current user.
        /// *   **AS_OWNER**: the tickets that are processed by the current user.
        /// *   **AS_Related**: the tickets that are related to the current user.
        /// </summary>
        [NameInMap("OrderResultType")]
        [Validation(Required=false)]
        public string OrderResultType { get; set; }

        /// <summary>
        /// The status of the tickets that you want to query. Valid values:
        /// 
        /// *   **ALL**: queries the tickets of all statuses.
        /// *   **FINISHED**: queries the tickets that are completed.
        /// *   **RUNNING**: queries the tickets that are being processed.
        /// </summary>
        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

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
        /// The type of the tickets that you want to query. For more information, see [PluginType parameter](https://help.aliyun.com/document_detail/429109.html).
        /// </summary>
        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        /// <summary>
        /// The keyword that is used to query tickets.
        /// </summary>
        [NameInMap("SearchContent")]
        [Validation(Required=false)]
        public string SearchContent { get; set; }

        /// <summary>
        /// The time condition based on which you want to query tickets. Valid values:
        /// 
        /// *   **CREATE_TIME**: the time when a ticket was created.
        /// *   **MODIFY_TIME**: the time when a ticket was last modified.
        /// </summary>
        [NameInMap("SearchDateType")]
        [Validation(Required=false)]
        public string SearchDateType { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) or [ListUserTenants](https://help.aliyun.com/document_detail/198074.html) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
