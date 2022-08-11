// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeWorkflowsResponseBody : TeaModel {
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<DescribeWorkflowsResponseBodyJobs> Jobs { get; set; }
        public class DescribeWorkflowsResponseBodyJobs : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("create_time")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("job_name")]
            [Validation(Required=false)]
            public string JobName { get; set; }

        }

    }

}
