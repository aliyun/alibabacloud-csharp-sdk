// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The label filter conditions. Separate multiple conditions with commas (,).
        /// The format of a single filter condition is <c>Key=Value</c>.</para>
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
        /// <para>The name of the experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The optional parameters.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ListExperimentRequestOptions Options { get; set; }
        public class ListExperimentRequestOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether the name is an exact match. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("match_name_exactly")]
            [Validation(Required=false)]
            public string MatchNameExactly { get; set; }

        }

        /// <summary>
        /// <para>The sort order of the specified field in a paged query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.
        /// Default value: DESC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The list of sort order strings. Supported fields for sorting include GmtCreateTime, Name, GmtModifiedTime, and ExperimentId. The sort order can be DESC or ASC. Default value: ASC.</para>
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
        /// <para>The pagination token. Pages start from 0. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageToken")]
        [Validation(Required=false)]
        public long? PageToken { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results of a paged query. Currently, only the GmtCreateTime field is supported for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the LatestRun information associated with the experiment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the experiment belongs. For more information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// <remarks>
        /// <para>If you do not specify the workspace ID, the system returns the list of experiments in the default workspace.</para>
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
