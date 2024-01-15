// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDesktopGroupTimerRequest : TeaModel {
        /// <summary>
        /// The CRON expression for the scheduled task.
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// The ID of the desktop group.
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
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the disk that you want to reset.
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public int? ResetType { get; set; }

        /// <summary>
        /// The type of the scheduled task.
        /// </summary>
        [NameInMap("TimerType")]
        [Validation(Required=false)]
        public int? TimerType { get; set; }

    }

}
