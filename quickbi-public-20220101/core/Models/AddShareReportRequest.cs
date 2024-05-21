// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddShareReportRequest : TeaModel {
        /// <summary>
        /// The scope of authorization. Valid values:
        /// 
        /// *   1: view only
        /// *   3: View and export
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthPoint")]
        [Validation(Required=false)]
        public int? AuthPoint { get; set; }

        /// <summary>
        /// The validity period of the share. The value is a timestamp in milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// The ID of the person to be shared, which may be the user ID of the Quick BI or the user group ID.
        /// 
        /// *   If ShareToType is 0 (user), ShareTo is the user ID.
        /// *   When ShareToType is set to 1 (user group), ShareTo is the user group ID.
        /// *   When ShareToType=2 (organization), ShareTo is the ID of the organization.
        /// </summary>
        [NameInMap("ShareToId")]
        [Validation(Required=false)]
        public string ShareToId { get; set; }

        /// <summary>
        /// The share type of the template. Valid values:
        /// 
        /// *   0: user
        /// *   1: user group
        /// *   2: organization
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

        /// <summary>
        /// The ID of the shared work. The works here include BI portal, dashboards, spreadsheets, and self-service access.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
