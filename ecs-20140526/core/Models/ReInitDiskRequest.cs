// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ReInitDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically start the instance after the disk is reinitialized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: automatically starts the instance.</description></item>
        /// <item><description>false: does not automatically start the instance.</description></item>
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
        /// <para>The ID of the disk to be reinitialized.</para>
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
        /// <para>This parameter is applicable only to Linux instances. When the system disk is reinitialized, you can attach an SSH key pair to the ECS instance as the logon credential. After you use an SSH key pair, the username and password logon method is disabled.</para>
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
        /// <para>Specifies whether to reset the username and password of the ECS instance when the system disk is reinitialized. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <pre><c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/
        /// </c></pre>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the <c>Password</c> parameter, use HTTPS to send the request to avoid password leaks.</para>
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
        /// <para>Specifies whether to use the free Security Center service after the system disk is reinitialized. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>Active: uses the Security Center service. This value is applicable only to public images.  </para>
        /// </description></item>
        /// <item><description><para>Deactive: does not use the Security Center service. This value is applicable to all images.</para>
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
