// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceCLSRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n8t18o******6d5</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Encryption algorithm to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AES_128_CBC</description></item>
        /// <item><description>AES_128_GCM</description></item>
        /// <item><description>AES_128_CTR</description></item>
        /// <item><description>AES_128_ECB</description></item>
        /// <item><description>AES_256_CBC</description></item>
        /// <item><description>AES_256_GCM</description></item>
        /// <item><description>AES_256_CTR</description></item>
        /// <item><description>AES_256_ECB</description></item>
        /// <item><description>SM4_128_CBC</description></item>
        /// <item><description>SM4_128_GCM</description></item>
        /// <item><description>SM4_128_CTR</description></item>
        /// <item><description>SM4_128_ECB</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256_GCM</para>
        /// </summary>
        [NameInMap("EncryptionAlgorithm")]
        [Validation(Required=false)]
        public string EncryptionAlgorithm { get; set; }

        /// <summary>
        /// <para>Encryption key ID. This parameter is required when using a KMS key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>Column encryption key mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>client_key (configure a randomly generated user key on the client side)</description></item>
        /// <item><description>kms_key (use a custom key configured via Alibaba Cloud KMS)</description></item>
        /// </list>
        /// <para>Note:
        /// Once an instance is configured to use a KMS key, it can no longer use the client-side random key configuration method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kms_key</para>
        /// </summary>
        [NameInMap("EncryptionKeyMode")]
        [Validation(Required=false)]
        public string EncryptionKeyMode { get; set; }

        /// <summary>
        /// <para>Column encryption status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1 (Enabled)</description></item>
        /// <item><description>0 (Disabled)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EncryptionStatus")]
        [Validation(Required=false)]
        public string EncryptionStatus { get; set; }

        /// <summary>
        /// <para>Whether to rotate the key</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRotate")]
        [Validation(Required=false)]
        public bool? IsRotate { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Global Resource Descriptor (GRD) of the role used to specify the exact role. For more information, see RAM Role Overview.</para>
        /// <para>Note:
        /// This parameter takes effect only when the column encryption key mode is set to kms_key. If not provided, the system uses an internal default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406926****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>Whether to enable whitelist mode. true indicates that only columns in the whitelist are encrypted; false indicates that all columns are encrypted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WhiteListMode")]
        [Validation(Required=false)]
        public bool? WhiteListMode { get; set; }

    }

}
