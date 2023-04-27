// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowRelationsRequest : TeaModel {
        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to query the task flow ID.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The list of task flow edges to be updated.
        /// </summary>
        [NameInMap("Edges")]
        [Validation(Required=false)]
        public List<UpdateTaskFlowRelationsRequestEdges> Edges { get; set; }
        public class UpdateTaskFlowRelationsRequestEdges : TeaModel {
            /// <summary>
            /// The error code returned if the request failed.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
            /// </summary>
            [NameInMap("NodeEnd")]
            [Validation(Required=false)]
            public long? NodeEnd { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to **UpdateTaskFlowRelations**.
            /// </summary>
            [NameInMap("NodeFrom")]
            [Validation(Required=false)]
            public long? NodeFrom { get; set; }

        }

        /// <summary>
        /// The ID of the task flow edge.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
