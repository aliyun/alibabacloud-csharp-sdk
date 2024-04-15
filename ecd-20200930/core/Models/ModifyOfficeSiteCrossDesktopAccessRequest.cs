// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteCrossDesktopAccessRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the communication between cloud computers in an office network. If you enable the communication between cloud computers in an office network, the cloud computers can access each other.
        /// </summary>
        [NameInMap("EnableCrossDesktopAccess")]
        [Validation(Required=false)]
        public bool? EnableCrossDesktopAccess { get; set; }

        /// <summary>
        /// The office network ID.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
