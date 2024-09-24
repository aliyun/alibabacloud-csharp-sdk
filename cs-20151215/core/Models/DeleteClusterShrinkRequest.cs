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
        /// Specifies whether to retain the Server Load Balancer (SLB) resources that are created by the cluster.
        /// 
        /// *   `true`: retains the SLB instances that are created by the cluster.
        /// *   `false`: does not retain the SLB instances that are created by the cluster.
        /// 
        /// Default value: `false`. Set resource_type to `SLB` in the `delete_options` parameter to manage SLB instances.
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// Specifies whether to retain all resources. If you set the parameter to `true`, the `retain_resources` parameter is ignored. The cloud resources that are created by the cluster are retained. You can call the `DescribeClusterResources` operation to query cloud resources created by the cluster. If you set the parameter to `false`, resources to be retained by default in the `delete_options` parameter are still retained. To delete these resources, set `delete_mode` to `delete` in `delete_options`.
        /// 
        /// *   `true`: retains all resources, including cloud resources created by the cluster.
        /// *   `false`: does not retain all resources. Resources to be retained by default in the `delete_options` parameter are retained. For example, `ALB` instances are retained when this parameter is set to `false`.
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
