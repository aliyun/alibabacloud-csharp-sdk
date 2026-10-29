// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The deletion options for the resources associated with the cluster.</para>
        /// </summary>
        [NameInMap("delete_options")]
        [Validation(Required=false)]
        public string DeleteOptionsShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to retain the Server Load Balancer (SLB) instances created by using Services.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the created SLB resources.</description></item>
        /// <item><description><c>false</c>: does not retain the created SLB resources.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.
        /// <b>[Deprecated]</b> Use <c>SLB</c> in <c>delete_options</c> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain all resources. If you set this parameter to <c>true</c>, the <c>retain_resources</c> parameter is ignored, and all cloud resources created by the cluster that are queried by calling the <c>DescribeClusterResources</c> operation are retained. If you set this parameter to <c>false</c>, note that the resources that are retained by default in <c>delete_options</c> are still retained. To delete these resources, set <c>delete_mode</c> to <c>delete</c> in <c>delete_options</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains all resources, including all cloud resources created by the cluster.</description></item>
        /// <item><description><c>false</c>: does not retain all resources, except for the resources that are retained by default in <c>delete_options</c>. For example, ALB resources are still retained even if this parameter is set to <c>false</c>.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("retain_all_resources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        /// <summary>
        /// <para>The list of resources. To retain resources when you delete the cluster, specify the IDs of the corresponding resources.</para>
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public string RetainResourcesShrink { get; set; }

    }

}
