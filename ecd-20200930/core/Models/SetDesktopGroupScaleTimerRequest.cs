// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDesktopGroupScaleTimerRequest : TeaModel {
        /// <summary>
        /// The ID of the desktop group.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The information about the scheduled auto scaling tasks.
        /// </summary>
        [NameInMap("ScaleTimerInfos")]
        [Validation(Required=false)]
        public List<SetDesktopGroupScaleTimerRequestScaleTimerInfos> ScaleTimerInfos { get; set; }
        public class SetDesktopGroupScaleTimerRequestScaleTimerInfos : TeaModel {
            /// <summary>
            /// The number of cloud desktops that you want to create in the desktop group. Valid values: 0 to 200. You must configure this parameter for the scaling policy.
            /// </summary>
            [NameInMap("BuyResAmount")]
            [Validation(Required=false)]
            public int? BuyResAmount { get; set; }

            /// <summary>
            /// The CRON expression that is used when an auto scaling task is triggered.
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// The keep-alive duration after the cloud desktop is disconnected. Unit: milliseconds.
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// The load balancing policy of the multi-session desktop group.
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// The maximum number of cloud desktops in the workspace after scaling. Valid values: 0 to 200. You must configure this parameter for the scaling policy.
            /// </summary>
            [NameInMap("MaxResAmount")]
            [Validation(Required=false)]
            public int? MaxResAmount { get; set; }

            /// <summary>
            /// The minimum number of cloud desktops that can be connected. Valid values: 0 to 200.
            /// </summary>
            [NameInMap("MinResAmount")]
            [Validation(Required=false)]
            public int? MinResAmount { get; set; }

            /// <summary>
            /// The threshold for the ratio of connected sessions. This parameter is the condition that triggers auto scaling in a multi-session desktop group. `Ratio of connected sessions = Number of connected sessions/(Total number of cloud desktops × Maximum number of sessions supported by each cloud desktop) × 100%`. When the ratio of connected sessions is greater than the specified threshold, desktop scale-out is automatically triggered. When the ratio of connected sessions is smaller than the specified threshold, desktop scale-in is automatically triggered under a specific condition.
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// The type of the policy.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
