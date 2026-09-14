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
        /// <item><description><para>true: Attach as a system disk.</para>
        /// </description></item>
        /// <item><description><para>false: Do not attach as a system disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If <c>Bootable</c> is set to <c>true</c>, the target ECS instance must have no system disk attached.</para>
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
        /// <item><description>true: The disk is released with the instance.</description></item>
        /// <item><description>false: The disk is not released with the instance. The disk is retained as a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>Note the following when setting this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>DeleteWithInstance</c> is set to <c>false</c> and the ECS instance is under security control (that is, <c>OperationLocks</c> contains <c>&quot;LockReason&quot; : &quot;security&quot;</c>), this attribute is ignored when the ECS instance is released, and the disk is released along with the instance.</para>
        /// </description></item>
        /// <item><description><para>If the disk to attach is an elastic ephemeral disk, you must set <c>DeleteWithInstance</c> to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is not supported for disks with the multi-attach feature enabled.</para>
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
        /// <para>This parameter is being deprecated. To improve compatibility, use other parameters to identify the disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDeviceName</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The ID of the disk to attach. The disk (<c>DiskId</c>) and the instance (<c>InstanceId</c>) must be in the same zone.</para>
        /// <remarks>
        /// <para>Both data disks and system disks are supported. For the relevant constraints, see the operation description above.</para>
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
        /// <para>Specifies whether the request is a forced attach request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>Currently, only the ESSD regional disk type (cloud_regional_disk_auto) supports setting this field to true.</para>
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
        /// <para>The name of the SSH key pair to bind to a Linux ECS instance when attaching a system disk.</para>
        /// <list type="bullet">
        /// <item><description><para>Windows Server instances: SSH key pairs are not supported. Even if this parameter is specified, only the <c>Password</c> configuration takes effect.</para>
        /// </description></item>
        /// <item><description><para>Linux instances: Password-based logon is disabled after the key pair is bound.</para>
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
        /// <para>The password for the instance when attaching a system disk. This parameter applies only to the administrator and root usernames. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the <c>Password</c> parameter, use HTTPS to send the request to prevent password leakage.</para>
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
