// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReportInstancesStatusRequest : TeaModel {
        /// <summary>
        /// <para>The detailed description of the exception.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The local disk is unavailable, access to the mount point is denied, and files cannot be loaded</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The device names of the attached disks that have the same exception. You can specify up to 100 device names. If you use ECS Bare Metal instances, specify the slot information of the disk devices.</para>
        /// <remarks>
        /// <para>For ECS Bare Metal instances, this parameter is required when the Reason parameter is set to abnormal-local-disk or abnormal-cloud-disk, or when the IssueCategory parameter is set to hardware-disk-error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/dev/xvdb</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<string> Device { get; set; }

        /// <summary>
        /// <para>The IDs of the disks that have the same exception. You can specify up to 100 disk IDs. If you use ECS Bare Metal instances, specify the serial numbers (SNs) of the disk devices.</para>
        /// <remarks>
        /// <para>This parameter is required when the Reason parameter is set to abnormal-local-disk or abnormal-cloud-disk, or when the IssueCategory parameter is set to hardware-disk-error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1aeljlfad7x6u1****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The end time of the instance failures. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances. You can specify up to 100 instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp165p6xk2tmdhj0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The category of the exception. This parameter is applicable only to ECS Bare Metal instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hardware-cpu-error: CPU failure</description></item>
        /// <item><description>hardware-motherboard-error: Motherboard failure</description></item>
        /// <item><description>hardware-mem-error: Memory failure</description></item>
        /// <item><description>hardware-power-error: Power supply failure</description></item>
        /// <item><description>hardware-disk-error: Disk failure</description></item>
        /// <item><description>hardware-networkcard-error: Network interface controller (NIC) failure</description></item>
        /// <item><description>hardware-raidcard-error: SAS/RAID card failure</description></item>
        /// <item><description>hardware-fan-error: Fan failure</description></item>
        /// <item><description>others: Other exceptions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hardware-cpu-error</para>
        /// </summary>
        [NameInMap("IssueCategory")]
        [Validation(Required=false)]
        public string IssueCategory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The impact of the exception on the ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance-hang: The ECS instance is unavailable or unreachable.</description></item>
        /// <item><description>instance-stuck-in-status: The ECS instance remains in a specific state, such as Starting or Stopping, for an extended period.</description></item>
        /// <item><description>abnormal-network: A network exception occurs on the ECS instance.</description></item>
        /// <item><description>abnormal-local-disk: An exception occurs on the local disk attached to the ECS instance.</description></item>
        /// <item><description>abnormal-cloud-disk: An exception occurs on the disk or Shared Block Storage attached to the ECS instance.</description></item>
        /// <item><description>others: Other exception types. If none of the preceding impact types apply, you can set Reason to others and provide more information in Description.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abnormal-local-disk</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the instance failures. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
