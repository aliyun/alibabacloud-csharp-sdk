// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListClustersRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the clusters to query. Valid values of N: 0 to 20.</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// <para>The names of the clusters to query. Valid values of N: 0 to 20.</para>
        /// </summary>
        [NameInMap("ClusterNames")]
        [Validation(Required=false)]
        public List<string> ClusterNames { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Settings the number of rows per page for paging. Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
