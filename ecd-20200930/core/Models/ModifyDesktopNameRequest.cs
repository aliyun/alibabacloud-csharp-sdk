// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopNameRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud computer.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The new name of the cloud computer. The name of the cloud computer must meet the following requirements:
        /// 
        /// *   The name must be 1 to 64 characters in length.
        /// *   The name must start with a letter but cannot start with `http://` or `https://`.
        /// *   The name can only contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("NewDesktopName")]
        [Validation(Required=false)]
        public string NewDesktopName { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
