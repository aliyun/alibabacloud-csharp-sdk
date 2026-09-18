// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateTensorboardRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: Visible only to you and administrators in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The dataset ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the dataset ID, see <a href="https://help.aliyun.com/document_detail/457222.html">ListDatasets</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The dataset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS</description></item>
        /// <item><description>NAS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The datasource configurations.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<DataSourceItem> DataSources { get; set; }

        /// <summary>
        /// <para>The TensorBoard name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tensorboard</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The job ID. For information about how to obtain the job ID, see <a href="https://help.aliyun.com/document_detail/459676.html">ListJobs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The maximum running duration. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>240</para>
        /// </summary>
        [NameInMap("MaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? MaxRunningTimeMinutes { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <para>The extended field of custom dataset in JSON format. Currently, MountPath is supported, which specifies the custom mount path of custom dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mountpath&quot;:&quot;/root/data/&quot;}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>The priority of the job. This is an optional parameter. Default value: 1. Valid values: 1 to 9.</para>
        /// <list type="bullet">
        /// <item><description>1: the lowest priority.</description></item>
        /// <item><description>9: the highest priority.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The resource quota ID. This parameter is required when you create a TensorBoard job by using resources from a resource quota. &lt;props=&quot;china&quot;&gt;For information about how to obtain the resource quota ID, see <a href="https://help.aliyun.com/document_detail/2628071.html">ListQuotas</a>.
        /// &lt;props=&quot;china&quot;&gt;Published only on China site.
        /// Currently, only whitelisted users can create TensorBoard jobs by using resource quota resources. To use this feature, contact us.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota12345</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-xxxxxx</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The summary directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/data/</para>
        /// </summary>
        [NameInMap("SummaryPath")]
        [Validation(Required=false)]
        public string SummaryPath { get; set; }

        /// <summary>
        /// <para>The summary relative directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/summary/</para>
        /// </summary>
        [NameInMap("SummaryRelativePath")]
        [Validation(Required=false)]
        public string SummaryRelativePath { get; set; }

        /// <summary>
        /// <para>The list of dataset configurations mounted to the TensorBoard job.</para>
        /// </summary>
        [NameInMap("TensorboardDataSources")]
        [Validation(Required=false)]
        public List<TensorboardDataSourceSpec> TensorboardDataSources { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go configuration for TensorBoard, which is used to create a TensorBoard job that uses pay-as-you-go resources.</para>
        /// </summary>
        [NameInMap("TensorboardSpec")]
        [Validation(Required=false)]
        public TensorboardSpec TensorboardSpec { get; set; }

        /// <summary>
        /// <para>The URI of the dataset:</para>
        /// <list type="bullet">
        /// <item><description>If DataSourceType is set to OSS, the format is <c>oss://[oss-bucket].[endpoint]/[path]</c>.</description></item>
        /// <item><description>If DataSourceType is set to NAS, the format is <c>nas://[nas-filesystem-id].[region]/[path]</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss://.oss-cn-shanghai-finance-1.aliyuncs.com/</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The workspace ID. &lt;props=&quot;china&quot;&gt;For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
