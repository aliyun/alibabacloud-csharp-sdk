// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncInvokeConfigsRequest : TeaModel {
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
