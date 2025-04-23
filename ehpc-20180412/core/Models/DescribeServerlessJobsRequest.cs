// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeServerlessJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the E-HPC cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The list of serverless job IDs or the subtask IDs (array jobs).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the serverless job is an array job, you can specify only the subtask ID. Specify the subtask ID in the format of \<array job ID>_&lt; subtask index&gt;. For example, 10_3 indicates the subtask whose index is 3 in the array job whose ID is 10.</para>
        /// </description></item>
        /// <item><description><para>You can specify only a single ID in one request.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

    }

}
