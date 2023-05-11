// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CancelReportShareRequest : TeaModel {
        /// <summary>
        /// The ID of the work. The works here include BI portal, dashboards, spreadsheets, and self-service access.
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// The ID of the person to be shared, which may be the user ID of the Quick BI or the user group ID.
        /// 
        /// *   If ShareToType is 0 (user), ShareTo is the user ID.
        /// *   When ShareToType is set to 1 (user group), ShareTo is the user group ID.
        /// *   When ShareToType=2 (organization), ShareTo is the ID of the organization.
        /// </summary>
        [NameInMap("ShareToIds")]
        [Validation(Required=false)]
        public string ShareToIds { get; set; }

        /// <summary>
        /// The deletion method. Valid values:
        /// 
        /// *   0: Delete by user
        /// *   1: Delete by user group
        /// *   2: Delete by organization
        /// </summary>
        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

    }

}
