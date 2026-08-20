// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Ray Jobs.</para>
        /// </summary>
        [NameInMap("rayJobs")]
        [Validation(Required=false)]
        public List<ListRayJobResponseBodyRayJobs> RayJobs { get; set; }
        public class ListRayJobResponseBodyRayJobs : TeaModel {
            /// <summary>
            /// <para>The status of the corresponding Ray cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Deleted: deleted.</description></item>
            /// <item><description>Submitted: submitted but not yet being created.</description></item>
            /// <item><description>Pending: being created.</description></item>
            /// <item><description>Running: running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("clusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            /// <summary>
            /// <para>The nickname of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The number of compute units (CUs) consumed during the job execution cycle. This value is an estimate. The actual value is subject to the bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public double? CuHours { get; set; }

            /// <summary>
            /// <para>The URL of the Ray cluster dashboard. When the Ray cluster is in the Running state, the URL points to the Runtime UI. After the cluster is in the Deleted state, the URL points to the History UI. The History UI is supported only in err-1.2.0 and later versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://emr-ray-gateway.aliyuncs.com?token=xxxxxxxxx">https://emr-ray-gateway.aliyuncs.com?token=xxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("dashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            /// <summary>
            /// <para>The execution duration of the job. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3564</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The time when the job ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776945509000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The name of the Ray Job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testRayJob</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Ray DPI engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>err-1.2.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("resourceQueue")]
            [Validation(Required=false)]
            public string ResourceQueue { get; set; }

            /// <summary>
            /// <para>The time when the job was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776945499000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Submitted: submitted.</description></item>
            /// <item><description>Pending: the cluster is being created.</description></item>
            /// <item><description>Running: the job is running.</description></item>
            /// <item><description>Succeeded: the job succeeded.</description></item>
            /// <item><description>Failed: the job failed.</description></item>
            /// <item><description>Cancelling: the job is being canceled.</description></item>
            /// <item><description>Cancelled: the job is canceled.</description></item>
            /// <item><description>Timeout: the job timed out and was canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the Ray Job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rj-uiulpgow9xljimm1</para>
            /// </summary>
            [NameInMap("submissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776945399000</para>
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
