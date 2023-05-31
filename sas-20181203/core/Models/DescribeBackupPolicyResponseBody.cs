// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// The details of the anti-ransomware policy.
        /// </summary>
        [NameInMap("BackupPolicyDetail")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDetail BackupPolicyDetail { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDetail : TeaModel {
            /// <summary>
            /// The status of the anti-ransomware agent. Valid values:
            /// 
            /// *   **running**: normal
            /// *   **exception**: abnormal
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// *   **IsDefault**: the type of the anti-ransomware policy. Valid values:
            /// 
            ///     *   **1**: recommended policy
            ///     *   **0**: custom policy
            /// 
            /// *   **Include**: the format of the files that you want to protect. If you want to protect the files in all formats, set this field to \[].
            /// 
            /// *   **Source**: the directory that you want to protect. If you want to protect all directories, set this field to \[].
            /// 
            /// *   **ExcludeSystemPath**: specifies whether to exclude a specific directory from the anti-ransomware policy. If you want to exclude a directory, set this field to **true**. If you do not want to exclude a directory, leave this field empty.
            /// 
            /// *   **Exclude**: the directory that you want to exclude from the anti-ransomware policy. If you do not want to exclude a directory, set this field to \[].
            /// 
            /// *   **Schedule**: the start time and interval of a data backup task. We recommend that you specify a start time that begins during off-peak hours but does not start on the hour. Examples:
            /// 
            ///     *   If you set this field to I|1583216092|P21D, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of three weeks.
            ///     *   If you set this field to I|1583216092|PT24H, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of 24 hours.
            /// 
            /// *   **Retention**: the period during which backup data is retained. Unit: days. If you set this field to 7, backup data is retained for a week. If you set this field to 365, backup data is retained for a year. If you set this field to -1, backup data is permanently retained.
            /// 
            /// *   **SpeedLimiter**: the limit on the network bandwidth for data backup tasks. If you set this field to 0:24:30720, the maximum bandwidth for a data backup task is 30 MB/s from 00:00 to 24:00.
            /// 
            /// *   **UseVss**: specifies whether to enable the VSS feature. The feature is available only for Windows servers. Valid values:
            /// 
            ///     *   **true**: yes
            ///     *   **false**: no
            /// 
            /// >  The VSS feature is available only if you create the anti-ransomware policy for Windows servers. After you enable the feature, the number of backup failures due to running processes is significantly reduced. We recommend that you enable the VSS feature. After you enable the feature, the data of disks that are in the exFAT and FAT32 formats cannot be backed up.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The version of the anti-ransomware policy.
            /// 
            /// *   **1.0.0**
            /// *   **2.0.0**
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// The ID of the region in which backup data is stored.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the anti-ransomware policy. Valid values:
            /// 
            /// *   **enabled**: The anti-ransomware policy is manually enabled.
            /// *   **disabled**: The anti-ransomware policy is manually disabled. After an anti-ransomware policy is disabled, the data backup task that is running based on the policy stops.
            /// *   **closed**: The anti-ransomware policy automatically stops because the anti-ransomware capacity is insufficient.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// An array consisting of the UUIDs of the servers to which the anti-ransomware policy is applied.
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
