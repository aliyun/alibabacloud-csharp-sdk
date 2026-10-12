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
        /// <para>The time when the instance was created. The time follows the ISO 8601 standard in UTC. Format: YYYY-MM-DDTHH:mm:ss.sssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The labels of the task for exact match. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>Single-label query: &quot;is_evaluation:true&quot;</description></item>
        /// <item><description>Multi-label scenario (not recommended except in special cases due to potential performance issues): &quot;is_evaluation:true,LLM_evaluation:true&quot; separated by commas (,), indicating that multiple label key-value pairs must all match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>is_evaluation:true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The run name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sorting order for the specified field in a paging query. Used together with SortBy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: Ascending order.</description></item>
        /// <item><description>DESC (default): Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>A comma-separated list of sorting strings. Supported fields: GmtCreateTime and Name. Supported sorting orders: DESC and ASC. Default: ASC. Separate multiple fields with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime DESC,Name ASC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination token. Starts from 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public long? PageToken { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Name: The run name.</description></item>
        /// <item><description>GmtCreateTime (default): The run creation time.</description></item>
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
        /// <para>Specifies whether to display detailed information, including Metrics, Params, and Labels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Detailed information is displayed.</description></item>
        /// <item><description>false (default): Detailed information is not displayed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the experiment resides. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a workspace ID, the system returns the run list of the default workspace.</para>
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
