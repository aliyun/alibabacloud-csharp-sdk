// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOssScanConfigRequest : TeaModel {
        [NameInMap("AllKeyPrefix")]
        [Validation(Required=false)]
        public bool? AllKeyPrefix { get; set; }

        /// <summary>
        /// The names of buckets.
        /// </summary>
        [NameInMap("BucketNameList")]
        [Validation(Required=false)]
        public List<string> BucketNameList { get; set; }

        /// <summary>
        /// Specifies whether to enable the policy. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// The time when the scan ends. The time must be in the HH:mm:ss format.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("KeyPrefixList")]
        [Validation(Required=false)]
        public List<string> KeyPrefixList { get; set; }

        /// <summary>
        /// The suffixes of the files to scan.
        /// </summary>
        [NameInMap("KeySuffixList")]
        [Validation(Required=false)]
        public List<string> KeySuffixList { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The days on which the scan is executed in a week.
        /// </summary>
        [NameInMap("ScanDayList")]
        [Validation(Required=false)]
        public List<int?> ScanDayList { get; set; }

        /// <summary>
        /// The time when the scan starts. The time must be in the HH:mm:ss format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
