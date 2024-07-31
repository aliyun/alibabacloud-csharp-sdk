// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartDIJobRequest : TeaModel {
        /// <summary>
        /// The task ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// Specifies whether to forcefully rerun all synchronization steps. If you do not configure this parameter, the system does not forcefully rerun the task.
        /// </summary>
        [NameInMap("ForceToRerun")]
        [Validation(Required=false)]
        public bool? ForceToRerun { get; set; }

        /// <summary>
        /// The settings for the start.
        /// </summary>
        [NameInMap("RealtimeStartSettings")]
        [Validation(Required=false)]
        public StartDIJobRequestRealtimeStartSettings RealtimeStartSettings { get; set; }
        public class StartDIJobRequestRealtimeStartSettings : TeaModel {
            /// <summary>
            /// The failover settings.
            /// </summary>
            [NameInMap("FailoverSettings")]
            [Validation(Required=false)]
            public StartDIJobRequestRealtimeStartSettingsFailoverSettings FailoverSettings { get; set; }
            public class StartDIJobRequestRealtimeStartSettingsFailoverSettings : TeaModel {
                /// <summary>
                /// The failover interval. Unit: minutes.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// The maximum number of failovers.
                /// </summary>
                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                public long? UpperLimit { get; set; }

            }

            /// <summary>
            /// The timestamp of the start offset. Unit: seconds. If you do not configure this parameter, the offset is not reset by default.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
