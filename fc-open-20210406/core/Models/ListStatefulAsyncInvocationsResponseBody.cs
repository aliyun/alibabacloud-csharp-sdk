// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListStatefulAsyncInvocationsResponseBody : TeaModel {
        /// <summary>
        /// The version or alias of the service to which the asynchronous task belongs.
        /// </summary>
        [NameInMap("invocations")]
        [Validation(Required=false)]
        public List<StatefulAsyncInvocation> Invocations { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
