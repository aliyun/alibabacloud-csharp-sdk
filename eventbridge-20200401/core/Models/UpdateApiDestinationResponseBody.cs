// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateApiDestinationResponseBody : TeaModel {
        /// <summary>
        /// api-destination-name
        /// </summary>
        [NameInMap("ApiDestinationName")]
        [Validation(Required=false)]
        public string ApiDestinationName { get; set; }

        /// <summary>
        /// The response code. If the request is successful, Success is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message. If the request is successful, success is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
