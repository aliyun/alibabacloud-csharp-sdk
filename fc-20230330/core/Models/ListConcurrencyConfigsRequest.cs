// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListConcurrencyConfigsRequest : TeaModel {
        /// <summary>
        /// The function name. If you leave this parameter empty, the concurrency configurations of all functions are returned.
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
