// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceEncryptionKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The UID of the key creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The scheduled deletion time of the instance key. If this value is empty, the key is not automatically deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-06T18:22:03Z</para>
        /// </summary>
        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        /// <summary>
        /// <para>The description of the instance key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key description example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The status of the instance key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: The instance key is available.</description></item>
        /// <item><description><b>Disabled</b>: The instance key is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The purpose of the instance key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENCRYPT/DECRYPT</para>
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// <para>The expiration time of the key (UTC). If this value is empty, the key does not expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-06T18:22:03Z</para>
        /// </summary>
        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        /// <summary>
        /// <para>The source of the instance key.</para>
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
        /// <para>783C2062-A2D3-4EA8-88AD-E43F990C23BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
