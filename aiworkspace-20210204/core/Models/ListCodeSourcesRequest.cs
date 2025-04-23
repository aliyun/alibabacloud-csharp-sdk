// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListCodeSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the code source. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDataSource</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The order in which the entries are sorted by the specific field on the returned page.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order. This is the default value.</description></item>
        /// <item><description>desc: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModifyTime: the time when the source code is modified.</description></item>
        /// <item><description>DisplayName: the display name.</description></item>
        /// <item><description>CodeSourceId: the ID of the code source.</description></item>
        /// <item><description>GmtCreateTime: the time when the code source is created. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModifyTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
