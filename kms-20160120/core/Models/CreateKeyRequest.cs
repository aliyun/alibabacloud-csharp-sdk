// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the KMS instance.</para>
        /// <remarks>
        /// <para>You must specify this parameter if you need to create a key for a KMS instance. If you need to create a default key of the CMK type, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>kst-bjj62d8f5e0sgtx8h****</para>
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the key.</para>
        /// <para>The description can be 0 to 8,192 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key description example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic key rotation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <para>This parameter is valid only when the key belongs to an instance type that supports automatic rotation. For more information, see <a href="https://help.aliyun.com/document_detail/2358146.html">Key rotation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// <para>The key specification. The valid values vary based on the KMS instance type. For more information, see <a href="https://help.aliyun.com/document_detail/480159.html">Overview</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a value for this parameter, the default key specification is Aliyun_AES_256.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun_AES_256</para>
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        [NameInMap("KeyStorageMechanism")]
        [Validation(Required=false)]
        public string KeyStorageMechanism { get; set; }

        /// <summary>
        /// <para>The usage of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENCRYPT/DECRYPT</description></item>
        /// <item><description>SIGN/VERIFY</description></item>
        /// </list>
        /// <para>If the key supports signing and verification, the default value is SIGN/VERIFY. If the key does not support signing and verification, the default value is ENCRYPT/DECRYPT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENCRYPT/DECRYPT</para>
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// <para>The key material origin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Aliyun_KMS (default): KMS generates key material.</description></item>
        /// <item><description>EXTERNAL: You import key material.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter is case-sensitive.</description></item>
        /// <item><description>Default keys of the customer master key (CMK) type support Aliyun_KMS and EXTERNAL. Keys in instances of the software key management type support only Aliyun_KMS. Keys in instances of the hardware key management type support Aliyun_KMS and EXTERNAL.</description></item>
        /// <item><description>If you set Origin to EXTERNAL, you must import key material. For more information, see <a href="https://help.aliyun.com/document_detail/607841.html">Import key material into a symmetric key</a> or <a href="https://help.aliyun.com/document_detail/608827.html">Import key material into an asymmetric key</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun_KMS</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>You do not need to specify this parameter. KMS sets a protection level for your key.</para>
        /// <para>The protection level of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SOFTWARE</description></item>
        /// <item><description>HSM</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If DKMSInstanceId is specified, this parameter does not take effect. If your instance is an instance of the software key management type, set the value to SOFTWARE. If your instance is an instance of the hardware key management type, set the value to HSM.</description></item>
        /// <item><description>If you do not specify DKMSInstanceId, we recommend that you do not specify this parameter. KMS sets a protection level for your key. If managed hardware security modules (HSMs) exist in the region of your KMS instance, set the value to HSM. If managed HSMs do not exist in the region of your KMS instance, set the value to SOFTWARE. For more information, see Managed HSM overview.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SOFTWARE</para>
        /// </summary>
        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public string ProtectionLevel { get; set; }

        /// <summary>
        /// <para>The period of automatic key rotation. Format: integer[unit]. Unit: d (day), h (hour), m (minute), or s (second). For example, both 7d and 604800s represent a seven-day interval.</para>
        /// <list type="bullet">
        /// <item><description>For a default key, set the value to 365 days.</description></item>
        /// <item><description>For a software-protected key, set a value that ranges from 7 to 365 days.</description></item>
        /// <item><description>A hardware-protected key does not support automatic rotation.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If EnableAutomaticRotation is set to true, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>365d</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The tag that is added to the key. A tag consists of a key-value pair.</para>
        /// <para>You can enter up to 20 tags. Enter multiple tags in the [{&quot;TagKey&quot;:&quot;key1&quot;,&quot;TagValue&quot;:&quot;value1&quot;},{&quot;TagKey&quot;:&quot;key2&quot;,&quot;TagValue&quot;:&quot;value2&quot;},..] format.</para>
        /// <para>Each tag key or tag value can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).</para>
        /// <remarks>
        /// <para>The tag key cannot start with aliyun or acs:.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagKey&quot;:&quot;disk-encryption&quot;,&quot;TagValue&quot;:&quot;true&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
