// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReplaceSystemDiskRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ReplaceSystemDiskRequestSystemDisk SystemDisk { get; set; }
        public class ReplaceSystemDiskRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The capacity of the new system disk. Unit: GiB. Valid values for different disk categories:</para>
            /// <list type="bullet">
            /// <item><description><para>Basic disk: Max{20, Size of the image specified by ImageId} to 500.</para>
            /// </description></item>
            /// <item><description><para>Enterprise SSD (ESSD):</para>
            /// <list type="bullet">
            /// <item><description>PL0: Max{1, Size of the image specified by ImageId} to 2048.</description></item>
            /// <item><description>PL1: Max{20, Size of the image specified by ImageId} to 2048.</description></item>
            /// <item><description>PL2: Max{461, Size of the image specified by ImageId} to 2048.</description></item>
            /// <item><description>PL3: Max{1261, Size of the image specified by ImageId} to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL disk: Max{1, Size of the image specified by ImageId} to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: Max{20, Size of the image specified by ImageId} to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: 40 or the size of the image specified by ImageId, whichever is greater.</para>
            /// <remarks>
            /// <para> If the capacity of the new system disk exceeds <c>Max{20, Capacity of the original system disk}</c>, you are charged for the excess capacity.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i386</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>This parameter is not available for public use.</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<ReplaceSystemDiskRequestArn> Arn { get; set; }
        public class ReplaceSystemDiskRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is unavailable.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but make sure that the token is unique across requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated. To improve compatibility, we recommend that you use <c>ImageId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: encrypts the disk.</description></item>
        /// <item><description>false: does not encrypt the disk.</description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the image to be used to replace the system disk.</para>
        /// <para>If the <c>DiskId</c> parameter is not specified, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

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

        /// <summary>
        /// <para>The ID of the KMS key to use for the system disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e522b26d-abf6-4e0d-b5da-04b7******3c</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to Linux instances. You can bind an SSH key pair to the instance as a logon credential. After you bind the SSH key pair, the username and password logon method is disabled for the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
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
        /// <para>Specifies whether to reset the password for the instance. The password must be 8 to 30 characters in length and contain at least three of the following items: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>The passwords of Windows instances cannot start with a forward slash (/).</para>
        /// <para>This parameter is empty by default, which indicates that the current password remains unchanged.</para>
        /// <remarks>
        /// <para>If you specify <c>Password</c>, we recommend that you send requests over HTTPS to prevent password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EcsV587!</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image.</para>
        /// <para>Default value: false</para>
        /// <remarks>
        /// <para>If the PasswordInherit parameter is specified, you must leave the Password parameter empty. Before you use this parameter, make sure that a password is preset for the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use Security Center Basic after the system disk is replaced. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: uses Security Center Basic after the system disk is re-initialized. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: does not use Security Center Basic after the system disk is re-initialized. This value is applicable to all images.</description></item>
        /// </list>
        /// <para>Default value: Deactive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the system configurations for virtual machines provided by Alibaba Cloud. System configurations for Windows: NTP and KMS. System configurations for Linux: NTP and YUM.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you attach a system disk whose device name is /dev/xvda.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseAdditionalService")]
        [Validation(Required=false)]
        public bool? UseAdditionalService { get; set; }

    }

}
