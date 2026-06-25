// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for labels. Separate multiple conditions with commas (,). A single filter condition must be in the <c>Key=Value</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>is_evaluation:true</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. The default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The name of the experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Optional parameters.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ListExperimentRequestOptions Options { get; set; }
        public class ListExperimentRequestOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to perform an exact match for the name. Valid values are &quot;true&quot; and &quot;false&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("match_name_exactly")]
            [Validation(Required=false)]
            public string MatchNameExactly { get; set; }

        }

        /// <summary>
        /// <para>The order in which to sort the results of a paged query. Valid values:</para>
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
        /// <para>A list of sorting methods as strings. You can sort by the following fields: GmtCreateTime, Name, GmtModifiedTime, or ExperimentId. The sorting methods are DESC and ASC. The default is ASC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime DESC,Name ASC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The paging token. It starts from 0. The default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public long? PageToken { get; set; }

        /// <summary>
        /// <para>The field to use for sorting in a paged query. Currently, only the GmtCreateTime field is supported for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the LatestRun information related to the experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The ID of the workspace where the experiment resides. For more information about how to obtain a workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a workspace ID, the system returns the list of experiments in the default workspace.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1517**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
