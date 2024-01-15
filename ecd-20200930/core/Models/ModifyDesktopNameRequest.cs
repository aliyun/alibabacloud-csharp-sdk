// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopNameRequest : TeaModel {
        /// <summary>
        /// The cloud computer ID.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The new name of the cloud desktop. The name of the cloud desktop must meet the following requirements:
        /// 
        /// *   The name must be 1 to 64 characters in length.
        /// *   The name must start with a letter but cannot start with `http://` or `https://`.
        /// *   It can contain letters, digits, colons (:), underscores (\_), periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("NewDesktopName")]
        [Validation(Required=false)]
        public string NewDesktopName { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
