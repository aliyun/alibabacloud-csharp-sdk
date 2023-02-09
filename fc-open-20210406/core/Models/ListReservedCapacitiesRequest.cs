// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListReservedCapacitiesRequest : TeaModel {
        /// <summary>
        /// The maximum number of resources to return. Valid values: \[1, 100].
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// The token that determines the start point of the query.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
