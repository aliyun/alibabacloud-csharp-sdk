// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteMultiAccountSQLQueryResponseBody : TeaModel {
        /// <summary>
        /// The columns.
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ExecuteMultiAccountSQLQueryResponseBodyColumns> Columns { get; set; }
        public class ExecuteMultiAccountSQLQueryResponseBodyColumns : TeaModel {
            /// <summary>
            /// The name of the column.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the column.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array of search results.
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public List<object> Rows { get; set; }

    }

}
