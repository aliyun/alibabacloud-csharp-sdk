// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The hostname of the Elastic Compute Service (ECS) instance. The value can be 2 to 64 characters in length. You can use periods (.) to separate the value into multiple segments. Each segment can contain letters, digits, hyphens (-), and periods. Consecutive periods or hyphens are not allowed. The name cannot start or end with a period (.) or a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testHostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which you want to modify attributes. You can specify only one ID.</para>
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
        /// <para>The name must be 2 to 128 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
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
        /// <para>The user data of the instance. User data must be encoded in Base64.</para>
        /// <para>The size of your UserData cannot exceed 16 KB. We recommend that you do not pass in confidential information such as passwords and private keys in the plaintext format. If you must pass in confidential information, we recommend that you encrypt and Base64-encode the information before you pass it in. Then you can decode and decrypt the information in the same way within the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgK****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
