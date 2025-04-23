// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class RerunJobsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use an asynchronous link to rerun the job.</para>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-sh-3VeFyR****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The list of jobs that you want to run. Maximum number of jobs: 100. Minimum number of jobs: 1.</para>
        /// <para>Format: <c>[{&quot;Id&quot;: &quot;0.sched****&quot;},{&quot;Id&quot;: &quot;1.sched****&quot;}]</c>. Separate multiple jobs with commas (,).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87251.html">ListJobs</a> operation to query the job ID.</para>
        /// <remarks>
        /// <para> You can rerun only jobs that are in the RUNNING or QUEUED state.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Id&quot;:&quot;1.scheduler&quot;}]</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public string Jobs { get; set; }

    }

}
