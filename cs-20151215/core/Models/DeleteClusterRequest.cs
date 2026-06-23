// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterRequest : TeaModel {
        /// <summary>
        /// <para>The deletion options for cluster-associated resources.</para>
        /// </summary>
        [NameInMap("delete_options")]
        [Validation(Required=false)]
        public List<DeleteClusterRequestDeleteOptions> DeleteOptions { get; set; }
        public class DeleteClusterRequestDeleteOptions : TeaModel {
            /// <summary>
            /// <para>The deletion policy for this resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>delete: deletes resources of this type.</description></item>
            /// <item><description>retain: retains resources of this type.</description></item>
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
            /// <item><description>SLB: SLB resources created through services. Deleted by default. You can choose to retain them.</description></item>
            /// <item><description>ALB: ALB resources created by ALB Ingress Controller. Retained by default. You can choose to delete them.</description></item>
            /// <item><description>SLS_Data: the SLS project used by the cluster logging feature. Retained by default. You can choose to delete it.</description></item>
            /// <item><description>SLS_ControlPlane: the SLS project used by the control plane logs of managed clusters. Retained by default. You can choose to delete it.</description></item>
            /// <item><description>PrivateZone: PrivateZone resources created by ACK Serverless clusters. Retained by default. You can choose to delete them.</description></item>
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
        /// <para>Specifies whether to retain SLB resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the created SLB resources.</description></item>
        /// <item><description><c>false</c>: does not retain the created SLB resources.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.
        /// Use <c>SLB</c> in <c>delete_options</c> to manage this setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain all resources. If this parameter is set to <c>true</c>, <c>retain_resources</c> is ignored, and cloud resources created through the cluster that are queried by the <c>DescribeClusterResources</c> operation are retained. If this parameter is set to <c>false</c>, resources that are retained by default in <c>delete_options</c> are still retained. To delete these resources, set <c>delete_mode</c> to <c>delete</c> in <c>delete_options</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains all resources, including all cloud resources created through the cluster.</description></item>
        /// <item><description><c>false</c>: does not retain all resources, except resources defined as retained by default in <c>delete_options</c>. For example, <c>ALB</c> resources are still retained when this parameter is set to <c>false</c>.</description></item>
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
        /// <para>The resource list. To retain resources when you delete a cluster, specify the IDs of the resources to retain.</para>
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

    }

}
