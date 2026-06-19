// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request without releasing the instance. The system checks whether the required parameters are specified, the request format is valid, business requirements are met, and ECS resources are sufficient. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description>false (default): Sends a normal request. After the request passes the check, the instance is directly deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully release a <b>running</b> (<c>Running</c>) instance.</para>
        /// <list type="bullet">
        /// <item><description>true: Forcefully releases a <b>running</b> (<c>Running</c>) instance.</description></item>
        /// <item><description>false: Releases the instance in the normal way. The instance must be in the <b>Stopped</b> (<c>Stopped</c>) state.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>Warning: A forceful release is equivalent to a power-off. Temporary data in the instance memory and storage is erased and cannot be recovered..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the forced shutdown policy when releasing a <b>running</b> (<c>Running</c>) instance. This parameter takes effect only when <c>Force=true</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Forcefully shuts down and releases the instance. This is equivalent to a typical power-off operation. The instance directly enters the resource release process.<remarks>
        /// <para>Warning: A forceful release is equivalent to a power-off. Temporary data in the instance memory and storage is erased and cannot be recovered.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>false: Before the instance is released, the system preferentially performs a standard shutdown process. This mode causes the instance release to take several minutes. You can configure service draining actions during the operating system shutdown to reduce noise in your business systems.</description></item>
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
        /// <para>The instance ID.</para>
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
        /// <para>Specifies whether to release an expired subscription instance.</para>
        /// <list type="bullet">
        /// <item><description>true: Releases the instance.</description></item>
        /// <item><description>false: Does not release the instance.</description></item>
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
