/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class AttachClusterToHubRequest : TeaModel {
        /// <summary>
        /// Specifies whether to associate the clusters with Service Mesh (ASM) instances. Valid values:
        /// </summary>
        [NameInMap("AttachToMesh")]
        [Validation(Required=false)]
        public bool? AttachToMesh { get; set; }

        /// <summary>
        /// The ID of the master instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// A JSON string that can be parsed into a string array. The string specifies the clusters that you want to associate with the master instance.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

    }

}
