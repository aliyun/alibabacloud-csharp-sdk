// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListViewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token to retrieve the next page of results. A null value indicates that this is the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>A list of view names.</para>
        /// </summary>
        [NameInMap("views")]
        [Validation(Required=false)]
        public List<string> Views { get; set; }

    }

}
