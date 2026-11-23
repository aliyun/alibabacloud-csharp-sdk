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
        /// <para>The time when the instance was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ss.sssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-30T12:51:33.028Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The labels of the task for exact matching. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>Single-label query: &quot;is_evaluation:true&quot;</description></item>
        /// <item><description>Multi-label query (not recommended unless necessary due to potential performance issues): &quot;is_evaluation:true,LLM_evaluation:true&quot;. Separate multiple label key-value pairs with commas (,). All specified label key-value pairs must be matched at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>is_evaluation:true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for the request. Default value: 10.</para>
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
        /// <para>The sorting order of the specified field for a paging query. This parameter is used together with SortBy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC (default): descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The list of strings that specify the sorting methods. Supported fields for sorting include GmtCreateTime and Name. Valid sorting methods are DESC and ASC. Default value: ASC. You can specify multiple fields and separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime DESC,Name ASC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The current page number. Valid values: integers greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination token. The token starts from 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public long? PageToken { get; set; }

        /// <summary>
        /// <para>The name of the field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Name: the name of the run.</description></item>
        /// <item><description>GmtCreateTime (default): the time when the run was created.</description></item>
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
        /// <item><description>true: displays detailed information.</description></item>
        /// <item><description>false (default): does not display detailed information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the experiment belongs. For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <remarks>
        /// <para>If you do not specify the workspace ID, the system returns the list of runs in the default workspace.</para>
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
