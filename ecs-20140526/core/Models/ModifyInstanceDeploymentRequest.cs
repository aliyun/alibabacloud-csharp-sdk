// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to associate the instance with a dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>host: associates the instance with a dedicated host. When you start a stopped instance in economical mode, the instance remains on its original dedicated host.</description></item>
        /// <item><description>default: does not associate the instance with a dedicated host. When you start a stopped instance in economical mode, the instance can be automatically deployed to another dedicated host in the automatic deployment resource pool if the resources of the original dedicated host are insufficient.</description></item>
        /// </list>
        /// <para>If you want to migrate the instance from a shared host to a dedicated host, use the default value. Default value: default.</para>
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
        /// <para>The ID of the destination dedicated host. You can call the <a href="https://help.aliyun.com/document_detail/134242.html">DescribeDedicatedHosts</a> operation to query the most recent list of dedicated hosts.</para>
        /// <para>When you migrate an instance from a shared host to a dedicated host or between dedicated hosts, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>To migrate the instance to a specific dedicated host, specify this parameter.</description></item>
        /// <item><description>To migrate the instance to a system-selected dedicated host, leave this parameter empty and set <c>Tenancy</c> to host.</description></item>
        /// </list>
        /// <para>For information about the automatic deployment feature, see <a href="https://help.aliyun.com/document_detail/118938.html">Functions and features</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The number of the deployment set group in which to deploy the instance in the destination deployment set. This parameter is valid only when the destination deployment set uses the high availability group strategy (AvailabilityGroup). Valid values: 1 to 7.</para>
        /// <remarks>
        /// <para>If you call this operation to deploy an instance to a deployment set that uses the high availability group strategy (<c>AvailablilityGroup</c>) and leave this parameter empty, the system evenly distributes instances among the deployment set groups in the deployment set. If you call this operation to change the deployment set of an instance and specify the current deployment set of the instance as the destination deployment set, the system evenly distributes instances again among the deployment set groups in the deployment set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public int? DeploymentSetGroupNo { get; set; }

        /// <summary>
        /// <para>The ID of the destination deployment set.</para>
        /// <para>This parameter is required when you add an instance to a deployment set or change the deployment set of an instance.</para>
        /// <remarks>
        /// <para>You cannot change the deployment set when you modify dedicated host configurations, including the <c>Tenancy</c>, <c>Affinity</c>, and <c>DedicatedHostId</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully change the host of the instance when the deployment set of the instance is changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: forcefully changes the host of the instance when the deployment set of the instance is changed. Hosts can be forcefully changed only for instances in the Running (Running) or Stopped (Stopped) state. The instances that are in the Stopped (Stopped) state do not include pay-as-you-go instances that are stopped in economical mode.</para>
        /// <para>**</para>
        /// <para><b>Note</b> If the specified instance has local disks attached, the local disks are forcefully changed when the host of the instance is forcefully changed. This may cause data loss in the local disks. Proceed with caution.</para>
        /// </description></item>
        /// <item><description><para>false: does not forcefully change the host of the instance when the deployment set of the instance is changed. You can add the instance to a deployment set only when the instance remains on the current host. When the Force parameter is set to false, the deployment set may fail to be changed.</para>
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
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type to which the instance is changed. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent list of instance types.</para>
        /// <para>You can change the instance type of an instance when you migrate the instance to a dedicated host. The new instance type must match the type of the specified dedicated host. For more information, see <a href="https://help.aliyun.com/document_detail/68564.html">Dedicated host types</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, you must also specify <c>DedicatedHostId</c>.</description></item>
        /// <item><description>You cannot change the instance type of an instance if you use the automatic deployment feature to migrate the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to stop the instance before it is migrated to the destination dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>reboot: stops the instance before it is migrated.</description></item>
        /// <item><description>live: migrates the instance without stopping it. If you set MigrationType to live, you must specify DedicatedHostId. In this case, you cannot change the instance type of the instance when the instance is migrated.</description></item>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the specified instance from the specified deployment set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If you set this parameter to true, you must specify InstanceId and DeploymentSetId and make sure that the specified instance belongs to the specified deployment set.</para>
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
        /// <para>Specifies whether to deploy the instance on a dedicated host. Set the value to host, which indicates that the instance is deployed on a dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

    }

}
