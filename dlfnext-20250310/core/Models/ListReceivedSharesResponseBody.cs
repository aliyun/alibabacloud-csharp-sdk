// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListReceivedSharesResponseBody : TeaModel {
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
        /// <para>The received shares.</para>
        /// </summary>
        [NameInMap("shares")]
        [Validation(Required=false)]
        public List<ReceivedShare> Shares { get; set; }

    }

}
