// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventHouseRuntimesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of runtimes to return per page. If this parameter is not specified or set to 0, the default value 20 is used. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Not required for the first query. For subsequent queries, use the NextToken returned in the previous response. An empty value indicates that no more pages are available.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
