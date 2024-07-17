// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class DeleteFolderResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Response<Map<String, String>>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteFolderResponseBodyResult Result { get; set; }
        public class DeleteFolderResponseBodyResult : TeaModel {
            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// The result
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public Dictionary<string, string> Result { get; set; }

        }

    }

}
