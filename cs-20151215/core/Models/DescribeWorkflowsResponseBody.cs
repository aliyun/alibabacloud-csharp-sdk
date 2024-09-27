// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeWorkflowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs.</para>
        /// </summary>
        [NameInMap("jobs")]
        [Validation(Required=false)]
        public List<DescribeWorkflowsResponseBodyJobs> Jobs { get; set; }
        public class DescribeWorkflowsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb1a7214cfc0b41d9bb086affc2d8f51c</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The time when the workflow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-15T13:18:52Z</para>
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wgs-gpu-qb4dk</para>
            /// </summary>
            [NameInMap("job_name")]
            [Validation(Required=false)]
            public string JobName { get; set; }

        }

    }

}
