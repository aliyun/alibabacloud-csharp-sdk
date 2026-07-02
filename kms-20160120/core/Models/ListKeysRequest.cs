// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeysRequest : TeaModel {
        /// <summary>
        /// <para>A filter for master keys. The filter consists of 0 to 10 key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><para>Key</para>
        /// <list type="bullet">
        /// <item><description><para>Description: The property to filter.</para>
        /// </description></item>
        /// <item><description><para>Type: String.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Values</para>
        /// <list type="bullet">
        /// <item><description><para>Description: The value to be included after filtering.</para>
        /// </description></item>
        /// <item><description><para>Type: String array.</para>
        /// </description></item>
        /// <item><description><para>Length: 0 to 10.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>KeyState\\</c>, it specifies the key status. Valid values for \<c>Value\\</c> are \<c>Enabled\\</c>, \<c>Disabled\\</c>, \<c>PendingDeletion\\</c>, and \<c>PendingImport\\</c>.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>KeySpec\\</c>, it specifies the key type. Valid values for \<c>Value\\</c> are \<c>Aliyun_AES_256\\</c>, \<c>Aliyun_SM4\\</c>, \<c>RSA_2048\\</c>, \<c>EC_P256\\</c>, \<c>EC_P256K\\</c>, \<c>EC_SM2\\</c>, and \<c>Aliyun_SM4\\</c>.<br> Note: You can create keys of the \<c>EC_SM2\\</c> and \<c>Aliyun_SM4\\</c> types only in regions that support managed HSMs and have passed the compliance assessment of the Office of State Commercial Cryptography Administration (OSCCA). For more information about the supported regions, see <a href="https://help.aliyun.com/document_detail/125803.html">Supported regions</a>. If you specify \<c>EC_SM2\\</c> or \<c>Aliyun_SM4\\</c> in a region that does not support these key types, the parameters are ignored.<br></para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>KeyUsage\\</c>, it specifies the key usage. Valid values for \<c>Value\\</c> are \<c>ENCRYPT/DECRYPT\\</c> (for data encryption and decryption) and \<c>SIGN/VERIFY\\</c> (for generating and verifying digital signatures).</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>ProtectionLevel\\</c>, it specifies the protection level of the key. Valid values for \<c>Value\\</c> are \<c>SOFTWARE\\</c> and \<c>HSM\\</c>.<br> Note: The HSM protection level is supported only in specific regions. For more information about the supported regions, see <a href="https://help.aliyun.com/document_detail/125803.html">Supported regions</a>. If you specify \<c>HSM\\</c> in a region that does not support it, the parameter is ignored.<br></para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>CreatorType\\</c>, it specifies the creator type. Valid values for \<c>Value\\</c> are \<c>User\\</c> (returns master keys created by users) and \<c>Service\\</c> (returns master keys that are automatically created by other Alibaba Cloud services based on your authorization).</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>DKMSInstanceId\\</c>, it specifies the ID of the KMS instance. Set \<c>Value\\</c> as needed.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>keyId\\</c>, it specifies the key ID. Set \<c>Value\\</c> as needed.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>AliasName\\</c>, it specifies the key alias. Set \<c>Value\\</c> as needed.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>Creator\\</c>, it specifies the key creator. Set \<c>Value\\</c> as needed.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>TagKey\\</c>, it specifies the key of a key tag. Set \<c>Value\\</c> as needed.</para>
        /// </description></item>
        /// <item><description><para>If \<c>Key\\</c> is set to \<c>TagValue\\</c>, it specifies the value of a key tag. Set \<c>Value\\</c> as needed.</para>
        /// </description></item>
        /// </list>
        /// <para>The logical relationship between different keys in \<c>Filters\\</c> is \<c>AND\\</c>. The logical relationship between multiple values for the same key is \<c>OR\\</c>. For example, if you enter <c>[ {&quot;Key&quot;:&quot;KeyState&quot;, &quot;Values&quot;:[&quot;Enabled&quot;,&quot;Disabled&quot;]}, {&quot;Key&quot;:&quot;KeyState&quot;, &quot;Values&quot;:[&quot;PendingDeletion&quot;]}, {&quot;Key&quot;:&quot;KeySpec&quot;, &quot;Values&quot;:[&quot;Aliyun_AES_256&quot;]} ]</c>, the semantics are: <c>(KeyState=Enabled OR KeyState=Disabled OR KeyState=PendingDeletion) AND (KeySpec=Aliyun_AES_256)</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;KeyState&quot;, &quot;Values&quot;:[&quot;Enabled&quot;,&quot;Disabled&quot;]}]</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The page number.<br> Valid values: greater than 0.<br> Default value: 1.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.<br> Valid values: 1 to 100.<br> Default value: 10.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
