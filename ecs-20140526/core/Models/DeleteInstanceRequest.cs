// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and unavailable ECS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false (default): performs a dry run and performs the actual request. If the request passes the dry run, the instance is released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully release the ECS instance in the <b>Running</b> (<c>Running</c>) state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: forcefully releases the ECS instance in the <b>Running</b> (<c>Running</c>) state.</description></item>
        /// <item><description>false: normally releases the ECS instance. This value is valid only if the instance is in the <b>Stopped</b> (<c>Stopped</c>) state.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>**</para>
        /// <para><b>Warning</b> When Force is set to true, this operation is equivalent to a power-off operation. Temporary data in the memory and storage of the instance is erased and cannot be restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully stop the ECS instance in the <b>Running</b> (<c>Running</c>) state before the instance is released. This parameter takes effect only when <c>Force</c> is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: forcefully stops and releases the ECS instance. In this case, this operation is equivalent to a power-off operation. The instance directly enters the resource release process.</para>
        /// <para>**</para>
        /// <para><b>Warning</b> A forceful stop and release is equivalent to a power-off operation. Temporary data in the memory and storage of the instance is erased and cannot be restored.</para>
        /// </description></item>
        /// <item><description><para>false: stops the ECS instance in the normal stop process and then releases the instance. In this case, the release process takes several minutes to complete. You can configure business drainage actions to reduce the noise of the business system on operating system shutdown.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6zv0ce8oghu7****</para>
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
        /// <para>Specifies whether to release the expired subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TerminateSubscription")]
        [Validation(Required=false)]
        public bool? TerminateSubscription { get; set; }

    }

}
