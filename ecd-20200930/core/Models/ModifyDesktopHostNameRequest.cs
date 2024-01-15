// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopHostNameRequest : TeaModel {
        /// <summary>
        /// The cloud desktop ID.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The new hostname of the cloud desktop. The hostname must meet the following requirements:
        /// 
        /// *   It must be 2 to 15 characters in length.
        /// *   It can contain letters, digits, and hyphens (-). The hostname cannot start or end with a hyphen (-), contain consecutive hyphens (-), or contain only digits.
        /// </summary>
        [NameInMap("NewHostName")]
        [Validation(Required=false)]
        public string NewHostName { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
