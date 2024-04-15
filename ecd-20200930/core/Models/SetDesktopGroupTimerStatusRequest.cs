// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDesktopGroupTimerStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud computer pool.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The status of the scheduled task.
        /// 
        /// Valid values:
        /// 
        /// *   1: enabled
        /// *   2: disabled
        /// *   3: deleted
        /// *   100: unknown
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

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
