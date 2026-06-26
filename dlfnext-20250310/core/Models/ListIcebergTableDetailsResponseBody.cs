// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListIcebergTableDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is null, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>A list of data tables.</para>
        /// </summary>
        [NameInMap("tableDetails")]
        [Validation(Required=false)]
        public List<IcebergTable> TableDetails { get; set; }

    }

}
