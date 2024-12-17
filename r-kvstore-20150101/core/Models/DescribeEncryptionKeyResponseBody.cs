// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEncryptionKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to create the custom key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17649847********</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The time when the custom key is expected to be deleted. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <para>If the return value is an empty string, the custom key cannot be automatically deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-24T18:22:03Z</para>
        /// </summary>
        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        /// <summary>
        /// <para>The description of the custom key. By default, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testkey</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the custom key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad463061-992d-4195-8a94-ed63********</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The state of the custom key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: The custom key is available.</description></item>
        /// <item><description><b>Disabled</b>: The custom key is unavailable.</description></item>
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
        /// <para>The purpose of the custom key. A value of <c>ENCRYPT/DECRYPT</c> indicates encryption and decryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENCRYPT/DECRYPT</para>
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// <para>The time when the custom key expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <para>If the return value is an empty string, the custom key does not expire.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-24T18:22:03Z</para>
        /// </summary>
        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        /// <summary>
        /// <para>The source of the custom key. A value of <b>Aliyun_KMS</b> indicates <a href="https://help.aliyun.com/document_detail/28935.html">Key Management Service (KMS)</a> of Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun_KMS</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A931CE5-C926-5E09-B0EC-6299C4A6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role to which you want to grant permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/AliyunRdsInstanceEncryptionDefaultRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
