// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterRequest : TeaModel {
        /// <summary>
        /// <para>The type of cluster resource that you want to delete or retain.</para>
        /// </summary>
        [NameInMap("delete_options")]
        [Validation(Required=false)]
        public List<DeleteClusterRequestDeleteOptions> DeleteOptions { get; set; }
        public class DeleteClusterRequestDeleteOptions : TeaModel {
            /// <summary>
            /// <para>The deletion policy for the specified type of resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>delete: deletes the specified type of resource.</description></item>
            /// <item><description>retain: retains the specified type of resource.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delete</para>
            /// </summary>
            [NameInMap("delete_mode")]
            [Validation(Required=false)]
            public string DeleteMode { get; set; }

            /// <summary>
            /// <para>The type of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SLB: SLB resources created for Services. By default, the SLB resources are automatically deleted.</description></item>
            /// <item><description>ALB: Application Load Balancer (ALB) resources created by the ALB Ingress controller. By default, the ALB resources are retained.</description></item>
            /// <item><description>SLS_Data: Simple Log Service projects used by the cluster logging feature. By default, the Simple Log Service projects are retained.</description></item>
            /// <item><description>SLS_ControlPlane: Simple Log Service projects used to store the logs of control planes in ACK managed clusters. By default, the Simple Log Service projects are retained.</description></item>
            /// <item><description>PrivateZone: PrivateZone resources created by ACK Serverless clusters. By default, the PrivateZone resources are retained.</description></item>
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
        /// <para>Specifies whether to retain the Server Load Balancer (SLB) resources that are created by the cluster.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains the SLB instances that are created by the cluster.</description></item>
        /// <item><description><c>false</c>: does not retain the SLB instances that are created by the cluster.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>. Set resource_type to <c>SLB</c> in the <c>delete_options</c> parameter to manage SLB instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? KeepSlb { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain all resources. If you set the parameter to <c>true</c>, the <c>retain_resources</c> parameter is ignored. The cloud resources that are created by the cluster are retained. You can call the <c>DescribeClusterResources</c> operation to query cloud resources created by the cluster. If you set the parameter to <c>false</c>, resources to be retained by default in the <c>delete_options</c> parameter are still retained. To delete these resources, set <c>delete_mode</c> to <c>delete</c> in <c>delete_options</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: retains all resources, including cloud resources created by the cluster.</description></item>
        /// <item><description><c>false</c>: does not retain all resources. Resources to be retained by default in the <c>delete_options</c> parameter are retained. For example, <c>ALB</c> instances are retained when this parameter is set to <c>false</c>.</description></item>
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
        /// <para>The list of resources. To retain resources when you delete a cluster, you need to specify the IDs of the resources to be retained.</para>
        /// </summary>
        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

    }

}
