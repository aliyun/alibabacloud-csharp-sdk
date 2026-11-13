// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class CreateDataMaskingRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the column encryption algorithm. The availability of AES_128_GCM, AES_256_GCM, and SM4_128_GCM depends on the instance. Select an available algorithm from ListDataMaskingEncryptionAlgorithms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256_GCM</para>
        /// </summary>
        [NameInMap("EncAlgorithm")]
        [Validation(Required=false)]
        public string EncAlgorithm { get; set; }

        /// <summary>
        /// <para>The KMS key identifier. You can obtain it from Items[].KeyId in the response of ListKmsKeys. Provide this parameter when you use a KMS key. Do not pass this parameter in local key scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-12345678****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The key mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>client_key: local key.</description></item>
        /// <item><description>kms_key: KMS key.
        /// If you use kms_key, you must specify EncryptionKeyId.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>client_key</para>
        /// </summary>
        [NameInMap("EncryptionKeyMode")]
        [Validation(Required=false)]
        public string EncryptionKeyMode { get; set; }

        /// <summary>
        /// <para>The database engine type. The value must be consistent with the EngineType of the target instance, such as MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The expiration time of the plaintext access permissions. The value is a UNIX timestamp in milliseconds since 00:00:00 UTC on January 1, 1970. Specify this parameter only when ExpireTimeOperation is set to SET. The value must be later than the current time and no greater than 2145953410000. The server saves the value with second precision. Do not pass this parameter when ExpireTimeOperation is set to PRESERVE or CLEAR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2145953410000</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <para>The processing method for the permission expiration time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRESERVE: retains the original expiration time.</description></item>
        /// <item><description>CLEAR: clears the expiration time.</description></item>
        /// <item><description>SET: sets ExpireTime.
        /// Default value: PRESERVE. Only fullAccess supports setting a validity period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRESERVE</para>
        /// </summary>
        [NameInMap("ExpireTimeOperation")]
        [Validation(Required=false)]
        public string ExpireTimeOperation { get; set; }

        /// <summary>
        /// <para>The database instance identity. You can obtain it from Items[].InstanceId in the response of ListDataMaskingInstances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The cloud service code. Column encryption supports RDS, POLARDB, and PolarDBX2. If you pass ProductId at the same time, the two values must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The cloud service type identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: POLARDB.</description></item>
        /// <item><description>27: PolarDBX2.
        /// If you specify this parameter together with ProductCode, the values must match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The identifier of the associated risk handling record. You do not need to specify this parameter in the standard column encryption creation process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("RiskHandleId")]
        [Validation(Required=false)]
        public long? RiskHandleId { get; set; }

        /// <summary>
        /// <para>The list of column encryption targets grouped by database and table.</para>
        /// </summary>
        [NameInMap("SubRuleList")]
        [Validation(Required=false)]
        public string SubRuleListShrink { get; set; }

        /// <summary>
        /// <para>The list of database accounts to which the fullAccess plaintext access permissions are granted. The accounts must belong to the target instance.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public string UserListShrink { get; set; }

    }

}
