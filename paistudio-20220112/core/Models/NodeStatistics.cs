// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeStatistics : TeaModel {
        [NameInMap("ActualMinResources")]
        [Validation(Required=false)]
        public StatisticsResources ActualMinResources { get; set; }

        [NameInMap("GPUDetails")]
        [Validation(Required=false)]
        public List<NodeStatisticsGPUDetails> GPUDetails { get; set; }
        public class NodeStatisticsGPUDetails : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("IdleNum")]
            [Validation(Required=false)]
            public long? IdleNum { get; set; }

        }

        [NameInMap("HyperNodeDetails")]
        [Validation(Required=false)]
        public List<NodeStatisticsHyperNodeDetails> HyperNodeDetails { get; set; }
        public class NodeStatisticsHyperNodeDetails : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("IdleNum")]
            [Validation(Required=false)]
            public long? IdleNum { get; set; }

        }

        [NameInMap("IdleResources")]
        [Validation(Required=false)]
        public StatisticsResources IdleResources { get; set; }

        [NameInMap("SchedulableResources")]
        [Validation(Required=false)]
        public StatisticsResources SchedulableResources { get; set; }

        [NameInMap("SystemReservedResources")]
        [Validation(Required=false)]
        public StatisticsResources SystemReservedResources { get; set; }

    }

}
