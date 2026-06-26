// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The function definitions.</para>
        /// </summary>
        [NameInMap("functions")]
        [Validation(Required=false)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// <para>A pagination token. Use this token to retrieve the next page of results. If this parameter is null, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E8ABEB1C3DB893D16576269017992F57</para>
        /// </summary>
        [NameInMap("nextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

    }

}
