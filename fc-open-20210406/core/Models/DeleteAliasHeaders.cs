// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class DeleteAliasHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// If the ETag specified in the request matches the ETag value of the object, OSS transmits the object and returns 200 OK. If the ETag specified in the request does not match the ETag value of the object, OSS returns 412 Precondition Failed. 
        /// The ETag value of a resource is used to check whether the resource has changed. You can check data integrity by using the ETag value. 
        /// Default value: null
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
        /// The time when Function Compute API is called. Specify the time in the **EEE,d MMM yyyy HH:mm:ss GMT** format.
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
