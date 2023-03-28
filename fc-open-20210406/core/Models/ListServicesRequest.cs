// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// The maximum number of resources to return. Default value: 20. The value cannot exceed 100. The number of returned configurations is less than or equal to the specified number.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The starting position of the query. If this parameter is left empty, the query starts from the beginning. You do not need to specify this parameter in the first query. If the number of asynchronous tasks exceeds the limit, the nextToken parameter is returned, the value of which can be used in subsequent calls to obtain more results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The prefix that the names of returned resources must contain. If the name prefix is a, the names of returned resources must start with a.
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The returned resources are sorted in alphabetical order, and the resources that include and follow the resource specified by the startKey parameter are returned.
        /// </summary>
        [NameInMap("startKey")]
        [Validation(Required=false)]
        public string StartKey { get; set; }

    }

}
