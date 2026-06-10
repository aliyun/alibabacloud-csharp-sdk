// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The options for deleting the resources that are associated with the cluster.</para>
        /// </summary>
        [NameInMap("delete_options")]
        [Validation(Required=false)]
        public string DeleteOptionsShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Whether to retain SLB resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Retains the SLB resources that are created for the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not retain the SLB resources that are created for the cluster.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.
        /// Use the <c>delete_options</c> parameter to manage <c>SLB</c> resources instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// <para>Whether to retain all associated resources. If you set this parameter to <c>true</c>, the <c>retain_resources</c> parameter is ignored, and all cloud resources that are created with the cluster and can be queried by calling <c>DescribeClusterResources</c> are retained. If you set this parameter to <c>false</c>, note that resources that are configured to be retained by default in the <c>delete_options</c> parameter are still retained. To delete these resources, you must explicitly set the <c>delete_mode</c> parameter to <c>delete</c> for them in <c>delete_options</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Retains all associated cloud resources that are created with the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not retain all associated cloud resources. Resources that are configured to be retained by default in the <c>delete_options</c> parameter, such as <c>ALB</c>, are still retained when this parameter is set to <c>false</c>.</para>
        /// </description></item>
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
        /// <para>The IDs of resources to retain when the cluster is deleted.</para>
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public string RetainResourcesShrink { get; set; }

    }

}
