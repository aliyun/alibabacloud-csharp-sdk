// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListRunsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the experiment to which the run belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-1zpfthdx******</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The labels of the run for an exact match. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>Single-label query: &quot;is_evaluation:true&quot;</para>
        /// </description></item>
        /// <item><description><para>Multi-label query: &quot;is_evaluation:true,LLM_evaluation:true&quot;. This method is not recommended for common scenarios because it may degrade performance. Use commas (,) to separate multiple labels. The system matches all specified key-value pairs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>is_evaluation:true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order for the paged query. Use this parameter with SortBy.</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: ascending order.</para>
        /// </description></item>
        /// <item><description><para>DESC (default): descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The fields to sort by and the sort order. You can sort by GmtCreateTime and Name. Valid sort orders are DESC and ASC. The default is ASC. To sort by multiple fields, separate them with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime DESC,Name ASC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to display on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The paging token. The value starts from 0. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public long? PageToken { get; set; }

        /// <summary>
        /// <para>The field to use for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Name: the name of the run.</para>
        /// </description></item>
        /// <item><description><para>GmtCreateTime (default): the time when the run was created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the PAI workload associated with the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-rbvg5wzlj****</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the PAI workload associated with the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TrainingService</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to display details, including Metrics, Params, and Labels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: displays details.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not display details.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the experiment resides. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a workspace ID, the system returns the list of runs in the default workspace.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>228**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
