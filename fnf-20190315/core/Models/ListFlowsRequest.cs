// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListFlowsRequest : TeaModel {
        /// <summary>
        /// The number of workflows that you want to query. Valid values: 1 - 999. Default value: 60.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The token to start the query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
