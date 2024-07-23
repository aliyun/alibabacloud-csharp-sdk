// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to attach the disk as a system disk.</para>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para> You can set <c>Bootable</c> to true only if the instance does not have a system disk.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Bootable")]
        [Validation(Required=false)]
        public bool? Bootable { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the disk when the instance is released.</para>
        /// <list type="bullet">
        /// <item><description>true: releases the disk when the instance is released.</description></item>
        /// <item><description>false: does not release the disk when the instance is released. The disk is retained as a pay-as-you-go data disk.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When you specify this parameter, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>If <c>OperationLocks</c> in the DescribeInstances response contains <c>&quot;LockReason&quot; : &quot;security&quot;</c> for the instance to which the disk is attached, the instance is locked for security reasons. Regardless of whether you set <c>DeleteWithInstance</c> to <c>false</c>, the DeleteWithInstance setting is ignored, and the disk is released when the instance is released.</description></item>
        /// <item><description>If you want to attach an <c>elastic ephemeral disk</c>, you must set <c>DeleteWithInstance</c> to <c>true</c>.</description></item>
        /// <item><description>This parameter is unavailable for disks for which the multi-attach feature is enabled.</description></item>
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
        /// <para> This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDeviceName</para>
        /// </summary>
        [NameInMap("Device")]
        [Validation(Required=false)]
        public string Device { get; set; }

        /// <summary>
        /// <para>The ID of the disk. The disk specified by <c>DiskId</c> and the instance specified by <c>InstanceId</c> must reside in the same zone.</para>
        /// <remarks>
        /// <para> For more information about the limits on attaching a data disk and a system disk, see the &quot;Usage notes&quot; section of this topic.</para>
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
        /// <para>Specifies whether to forcefully attach the disk to the instance.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which you want to attach the disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1dq5lozx5f4pmd****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the SSH key pair that you bind to the Linux instance when you attach the system disk.</para>
        /// <list type="bullet">
        /// <item><description>Windows instances do not support logons based on SSH key pairs. The <c>Password</c> parameter takes effect even if the KeyPairName parameter is specified.</description></item>
        /// <item><description>For Linux instances, the username and password-based logon method is disabled by default.</description></item>
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
        /// <para>The password that is set when you attach the system disk. The password is applicable only to the administrator and root users. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, passwords cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If <c>Password</c> is configured, we recommend that you send requests over HTTPS to prevent password leaks.</para>
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
