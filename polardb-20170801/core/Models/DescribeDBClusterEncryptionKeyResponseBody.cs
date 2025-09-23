// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterEncryptionKeyResponseBody : TeaModel {
        [NameInMap("EncryptionKeyList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterEncryptionKeyResponseBodyEncryptionKeyList> EncryptionKeyList { get; set; }
        public class DescribeDBClusterEncryptionKeyResponseBodyEncryptionKeyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>alias/your_default_key</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1****1</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-08T08:14:16Z</para>
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Description of the key</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51858179-afb3-4369-8329-*********</para>
            /// </summary>
            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("EncryptionKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionKeyStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ServiceKey</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ENCRYPT/DECRYPT</para>
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10-18T08:14:16Z</para>
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Aliyun_KMS</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DiskEncryption</para>
            /// </summary>
            [NameInMap("UsedBy")]
            [Validation(Required=false)]
            public string UsedBy { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>137ECCC0-920E-5B3B-9F8E-B81632108BBE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
