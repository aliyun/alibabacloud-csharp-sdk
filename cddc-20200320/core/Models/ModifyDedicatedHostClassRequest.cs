// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class ModifyDedicatedHostClassRequest : TeaModel {
        /// <summary>
        /// The host ID. You can log on to the ApsaraDB for MyBase console and go to the **Hosts** page to view the host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The [region ID](~~198326~~).
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

        /// <summary>
        /// The time when you want to upgrade the specifications of the host. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// >  This parameter must be specified only when SwitchTimeMode is set to 2.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// The execution mode that is used to upgrade host specifications. Valid values:
        /// 
        /// *   **0** (default): immediately upgrades host specifications.
        /// *   **2**: upgrades host specifications at a specified point in time.
        /// 
        /// >  If you set this parameter to **2**, you must specify **SwitchTime**.
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// The instance type to which you want the host to be upgraded. For more information, see [Host specification details](~~206343~~).
        /// </summary>
        [NameInMap("TargetClassCode")]
        [Validation(Required=false)]
        public string TargetClassCode { get; set; }

    }

}
