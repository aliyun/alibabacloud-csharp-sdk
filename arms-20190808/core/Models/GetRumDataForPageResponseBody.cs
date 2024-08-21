// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumDataForPageResponseBody : TeaModel {
        /// <summary>
        /// The responses code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The result of the operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRumDataForPageResponseBodyData Data { get; set; }
        public class GetRumDataForPageResponseBodyData : TeaModel {
            /// <summary>
            /// A reserved parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("Authentication")]
            [Validation(Required=false)]
            public string Authentication { get; set; }

            /// <summary>
            /// Indicates whether the query ends. Valid values: true and false.
            /// </summary>
            [NameInMap("Completion")]
            [Validation(Required=false)]
            public string Completion { get; set; }

            /// <summary>
            /// The queried data.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Items { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public string Page { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// A reserved parameter. Ignore this parameter.
            /// </summary>
            [NameInMap("Preference")]
            [Validation(Required=false)]
            public string Preference { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

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
