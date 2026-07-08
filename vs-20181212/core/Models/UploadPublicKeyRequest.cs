// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadPublicKeyRequest : TeaModel {
        /// <summary>
        /// <para>Base64-encoded public key content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_dffeb6610035dcb77b413a59c3*****</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Description of the public key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试使用</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Group for the public key. Used for public key management.</para>
        /// <ol>
        /// <item><description><para>Length: 0 to 255 characters.</para>
        /// </description></item>
        /// <item><description><para>Valid characters: lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// </description></item>
        /// <item><description><para>First character must be a letter or digit.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>g-test</para>
        /// </summary>
        [NameInMap("KeyGroup")]
        [Validation(Required=false)]
        public string KeyGroup { get; set; }

        /// <summary>
        /// <para>Name of the public key. Must be unique.</para>
        /// <ol>
        /// <item><description><para>Length: 8 to 255 characters.</para>
        /// </description></item>
        /// <item><description><para>Valid characters: lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// </description></item>
        /// <item><description><para>First character must be a letter or digit.</para>
        /// </description></item>
        /// <item><description><para>Prefix cannot be group-.</para>
        /// </description></item>
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
        /// <para>Type of the public key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>adb</b>: ADB key.</para>
        /// </description></item>
        /// <item><description><para><b>ssh</b>: SSH key.</para>
        /// </description></item>
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
