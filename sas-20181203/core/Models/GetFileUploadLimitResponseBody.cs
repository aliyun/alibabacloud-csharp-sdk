// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileUploadLimitResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the request is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileUploadLimitResponseBodyData Data { get; set; }
        public class GetFileUploadLimitResponseBodyData : TeaModel {
            /// <summary>
            /// The QPS limit on the files uploaded from the client.
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public string Limit { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
