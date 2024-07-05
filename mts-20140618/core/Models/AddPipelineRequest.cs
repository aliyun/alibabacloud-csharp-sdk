// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddPipelineRequest : TeaModel {
        /// <summary>
        /// The name of the MPS queue. The name can be up to 128 bytes in size.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Message Service (MNS) configuration.
        /// </summary>
        [NameInMap("NotifyConfig")]
        [Validation(Required=false)]
        public string NotifyConfig { get; set; }

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

        /// <summary>
        /// The role.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The type of the MPS queue. Valid values:
        /// 
        /// *   **Boost**: MPS queue with transcoding speed boosted.
        /// *   **Standard**: standard MPS queue.
        /// *   **NarrowBandHDV2**: MPS queue that supports Narrowband HD 2.0.
        /// *   **AIVideoCover**: MPS queue for intelligent snapshot capture.
        /// *   **AIVideoTag**: MPS queue for video tagging. The supported regions are China (Shanghai), China (Beijing), and China (Hangzhou).
        /// 
        /// Default value: **Standard**.
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

        /// <summary>
        /// The level of the MPS queue. Valid values: **1 to 3**.
        /// </summary>
        [NameInMap("SpeedLevel")]
        [Validation(Required=false)]
        public long? SpeedLevel { get; set; }

    }

}
