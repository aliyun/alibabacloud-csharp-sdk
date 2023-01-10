// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListStatefulAsyncInvocationFunctionsResponseBody : TeaModel {
        /// <summary>
        /// The details of returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<AsyncConfigMeta> Data { get; set; }

        /// <summary>
        /// The token used to obtain more results. If this parameter is left empty, all the results are returned.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
