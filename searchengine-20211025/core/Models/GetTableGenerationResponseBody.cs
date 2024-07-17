// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetTableGenerationResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTableGenerationResponseBodyResult Result { get; set; }
        public class GetTableGenerationResponseBodyResult : TeaModel {
            /// <summary>
            /// generationId
            /// </summary>
            [NameInMap("generationId")]
            [Validation(Required=false)]
            public long? GenerationId { get; set; }

            /// <summary>
            /// starting, building, ready, stopped, failed
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
