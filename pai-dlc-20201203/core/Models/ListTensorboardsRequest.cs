// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListTensorboardsRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Visible to all users in this workspace.</description></item>
        /// <item><description>PRIVATE: Visible only to you and administrators in this workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The display name of the Tensorboard instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTensorboard</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The end time of the query range. The creation time of the Tensorboard instance in UTC is used for filtering. If this parameter is left empty, the default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T14:45:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Filters Tensorboard instances by DLC job ID. See <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-xxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: Descending order.</description></item>
        /// <item><description>asc: Ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in a paged query. The value starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of Tensorboard instances to return per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing type of the Tensorboard instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Free: The Tensorboard instance uses free resources.</description></item>
        /// <item><description>Postpaid: The Tensorboard instance uses pay-as-you-go resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The resource quota ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Currently, only whitelisted users can use resource quota resources to create Tensorboard instances. To use this feature, contact us.</description></item>
        /// <item><description>This value is valid only when the Tensorboard instance uses resource quota resources.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>quota12***</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only Tensorboard instances created by the current user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <para>Sorts the results by the following fields. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DisplayName: The job name.</description></item>
        /// <item><description>GmtCreateTime: The job creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The data source ID. See <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-xxxxxx</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The data source type. Currently, only DLC training jobs are supported, which means the value is job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the query range. The creation time of the Tensorboard instance in UTC is used for filtering. If this parameter is left empty, the default value is 7 days before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The Tensorboard status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: Being created.</description></item>
        /// <item><description>Running: Running.</description></item>
        /// <item><description>Stopped: Stopped.</description></item>
        /// <item><description>Succeeded: Succeeded.</description></item>
        /// <item><description>Failed: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters the Tensorboard list by Tensorboard ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorboard-xxx</para>
        /// </summary>
        [NameInMap("TensorboardId")]
        [Validation(Required=false)]
        public string TensorboardId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>161****3000</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>she****mo</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>Specifies whether to show details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Show details.</description></item>
        /// <item><description>false: Do not show details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The workspace ID. The Tensorboard list is retrieved based on the workspace ID. &lt;props=&quot;china&quot;&gt;See <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>380</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
