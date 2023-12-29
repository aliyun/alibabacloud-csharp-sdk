// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class DescribeVerifySchemeResponseBody : TeaModel {
        /// <summary>
        /// The response code. OK indicates that the request is successful. For more information about other error codes, see [API response codes](~~85198~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("SchemeQueryResultDTO")]
        [Validation(Required=false)]
        public DescribeVerifySchemeResponseBodySchemeQueryResultDTO SchemeQueryResultDTO { get; set; }
        public class DescribeVerifySchemeResponseBodySchemeQueryResultDTO : TeaModel {
            /// <summary>
            /// The key generated when you create a service in the console.
            /// </summary>
            [NameInMap("AppEncryptInfo")]
            [Validation(Required=false)]
            public string AppEncryptInfo { get; set; }

        }

    }

}
