// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class TransformClusterMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the instance that you want to import or migrate. Separate multiple IDs with commas (,).
        /// 
        /// *   An instance may not belong to a cluster, but an instance can belong to only one cluster at most.
        /// *   The ECS instances and the destination cluster must be in the same virtual private cloud (VPC).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The logon password of the ECS instance that you want to import or migrate to the cluster.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The ID of the destination cluster.
        /// </summary>
        [NameInMap("TargetClusterId")]
        [Validation(Required=false)]
        public string TargetClusterId { get; set; }

    }

}
