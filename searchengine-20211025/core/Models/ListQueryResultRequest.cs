// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListQueryResultRequest : TeaModel {
        /// <summary>
        /// The query statement
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// The SQL statement that is executed in the query
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
