// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListClustersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster IDs. You can specify up to 20 IDs.</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIdsShrink { get; set; }

        /// <summary>
        /// <para>The cluster names. You can specify up to 20 names.</para>
        /// </summary>
        [NameInMap("ClusterNames")]
        [Validation(Required=false)]
        public string ClusterNamesShrink { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 10 to 100. Default value: 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
