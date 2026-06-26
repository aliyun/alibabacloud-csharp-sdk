// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListShareResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clg-paimon-xxxx</para>
        /// </summary>
        [NameInMap("catalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        /// <summary>
        /// <para>The token used to page through results. A null value indicates that this is the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The shared resources.</para>
        /// </summary>
        [NameInMap("shareResources")]
        [Validation(Required=false)]
        public List<ShareResource> ShareResources { get; set; }

    }

}
