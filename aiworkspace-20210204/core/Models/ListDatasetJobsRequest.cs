// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListDatasetJobsRequest : TeaModel {
        /// <summary>
        /// <para>The dataset version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The task action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SemanticIndex</para>
        /// </summary>
        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        /// <summary>
        /// <para>The sorting order for the specified sorting field in a paged query. Used together with SortBy. Default value: DESC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort field. By default, results are sorted by creation time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Specifies whether to return task logs.</para>
        /// </summary>
        [NameInMap("WithLogs")]
        [Validation(Required=false)]
        public bool? WithLogs { get; set; }

        /// <summary>
        /// <para>The workspace ID. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
