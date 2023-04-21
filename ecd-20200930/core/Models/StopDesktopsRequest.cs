// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class StopDesktopsRequest : TeaModel {
        /// <summary>
        /// The IDs of cloud desktops. You can specify up to 20 cloud desktop IDs.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The billing mode after you stop the cloud desktop.
        /// 
        /// *   StopCharging: Computing resources are not billed after you stop the cloud desktop. After the cloud desktop is stopped, the system automatically reclaims computing resources. From this point on, you are no longer charged for computing resources. However, you are still charged for storage resources.
        /// *   KeepCharging: The billing continues after you stop the cloud desktop. After the cloud desktop is stopped, the system does not reclaim resources to avoid startup failures due to insufficient resources. You are still charged for the resources.
        /// 
        /// Default value: StopCharging
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
