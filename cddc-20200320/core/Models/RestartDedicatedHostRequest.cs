// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class RestartDedicatedHostRequest : TeaModel {
        /// <summary>
        /// The host ID. You can log on to the ApsaraDB for MyBase console and go to the **Hosts** page to view the host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The switchover method of the primary instance. Valid values:
        /// 
        /// *   **MaintainTime** (default): The system performs a switchover within a maintenance window. The system switches workloads from the primary instance on the host to the secondary instance on another host, and then restarts the current host. This prevents service interruptions.
        /// *   **Immediate**: The system immediately restarts the host.
        /// </summary>
        [NameInMap("FailoverMode")]
        [Validation(Required=false)]
        public string FailoverMode { get; set; }

        /// <summary>
        /// Specifies whether to forcefully restart the host. Valid values:
        /// 
        /// *   true: The system forcefully restarts the host. If this value is used, the system powers off the host. This results in the loss of cached data that is not written to storage. Exercise caution when you select this value.
        /// *   false (default): The system restarts the host normally.
        /// 
        /// >  This parameter takes effect only for hosts that are created in ApsaraDB MyBase for Redis dedicated clusters of the Enhanced Edition (Tair). Hosts that are created in ApsaraDB MyBase dedicated clusters that run other database engines can be restarted normally.
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// [The region ID](~~198326~~) of the host.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
