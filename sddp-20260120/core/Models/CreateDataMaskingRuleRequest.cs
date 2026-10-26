// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class CreateDataMaskingRuleRequest : TeaModel {
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
        /// <para>The identifier of the Key Management Service (KMS) key. You can obtain it from Items[].KeyId in the response of the ListKmsKeys operation. Provide this parameter when you use a KMS key. Do not pass this parameter in local key scenarios.</para>
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
        /// <item><description>client_key: local key</description></item>
        /// <item><description>kms_key: KMS key
        /// When you use kms_key, you must specify EncryptionKeyId.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>client_key</para>
        /// </summary>
        [NameInMap("EncryptionKeyMode")]
        [Validation(Required=false)]
        public string EncryptionKeyMode { get; set; }

        /// <summary>
        /// <para>The type of the database engine. The value must be consistent with the EngineType of the target instance, such as MySQL or PostgreSQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The expiration time of the plaintext permission. The value is a UNIX timestamp in milliseconds since 00:00:00 UTC on January 1, 1970. Specify this parameter only when ExpireTimeOperation is set to SET. The value must be later than the current time and no greater than 2145953410000. The server saves the value with second precision. Do not specify this parameter when ExpireTimeOperation is set to PRESERVE or CLEAR.</para>
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
        /// <para>The instance identity. You can obtain it from Items[].InstanceId in the response of the ListDataMaskingInstances operation.</para>
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
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The code of the cloud service. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also passed, the two must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The identifier of the cloud service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS</description></item>
        /// <item><description>8: POLARDB</description></item>
        /// <item><description>27: PolarDBX2
        /// When specified together with ProductCode, the values must correspond to each other.</description></item>
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
        public List<CreateDataMaskingRuleRequestSubRuleList> SubRuleList { get; set; }
        public class CreateDataMaskingRuleRequestSubRuleList : TeaModel {
            /// <summary>
            /// <para>The list of target column names. Multiple column names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>phone,email</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public string Columns { get; set; }

            /// <summary>
            /// <para>The name of the target database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>business_db</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The name of the target table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The list of database accounts to which the fullAccess plaintext permission is granted. The accounts must belong to the target instance.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<CreateDataMaskingRuleRequestUserList> UserList { get; set; }
        public class CreateDataMaskingRuleRequestUserList : TeaModel {
            /// <summary>
            /// <para>The identifier of the database account. You can obtain it from Items[].Id in the response of the ListDataAssetAccounts operation. Pass the value as a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The authentication database for MongoDB accounts. This parameter is required when you select a MongoDB account. You do not need to pass this parameter for other services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("AuthDb")]
            [Validation(Required=false)]
            public string AuthDb { get; set; }

        }

    }

}
