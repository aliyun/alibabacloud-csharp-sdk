// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListPostQueryResultRequest : TeaModel {
        /// <summary>
        /// The instance endpoint.
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

        /// <summary>
        /// The query type. Valid values: sql: SQL query. ha3: Havenask query.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
