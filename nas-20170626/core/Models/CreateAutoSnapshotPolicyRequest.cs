// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The name of the automatic snapshot policy.
        /// 
        /// Limits:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter.
        /// *   The name can contain digits, colons (:), underscores (_), and hyphens (-). It cannot start with `http://` or `https://`.
        /// *   This parameter is empty by default.
        /// </summary>
        [NameInMap("AutoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid value: extreme, which indicates Extreme NAS file systems.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// The days of a week on which to create automatic snapshots.
        /// 
        /// Cycle: week.
        /// 
        /// Valid values: 1 to 7. The values from 1 to 7 indicate the seven days in a week from Monday to Sunday.
        /// 
        /// If you want to create multiple auto snapshots within a week, you can specify multiple days from Monday to Sunday and separate the days with commas (,). You can specify a maximum of seven days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RepeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// The retention period of auto snapshots.
        /// 
        /// Unit: days.
        /// 
        /// Valid values:
        /// 
        /// *   \\-1 (default). Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.
        /// *   1 to 65536: Auto snapshots are retained for the specified days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The points in time at which auto snapshots were created.
        /// 
        /// Unit: hours.
        /// 
        /// Valid values: 0 to 23. The values from 0 to 23 indicate a total of 24 hours from 00:00 to 23:00. For example, the value 1 indicates 01:00.
        /// 
        /// If you want to create multiple auto snapshots within a day, you can specify multiple points in time and separate the points in time with commas (,). You can specify a maximum of 24 points in time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
