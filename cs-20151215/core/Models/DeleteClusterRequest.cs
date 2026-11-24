// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterRequest : TeaModel {
        /// <summary>
        /// <para>The deletion options for the resources associated with the cluster.</para>
        /// </summary>
        [NameInMap("delete_options")]
        [Validation(Required=false)]
        public List<DeleteClusterRequestDeleteOptions> DeleteOptions { get; set; }
        public class DeleteClusterRequestDeleteOptions : TeaModel {
            /// <summary>
            /// <para>The deletion mode for this type of resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>delete: Deletes this type of resource.</description></item>
            /// <item><description>retain: Retains this type of resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delete</para>
            /// </summary>
            [NameInMap("delete_mode")]
            [Validation(Required=false)]
            public string DeleteMode { get; set; }

            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SLB: SLB resources created by using services. By default, these resources are deleted. You can choose to retain them.</description></item>
            /// <item><description>ALB: ALB resources created by ALB Ingress Controller. By default, these resources are retained. You can choose to delete them.</description></item>
            /// <item><description>SLS_Data: SLS projects used for the cluster logging feature. By default, these resources are retained. You can choose to delete them.</description></item>
            /// <item><description>SLS_ControlPlane: SLS projects used for the control plane logs of managed clusters. By default, these resources are retained. You can choose to delete them.</description></item>
            /// <item><description>PrivateZone: PrivateZone resources created by ACK Serverless clusters. By default, these resources are retained. You can choose to delete them.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SLS_Data</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use <c>SLB</c> in <c>delete_options</c> instead. Specifies whether to retain the SLB instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Retains the created SLB resources.</description></item>
        /// <item><description><c>false</c>: Does not retain the created SLB resources.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain all resources. If you set this parameter to <c>true</c>, the <c>retain_resources</c> parameter is ignored, and the cloud resources created by the cluster that are queried by calling the <c>DescribeClusterResources</c> operation are retained. If you set this parameter to <c>false</c>, note that the resources that are retained by default in <c>delete_options</c> are still retained. To delete these resources, set <c>delete_mode</c> to <c>delete</c> in <c>delete_options</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Retains all resources, including all cloud resources created by the cluster.</description></item>
        /// <item><description><c>false</c>: Does not retain all resources, except for the resources that are retained by default in <c>delete_options</c>. For example, <c>ALB</c> resources are still retained even if this parameter is set to <c>false</c>.</description></item>
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
        /// <para>The list of resources to retain. If you want to retain resources when deleting a cluster, you must provide the IDs of the corresponding resources.</para>
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

    }

}
