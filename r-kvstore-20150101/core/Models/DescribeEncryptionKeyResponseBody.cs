// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEncryptionKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the key creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17649847********</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The estimated time when the key is to be deleted. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>If this parameter is empty, the key will not be automatically deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-24T18:22:03Z</para>
        /// </summary>
        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        /// <summary>
        /// <para>The description of the key. By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testkey</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The key ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad463061-992d-4195-8a94-ed63********</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The status of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: The key is available.</description></item>
        /// <item><description><b>Disabled</b>: The key is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The encryption algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES-CTR-256</para>
        /// </summary>
        [NameInMap("EncryptionName")]
        [Validation(Required=false)]
        public string EncryptionName { get; set; }

        /// <summary>
        /// <para>The purpose of the key. The return value <c>ENCRYPT/DECRYPT</c> indicates that the key is used for encryption and decryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENCRYPT/DECRYPT</para>
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// <para>The expiration time of the key. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>If this parameter is empty, the key does not expire.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-24T18:22:03Z</para>
        /// </summary>
        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        /// <summary>
        /// <para>The source of the key material. The return value is <b>Aliyun_KMS</b>, which indicates Alibaba Cloud <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service (KMS)</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun_KMS</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A931CE5-C926-5E09-B0EC-6299C4A6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor ARN (Alibaba Cloud Resource Name) of the role to be granted authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/AliyunRdsInstanceEncryptionDefaultRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
