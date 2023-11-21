// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class ModifyDedicatedHostAttributeRequest : TeaModel {
        /// <summary>
        /// Indicates whether instances can be deployed on the host. Valid values:
        /// 
        /// *   **1**: yes.
        /// *   **0**: no.
        /// </summary>
        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        /// <summary>
        /// The host ID. You can log on to the ApsaraDB for MyBase console and go to the **Hosts** page to view the host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The [region ID](~~198326~~) of the host.
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
