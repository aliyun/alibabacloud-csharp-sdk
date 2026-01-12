// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobReplicaStatus : TeaModel {
        [NameInMap("Active")]
        [Validation(Required=false)]
        public int? Active { get; set; }

        [NameInMap("Dequeued")]
        [Validation(Required=false)]
        public int? Dequeued { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EstimatedAutoScalingSpec")]
        [Validation(Required=false)]
        public AutoScalingSpec EstimatedAutoScalingSpec { get; set; }

        [NameInMap("EstimatedPodCount")]
        [Validation(Required=false)]
        public long? EstimatedPodCount { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("EstimatedResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig EstimatedResourceConfig { get; set; }

        [NameInMap("Queuing")]
        [Validation(Required=false)]
        public int? Queuing { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
