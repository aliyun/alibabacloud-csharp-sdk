// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListJobsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The job visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The job is visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: The job is visible only to you and the administrator of the workspace.</description></item>
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
        /// <para>The job name. Fuzzy query is supported. The name is case-insensitive. Wildcards are not supported. For example, if you enter test, test-job1, job-test, job-test2, or job-test can be matched, and job-t1 cannot be matched. The default value null indicates any job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf-mnist-test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("DisplayNameSearchMode")]
        [Validation(Required=false)]
        public string DisplayNameSearchMode { get; set; }

        [NameInMap("EnableAssignNode")]
        [Validation(Required=false)]
        public string EnableAssignNode { get; set; }

        /// <summary>
        /// <para>The end time of the query. Use the job creation time to filter data. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T14:45:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to query a list of jobs across workspaces. This parameter must be used together with <c>ShowOwn=true</c>. You can use this parameter to query a list of jobs recently submitted by the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromAllWorkspaces")]
        [Validation(Required=false)]
        public bool? FromAllWorkspaces { get; set; }

        [NameInMap("ImageSearch")]
        [Validation(Required=false)]
        public string ImageSearch { get; set; }

        /// <summary>
        /// <para>The job ID. Fuzzy query is supported. The name is case-insensitive. Wildcards are not supported. The default value null indicates any job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc********</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The job type. The default value null indicates any type. Valid values:</para>
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

        [NameInMap("NumericRangeField")]
        [Validation(Required=false)]
        public string NumericRangeField { get; set; }

        [NameInMap("NumericRangeMax")]
        [Validation(Required=false)]
        public long? NumericRangeMax { get; set; }

        [NameInMap("NumericRangeMin")]
        [Validation(Required=false)]
        public long? NumericRangeMin { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc (default)</description></item>
        /// <item><description>asc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The Idle resource information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ForbiddenQuotaOverSold</description></item>
        /// <item><description>ForceQuotaOverSold</description></item>
        /// <item><description>AcceptQuotaOverSold-true (true indicates that the job uses idle resources.)</description></item>
        /// <item><description>AcceptQuotaOverSold-false (false indicates that the job uses guaranteed resources.)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ForbiddenQuotaOverSold</para>
        /// </summary>
        [NameInMap("OversoldInfo")]
        [Validation(Required=false)]
        public string OversoldInfo { get; set; }

        /// <summary>
        /// <para>The number of the page to return for the current query. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of jobs per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: Resource quota</description></item>
        /// <item><description>Spot: Preemptible resources</description></item>
        /// <item><description>PostPaid: Public resources</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The specific pipeline ID used to filter jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-*******</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ReasonSearch")]
        [Validation(Required=false)]
        public string ReasonSearch { get; set; }

        /// <summary>
        /// <para>The resource group ID. For information about how to obtain the ID of a dedicated resource group, see <a href="https://help.aliyun.com/document_detail/2651299.html">Manage resource quota</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r*****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource quota name used to filter jobs. Fuzzy search is supported. Wildcards are not supported. The default value null indicates that jobs are not filtered by resource quota name.</para>
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
        /// <para>The sorting field. Valid values:</para>
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
        /// <para>The start time of the query. Use the job creation time to filter data. The default value is the current time minus seven days. In other words, if you do not configure the StartTime and EndTime parameters, the system queries the job list in the last seven days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Queuing</description></item>
        /// <item><description>Bidding (only available for spot jobs that use Lingjun resources)</description></item>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        [NameInMap("TimeRangeField")]
        [Validation(Required=false)]
        public string TimeRangeField { get; set; }

        [NameInMap("UserCommandSearch")]
        [Validation(Required=false)]
        public string UserCommandSearch { get; set; }

        /// <summary>
        /// <para>The user ID used to filter jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20**************</para>
        /// </summary>
        [NameInMap("UserIdForFilter")]
        [Validation(Required=false)]
        public string UserIdForFilter { get; set; }

        /// <summary>
        /// <para>The username used to filter jobs. Fuzzy search is supported. Wildcards are not supported. The default value null indicates that jobs are not filtered by username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
