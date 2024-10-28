// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerStagingDeployStatusResponseBody : TeaModel {
        [NameInMap("ContainersReady")]
        [Validation(Required=false)]
        public string ContainersReady { get; set; }

        [NameInMap("CreationTimestamp")]
        [Validation(Required=false)]
        public string CreationTimestamp { get; set; }

        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public string Initialized { get; set; }

        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("PodRestartState")]
        [Validation(Required=false)]
        public GetEdgeContainerStagingDeployStatusResponseBodyPodRestartState PodRestartState { get; set; }
        public class GetEdgeContainerStagingDeployStatusResponseBodyPodRestartState : TeaModel {
            [NameInMap("LastTerminatedReason")]
            [Validation(Required=false)]
            public string LastTerminatedReason { get; set; }

            [NameInMap("RestartCount")]
            [Validation(Required=false)]
            public int? RestartCount { get; set; }

        }

        [NameInMap("Ready")]
        [Validation(Required=false)]
        public string Ready { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scheduled")]
        [Validation(Required=false)]
        public string Scheduled { get; set; }

        [NameInMap("VIPs")]
        [Validation(Required=false)]
        public List<string> VIPs { get; set; }

    }

}
