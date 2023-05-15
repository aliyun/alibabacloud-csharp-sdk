// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowEdgesRequest : TeaModel {
        /// <summary>
        /// The task flow ID. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to query the task flow ID.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The list of updated task flow edges.
        /// </summary>
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public List<UpdateTaskFlowEdgesRequestEdges> Edges { get; set; }
        public class UpdateTaskFlowEdgesRequestEdges : TeaModel {
            /// <summary>
            /// The ID of the task flow edge.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The ID of the end node of the edge.
            /// </summary>
            [NameInMap("NodeEnd")]
            [Validation(Required=false)]
            public long? NodeEnd { get; set; }

            /// <summary>
            /// The ID of the start node of the edge.
            /// </summary>
            [NameInMap("NodeFrom")]
            [Validation(Required=false)]
            public long? NodeFrom { get; set; }

        }

        /// <summary>
        /// The tenant ID.
        /// 
        /// > To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see [Manage DMS tenants](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
