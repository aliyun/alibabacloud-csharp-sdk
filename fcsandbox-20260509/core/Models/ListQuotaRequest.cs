// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class ListQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve more results. You do not need to specify this parameter for the first query. You can obtain the token for subsequent queries from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Trigger_fasdatalake_deductionfee</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
