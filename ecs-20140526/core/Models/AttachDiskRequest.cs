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
        /// <item><description><para>true: Yes.</para>
        /// </description></item>
        /// <item><description><para>false: No.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>Bootable=true</c>, the destination ECS instance must not have a system disk attached.</para>
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
        /// <item><description>true: The disk is released.</description></item>
        /// <item><description>false: The disk is not released. The disk is retained and converted to a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When you configure this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>DeleteWithInstance</c> to <c>false</c> and the ECS instance is locked for security reasons (that is, <c>&quot;LockReason&quot; : &quot;security&quot;</c> is marked in <c>OperationLocks</c>), this property of the disk is ignored and the disk is released when the ECS instance is released.</para>
        /// </description></item>
        /// <item><description><para>If the destination disk that you want to attach is an <c>elastic ephemeral disk</c>, you must set the <c>DeleteWithInstance</c> parameter to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter cannot be configured for disks with the multi-attach feature enabled.</para>
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
        /// <para>This parameter is being deprecated. To improve compatibility, we recommend that you use other parameters to identify the disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDeviceName</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The ID of the disk that you want to attach. The disk (<c>DiskId</c>) and the instance (<c>InstanceId</c>) must be in the same zone.</para>
        /// <remarks>
        /// <para>You can attach data disks and system disks. For the related constraints, see the operation description section above.</para>
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
        /// <para>Specifies whether to forcibly attach the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>Currently, only regional Enterprise SSDs (ESSDs) (<c>cloud_regional_disk_auto</c>) support setting this parameter to true.</para>
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
        /// <para>The name of the SSH key pair to bind to a Linux ECS instance when you attach a system disk.</para>
        /// <list type="bullet">
        /// <item><description><para>Windows Server: SSH key pairs are not supported. Even if you specify this parameter, only the <c>Password</c> configuration is applied.</para>
        /// </description></item>
        /// <item><description><para>Linux: Password-based logon is disabled by default.</para>
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
        /// <para>The logon password of the instance, which is configured when you attach a system disk. This parameter takes effect only for the administrator and root usernames and does not take effect for other usernames. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The special characters can be:</para>
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
