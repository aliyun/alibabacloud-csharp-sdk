// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to attach the disk as a system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The disk is attached as a system disk.</para>
        /// </description></item>
        /// <item><description><para>false: The disk is not attached as a system disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If you set <c>Bootable=true</c>, the destination ECS instance must have no system disk attached.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Bootable")]
        [Validation(Required=false)]
        public bool? Bootable { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the disk when the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The disk is released together with the instance.</description></item>
        /// <item><description>false: The disk is not released together with the instance. The disk is retained as a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When you set this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>DeleteWithInstance</c> to <c>false</c> and the ECS instance is locked for security reasons, meaning that <c>OperationLocks</c> contains <c>&quot;LockReason&quot; : &quot;security&quot;</c>, this parameter is ignored when the instance is released, and the disk is released together with the instance.</para>
        /// </description></item>
        /// <item><description><para>If the disk to be attached is an <c>elastic ephemeral disk</c>, you must set <c>DeleteWithInstance</c> to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>Disks with the multi-attach feature enabled do not support this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The device name of the disk.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. To improve compatibility, use other parameters to identify the disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDeviceName</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The ID of the disk to be attached. The disk (<c>DiskId</c>) and the instance (<c>InstanceId</c>) must be in the same zone.</para>
        /// <remarks>
        /// <para>Both data disks and system disks can be attached. For related constraints, see the operation description section above.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1j4l5axzdy6ftk****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully attach the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Forcefully attaches the disk.</description></item>
        /// <item><description>false: Does not forcefully attach the disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>Currently, only regional ESSDs (cloud_regional_disk_auto) support setting this parameter to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance to which you want to attach the disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1dq5lozx5f4pmd****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the SSH key pair that is bound to the Linux ECS instance when you attach a system disk.</para>
        /// <list type="bullet">
        /// <item><description><para>Windows Server instances: SSH key pairs are not supported. Even if this parameter is specified, only the <c>Password</c> configuration takes effect.</para>
        /// </description></item>
        /// <item><description><para>Linux instances: The password-based logon method is disabled by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairTestName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password that is set for the instance when you attach a system disk. The password is effective only for the administrator and root usernames and is not effective for other usernames. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the <c>Password</c> parameter, send the request over HTTPS to prevent password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsV587!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
