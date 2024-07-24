// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateRumAppResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the returned results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateRumAppResponseBodyData Data { get; set; }
        public class UpdateRumAppResponseBodyData : TeaModel {
            /// <summary>
            /// The user configurations. This is a reserved parameter.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The QPS limit. Unit: bytes.
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }

            /// <summary>
            /// Indicates whether the request is throttled due to the QPS limit. Valid values: true and false.
            /// </summary>
            [NameInMap("Limited")]
            [Validation(Required=false)]
            public bool? Limited { get; set; }

            /// <summary>
            /// The usage. Unit: bytes.
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
