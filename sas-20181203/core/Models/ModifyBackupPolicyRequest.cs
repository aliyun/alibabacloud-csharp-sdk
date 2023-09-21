// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the anti-ransomware policy that you want to modify.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The name of the anti-ransomware policy that you want to modify.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The configurations of the anti-ransomware policy that you want to modify. The value is a JSON string that contains the following fields:
        /// 
        /// *   **Source**: the directory that you want to protect. If you want to protect all directories, set this field to brackets \[].
        /// 
        /// *   **Include**: the format of the file that you want to protect. Examples: \*.jpg and \*.doc.
        /// 
        /// *   **Exclude**: the directory that you want to exclude from the anti-ransomware policy. You can call the DescribeExcludeSystemPath operation to query all directories and then specify the directory that you want to exclude. Example: /home/user.
        /// 
        /// *   **Schedule**: the start time and interval of a data backup task. We recommend that you specify a start time that begins during off-peak hours but does not start on the hour.
        /// 
        ///     *   If you set this field to I|1583216092|P21D, the data backup task starts from 2020-03-03 14:14:52, and the task is executed at an interval of three weeks.
        ///     *   If you set this field to I|1583216092|PT24H, the data backup task starts from 2020-03-03 14:14:52, and the task is executed at an interval of 24 hours.
        /// 
        /// *   **Retention**: the period during which backup data is retained. Unit: day. If you set this field to 7, backup data is retained for a week. If you set this field to 365, backup data is retained for a year. If you set this field to -1, backup data is permanently retained.
        /// 
        /// *   **SpeedLimiter**: the limit on the network bandwidth for data backup tasks. If you set this field to 12:15:15360|6:12:5120, the maximum bandwidth for a data backup task is 15 Mbit/s from 12:00 to 15:00 and 5 Mbit/s from 06:00 to 12:00.
        /// 
        /// If you back up data on an Elastic Compute Service (ECS) instance that is connected over an internal network, we recommend that you leave this field empty. If this field is left empty, the bandwidth for data backup tasks is unlimited.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public Dictionary<string, object> Policy { get; set; }

        /// <summary>
        /// The region ID of the server to which the anti-ransomware policy is applied.
        /// 
        /// You can call the [DescribeSupportRegion](~~DescribeSupportRegion~~) operation to query the regions in which the anti-ransomware feature is supported.
        /// </summary>
        [NameInMap("PolicyRegionId")]
        [Validation(Required=false)]
        public string PolicyRegionId { get; set; }

        /// <summary>
        /// The version of the anti-ransomware policy. You can call the [DescribeBackupPolicies](~~DescribeBackupPolicies~~) operation to query the versions of anti-ransomware policies.
        /// 
        /// *   **1.0.0**
        /// *   **2.0.0**
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// The UUIDs of the servers to which the anti-ransomware policy is applied.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
