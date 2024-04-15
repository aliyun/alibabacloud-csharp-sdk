// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListFunctionVersionsRequest : TeaModel {
        /// <summary>
        /// The sorting mode of function versions. Valid values: BACKWARD and FORWARD.
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The number of function versions that are returned.
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
