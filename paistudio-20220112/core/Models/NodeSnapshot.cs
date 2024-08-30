// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeSnapshot : TeaModel {
        [NameInMap("AncestorQuotaWorkloadNum")]
        [Validation(Required=false)]
        public int? AncestorQuotaWorkloadNum { get; set; }

        [NameInMap("DescendantQuotaWorkloadNum")]
        [Validation(Required=false)]
        public int? DescendantQuotaWorkloadNum { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public string RequestGPU { get; set; }

        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        [NameInMap("SelfQuotaWorkloadNum")]
        [Validation(Required=false)]
        public int? SelfQuotaWorkloadNum { get; set; }

        [NameInMap("WorkloadNum")]
        [Validation(Required=false)]
        public int? WorkloadNum { get; set; }

        [NameInMap("Workloads")]
        [Validation(Required=false)]
        public List<NodeSnapshotWorkloads> Workloads { get; set; }
        public class NodeSnapshotWorkloads : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("WorkloadId")]
            [Validation(Required=false)]
            public string WorkloadId { get; set; }

            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

        }

    }

}
