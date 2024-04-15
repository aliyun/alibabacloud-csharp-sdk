// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopHostNameRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud computer.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The new hostname of the cloud computer. The hostname must meet the following requirements:
        /// 
        /// *   The hostname must be 2 to 15 characters in length.
        /// *   The hostname can contain only letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
        /// </summary>
        [NameInMap("NewHostName")]
        [Validation(Required=false)]
        public string NewHostName { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
