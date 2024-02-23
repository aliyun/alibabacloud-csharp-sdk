// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallInPoolTransferConfigResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCallInPoolTransferConfigResponseBodyData Data { get; set; }
        public class QueryCallInPoolTransferConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The call mode. Valid values:
            /// 
            /// *   **roundRobin**
            /// *   **random**
            /// </summary>
            [NameInMap("CalledRouteMode")]
            [Validation(Required=false)]
            public string CalledRouteMode { get; set; }

            /// <summary>
            /// The details of the response parameters.
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<QueryCallInPoolTransferConfigResponseBodyDataDetails> Details { get; set; }
            public class QueryCallInPoolTransferConfigResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// The number used to transfer the call.
                /// </summary>
                [NameInMap("Called")]
                [Validation(Required=false)]
                public string Called { get; set; }

            }

            /// <summary>
            /// The time when the call transfer task was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The timeout period for transferring the call.
            /// </summary>
            [NameInMap("TransferTimeout")]
            [Validation(Required=false)]
            public string TransferTimeout { get; set; }

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
