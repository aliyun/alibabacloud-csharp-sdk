// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReportInstancesStatusRequest : TeaModel {
        /// <summary>
        /// <para>The detailed description of the anomalous issue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>本地盘不可用，挂载点拒绝访问，无法加载文件。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of device names of the disks that have the same anomalous issue and are attached to the instance. You can specify up to 100 device names.</para>
        /// <para>If you are using an ECS Bare Metal server instance, specify the SLOT information list of the disk devices.</para>
        /// <remarks>
        /// <para>For ECS bare metal instances, this parameter is required when the <c>Reason</c> parameter is set to <c>abnormal-local-disk</c> or <c>abnormal-cloud-disk</c>, or when the <c>IssueCategory</c> parameter is set to <c>hardware-disk-error</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/dev/xvdb</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<string> Device { get; set; }

        /// <summary>
        /// <para>The list of IDs of the disks that have the same anomalous issue. You can specify up to 100 disk IDs. If you are using an ECS Bare Metal server instance, specify the SN list of the disk devices.</para>
        /// <remarks>
        /// <para>This parameter is required when the <c>Reason</c> parameter is set to <c>abnormal-local-disk</c> or <c>abnormal-cloud-disk</c>, or when the <c>IssueCategory</c> parameter is set to <c>hardware-disk-error</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1aeljlfad7x6u1****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The time when the instance failures ended. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of ECS instance IDs. You can specify up to 100 instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp165p6xk2tmdhj0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The category of the anomalous issue. This parameter is applicable only to Elastic Compute Service Bare Metal Instance instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hardware-cpu-error: CPU failure.</description></item>
        /// <item><description>hardware-motherboard-error: Motherboard failure.</description></item>
        /// <item><description>hardware-mem-error: Memory failure.</description></item>
        /// <item><description>hardware-power-error: Power failure.</description></item>
        /// <item><description>hardware-disk-error: Disk failure.</description></item>
        /// <item><description>hardware-networkcard-error: Network interface controller (NIC) failure.</description></item>
        /// <item><description>hardware-raidcard-error: SAS/RAID card failure.</description></item>
        /// <item><description>hardware-fan-error: Fan failure.</description></item>
        /// <item><description>others: Other failures.</description></item>
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
        /// <para>The impact of the anomalous issue on the ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance-hang: The ECS instance is unavailable or cannot be connected to.</description></item>
        /// <item><description>instance-stuck-in-status: The ECS instance is stuck in a specific state, such as Starting or Stopping, for an extended period of time.</description></item>
        /// <item><description>abnormal-network: A network exception occurred on the ECS instance.</description></item>
        /// <item><description>abnormal-local-disk: A local disk attached to the ECS instance is abnormal.</description></item>
        /// <item><description>abnormal-cloud-disk: A cloud disk or Shared Block Storage device attached to the ECS instance is abnormal.</description></item>
        /// <item><description>others: Other exception types. If none of the preceding values apply, set <c>Reason=others</c> and provide more information in <c>Description</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abnormal-local-disk</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent list of Alibaba Cloud regions.</para>
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
        /// <para>The time when the instance failures started. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
