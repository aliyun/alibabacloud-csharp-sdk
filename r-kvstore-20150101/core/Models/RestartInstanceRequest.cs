// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RestartInstanceRequest : TeaModel {
        /// <summary>
        /// The time when you want to restart the instance. Default value: Immediately. Valid values:
        /// 
        /// *   **Immediately**: immediately restarts the instance.
        /// *   **MaintainTime**: restarts the instance during the maintenance window.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Specifies whether to update to the latest minor version when the instance is restarted. Valid values:
        /// 
        /// *   **true**: updates the minor version.
        /// *   **false**: does not update the minor version.
        /// 
        /// > The default value is **true**.
        /// </summary>
        [NameInMap("UpgradeMinorVersion")]
        [Validation(Required=false)]
        public bool? UpgradeMinorVersion { get; set; }

    }

}
