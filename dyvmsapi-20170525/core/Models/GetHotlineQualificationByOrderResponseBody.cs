// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class GetHotlineQualificationByOrderResponseBody : TeaModel {
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
        public GetHotlineQualificationByOrderResponseBodyData Data { get; set; }
        public class GetHotlineQualificationByOrderResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the qualification application ticket.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// The qualification ID.
            /// </summary>
            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }

            /// <summary>
            /// The qualification state. Valid values:
            /// 
            /// *   **NORMAL**
            /// *   **OTHER**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
