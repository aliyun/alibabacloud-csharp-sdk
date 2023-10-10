// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeleteClusterMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The member ID of the ECS instance that you want to remove from the cluster.
        /// </summary>
        [NameInMap("ClusterMemberId")]
        [Validation(Required=false)]
        public string ClusterMemberId { get; set; }

    }

}
