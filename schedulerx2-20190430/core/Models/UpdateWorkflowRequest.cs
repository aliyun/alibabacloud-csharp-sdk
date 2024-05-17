// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class UpdateWorkflowRequest : TeaModel {
        /// <summary>
        /// The description of the workflow.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The application group ID. You can obtain the application group ID on the Application Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// The time expression. You can set the time expression based on the selected method that is used to specify time.
        /// 
        /// *   If you set TimeType to cron, you need to enter a standard cron expression. Online verification is supported.
        /// *   If you set TimeType to api, no time expression is required.
        /// </summary>
        [NameInMap("TimeExpression")]
        [Validation(Required=false)]
        public string TimeExpression { get; set; }

        /// <summary>
        /// The method that is used to specify the time. Valid values:
        /// 
        /// *   1: cron
        /// *   100: api
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public int? TimeType { get; set; }

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
