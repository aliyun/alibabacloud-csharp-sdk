// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDesktopGroupTimerRequest : TeaModel {
        /// <summary>
        /// The cron expression for the scheduled task. This parameter is required when `TimerType` is set to 2, 3, or 4.
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// The ID of the cloud computer pool.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// Specifies whether to forcefully execute the scheduled task.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the disk that you want to reset.
        /// 
        /// Valid values:
        /// 
        /// - does not reset disks.
        /// - resets only the system disk.
        /// - resets only the user disk.
        /// - resets the system disk and the user disk.
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public int? ResetType { get; set; }

        /// <summary>
        /// The type of the scheduled task.
        /// 
        /// Valid values:
        /// 
        /// *   1: scheduled reset
        /// *   2: scheduled startup
        /// *   3: scheduled stop
        /// *   4: scheduled restart
        /// </summary>
        [NameInMap("TimerType")]
        [Validation(Required=false)]
        public int? TimerType { get; set; }

    }

}
