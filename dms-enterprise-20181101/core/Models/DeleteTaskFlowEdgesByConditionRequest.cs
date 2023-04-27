// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DeleteTaskFlowEdgesByConditionRequest : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The ID of the end node of the edge to delete.
        /// </summary>
        [NameInMap("NodeEnd")]
        [Validation(Required=false)]
        public long? NodeEnd { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DeleteTaskFlowEdgesByCondition**.
        /// </summary>
        [NameInMap("NodeFrom")]
        [Validation(Required=false)]
        public long? NodeFrom { get; set; }

        /// <summary>
        /// The ID of the start node on the edge to delete.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
