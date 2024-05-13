// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class AttachClusterToHubRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **AttachClusterToHub**.
        /// </summary>
        [NameInMap("AttachToMesh")]
        [Validation(Required=false)]
        public bool? AttachToMesh { get; set; }

        /// <summary>
        /// The ID of the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

    }

}
