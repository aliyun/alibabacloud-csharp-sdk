// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesResponseBody : TeaModel {
        /// <summary>
        /// The list of details about cloud-native boxes.
        /// </summary>
        [NameInMap("edge_machines")]
        [Validation(Required=false)]
        public List<DescribeEdgeMachinesResponseBodyEdgeMachines> EdgeMachines { get; set; }
        public class DescribeEdgeMachinesResponseBodyEdgeMachines : TeaModel {
            /// <summary>
            /// The time when the cloud-native box was activated.
            /// </summary>
            [NameInMap("active_time")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            /// <summary>
            /// The time when the cloud-native box was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The ID of the cloud-native box.
            /// </summary>
            [NameInMap("edge_machine_id")]
            [Validation(Required=false)]
            public string EdgeMachineId { get; set; }

            /// <summary>
            /// The `hostname` of the cloud-native box.
            /// </summary>
            [NameInMap("hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// The lifecycle status of the cloud-native box.
            /// </summary>
            [NameInMap("life_state")]
            [Validation(Required=false)]
            public string LifeState { get; set; }

            /// <summary>
            /// The model of the cloud-native box.
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// The name of the cloud-native box.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The online status of the cloud-native box.
            /// </summary>
            [NameInMap("online_state")]
            [Validation(Required=false)]
            public string OnlineState { get; set; }

            /// <summary>
            /// The serial number of the cloud-native box.
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// The time when the cloud-native box was last updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

        /// <summary>
        /// The pagination details.
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeEdgeMachinesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeEdgeMachinesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
