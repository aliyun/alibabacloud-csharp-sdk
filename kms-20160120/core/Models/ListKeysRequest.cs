// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeysRequest : TeaModel {
        /// <summary>
        /// <para>The CMK filter. The filter consists of one or more key-value pairs. You can specify a maximum of 10 key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description><para>Key</para>
        /// <list type="bullet">
        /// <item><description><para>Description: the property that you want to filter.</para>
        /// </description></item>
        /// <item><description><para>Type: string.</para>
        /// </description></item>
        /// <item><description><para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KeyState: the status of the CMK.</description></item>
        /// <item><description>KeySpec: the type of the CMK.</description></item>
        /// <item><description>KeyUsage: the usage of the CMK.</description></item>
        /// <item><description>ProtectionLevel: the protection level.</description></item>
        /// <item><description>CreatorType: the type of the creator.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Values</para>
        /// <list type="bullet">
        /// <item><description><para>Description: the value to be included after filtering.</para>
        /// </description></item>
        /// <item><description><para>Format: string array.</para>
        /// </description></item>
        /// <item><description><para>Length: 0 to 10.</para>
        /// </description></item>
        /// <item><description><para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>When Key is set to KeyState, the value can be Enabled, Disabled, PendingDeletion, or PendingImport.</para>
        /// </description></item>
        /// <item><description><para>When Key is set to KeySpec, the value can be Aliyun_AES_256, Aliyun_SM4, RSA_2048, EC_P256, EC_P256K, or EC_SM2.</para>
        /// <para>Note: You can create CMKs of the EC_SM2 or Aliyun_SM4 type only in regions where State Cryptography Administration (SCA)-certified managed HSMs reside. For more information about the regions, see <a href="https://help.aliyun.com/document_detail/125803.html">Supported regions</a>. If your region does not support EC_SM2 or Aliyun_SM4, the two values are ignored if they are specified.</para>
        /// </description></item>
        /// <item><description><para>When Key is set to KeyUsage, the value can be ENCRYPT/DECRYPT or SIGN/VERIFY. ENCRYPT/DECRYPT indicates that the CMK is used to encrypt and decrypt data. SIGN/VERIFY indicates that the CMK is used to generate and verify digital signatures.</para>
        /// </description></item>
        /// <item><description><para>When Key is set to ProtectionLevel, the value can be SOFTWARE (software) or HSM (hardware).</para>
        /// <para>You can set ProtectionLevel to HSM in only specific regions. For more information about the regions, see <a href="https://help.aliyun.com/document_detail/125803.html">Supported regions</a>. If your region does not support the value HSM, the value is ignored if the value is specified.</para>
        /// </description></item>
        /// <item><description><para>If Key is set to CreatorType, the value can be User or Service. User indicates that CMKs created by the current account are queried. Service indicates that CMKs automatically created by other cloud services authorized by the current account are queried.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>The logical relationship between different keys is AND, and the logical relationship between multiple items in the same key is OR. Example:</para>
        /// <para><c>[ {&quot;Key&quot;:&quot;KeyState&quot;, &quot;Values&quot;:[&quot;Enabled&quot;,&quot;Disabled&quot;]}, {&quot;Key&quot;:&quot;KeyState&quot;, &quot;Values&quot;:[&quot;PendingDeletion&quot;]}, {&quot;Key&quot;:&quot;KeySpec&quot;, &quot;Values&quot;:[&quot;Aliyun_AES_256&quot;]}]</c>. In this example, the semantics are:<c>(KeyState=Enabled OR KeyState=Disabled OR KeyState=PendingDeletion) AND (KeySpec=Aliyun_AES_ 256)</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;KeyState&quot;, &quot;Values&quot;:[&quot;Enabled&quot;,&quot;Disabled&quot;]}]</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
