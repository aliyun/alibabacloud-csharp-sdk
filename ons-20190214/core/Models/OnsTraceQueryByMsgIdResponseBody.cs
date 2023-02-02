// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTraceQueryByMsgIdResponseBody : TeaModel {
        /// <summary>
        /// The ID of the query task. You can call the [OnsTraceGetResult](~~59832~~) operation to query the details of the message trace based on the task ID.
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public string QueryId { get; set; }

        /// <summary>
        /// The ID of the request. The system generates a unique ID for each request. You can troubleshoot issues based on the request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
