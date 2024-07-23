// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceEncryptionKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The user who created the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1443*****9604</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The scheduled time at which the key is deleted. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-08T08:14:16Z</para>
        /// </summary>
        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        /// <summary>
        /// <para>The description of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description of the key</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5306d1b6-7fd3-42d9-9511-xxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The details about the key.</para>
        /// </summary>
        [NameInMap("EncryptionKeyList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceEncryptionKeyResponseBodyEncryptionKeyList> EncryptionKeyList { get; set; }
        public class DescribeDBInstanceEncryptionKeyResponseBodyEncryptionKeyList : TeaModel {
            /// <summary>
            /// <para>The alias of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alias/xxx</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The user who created the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1443*****9604</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The scheduled time at which the key is deleted. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-08T08:14:16Z</para>
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// <para>The description of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description of the key</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5306d1b6-7fd3-42d9-9511-xxxxxxx</para>
            /// </summary>
            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            /// <summary>
            /// <para>The status of the key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enabled</b></description></item>
            /// <item><description><b>Disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("EncryptionKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionKeyStatus { get; set; }

            /// <summary>
            /// <para>The type of the key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CMK</b></description></item>
            /// <item><description><b>ServiceKey</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceKey</para>
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            /// <summary>
            /// <para>The purpose of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENCRYPT/DECRYPT</para>
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// <para>The time at which the key expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-18T08:14:16Z</para>
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// <para>The source of the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliyun_KMS</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The role of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Master</b>: primary instance</description></item>
            /// <item><description><b>slave</b>: read-only instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Master</para>
            /// </summary>
            [NameInMap("UsedBy")]
            [Validation(Required=false)]
            public string UsedBy { get; set; }

        }

        /// <summary>
        /// <para>The status of the key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// <para>The purpose of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENCRYPT/DECRYPT</para>
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// <para>The time at which the key expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-18T08:14:16Z</para>
        /// </summary>
        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        /// <summary>
        /// <para>The source of the key.</para>
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
        /// <para>3BC2768E-DEDA-40FC-BBE9-6B884F3626AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
