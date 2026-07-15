// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListTensorboardsRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the Tensorboard instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: visible only to you and administrators in the workspace.</description></item>
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
        /// <para>The end time of the query range. Tensorboard instances are filtered by their creation time in UTC. If this parameter is left empty, the default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T14:45:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The DLC job ID used to filter Tensorboard instances. Call <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
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
        /// <item><description>desc: descending order.</description></item>
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
        /// <para>The page number for paging. The value starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of Tensorboard instances to return on each page for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method of the Tensorboard instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Free: a Tensorboard instance that uses free resources.</description></item>
        /// <item><description>Postpaid: a Tensorboard instance that uses pay-as-you-go resources.</description></item>
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
        /// <item><description>This parameter takes effect only when the Tensorboard instance uses resource quota resources.</description></item>
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
        /// <para>The field by which the results are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DisplayName: the job name.</description></item>
        /// <item><description>GmtCreateTime: the job creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The data source ID. Call <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
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
        /// <para>The start time of the query range. Tensorboard instances are filtered by their creation time in UTC. If this parameter is left empty, the default value is 7 days before the current time.</para>
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
        /// <item><description>Creating: being created.</description></item>
        /// <item><description>Running: running.</description></item>
        /// <item><description>Stopped: stopped.</description></item>
        /// <item><description>Succeeded: succeeded.</description></item>
        /// <item><description>Failed: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The Tensorboard ID used to filter the Tensorboard list.</para>
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
        /// <para>Specifies whether to display details.</para>
        /// <list type="bullet">
        /// <item><description>true: Display details.</description></item>
        /// <item><description>false: Do not display details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The workspace ID. Tensorboard instances are filtered by workspace ID. &lt;props=&quot;china&quot;&gt;Call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID..</para>
        /// 
        /// <b>Example:</b>
        /// <para>380</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
