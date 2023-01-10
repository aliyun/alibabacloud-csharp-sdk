// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateFunctionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The ID of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        /// <summary>
        /// The CRC-64 value of the function code package.
        /// </summary>
        [NameInMap("X-Fc-Code-Checksum")]
        [Validation(Required=false)]
        public string XFcCodeChecksum { get; set; }

        /// <summary>
        /// The time on which the function is invoked. The format of the value is: **EEE,d MMM yyyy HH:mm:ss GMT**.
        /// </summary>
        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        /// <summary>
        /// The trace ID of the request. The value is the same as that of the requestId parameter in the response.
        /// </summary>
        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
