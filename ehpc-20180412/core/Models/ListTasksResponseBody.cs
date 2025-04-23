// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89A1AC0F-4A6C-4F3D-98F9-BEF9A823****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListTasksResponseBodyTasks> Tasks { get; set; }
        public class ListTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ehpc-hz-FYUr32****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The current step of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("CurrentStep")]
            [Validation(Required=false)]
            public int? CurrentStep { get; set; }

            /// <summary>
            /// <para>The error messages returned for the task.</para>
            /// <para>You can view the error messages and the corresponding solutions in the <a href="https://error-center.alibabacloud.com/status/product/EHPC">Error Center</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Errors")]
            [Validation(Required=false)]
            public string Errors { get; set; }

            /// <summary>
            /// <para>The request parameters of the task. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;requestId\&quot;:\&quot;0A6CA33E-BFBF-4F92-BDAE-4E8860DA****\&quot;,\&quot;uid\&quot;:\&quot;160998252992****\&quot;,\&quot;bid\&quot;:\&quot;268**\&quot;,\&quot;clusterId\&quot;:\&quot;ehpc-hz-ysQtcZ****\&quot;}</para>
            /// </summary>
            [NameInMap("Request")]
            [Validation(Required=false)]
            public string Request { get; set; }

            /// <summary>
            /// <para>The result of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set TaskType to CreateCluster or AddComputes, the value of this parameter is in the <c>{\\&quot;Instances\\&quot;:[]}</c> format. The value indicates the information about the nodes that are added to the cluster.</description></item>
            /// <item><description>If you set TaskType to a value other than CreateCluster and AddComputes, the value of this parameter is in the <c>{}</c> format.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Instances\&quot;:[{\&quot;InstanceId\&quot;:\&quot;i-bp1inb1j2xz8pnoi****\&quot;,\&quot;Ip\&quot;:\&quot;192.168.<em>.</em>\&quot;,\&quot;Hostname\&quot;:\&quot;login0\&quot;,\&quot;role\&quot;:\&quot;login\&quot;}]}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Processing: The task is running.</description></item>
            /// <item><description>Success: The task succeeded.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// <item><description>PartialFail: The task partially failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Processing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateCluster: creates a cluster by calling the <a href="https://help.aliyun.com/document_detail/87100.html">CreateCluster</a> operation.</description></item>
            /// <item><description>StartCluster: starts a cluster by calling the <a href="https://help.aliyun.com/document_detail/200345.html">StartCluster</a> operation.</description></item>
            /// <item><description>StopCluster: stops a cluster by calling the <a href="https://help.aliyun.com/document_detail/200346.html">StopCluster</a> operation.</description></item>
            /// <item><description>DeleteCluster: releases a cluster by calling the <a href="https://help.aliyun.com/document_detail/87110.html">DeleteCluster</a> operation.</description></item>
            /// <item><description>AddComputes: adds nodes to a cluster by calling the <a href="https://help.aliyun.com/document_detail/87147.html">AddNodes</a> operation.</description></item>
            /// <item><description>StartComputes: starts nodes by calling the <a href="https://help.aliyun.com/document_detail/87159.html">StartNodes</a> operation.</description></item>
            /// <item><description>ResetCompute: resets nodes by calling the <a href="https://help.aliyun.com/document_detail/87158.html">ResetNodes</a> operation.</description></item>
            /// <item><description>StopComputes: stops nodes by calling the <a href="https://help.aliyun.com/document_detail/87160.html">StopNodes</a> operation.</description></item>
            /// <item><description>DeleteComputes: deletes nodes by calling the <a href="https://help.aliyun.com/document_detail/87155.html">DeleteNodes</a> operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StopCluster</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The total number of steps of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35</para>
            /// </summary>
            [NameInMap("TotalSteps")]
            [Validation(Required=false)]
            public int? TotalSteps { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
