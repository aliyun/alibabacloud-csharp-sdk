// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncInvokeConfigsRequest : TeaModel {
        /// <summary>
        /// The function name. If you do not configure this parameter, the asynchronous invocation configurations of all functions are displayed.
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The maximum number of entries to be returned.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The paging information. This parameter specifies the start point of the query.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
