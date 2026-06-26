// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListProvidedSharesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results. A null value indicates that this is the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The shares.</para>
        /// </summary>
        [NameInMap("shares")]
        [Validation(Required=false)]
        public List<Share> Shares { get; set; }

    }

}
