// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetSchedulerInfoRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The detailed settings of the scheduler.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public List<GetSchedulerInfoRequestScheduler> Scheduler { get; set; }
        public class GetSchedulerInfoRequestScheduler : TeaModel {
            /// <summary>
            /// The scheduler name. Valid values:
            /// 
            /// *   pbs
            /// *   pbs19
            /// *   slurm
            /// *   slurm19
            /// *   slurm20
            /// 
            /// Valid values of N: 0 to 100.
            /// </summary>
            [NameInMap("SchedName")]
            [Validation(Required=false)]
            public string SchedName { get; set; }

        }

    }

}
