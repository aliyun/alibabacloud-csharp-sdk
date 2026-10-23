// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReInitDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically start the instance after the cloud disk is reinitialized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes. The instance is automatically started.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoStartInstance")]
        [Validation(Required=false)]
        public bool? AutoStartInstance { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk to be reinitialized. The instance to which the cloud disk is attached must have been started at least once and must currently be in the Stopped state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to Linux instances. When you reinitialize the system cloud disk, you can bind an SSH key pair to the ECS instance as the logon credential. After an SSH key pair is used, the password logon method is disabled.</para>
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
        /// <para>Specifies whether to reset the logon password of the ECS instance when you reinitialize the system cloud disk. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
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

        /// <summary>
        /// <para>Specifies whether to use Security Center for free after the cloud disk is reinitialized when the specified cloud disk is a system cloud disk. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>Active: Uses Security Center. This value is supported only for public images.  </para>
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

    }

}
