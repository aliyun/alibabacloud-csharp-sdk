// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallInTransferRecordResponseBody : TeaModel {
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
        public QueryCallInTransferRecordResponseBodyData Data { get; set; }
        public class QueryCallInTransferRecordResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// The call transfer records.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<QueryCallInTransferRecordResponseBodyDataValues> Values { get; set; }
            public class QueryCallInTransferRecordResponseBodyDataValues : TeaModel {
                /// <summary>
                /// The called number of the inbound call.
                /// </summary>
                [NameInMap("CallInCalled")]
                [Validation(Required=false)]
                public string CallInCalled { get; set; }

                /// <summary>
                /// The calling number of the inbound call.
                /// </summary>
                [NameInMap("CallInCaller")]
                [Validation(Required=false)]
                public string CallInCaller { get; set; }

                /// <summary>
                /// The time when the call was initiated.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The recording URL.
                /// </summary>
                [NameInMap("RecordUrl")]
                [Validation(Required=false)]
                public string RecordUrl { get; set; }

                /// <summary>
                /// The phone number to which the call was transferred.
                /// </summary>
                [NameInMap("TransferCalled")]
                [Validation(Required=false)]
                public string TransferCalled { get; set; }

                /// <summary>
                /// The calling number that transferred the call.
                /// </summary>
                [NameInMap("TransferCaller")]
                [Validation(Required=false)]
                public string TransferCaller { get; set; }

            }

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
