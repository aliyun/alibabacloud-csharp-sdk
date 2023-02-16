// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteWorkflowRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can obtain the application ID on the Application Management page in Distributed Task Scheduling Platform.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The dynamic parameter of the workflow instance. The parameter must be 1 to 1,000 bytes in length.
        /// </summary>
        [NameInMap("InstanceParameters")]
        [Validation(Required=false)]
        public string InstanceParameters { get; set; }

        /// <summary>
        /// The ID of the namespace. You can obtain the ID of the namespace on the Namespace page in Distributed Task Scheduling Platform.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the workflow.
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

    }

}
