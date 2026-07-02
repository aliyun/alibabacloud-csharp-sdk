// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateAndExportDataKeyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the dry run feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the feature.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the feature.</para>
        /// </description></item>
        /// </list>
        /// <para>The DryRun mode is used to test API calls and verify the permissions on the resources that you have access to and the validity of the request parameters. If you enable the DryRun mode, KMS always returns a failure response and the cause of the failure. The following failure causes are included:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter is not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The parameters specified in the request are invalid.</para>
        /// </description></item>
        /// <item><description><para>AccessDeniedError: You are not authorized to perform this operation on the KMS resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of key-value pairs. If you specify this parameter, you must specify the same parameter when you call the Decrypt operation or other operations to re-encrypt the data key. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

        /// <summary>
        /// <para>The ID of the key. You can also specify the alias or Amazon Resource Name (ARN) of the key. For more information about aliases, see <a href="https://help.aliyun.com/document_detail/480655.html">Manage aliases</a>.</para>
        /// <remarks>
        /// <para>To access a key in another Alibaba Cloud account, you must specify the ARN of the key. The key ARN is in the format of <c>acs:kms:${region}:${account}:key/${keyid}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abcd-12ab-34cd-56ef-12345678****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The length of the data key that you want to generate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AES_256: a 256-bit symmetric key.</para>
        /// </description></item>
        /// <item><description><para>AES_128: a 128-bit symmetric key.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>We recommend that you use the KeySpec or NumberOfBytes parameter to specify the length of a data key. If you do not specify either of the parameters, KMS generates a 256-bit data key. If you specify both parameters, KMS ignores the KeySpec parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256</para>
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// <para>The length of the data key that you want to generate.</para>
        /// <para>Valid values: 1 to 1024.</para>
        /// <para>Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

        /// <summary>
        /// <para>The public key that is encoded in Base64.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAndKfC2ReLL2+y8a0+ZBBeAft/uBYo86GZiYJuflqgUzKxpyuvlo3uQkBv6b+nx+0tz8g8v7GhpPWMSW5L9mNHYsvYFsa7jTxsYdt17yj6GlUHPuMIs8hr5qbwl38IHU1iIa7nYWwE2fb3ePOvLDACRJVgGpU0yxioW80d2QD+9aU4jF5dlAahcfgsNzo2CXzCUc1+xbmNuq7Rp+H9VJB9dyYOwqnW3RhOLBo21FzpORapf0UiRlrHRpk1V6ez+aE1dofaYh/9bh0m6ioxj7j5hpZbWccuEZTMBKd+cbuBkRhJzc6Tti6qwZbDiu4fUwbZS0Tqpuo1UadiyxMW********</para>
        /// </summary>
        [NameInMap("PublicKeyBlob")]
        [Validation(Required=false)]
        public string PublicKeyBlob { get; set; }

        /// <summary>
        /// <para>The encryption algorithm that is used to encrypt the data key using the public key specified by PublicKeyBlob. For more information about encryption algorithms, see <a href="https://help.aliyun.com/document_detail/148130.html">AsymmetricDecrypt</a>.<br> Valid values:<br><br></para>
        /// <list type="bullet">
        /// <item><description><para>RSAES_OAEP_SHA_256</para>
        /// </description></item>
        /// <item><description><para>RSAES_OAEP_SHA_1</para>
        /// </description></item>
        /// <item><description><para>SM2PKE</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSAES_OAEP_SHA_256</para>
        /// </summary>
        [NameInMap("WrappingAlgorithm")]
        [Validation(Required=false)]
        public string WrappingAlgorithm { get; set; }

        /// <summary>
        /// <para>The type of the key specified by PublicKeyBlob. For more information about key types, see <a href="https://help.aliyun.com/document_detail/148147.html">Introduction to asymmetric keys</a>.<br> Valid values:<br><br></para>
        /// <list type="bullet">
        /// <item><description><para>RSA_2048</para>
        /// </description></item>
        /// <item><description><para>EC_SM2</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("WrappingKeySpec")]
        [Validation(Required=false)]
        public string WrappingKeySpec { get; set; }

    }

}
