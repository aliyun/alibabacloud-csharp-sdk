// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the instance is associated with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>host: The instance is associated with the dedicated host. When an instance that has economical mode enabled is restarted after being stopped, the instance is still deployed on the original dedicated host.</para>
        /// </description></item>
        /// <item><description><para>default: The instance is not associated with the dedicated host. When an instance that has economical mode enabled is restarted after being stopped, if the resources of the original dedicated host are insufficient, the instance can be migrated to another dedicated host in the automatic deployment resource pool.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value when migrating an instance from a shared host to a dedicated host: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host</para>
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host. You can call <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> to query available dedicated hosts.</para>
        /// <para>When you modify the host of an ECS instance (migrate the instance from a shared host to a dedicated host or between dedicated hosts):</para>
        /// <list type="bullet">
        /// <item><description>To migrate the instance to a specified dedicated host, you must specify this parameter.</description></item>
        /// <item><description>To migrate the instance to a dedicated host that is automatically selected by the system, you must set this parameter to empty and set the <c>Tenancy</c> parameter to host.</description></item>
        /// </list>
        /// <para>For more information about the automatic deployment feature, see <a href="https://help.aliyun.com/document_detail/118938.html">Features of dedicated hosts</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The group number of the instance in the deployment set when the deployment set uses the availability group strategy (AvailabilityGroup). Valid values: 1 to 7.</para>
        /// <remarks>
        /// <para>If you change the deployment set of an ECS instance and the deployment set uses the availability group strategy (<c>AvailablilityGroup</c>), the system automatically distributes ECS instances evenly across groups when this parameter is not specified. If you specify the same deployment set that the instance currently belongs to, the system also redistributes ECS instances evenly across groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public int? DeploymentSetGroupNo { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set.</para>
        /// <para>This parameter is required when you add an ECS instance to a deployment set or change the deployment set of an ECS instance.</para>
        /// <remarks>
        /// <para>When you modify dedicated host-related parameters (<c>Tenancy</c>, <c>Affinity</c>, and <c>DedicatedHostId</c>), you cannot modify the deployment set at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully change the host when the instance is added to a deployment set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Allows the operation. Allows restarting ECS instances in the Running or Stopped state. Stopped instances do not include pay-as-you-go ECS instances that have economical mode enabled.</para>
        /// <remarks>
        /// <para>If the specified ECS instance has local disks attached, the local disks are also forcefully replaced. This may cause data loss on the local disks during host replacement. Proceed with caution.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: Does not allow the operation. The instance is added to the deployment set only on the current host. This may cause the deployment set change to fail.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target instance type of the ECS instance. You can call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// <para>When you modify the host of an ECS instance, you can also change ECS instance type. The target instance type must match the specifications of the specified dedicated host. For more information, see <a href="https://help.aliyun.com/document_detail/68564.html">Dedicated host types</a>.</para>
        /// <list type="bullet">
        /// <item><description>To change ECS instance type, you must specify the dedicated host ID by setting the <c>DedicatedHostId</c> parameter.</description></item>
        /// <item><description>You cannot change ECS instance type when using the automatic deployment feature to migrate an ECS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop ECS instance before migrating it to the destination dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>reboot: Stops ECS instance before migration.</para>
        /// </description></item>
        /// <item><description><para>live: Migrates ECS instance without stopping it. In this case, you must specify the DedicatedHostId parameter. This value does not support changing ECS instance type while migrating ECS instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: reboot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the selected instance from the selected deployment set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>When this parameter is set to true, you must specify the InstanceId and DeploymentSetId that have an ownership relationship.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RemoveFromDeploymentSet")]
        [Validation(Required=false)]
        public bool? RemoveFromDeploymentSet { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is deployed on a dedicated host. Valid values: host. The instance is deployed only on a dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

    }

}
