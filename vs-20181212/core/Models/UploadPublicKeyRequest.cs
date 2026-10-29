// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadPublicKeyRequest : TeaModel {
        /// <summary>
        /// <para>The encoded content of the public key. The default encoding format is Base64.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_dffeb6610035dcb77b413a59c3*****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The description of the public key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For testing purposes</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The group of the public key. Used for public key management.
        /// Naming conventions:</para>
        /// <ol>
        /// <item><description>The length must be 0 to 255 characters.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</description></item>
        /// <item><description>The first character must be a letter or a digit.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>g-test</para>
        /// </summary>
        [NameInMap("KeyGroup")]
        [Validation(Required=false)]
        public string KeyGroup { get; set; }

        /// <summary>
        /// <para>The name of the public key. The name must be unique.
        /// Naming conventions:</para>
        /// <ol>
        /// <item><description>The length must be 8 to 255 characters.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</description></item>
        /// <item><description>The first character must be a letter or a digit.</description></item>
        /// <item><description>The prefix cannot be &quot;group-&quot;.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mykey-v1.0</para>
        /// </summary>
        [NameInMap("KeyName")]
        [Validation(Required=false)]
        public string KeyName { get; set; }

        /// <summary>
        /// <para>The type of the public key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>adb</b>: ADB key.</description></item>
        /// <item><description><b>ssh</b>: SSH key.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ssh</para>
        /// </summary>
        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

    }

}
