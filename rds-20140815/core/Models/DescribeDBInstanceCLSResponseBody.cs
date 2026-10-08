// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceCLSResponseBody : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm. Valid values:</para>
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
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The custom KMS master key ID.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the column encryption key pattern is set to kms_key. If this parameter is not specified, the current column encryption key settings of the database remain unchanged.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>749c1df7-<b><b>-</b></b>-<b><b>-</b></b></para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The column encryption key mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>client_key: configures a user-generated random key on the client side.</description></item>
        /// <item><description>kms_key: configures a custom key by using Alibaba Cloud Key Management Service (KMS).</description></item>
        /// </list>
        /// <remarks>
        /// <para> After an instance is configured to use KMS for key management, you can no longer switch back to the client-side random key mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>kms_key</para>
        /// </summary>
        [NameInMap("EncryptionKeyMode")]
        [Validation(Required=false)]
        public string EncryptionKeyMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0073A98-52F1-3075-8256-3943F*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the whitelist mode is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WhiteListMode")]
        [Validation(Required=false)]
        public bool? WhiteListMode { get; set; }

    }

}
