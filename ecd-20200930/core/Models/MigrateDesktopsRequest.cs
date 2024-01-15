// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MigrateDesktopsRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud desktops. You can specify one or more cloud desktops. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the destination workspace.
        /// </summary>
        [NameInMap("TargetOfficeSiteId")]
        [Validation(Required=false)]
        public string TargetOfficeSiteId { get; set; }

    }

}
