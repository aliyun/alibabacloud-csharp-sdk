// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The hostname of the ECS instance. The hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-). Consecutive periods (.) or hyphens (-) are not allowed. The hostname cannot start or end with a period (.) or a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testHostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the instance to modify. Only a single instance ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-instanc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-instanceidname</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The password of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The instance user data. The user data must be encoded in Base64.</para>
        /// <para>Before encoding, the raw data cannot exceed 16 KB in size. Do not pass sensitive information such as passwords and private keys in plaintext. If you must pass sensitive information, encrypt the information before you encode it in Base64, and then decrypt the information in the same way within the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgK****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
