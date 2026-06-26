// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListIcebergNamespaceDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The namespaces.</para>
        /// </summary>
        [NameInMap("namespaceDetails")]
        [Validation(Required=false)]
        public List<Namespace> NamespaceDetails { get; set; }

        /// <summary>
        /// <para>The token for the next page of results. If this parameter is not returned, all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

    }

}
