// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopIdsByVulNamesRequest : TeaModel {
        /// <summary>
        /// The priority to fix the vulnerability or the risk level of the vulnerability. Valid values:
        /// 
        /// *   asap: high
        /// *   later: medium
        /// *   nntf: low
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

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

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   cve: Linux software vulnerability
        /// *   sys: Windows system vulnerability
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VulName")]
        [Validation(Required=false)]
        public List<string> VulName { get; set; }

    }

}
