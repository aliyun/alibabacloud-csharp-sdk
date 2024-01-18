// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteClusterRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to obtain cluster IDs.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to release Elastic Compute Service (ECS) instances that are created by using Elastic High Performance Computing (E-HPC).
        /// 
        /// Default value: true.
        /// </summary>
        [NameInMap("ReleaseInstance")]
        [Validation(Required=false)]
        public string ReleaseInstance { get; set; }

    }

}
