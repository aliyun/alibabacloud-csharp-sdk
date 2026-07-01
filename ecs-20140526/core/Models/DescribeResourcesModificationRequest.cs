// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationRequest : TeaModel {
        /// <summary>
        /// <para>The list of conditions.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// <para>The number of vCPU kernels of the target instance type. For valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>.</para>
        /// <para>This parameter takes effect only when DestinationResource is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The type of the resource to be changed. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>InstanceType: instance type.</para>
        /// </description></item>
        /// <item><description><para>SystemDisk: system disk type.</para>
        /// <para>If you set this parameter to SystemDisk, you must also specify the InstanceType parameter to indicate the disk type required by the target instance type.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceType</para>
        /// </summary>
        [NameInMap("DestinationResource")]
        [Validation(Required=false)]
        public string DestinationResource { get; set; }

        /// <summary>
        /// <para>The target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// <para>If DestinationResource is set to SystemDisk, you must also specify the InstanceType parameter to indicate the disk type required by the target instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The memory size of the target instance type. Unit: GiB. For valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>.</para>
        /// <para>This parameter takes effect only when DestinationResource is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>Specifies whether cross-cluster instance type changes are supported. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: Supported.</description></item>
        /// <item><description>false: Not supported.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>If the MigrateAcrossZone parameter is set to true and you upgrade or downgrade the Elastic Compute Service instance based on the returned information, take note of the following items: </para>
        /// <list type="bullet">
        /// <item><description>VPC-type instances: For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, when a non-I/O optimized instance is changed to an I/O optimized instance, the disk device names and software authorization codes of the server are changed. For Linux instances, basic disks (cloud) are identified as xvda or xvdb. Ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vda or vdb.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// <para>The type of the Upgrade/Downgrade operation.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for subscription resources: </para>
        /// <list type="bullet">
        /// <item><description>Upgrade: upgrades resources.</description></item>
        /// <item><description>Downgrade: downgrades resources.</description></item>
        /// <item><description>RenewDowngrade: downgrades resources upon renewal.</description></item>
        /// <item><description>RenewModify: renewal with specification change for expired instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid value for pay-as-you-go resources: Upgrade.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance whose configuration you want to change. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID (InstanceId) of the instance whose instance type or system disk type you want to change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the target zone.</para>
        /// <para>Specify this parameter when you want to change the instance type across zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
