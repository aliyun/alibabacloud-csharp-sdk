// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBackupStorageCountResponseBody : TeaModel {
        /// <summary>
        /// The details about the anti-ransomware capacity.
        /// </summary>
        [NameInMap("BackupStorageCount")]
        [Validation(Required=false)]
        public GetBackupStorageCountResponseBodyBackupStorageCount BackupStorageCount { get; set; }
        public class GetBackupStorageCountResponseBodyBackupStorageCount : TeaModel {
            /// <summary>
            /// The anti-ransomware capacity that you purchased. Unit: bytes.
            /// </summary>
            [NameInMap("BuyStorageByte")]
            [Validation(Required=false)]
            public long? BuyStorageByte { get; set; }

            /// <summary>
            /// The storage capacity that is occupied by the backup data of your servers. Unit: bytes.
            /// </summary>
            [NameInMap("EcsUsageStorageByte")]
            [Validation(Required=false)]
            public long? EcsUsageStorageByte { get; set; }

            /// <summary>
            /// Indicates whether the anti-ransomware capacity that is used exceeds the anti-ransomware capacity that you purchased. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("Overflow")]
            [Validation(Required=false)]
            public int? Overflow { get; set; }

            /// <summary>
            /// The storage capacity that is occupied by the backup data of your databases. Unit: bytes.
            /// </summary>
            [NameInMap("UniUsageStorageByte")]
            [Validation(Required=false)]
            public long? UniUsageStorageByte { get; set; }

            /// <summary>
            /// The total anti-ransomware capacity that is used. Unit: bytes.
            /// </summary>
            [NameInMap("UsageStorageByte")]
            [Validation(Required=false)]
            public long? UsageStorageByte { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
