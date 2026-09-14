// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is being deprecated and is retained only for compatibility purposes. Ignore this parameter when you call this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfirmStop")]
        [Validation(Required=false)]
        public bool? ConfirmStop { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Performs a dry run without stopping the instance. The system checks whether the required parameters are specified, the request format is valid, service limits are met, and ECS inventory is sufficient. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description>false: Performs a normal request. After the check passes, the instance is stopped.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully stop the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Forcefully stops the instance. This is equivalent to a typical power-off operation. All cached data that is not written to the storage device is lost.</description></item>
        /// <item><description>false: Normally stops the instance.</description></item>
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
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public bool? Hibernate { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The stop mode for a pay-as-you-go ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StopCharging: Economical mode. After economical mode is enabled:</para>
        /// <list type="bullet">
        /// <item><description>Billing is suspended for compute resources (vCPUs, memory, and GPUs), image license fees, and the pay-by-bandwidth mode for static public IP addresses.</description></item>
        /// <item><description>Billing continues for system disks, data disks, and the pay-by-bandwidth mode for elastic IP addresses (EIPs).</description></item>
        /// <item><description>Because compute resources are reclaimed, the instance may fail to start due to insufficient inventory. In this case, try again later or change the instance type.</description></item>
        /// <item><description>If an EIP is associated with the instance before the instance is stopped, the IP address remains unchanged after the instance is restarted. Otherwise, the static public IP address may change, but the private IP address remains unchanged.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
        /// <remarks>
        /// <para>Notice:</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>If the instance does not support economical mode, the API does not return an error. The instance is stopped as a priority. Instance types that do not support economical mode include instances with local disks and subscription instances.</para>
        /// <list type="bullet">
        /// <item><description>KeepCharging: Standard stop mode. Billing continues after the instance is stopped.</description></item>
        /// </list>
        /// <para>Default value: If you enable the economical mode for instances in a VPC in the ECS console (for more information, see <a href="~~63353#default~~">Enable economical mode by default</a>) and the conditions are met, the default value is <c>StopCharging</c>. Otherwise, the default value is <c>KeepCharging</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeepCharging</para>
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
