// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter will be removed in the future and is retained only to ensure compatibility. We recommend that you ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ConfirmStop")]
        [Validation(Required=false)]
        public bool? ConfirmStop { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and available ECS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: performs a dry run and performs the actual request.</description></item>
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
        /// <para>Specifies whether to forcefully stop the ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: forcefully stops the ECS instance. If you set ForceStop to true, this operation is equivalent to a power-off operation. Cache data that is not written to storage devices on the instance is lost.</description></item>
        /// <item><description>false: normally stops the ECS instance.</description></item>
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
        /// <para>This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public bool? Hibernate { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The stop mode of the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StopCharging: economical mode. After the economical mode is enabled, billing for the following resources of the instance stops: computing resources (vCPUs, memory, and GPUs), image licenses, and public bandwidth of the static public IP address (if any) that uses the pay-by-bandwidth metering method. Billing for the following resources of the instance continues: system disk, data disks, and public bandwidth of the elastic IP address (EIP) (if any) that uses the pay-by-bandwidth metering method. For more information, see <a href="https://help.aliyun.com/document_detail/63353.html">Economical mode</a>.</para>
        /// <para>**</para>
        /// <para><b>Note</b></para>
        /// </description></item>
        /// <item><description><para>If the instance does not support the <b>economical</b> mode, the system stops the instance and does not report errors during the operation call. The economical mode cannot be enabled for instances of the classic network type, instances that use local disks, and instances that use persistent memory.</para>
        /// </description></item>
        /// <item><description><para>The instance may fail to restart due to the reclaimed computing resources or insufficient resources. Try again later or change the instance type of the instance.</para>
        /// </description></item>
        /// <item><description><para>If an EIP is associated with the instance before the instance is stopped, the EIP remains unchanged after the instance is restarted. If a static public IP address is associated with the instance before the instance is stopped, the static public IP address may change, but the private IP address does not change.</para>
        /// </description></item>
        /// <item><description><para>KeepCharging: standard mode. After the instance is stopped in standard mode, you continue to be charged for the instance.</para>
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
