// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListDeploymentsRequest : TeaModel {
        /// <summary>
        /// The ID of the user who creates the deployment.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The execution mode of the deployment.
        /// 
        /// Valid values:
        /// 
        /// *   BATCH
        /// *   STREAMING
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// The tag key.
        /// </summary>
        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// The tag value. Separate multiple values with semicolon (;).
        /// </summary>
        [NameInMap("labelValueArray")]
        [Validation(Required=false)]
        public string LabelValueArray { get; set; }

        /// <summary>
        /// The ID of the user who modifies the deployment.
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// The name of the deployment.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The page number. Minimum value: 1. Default value: 1.
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The latest status of the deployment.
        /// 
        /// Valid values:
        /// 
        /// *   CANCELLED
        /// *   FAILED
        /// *   RUNNING
        /// *   TRANSITIONING
        /// *   FINISHED
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
