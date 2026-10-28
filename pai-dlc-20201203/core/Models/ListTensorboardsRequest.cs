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
        /// <item><description>PUBLIC: The job is visible to all users in the workspace.</description></item>
        /// <item><description>PRIVATE: The job is visible only to you and administrators in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The display name of the TensorBoard instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTensorboard</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The end time of the query interval. Filters instances by the UTC creation time of the TensorBoard instance. If this parameter is left empty, the default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T14:45:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Filters TensorBoard instances by the DLC job ID. Refer to <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
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
        /// <para>The page number of the current page in the paged query. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of TensorBoard instances to return on each page in the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method of the TensorBoard instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Free: The instance uses free resources.</description></item>
        /// <item><description>Postpaid: The instance uses pay-as-you-go resources.</description></item>
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
        /// <item><description>Currently, only whitelisted users can use resource quotas to create TensorBoard instances. To use this feature, contact us.</description></item>
        /// <item><description>This parameter is valid only when the TensorBoard instance uses resources from a resource quota.</description></item>
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
        /// <para>Specifies whether to return only the TensorBoard instances created by the current logged-on user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowOwn")]
        [Validation(Required=false)]
        public bool? ShowOwn { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DisplayName: The name of the job.</description></item>
        /// <item><description>GmtCreateTime: The creation time of the job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The data source ID. Refer to <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a> to obtain the job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-xxxxxx</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The data source. Currently, only DLC training jobs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the query interval. Filters instances by the UTC creation time of the TensorBoard instance. If this parameter is left empty, the default value is 7 days before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the TensorBoard instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The instance is being created.</description></item>
        /// <item><description>Running: The instance is running.</description></item>
        /// <item><description>Stopped: The instance is stopped.</description></item>
        /// <item><description>Succeeded: The instance succeeded.</description></item>
        /// <item><description>Failed: The instance failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters TensorBoard instances by the TensorBoard ID.</para>
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
        /// <para>Specifies whether to display details. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Displays details.</description></item>
        /// <item><description>false: Does not display details.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The workspace ID. Retrieves the list of TensorBoard instances based on the workspace ID. &lt;props=&quot;china&quot;&gt;Refer to <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>380</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
