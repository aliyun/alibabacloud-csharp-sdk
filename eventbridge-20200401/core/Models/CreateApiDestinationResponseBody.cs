// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateApiDestinationResponseBody : TeaModel {
        /// <summary>
        /// The returned response code. The value Success indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the API destination is created.
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public CreateApiDestinationResponseBodyDate Date { get; set; }
        public class CreateApiDestinationResponseBodyDate : TeaModel {
            /// <summary>
            /// The name of the API destination.
            /// </summary>
            [NameInMap("ApiDestinationName")]
            [Validation(Required=false)]
            public string ApiDestinationName { get; set; }

        }

        /// <summary>
        /// The returned message.
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
