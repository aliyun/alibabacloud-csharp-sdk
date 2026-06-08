// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAttachment : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;SELECT city, COUNT(*) AS cnt FROM events GROUP BY city&quot;</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ExecutionResult Result { get; set; }

    }

}
