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
            /// <para>新数据库的IP地址。</para>
            /// <remarks>
            /// <para>当<b>Endpoint.InstanceType</b>取值为<b>Express</b>时，本参数才可用且必须传入。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.15.185.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>ECS或专有网络的实例ID。</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>当<b>Endpoint.InstanceType</b>取值为<b>ECS</b>时，本参数需传入ECS实例的ID。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>当<b>Endpoint.InstanceType</b>取值为<b>Express</b>时，本参数需传入专有网络ID。</description></item>
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
            /// <para>新数据库所属的实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>LocalInstance</b>：有公网IP的自建数据库；</description></item>
            /// <item><description><b>ECS</b>：ECS上的自建数据库。</description></item>
            /// <item><description><b>Express</b>：通过专线接入的自建数据库。</description></item>
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
            /// <para>新的数据库服务端口。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>待调整连接信息的实例，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>Source</b>：源实例。</description></item>
            /// <item><description><b>Destination</b>：目标实例。</description></item>
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
            /// <para>当源实例与目标实例所属阿里云账号不同时，您需要传入该参数指定源实例的所属阿里云账号的ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>14069264****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>当源实例与目标实例所属阿里云账号不同时，需传入该参数，来指定源实例的授权角色，以允许目标实例阿里云账号访问源实例的实例信息。</para>
            /// <remarks>
            /// <para>角色所需的权限及授权方式，请参见<a href="https://help.aliyun.com/document_detail/48468.html">跨阿里云账号数据迁移或同步时如何配置RAM授权</a>。</para>
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
        /// <para>The Alibaba Cloud account ID. You do not need to specify this parameter because it will be deprecated.</para>
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

        /// <summary>
        /// <para>The region ID. Specify this parameter to indicate the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>Forward</b>. The value <b>Reverse</b> takes effect only when the synchronization topology of the data synchronization instance is two-way synchronization.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>Instance ID of the data synchronization instance. You can call the DescribeSynchronizationJobs operation to query instance ID.</para>
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
