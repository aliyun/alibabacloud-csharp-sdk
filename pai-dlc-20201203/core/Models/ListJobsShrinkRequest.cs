// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListJobsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: visible to all users in the workspace.</description></item>
        /// <item><description>PRIVATE: visible only to you and administrators in the workspace. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The ID of the user associated with the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16****</para>
        /// </summary>
        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        /// <summary>
        /// <para>The caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>The keyword used for full text search in the node description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a training job</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The job name. Fuzzy match is supported. The match is case-insensitive and does not support wildcards. For example, if you enter test, it can match test-job1, job-test, job-test2, or job-Test, but cannot match job-t1. Default value: empty, which indicates any job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf-mnist-test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The search mode for DisplayName. Default value: wildcard match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wildcard</para>
        /// </summary>
        [NameInMap("DisplayNameSearchMode")]
        [Validation(Required=false)]
        public string DisplayNameSearchMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter jobs that run on specified nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAssignNode")]
        [Validation(Required=false)]
        public string EnableAssignNode { get; set; }

        /// <summary>
        /// <para>The end time of the query interval. The creation time of the job is used for filtering. Default value: the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-16T07:26:41Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve jobs across workspaces. This parameter must be used together with ShowOwn=true to query the jobs recently submitted by the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromAllWorkspaces")]
        [Validation(Required=false)]
        public bool? FromAllWorkspaces { get; set; }

        /// <summary>
        /// <para>Uses the full-text index to retrieve data in the images field. Chinese and English tokenization are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pytorch</para>
        /// </summary>
        [NameInMap("ImageSearch")]
        [Validation(Required=false)]
        public string ImageSearch { get; set; }

        /// <summary>
        /// <para>The job ID. Fuzzy match is not supported. The match is case-insensitive and does not support wildcards. Default value: empty, which indicates any job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc********</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The list of job IDs. Separate multiple IDs with commas (,). If both JobIds and JobId are specified, JobId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc123abc</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The job type. Default value: empty, which indicates all types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TFJob</description></item>
        /// <item><description>PyTorchJob</description></item>
        /// <item><description>XGBoostJob</description></item>
        /// <item><description>OneFlowJob</description></item>
        /// <item><description>ElasticBatchJob</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The field name for numeric range filtering. This parameter must be used together with NumericRangeMin and NumericRangeMax.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RequestGPU</para>
        /// </summary>
        [NameInMap("NumericRangeField")]
        [Validation(Required=false)]
        public string NumericRangeField { get; set; }

        /// <summary>
        /// <para>The maximum value for numeric range filtering, inclusive. This parameter must be used together with NumericRangeField.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("NumericRangeMax")]
        [Validation(Required=false)]
        public long? NumericRangeMax { get; set; }

        /// <summary>
        /// <para>The minimum value for numeric range filtering, inclusive. This parameter must be used together with NumericRangeField.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NumericRangeMin")]
        [Validation(Required=false)]
        public long? NumericRangeMin { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order. This is the default value.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The idle resource information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ForbiddenQuotaOverSold</description></item>
        /// <item><description>ForceQuotaOverSold</description></item>
        /// <item><description>AcceptQuotaOverSold-true: true indicates that the job actually used idle resources.</description></item>
        /// <item><description>AcceptQuotaOverSold-false: false indicates that the job actually used guaranteed resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ForbiddenQuotaOverSold</para>
        /// </summary>
        [NameInMap("OversoldInfo")]
        [Validation(Required=false)]
        public string OversoldInfo { get; set; }

        /// <summary>
        /// <para>The page number for paging in a paged query. The start value is 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of jobs to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: resource quota</description></item>
        /// <item><description>Spot: preemptible resources</description></item>
        /// <item><description>PostPaid: public resources</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The pipeline ID used to filter jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-*******</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>Uses the full-text index to retrieve data in the reason field of the failed node. Chinese and English tokenization are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OOM</para>
        /// </summary>
        [NameInMap("ReasonSearch")]
        [Validation(Required=false)]
        public string ReasonSearch { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about how to query the ID of a dedicated resource group, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quotas</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r*****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The list of resource IDs used to filter jobs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The name of the resource quota used to filter the job list. Fuzzy match is supported, but wildcards are not supported. Default value: empty, which indicates no filtering by resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota***</para>
        /// </summary>
        [NameInMap("ResourceQuotaName")]
        [Validation(Required=false)]
        public string ResourceQuotaName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only the jobs submitted by the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <para>The field by which to sort. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DisplayName</description></item>
        /// <item><description>JobType</description></item>
        /// <item><description>Status</description></item>
        /// <item><description>GmtCreateTime</description></item>
        /// <item><description>GmtFinishTime</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start time of the query interval. The creation time of the job is used for filtering. Default value: the current time minus 7 days. If neither StartTime nor EndTime is configured, the jobs created in the last 7 days are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-16T07:25:34Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The running status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Queuing</description></item>
        /// <item><description>Bidding (currently limited to Lingjun spot jobs)</description></item>
        /// <item><description>EnvPreparing</description></item>
        /// <item><description>SanityChecking</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Restarting</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>SucceededReserving</description></item>
        /// <item><description>FailedReserving</description></item>
        /// <item><description>Succeeded</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Stopped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags used for filtering.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The template ID used to filter jobs created by the specified template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tmlabc123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The time field used for StartTime and EndTime filtering. Default value: creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtFinishTime</para>
        /// </summary>
        [NameInMap("TimeRangeField")]
        [Validation(Required=false)]
        public string TimeRangeField { get; set; }

        /// <summary>
        /// <para>Uses the full-text index to retrieve data in the user_command field. Chinese and English tokenization are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python train.py</para>
        /// </summary>
        [NameInMap("UserCommandSearch")]
        [Validation(Required=false)]
        public string UserCommandSearch { get; set; }

        /// <summary>
        /// <para>The user ID of the job submitter used to filter the job list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20**************</para>
        /// </summary>
        [NameInMap("UserIdForFilter")]
        [Validation(Required=false)]
        public string UserIdForFilter { get; set; }

        /// <summary>
        /// <para>The username of the job submitter used to filter the job list. Fuzzy match is supported, but wildcards are not supported. Default value: empty, which indicates no filtering by username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
