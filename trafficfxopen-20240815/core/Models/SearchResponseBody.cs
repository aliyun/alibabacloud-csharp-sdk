// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.TrafficFxOpen20240815.Models
{
    public class SearchResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorData")]
        [Validation(Required=false)]
        public SearchResponseBodyErrorData ErrorData { get; set; }
        public class SearchResponseBodyErrorData : TeaModel {
            [NameInMap("rawErrorCode")]
            [Validation(Required=false)]
            public string RawErrorCode { get; set; }

            [NameInMap("rawErrorMsg")]
            [Validation(Required=false)]
            public string RawErrorMsg { get; set; }

        }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
