// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AttachDdosToAcceleratorRequest : TeaModel {
        /// <summary>
        /// The ID of the GA instance with which the Anti-DDoS Pro/Premium instance is associated.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Pro/Premium instance to be associated with the GA instance.
        /// </summary>
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        public string DdosId { get; set; }

        /// <summary>
        /// The region where the Anti-DDoS Pro/Premium instance is deployed. Valid values:
        /// 
        /// *   **cn-hangzhou**: regions in the Chinese mainland
        /// *   **ap-southeast-1**: regions outside the Chinese mainland
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
