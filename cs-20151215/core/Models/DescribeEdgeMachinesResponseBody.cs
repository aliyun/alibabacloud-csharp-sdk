// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesResponseBody : TeaModel {
        [NameInMap("edge_machines")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachinesResponseBodyEdgeMachines> EdgeMachines { get; set; }
        public class DescribeEdgeMachinesResponseBodyEdgeMachines : TeaModel {
            [NameInMap("active_time")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("edge_machine_id")]
            [Validation(Required=false)]
            public string EdgeMachineId { get; set; }

            [NameInMap("hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("life_state")]
            [Validation(Required=false)]
            public string LifeState { get; set; }

            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("online_state")]
            [Validation(Required=false)]
            public string OnlineState { get; set; }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEdgeMachinesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEdgeMachinesResponseBodyPageInfo : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
