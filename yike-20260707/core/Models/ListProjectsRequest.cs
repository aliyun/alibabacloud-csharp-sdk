// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class ListProjectsRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from 1. Specify a valid positive integer for both this parameter and PageSize. Otherwise, the query defaults to page 1 with 10 entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Specify a valid positive integer for both this parameter and PageNo. Otherwise, the query defaults to page 1 with 10 entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters projects by workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws_zna577pdximv***</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
