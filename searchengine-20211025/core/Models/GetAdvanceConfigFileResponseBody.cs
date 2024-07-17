// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetAdvanceConfigFileResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAdvanceConfigFileResponseBodyResult Result { get; set; }
        public class GetAdvanceConfigFileResponseBodyResult : TeaModel {
            /// <summary>
            /// The file content.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}
