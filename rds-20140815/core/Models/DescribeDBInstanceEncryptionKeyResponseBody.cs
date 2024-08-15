// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceEncryptionKeyResponseBody : TeaModel {
        /// <summary>
        /// The user who created the key.
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The scheduled time at which the key is deleted. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        /// <summary>
        /// The description of the key.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the key.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The details about the key.
        /// </summary>
        [NameInMap("EncryptionKeyList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceEncryptionKeyResponseBodyEncryptionKeyList> EncryptionKeyList { get; set; }
        public class DescribeDBInstanceEncryptionKeyResponseBodyEncryptionKeyList : TeaModel {
            /// <summary>
            /// The alias of the key.
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// The user who created the key.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The scheduled time at which the key is deleted. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// The description of the key.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the key.
            /// </summary>
            [NameInMap("EncryptionKey")]
            [Validation(Required=false)]
            public string EncryptionKey { get; set; }

            /// <summary>
            /// The status of the key. Valid values:
            /// 
            /// *   **Enabled**
            /// *   **Disabled**
            /// </summary>
            [NameInMap("EncryptionKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionKeyStatus { get; set; }

            /// <summary>
            /// The type of the key. Valid values:
            /// 
            /// *   **CMK**
            /// *   **ServiceKey**
            /// </summary>
            [NameInMap("KeyType")]
            [Validation(Required=false)]
            public string KeyType { get; set; }

            /// <summary>
            /// The purpose of the key.
            /// </summary>
            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

            /// <summary>
            /// The time at which the key expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("MaterialExpireTime")]
            [Validation(Required=false)]
            public string MaterialExpireTime { get; set; }

            /// <summary>
            /// The source of the key.
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// The role of the instance. Valid values:
            /// 
            /// *   **Master**: primary instance
            /// *   **slave**: read-only instance
            /// </summary>
            [NameInMap("UsedBy")]
            [Validation(Required=false)]
            public string UsedBy { get; set; }

        }

        /// <summary>
        /// The status of the key. Valid values:
        /// 
        /// *   **Enabled**
        /// *   **Disabled**
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// The purpose of the key.
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// The time at which the key expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        /// <summary>
        /// The source of the key.
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
