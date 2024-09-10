// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOssBucketScanTaskRequest : TeaModel {
        /// <summary>
        /// Whether to match all prefixes.
        /// </summary>
        [NameInMap("AllKeyPrefix")]
        [Validation(Required=false)]
        public bool? AllKeyPrefix { get; set; }

        /// <summary>
        /// The names of the buckets.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        /// <summary>
        /// The maximum number of files for decompression. The minimum value is 1, and the maximum value is 1000. If the decompression level exceeds the maximum, the decompression operation will be terminated, but the detection of decompressed files will not be affected.
        /// </summary>
        [NameInMap("DecompressMaxFileCount")]
        [Validation(Required=false)]
        public int? DecompressMaxFileCount { get; set; }

        /// <summary>
        /// The maximum level of decompression when dealing with nested compressed files with multiple levels. The minimum value is 1, and the maximum value is 5. If the decompression level exceeds the maximum, the decompression operation will be terminated, but the detection of decompressed files will not be affected.
        /// </summary>
        [NameInMap("DecompressMaxLayer")]
        [Validation(Required=false)]
        public int? DecompressMaxLayer { get; set; }

        [NameInMap("DecryptionList")]
        [Validation(Required=false)]
        public List<string> DecryptionList { get; set; }

        /// <summary>
        /// The suffixes of the objects that you do not want to check.
        /// </summary>
        [NameInMap("ExcludeKeySuffixList")]
        [Validation(Required=false)]
        public List<string> ExcludeKeySuffixList { get; set; }

        /// <summary>
        /// The prefixes of the objects that you want to check.
        /// </summary>
        [NameInMap("KeyPrefixList")]
        [Validation(Required=false)]
        public List<string> KeyPrefixList { get; set; }

        /// <summary>
        /// The suffixes of the objects that you want to check.
        /// </summary>
        [NameInMap("KeySuffixList")]
        [Validation(Required=false)]
        public List<string> KeySuffixList { get; set; }

        [NameInMap("LastModifiedStartTime")]
        [Validation(Required=false)]
        public long? LastModifiedStartTime { get; set; }

        /// <summary>
        /// The check mode. Valid values:
        /// 
        /// *   **1**: checks all objects in the bucket.
        /// *   **2**: checks only new objects in the bucket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public int? ScanMode { get; set; }

    }

}
