// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the batch operation mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AllTogether: The batch operation is successful only after all operations are successful. If any operation fails, the batch operation is considered failed, and all operations that have been performed are undone to restore the instances to the status before the batch operation.</description></item>
        /// <item><description>SuccessFirst: allows each operation in a batch to be independently executed. If an operation fails, other operations can continue and confirm success. In this mode, successful operations are committed and failed operations are marked as failed, but the execution results of other operations are not affected.</description></item>
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
        /// <para>Specifies whether to send a precheck request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and instance status. If the check fails, the corresponding error message is returned. If the request passes the dry run, <c>DRYRUN.SUCCESS</c> is returned.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set <c>BatchOptimization</c> to <c>SuccessFirst</c> and <c>DryRun</c> to true, only <c>DRYRUN.SUCCESS</c> is returned, regardless of whether the request passes the dry run.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, instances are stopped.</description></item>
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
        /// <para>Specifies whether to forcefully stop instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: forcefully stops the ECS instance.</para>
        /// <para>**</para>
        /// <para><b>Alert</b> Force Stop: forcefully stops the instance. A force stop is equivalent to a physical shutdown and may cause data loss if instance data has not been written to disks.</para>
        /// </description></item>
        /// <item><description><para>false: normally stops the ECS instance.</para>
        /// </description></item>
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
        /// <para>The IDs of ECS instances. You can specify 1 to 100 instance IDs.</para>
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
        /// <para>Stop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StopCharging: economical mode. After an instance is stopped in economical mode:</para>
        /// <list type="bullet">
        /// <item><description>Billing for the following resources of the instance stops: computing resources (vCPUs, memory, and GPUs), image licenses, and public bandwidth of the static public IP address (if any) that uses the pay-by-bandwidth metering method.</description></item>
        /// <item><description>Billing for the following resources of the instance continues: system disk, data disks, and public bandwidth of the elastic IP address (EIP) (if any) that uses the pay-by-bandwidth metering method.</description></item>
        /// <item><description>The instance may fail to restart due to the reclaimed computing resources or insufficient resources. Try again later or change the instance type of the instance.</description></item>
        /// <item><description>If an EIP is associated with the instance before the instance is stopped, the EIP remains unchanged after the instance is restarted. If a static public IP address is associated with the instance before the instance is stopped, the static public IP address may change, but the private IP address does not change.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
        /// <para>**</para>
        /// <para><b>Note</b> If the instance itself does not support the economical shutdown mode, the API side does not intercept errors, and the instance is preferentially stopped. The following types of instances are not supported: classic network instances, local disks, and monthly instances.</para>
        /// </description></item>
        /// <item><description><para>KeepCharging: standard mode. After the instance is stopped in standard mode, you continue to be charged for the instance. If you want to change the operating system, re-initialize disks, change the instance type, or modify the private IP address, we recommend selecting this mode to avoid startup failures.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: If the conditions for <a href="~~63353#default~~">enabling the economical mode for an instance in a VPC</a> are met and you have enabled this mode in the ECS console, the default value is <c>StopCharging</c>. Otherwise, the default value is <c>KeepCharging</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeepCharging</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
