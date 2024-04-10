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
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        [NameInMap("DecompressMaxFileCount")]
        [Validation(Required=false)]
        public int? DecompressMaxFileCount { get; set; }

        [NameInMap("DecompressMaxLayer")]
        [Validation(Required=false)]
        public int? DecompressMaxLayer { get; set; }

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

        /// <summary>
        /// The check mode. Valid values:
        /// 
        /// *   **1**: checks all objects in the bucket.
        /// *   **2**: checks only new objects in the bucket.
        /// </summary>
        [NameInMap("ScanMode")]
        [Validation(Required=false)]
        public int? ScanMode { get; set; }

    }

}
