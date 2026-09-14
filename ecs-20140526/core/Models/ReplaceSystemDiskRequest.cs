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
            /// <para>The new capacity of the system disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic disk: Max{20, image size specified by the ImageId parameter} to 500.</description></item>
            /// <item><description>Enterprise SSD:<list type="bullet">
            /// <item><description>PL0: Max{1, image size specified by the ImageId parameter} to 2048.</description></item>
            /// <item><description>PL1: Max{20, image size specified by the ImageId parameter} to 2048.</description></item>
            /// <item><description>PL2: Max{461, image size specified by the ImageId parameter} to 2048.</description></item>
            /// <item><description>PL3: Max{1261, image size specified by the ImageId parameter} to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>ESSD AutoPL disk: Max{1, image size specified by the ImageId parameter} to 2048.</description></item>
            /// <item><description>Other disk types: Max{20, image size specified by the ImageId parameter} to 2048.</description></item>
            /// </list>
            /// <para>Default value: Max{40, image size specified by the ImageId parameter}.</para>
            /// <remarks>
            /// <para>Disk capacity that exceeds <c>Max{20, original system disk capacity}</c> incurs additional charges.</para>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i386</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>This parameter is not available for use.</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<ReplaceSystemDiskRequestArn> Arn { get; set; }
        public class ReplaceSystemDiskRequestArn : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available for use.</para>
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
            /// <para>This parameter is not available for use.</para>
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
            /// <para>This parameter is not available for use.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. To improve compatibility, use <c>ImageId</c> instead.</para>
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
        /// <para>This parameter is not available for use.</para>
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
        /// <item><description><para>true: encrypts the disk.</para>
        /// </description></item>
        /// <item><description><para>false: does not encrypt the disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>Notice: When you use a shared encrypted image to create a disk based on an encrypted snapshot, you must set the request parameter Encrypted=true for the disk to ensure that the disk uses the key of the account that receives the shared image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The ID of the image to use when resetting the system disk. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The ID of the target instance.</para>
        /// <remarks>
        /// <para>Make sure that the target instance is in the <c>Stopped</c> instance status before you send the request.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The KMS key ID of the system disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e522b26d-abf6-4e0d-b5da-04b7******3c</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The name of the key pair. </para>
        /// <remarks>
        /// <para>This parameter applies only to Linux ECS instances. You can bind an SSH key pair to an ECS instance as a logon credential. After an SSH key pair is bound, username and password-based logon is disabled.</para>
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
        /// <para>Specifies whether to reset the password of the ECS instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <para>Default value: The password remains unchanged.</para>
        /// <remarks>
        /// <para>If you specify the <c>Password</c> parameter, use HTTPS to send the request to prevent password leaks.</para>
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
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If you use this parameter, the Password parameter must be empty. Make sure that the image you use has a preset password.</para>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated.</para>
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
        /// <para>Specifies whether to use Security Center for free after the system disk is replaced. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>Active: Uses Security Center. This value is supported only for public images.</para>
        /// </description></item>
        /// <item><description><para>Deactive: Does not use Security Center. This value is supported for all images.</para>
        /// </description></item>
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
        /// <para>Specifies whether to use the virtual machine system configurations provided by Alibaba Cloud (Windows: NTP and KMS. Linux: NTP and YUM).</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the system disk is attached (that is, the device name is /dev/xvda).</para>
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
