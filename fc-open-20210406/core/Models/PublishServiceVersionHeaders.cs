// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PublishServiceVersionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The ETag value of the service. This value is used to ensure that the modified service is consistent with the service to be modified. The ETag value is returned in the responses of the [CreateService](~~175256~~), [UpdateService](~~188167~~), and [GetService](~~189225~~) operations.
        /// </summary>
        [NameInMap("If-Match")]
        [Validation(Required=false)]
        public string IfMatch { get; set; }

        /// <summary>
        /// The ID of your Alibaba Cloud account.
        /// </summary>
        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        /// <summary>
        /// The start time when the function is invoked. Specify the time in the yyyy-mm-ddhh:mm:ss format.
        /// </summary>
        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        /// <summary>
        /// The trace ID of the invocation request of Function Compute.
        /// </summary>
        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
