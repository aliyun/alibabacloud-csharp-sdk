// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListRestQueryResultRequest : TeaModel {
        /// <summary>
        /// The instance endpoint.
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The name of the index table.
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// The rest query statement.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public Dictionary<string, object> Query { get; set; }

    }

}
