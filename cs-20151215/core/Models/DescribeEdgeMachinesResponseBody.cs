// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("edge_machines")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachinesResponseBodyEdgeMachines> EdgeMachines { get; set; }
        public class DescribeEdgeMachinesResponseBodyEdgeMachines : TeaModel {
            /// <summary>
            /// actvite time
            /// </summary>
            [NameInMap("active_time")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            /// <summary>
            /// created time
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// edge machine id
            /// </summary>
            [NameInMap("edge_machine_id")]
            [Validation(Required=false)]
            public string EdgeMachineId { get; set; }

            /// <summary>
            /// hostname
            /// </summary>
            [NameInMap("hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// life state
            /// </summary>
            [NameInMap("life_state")]
            [Validation(Required=false)]
            public string LifeState { get; set; }

            /// <summary>
            /// model
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// name of edgemachine
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// online state
            /// </summary>
            [NameInMap("online_state")]
            [Validation(Required=false)]
            public string OnlineState { get; set; }

            /// <summary>
            /// sn
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// update time
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// page info
        /// </summary>
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
        };

    }

}
