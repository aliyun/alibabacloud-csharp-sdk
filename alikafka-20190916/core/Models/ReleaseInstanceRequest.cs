// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ReleaseInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to immediately release the physical resources of the instance. Valid values:
        /// 
        /// *   **true**: The physical resources of the instance are immediately released.
        /// *   **false**: The physical resources of the instance are retained for a period of time before they are released.
        /// </summary>
        [NameInMap("ForceDeleteInstance")]
        [Validation(Required=false)]
        public bool? ForceDeleteInstance { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
