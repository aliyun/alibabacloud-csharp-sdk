// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeWorkflowsResponseBody : TeaModel {
        /// <summary>
        /// The list of the jobs.
        /// </summary>
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<DescribeWorkflowsResponseBodyJobs> Jobs { get; set; }
        public class DescribeWorkflowsResponseBodyJobs : TeaModel {
            /// <summary>
            /// The ID of the ACK cluster.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The time when the workflow was created.
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The name of the workflow.
            /// </summary>
            [NameInMap("job_name")]
            [Validation(Required=false)]
            public string JobName { get; set; }

        }

    }

}
