// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteCrossDesktopAccessRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable cross-desktop access for a workspace.
        /// 
        /// *   true: enables cross-desktop access.
        /// *   false: disables cross-desktop access.
        /// </summary>
        [NameInMap("EnableCrossDesktopAccess")]
        [Validation(Required=false)]
        public bool? EnableCrossDesktopAccess { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
