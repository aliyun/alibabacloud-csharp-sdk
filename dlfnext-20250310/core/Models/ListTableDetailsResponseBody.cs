// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListTableDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results. A null value indicates that all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>A list of tables.</para>
        /// </summary>
        [NameInMap("tableDetails")]
        [Validation(Required=false)]
        public List<Table> TableDetails { get; set; }

    }

}
