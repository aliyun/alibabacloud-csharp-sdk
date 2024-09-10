// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBackupPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBackupPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: 10.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of anti-ransomware policies returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The details of the anti-ransomware policy.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeBackupPoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeBackupPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// The number of the servers on which the anti-ransomware agent is in an abnormal state.
            /// </summary>
            [NameInMap("ClientErrorCount")]
            [Validation(Required=false)]
            public int? ClientErrorCount { get; set; }

            /// <summary>
            /// The UUIDs of the servers on which the anti-ransomware agent is in an **abnormal** state.
            /// </summary>
            [NameInMap("ClientErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ClientErrorUuidList { get; set; }

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
            /// The number of the servers on which the anti-ransomware agent is in a normal state.
            /// </summary>
            [NameInMap("HealthClientCount")]
            [Validation(Required=false)]
            public int? HealthClientCount { get; set; }

            /// <summary>
            /// The UUIDs of the servers on which the anti-ransomware agent is in a **normal** state.
            /// </summary>
            [NameInMap("HealthClientUuidList")]
            [Validation(Required=false)]
            public List<string> HealthClientUuidList { get; set; }

            /// <summary>
            /// The ID of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The time when the anti-ransomware policy was last updated. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastStatusSyncTime")]
            [Validation(Required=false)]
            public long? LastStatusSyncTime { get; set; }

            /// <summary>
            /// The name of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The configurations of the anti-ransomware policy. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **IsDefault**: the type of the anti-ransomware policy. Valid values:
            /// 
            ///     *   **1**: recommended policy
            ///     *   **0**: custom policy
            /// 
            /// *   **Include**: the format of the files that are protected. If the value of this field is [], all formats of files are protected.
            /// 
            /// *   **Source**: the directory that is protected. If the value of this field is [], all directories are protected.
            /// 
            /// *   **ExcludeSystemPath**: indicates whether a specified directory is excluded from the anti-ransomware policy. If the value of this field is **true**, a directory is excluded. If this field is left empty, no directories are excluded.
            /// 
            /// *   **Exclude**: the directory that is excluded from the anti-ransomware policy. If the value of this field is [], no directories are excluded.
            /// 
            /// *   **Schedule**: the start time and interval of a data backup task. We recommend that you specify a start time that begins during off-peak hours but does not start on the hour. Examples:
            /// 
            ///     *   If the value of this field is I|1583216092|P21D, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of three weeks.
            ///     *   If the value of this field is I|1583216092|PT24H, the data backup task starts from 2020-03-03 14:14:52, and the task is run at an interval of 24 hours.
            /// 
            /// *   **Retention**: the period during which backup data is retained. Unit: days. If the value of this field is 7, backup data is retained for a week. If the value of this field is 365, backup data is retained for a year. If the value of this field is -1, backup data is permanently retained.
            /// 
            /// *   **SpeedLimiter**: the limit on the network bandwidth for data backup tasks. If the value of this field is 0:24:30720, the maximum bandwidth for a data backup task is 30 MB/s from 00:00 to 24:00.
            /// 
            /// *   **UseVss**: indicates whether the VSS feature is enabled. The feature is available only for Windows servers. Valid values:
            /// 
            ///     *   **true**
            ///     *   **false**
            /// 
            /// >  The VSS feature is available only if you create the anti-ransomware policy for Windows servers. After you enable the feature, the number of backup failures due to running processes is significantly reduced. We recommend that you enable the VSS feature. After you enable the feature, the data of disks that are in the exFAT and FAT32 formats cannot be backed up.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The ID of the region that you specified for data backup when you installed the anti-ransomware agent for the server not deployed on Alibaba Cloud.
            /// </summary>
            [NameInMap("PolicyRegionId")]
            [Validation(Required=false)]
            public string PolicyRegionId { get; set; }

            /// <summary>
            /// The version of the anti-ransomware policy. Valid values:
            /// 
            /// *   1.0.0
            /// *   2.0.0
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// The previous status of the anti-ransomware policy. Valid values:
            /// 
            /// *   **enabled**: The anti-ransomware policy is manually enabled.
            /// *   **disabled**: The anti-ransomware policy is manually disabled. After an anti-ransomware policy is disabled, the data backup task that is running based on the policy stops.
            /// *   **closed**: The anti-ransomware policy automatically stops because the anti-ransomware capacity is insufficient.
            /// </summary>
            [NameInMap("PreStatus")]
            [Validation(Required=false)]
            public string PreStatus { get; set; }

            /// <summary>
            /// The UUIDs that are returned based on the value of the MachineRemark request parameter.
            /// </summary>
            [NameInMap("RemarkedUuidList")]
            [Validation(Required=false)]
            public List<string> RemarkedUuidList { get; set; }

            /// <summary>
            /// The type of the server. Valid values:
            /// 
            /// *   **OUT_CLOUD**: server not deployed on Alibaba Cloud
            /// *   **ALIYUN**: Elastic Compute Service (ECS) instance
            /// *   **TRIPARTITE**: simple application server
            /// </summary>
            [NameInMap("ServerType")]
            [Validation(Required=false)]
            public string ServerType { get; set; }

            /// <summary>
            /// The number of servers on which data backup is exceptional.
            /// </summary>
            [NameInMap("ServiceErrorCount")]
            [Validation(Required=false)]
            public int? ServiceErrorCount { get; set; }

            /// <summary>
            /// The UUIDs of the servers on which data backup is exceptional.
            /// </summary>
            [NameInMap("ServiceErrorUuidList")]
            [Validation(Required=false)]
            public List<string> ServiceErrorUuidList { get; set; }

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
            /// The upgrade status of the anti-ransomware policy. Valid values:
            /// 
            /// *   **NotUpgraded**
            /// *   **Upgrading**
            /// *   **UpgradeFailed**
            /// *   **UpgradeSuccess**
            /// </summary>
            [NameInMap("UpgradeStatus")]
            [Validation(Required=false)]
            public string UpgradeStatus { get; set; }

            /// <summary>
            /// The UUIDs of the servers to which the anti-ransomware policy is applied.
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
