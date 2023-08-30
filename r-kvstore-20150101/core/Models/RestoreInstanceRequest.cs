// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class RestoreInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the backup file. You can call the [DescribeBackups](~~61081~~) operation to query the IDs of backup files.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The key that you want to restore. You can specify multiple keys. Separate multiple keys with commas (,). Regular expressions are supported.
        /// 
        /// > 
        /// 
        /// *   In a regular expression, an asterisk (`*`) matches zero or more occurrences of a subexpression that occurs before. For example, if you set this parameter to `h.*llo`, strings such as `hllo` and `heeeello` are matched.
        /// 
        /// *   This parameter is available only if you set the **RestoreType** parameter to **1**.
        /// </summary>
        [NameInMap("FilterKey")]
        [Validation(Required=false)]
        public string FilterKey { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time to which you want to restore data. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   If the [data flashback](~~148479~~) feature is enabled for the instance, you can specify this parameter and the **FilterKey** parameter to restore the data of the specified key to the specified point in time that is accurate to the second. Other keys are not affected. This way, you can achieve more fine-grained data restoration.
        /// 
        /// *   This parameter is available only if you set the **RestoreType** parameter to **1**.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The restoration mode. Default value: 0. Valid values:
        /// 
        /// *   **0**: restores data from the specified backup set.
        /// *   **1**: restores data to a specified point in time. You can specify this value only if the [data flashback](~~148479~~) feature is enabled for the instance. If you specify this value, you must also specify the **RestoreTime** parameter.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The expiration offset time point of a key. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC. The key expires after the remaining validity period of the key elapses based on the expiration offset time point.
        /// 
        /// > This time point must be between the specified flashback time point and the submission time of the data restoration task.
        /// </summary>
        [NameInMap("TimeShift")]
        [Validation(Required=false)]
        public string TimeShift { get; set; }

    }

}
