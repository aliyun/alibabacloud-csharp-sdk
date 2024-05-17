// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class UpdateWorkflowDagRequest : TeaModel {
        /// <summary>
        /// The directed acyclic graph (DAG) of the workflow, including the information about the nodes and the edges. Specify the value of this parameter in the JSON format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DagJson")]
        [Validation(Required=false)]
        public string DagJson { get; set; }

        /// <summary>
        /// The application group ID. You can obtain the application group ID on the Application Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the namespace. This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The workflow ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
