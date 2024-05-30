// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListProductResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other values indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/196974.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public ListProductResponseBodyModel Model { get; set; }
        public class ListProductResponseBodyModel : TeaModel {
            /// <summary>
            /// The returned data.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            /// <summary>
            /// The pagination details.
            /// </summary>
            [NameInMap("Paging")]
            [Validation(Required=false)]
            public ListProductResponseBodyModelPaging Paging { get; set; }
            public class ListProductResponseBodyModelPaging : TeaModel {
                /// <summary>
                /// The cursors for pagination.
                /// </summary>
                [NameInMap("Cursors")]
                [Validation(Required=false)]
                public ListProductResponseBodyModelPagingCursors Cursors { get; set; }
                public class ListProductResponseBodyModelPagingCursors : TeaModel {
                    /// <summary>
                    /// The cursor that points to the end of the page of the returned data.
                    /// </summary>
                    [NameInMap("After")]
                    [Validation(Required=false)]
                    public string After { get; set; }

                    /// <summary>
                    /// The cursor that points to the beginning of the page of the returned data.
                    /// </summary>
                    [NameInMap("Before")]
                    [Validation(Required=false)]
                    public string Before { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
