// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SwitchSynchronizationEndpointRequest : TeaModel {
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestEndpoint Endpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestEndpoint : TeaModel {
            /// <summary>
            /// <para>The IP address of the database.</para>
            /// <remarks>
            /// <para> You must specify the IP address only if the <b>Endpoint.InstanceType</b> parameter is set to <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.15.185.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The ID of the ECS instance or the virtual private cloud (VPC).</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>If the <b>Endpoint.InstanceType</b> parameter is set to <b>ECS</b>, you must specify the ID of the ECS instance.</description></item>
            /// <item><description>If the <b>Endpoint.InstanceType</b> parameter is set to <b>Express</b>, you must specify the ID of the VPC.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp11haem1kpkhoup****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance type of the database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
            /// <item><description><b>ECS</b>: self-managed database that is hosted on ECS</description></item>
            /// <item><description><b>Express</b>: self-managed database that is connected over Express Connect</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The service port number of the database.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>Specifies whether to update the connection settings of the source instance or the destination instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Source</b></description></item>
            /// <item><description><b>Destination</b></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Destination</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestSourceEndpoint SourceEndpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the source instance belongs. You must specify this parameter only if the source instance and the destination instance belong to different Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14069264****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>The authorized Resource Access Management (RAM) role of the source instance. You must specify the RAM role only if the source instance and the destination instance belong to different Alibaba Cloud accounts. You can use the RAM role to allow the Alibaba Cloud account that owns the destination instance to access the source instance.</para>
            /// <remarks>
            /// <para> For information about the permissions and authorization methods of the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration and synchronization</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ram-for-dts</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b></description></item>
        /// <item><description><b>Reverse</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: <b>Forward</b>.</para>
        /// </remarks>
        /// <para>The value <b>Reverse</b> takes effect only if the topology of the data synchronization instance is two-way synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization instance. You can call the DescribeSynchronizationJobs operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsexjk1alb116****</para>
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

    }

}
