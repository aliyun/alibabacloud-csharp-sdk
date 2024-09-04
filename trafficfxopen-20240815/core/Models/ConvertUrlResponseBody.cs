// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.TrafficFxOpen20240815.Models
{
    public class ConvertUrlResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ConvertUrlResponseBodyData Data { get; set; }
        public class ConvertUrlResponseBodyData : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("authUrl")]
            [Validation(Required=false)]
            public string AuthUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public ConvertUrlResponseBodyDataStatus Status { get; set; }
            public class ConvertUrlResponseBodyDataStatus : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

            }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorData")]
        [Validation(Required=false)]
        public ConvertUrlResponseBodyErrorData ErrorData { get; set; }
        public class ConvertUrlResponseBodyErrorData : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
