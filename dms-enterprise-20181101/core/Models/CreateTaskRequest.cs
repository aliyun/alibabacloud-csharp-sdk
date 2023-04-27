// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the task flow. You can call the [ListTaskFlow](~~424565~~) or [ListLhTaskFlowAndScenario](~~426672~~) operation to query the task flow ID.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The position of the node on the Directed Acyclic Graph (DAG).
        /// </summary>
        [NameInMap("GraphParam")]
        [Validation(Required=false)]
        public string GraphParam { get; set; }

        /// <summary>
        /// The configuration of the node.
        /// </summary>
        [NameInMap("NodeContent")]
        [Validation(Required=false)]
        public string NodeContent { get; set; }

        /// <summary>
        /// The name of the node that you want to create.
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// The output variables configured for the task.
        /// </summary>
        [NameInMap("NodeOutput")]
        [Validation(Required=false)]
        public string NodeOutput { get; set; }

        /// <summary>
        /// The type of the node that you want to create. For more information about the valid values for this parameter, see [NodeType parameter](~~424705~~).
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// The tenant ID.
        /// 
        /// >  To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The time variables configured for the node.
        /// </summary>
        [NameInMap("TimeVariables")]
        [Validation(Required=false)]
        public string TimeVariables { get; set; }

    }

}
