// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationRequest : TeaModel {
        /// <summary>
        /// <para>The conditions.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// <para>The number of vCPUs of the instance type. For information about the values, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>. This parameter takes effect only when DestinationResource is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InstanceType</description></item>
        /// <item><description>SystemDisk</description></item>
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
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent instance type list. This parameter must be specified when DestinationResource is set to SystemDisk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The memory size of the instance type. Unit: GiB. For information about the values, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>. This parameter takes effect only when DestinationResource is set to InstanceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>Specifies whether cross-cluster instance type upgrades are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When MigrateAcrossZone is set to true and you upgrade the instance type of an instance based on the returned information, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>Instance that resides in the classic network:</para>
        /// <list type="bullet">
        /// <item><description>For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, when a non-I/O optimized instance is upgraded to an I/O optimized instance, the private IP address, disk device names, and software authorization codes of the instance change. For a Linux instance, basic disks (cloud) are identified as xvd\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\* such as vda and vdb.</description></item>
        /// <item><description>For <a href="https://help.aliyun.com/document_detail/25378.html">instance families available for purchase</a>, when the instance type of an instance is changed, the private IP address of the instance changes.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Instance that resides in a virtual private cloud (VPC): For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, when a non-I/O optimized instance is upgraded to an I/O optimized instance, the disk device names and software authorization codes of the instance change. For a Linux instance, basic disks (cloud) are identified as xvd\* such as xvda and xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vd\* such as vda and vdb.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

        /// <summary>
        /// <para>The operation of changing resource configurations.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for subscription resources:</para>
        /// <list type="bullet">
        /// <item><description>Upgrade: upgrades resources.</description></item>
        /// <item><description>Downgrade: downgrades resources.</description></item>
        /// <item><description>RenewDowngrade: renews and downgrades resources.</description></item>
        /// <item><description>RenewModify: renews an expired instance and changes its configurations.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Set the value to Upgrade for pay-as-you-go resources.</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource. For example, when DestinationResource is set to InstanceType, this parameter can be interpreted as InstanceId.</para>
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
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
