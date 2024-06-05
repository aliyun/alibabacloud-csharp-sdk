// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BatchResponseBody : TeaModel {
        /// <summary>
        /// All responses of the child requests.
        /// </summary>
        [NameInMap("responses")]
        [Validation(Required=false)]
        public List<BatchResponseBodyResponses> Responses { get; set; }
        public class BatchResponseBodyResponses : TeaModel {
            /// <summary>
            /// The response parameters of a child request. For more information, see the topic of the corresponding child request.
            /// </summary>
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, object> Body { get; set; }

            /// <summary>
            /// The ID of the child request. The ID is used to associate a child request with a response.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The returned HTTP status code of a child request. For more information, see the topic of the corresponding child request.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
