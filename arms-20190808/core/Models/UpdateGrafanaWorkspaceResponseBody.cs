// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateGrafanaWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned for the request. Valid values:
        /// 
        /// *   `2XX`: The request is successful.
        /// *   `3XX`: A redirection message is returned.
        /// *   `4XX`: The request is invalid.
        /// *   `5XX`: A server error occurs.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Indicates whether the update is successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// The error message returned for the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the trace. The ID is used to query the details of a request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
