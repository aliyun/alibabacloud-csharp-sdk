// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterShrinkRequest : TeaModel {
        /// <summary>
        /// The type of cluster resource that you want to delete or retain.
        /// </summary>
        [NameInMap("delete_options")]
        [Validation(Required=false)]
        public string DeleteOptionsShrink { get; set; }

        /// <summary>
        /// Specifies whether to retain the Server Load Balancer (SLB) instances that are created by the cluster.
        /// 
        /// *   `true`: retains the SLB instances that are created by the cluster.
        /// *   `false`: does not retain the SLB instances that are created by the cluster.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// Specifies whether to retain all resources. If you set the parameter to `true`, the `retain_resources` parameter is ignored.
        /// 
        /// *   `true`: retains all resources.
        /// *   `false`: does not retain all resources.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("retain_all_resources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        /// <summary>
        /// The list of resources. To retain resources when you delete a cluster, you need to specify the IDs of the resources to be retained.
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public string RetainResourcesShrink { get; set; }

    }

}
