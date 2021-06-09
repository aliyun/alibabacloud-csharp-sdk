// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeWorkflowsResponseBody : TeaModel {
        /// <summary>
        /// job信息
        /// </summary>
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<DescribeWorkflowsResponseBodyJobs> Jobs { get; set; }
        public class DescribeWorkflowsResponseBodyJobs : TeaModel {
            /// <summary>
            /// 集群ID。
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 工作流名称。
            /// </summary>
            [NameInMap("job_name")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// 工作流创建时间。
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

    }

}
