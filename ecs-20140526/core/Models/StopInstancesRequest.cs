// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AllTogether: all operations must succeed for the entire batch operation to be considered successful. If any operation fails, the entire batch operation is considered failed, and all executed operations are rolled back to their original state.</para>
        /// </description></item>
        /// <item><description><para>SuccessFirst: each operation in the batch is executed independently. If an operation fails, other operations can still continue and succeed. In this mode, successful operations are committed, and failed operations are marked as failed without affecting the results of other operations.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: AllTogether.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllTogether</para>
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a dry run request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: sends a dry run request without stopping the instances. The system checks whether required parameters are specified, the request format is valid, and the instance status is valid. If the request fails the check, an error is returned. If the request passes the check, <c>DRYRUN.SUCCESS</c> is returned.</para>
        /// <remarks>
        /// <para>If the <c>BatchOptimization</c> parameter is set to <c>SuccessFirst</c>, the dry run result for <c>DryRun=true</c> only returns <c>DRYRUN.SUCCESS</c>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>false: sends a regular request and stops the instances directly after the request passes the check.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to force stop the instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: force stops the instances.<remarks>
        /// <para>Warning: Force stopping an instance is equivalent to a power outage and may cause data in the operating system that is not written to the disk to be lost. Proceed with caution.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>false: normally stops the instances.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// <para>The instance IDs. Array length: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The stop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StopCharging: economical mode. After you enable economical mode:</para>
        /// <list type="bullet">
        /// <item><description>Billing is suspended for computing resources (vCPUs, memory, and GPUs), image licenses, and static public IP addresses that use the pay-by-bandwidth billing method.</description></item>
        /// <item><description>Billing continues for system cloud disks, data cloud disks, and Elastic IP Addresses (EIPs) that use the pay-by-bandwidth billing method.</description></item>
        /// <item><description>Because computing resources are released, the instance may fail to start due to insufficient resource inventory. If this occurs, try again later or change the instance type.</description></item>
        /// <item><description>If an EIP was associated with the instance before it was stopped, the IP address remains unchanged after the instance is restarted. Otherwise, the static public IP address may change, but the private IP address remains unchanged.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
        /// <remarks>
        /// <para>Notice:</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>If the instance does not support economical mode, the API does not return an error and prioritizes stopping the instance. Instance types that do not support economical mode include instances with local disks and subscription instances.</para>
        /// <list type="bullet">
        /// <item><description>KeepCharging: standard stop mode. After the instance is stopped, its resources are retained and continue to be billed. The ECS instance type inventory and public IP address are also reserved for you. Select this mode if you stop the instance to perform operations such as replacing the operating system, reinitializing cloud disks, changing the instance type, or modifying the private IP address. This prevents startup failures.</description></item>
        /// </list>
        /// <para>Default value: If you <a href="~~63353#default~~">enable economical mode for instances in a VPC</a> and the instance meets the requirements, the default value is <c>StopCharging</c>. Otherwise, the default value is <c>KeepCharging</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeepCharging</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
