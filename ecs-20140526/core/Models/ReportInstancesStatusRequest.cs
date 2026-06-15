// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReportInstancesStatusRequest : TeaModel {
        /// <summary>
        /// <para>The description of the exception.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>本地盘不可用，挂载点拒绝访问，无法加载文件。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The device names of disks on an instance that have the exception. You can specify to 100 device names in a single request.</para>
        /// <para>If you are using an ECS bare metal instance, enter the slot numbers of disks on the instance.</para>
        /// <remarks>
        /// <para>For ECS bare metal instances, this parameter is required when the value of the <c>Reason</c> parameter is <c>abnormal-local-disk</c> or <c>abnormal-cloud-disk</c> or when the value of the <c>IssueCategory</c> parameter is <c>hardware-disk-error</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/dev/xvdb</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<string> Device { get; set; }

        /// <summary>
        /// <para>The IDs of disks on an instance that have the exception. You can specify up to 100 disk IDs in a single request. If you are using an ECS bare metal instance, enter the serial numbers of disks on the instance.</para>
        /// <remarks>
        /// <para>This parameter is required when the value of the <c>Reason</c> parameter is <c>abnormal-local-disk</c> or <c>abnormal-cloud-disk</c> or when the value of the <c>IssueCategory</c> parameter is <c>hardware-disk-error</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1aeljlfad7x6u1****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The end time of the instance exception. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-11-31T06:32:31Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The IDs of instances. You can specify up to 100 instance IDs in a single request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp165p6xk2tmdhj0****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The category of the exception. This parameter is applicable only to ECS bare metal instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>hardware-cpu-error: CPU failure</para>
        /// </description></item>
        /// <item><description><para>hardware-motherboard-error: motherboard failure</para>
        /// </description></item>
        /// <item><description><para>hardware-mem-error: memory failure</para>
        /// </description></item>
        /// <item><description><para>hardware-power-error: power failure</para>
        /// </description></item>
        /// <item><description><para>hardware-disk-error: disk failure</para>
        /// </description></item>
        /// <item><description><para>hardware-networkcard-error: network interface controller (NIC) failure</para>
        /// </description></item>
        /// <item><description><para>hardware-raidcard-error: SAS/RAID card failure</para>
        /// </description></item>
        /// <item><description><para>hardware-fan-error: fan failure</para>
        /// </description></item>
        /// <item><description><para>others: other failures</para>
        /// </description></item>
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
        /// <para>The impact of the exception on the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>instance-hang: The instance is unavailable or cannot be connected.</para>
        /// </description></item>
        /// <item><description><para>instance-stuck-in-status: The instance is stuck in a state such as Starting or Stopping.</para>
        /// </description></item>
        /// <item><description><para>abnormal-network: The instance has a network exception.</para>
        /// </description></item>
        /// <item><description><para>abnormal-local-disk: A local disk attached to the instance has an exception.</para>
        /// </description></item>
        /// <item><description><para>abnormal-cloud-disk: A disk or a Shared Block Storage device attached to the instance has an exception.</para>
        /// </description></item>
        /// <item><description><para>others: other exception types. If the impact is not of the preceding types, you can set <c>Reason</c> to others and specify the <c>Description</c> parameter.</para>
        /// </description></item>
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
        /// <para>The start time of the instance exception. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-11-30T06:32:31Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
