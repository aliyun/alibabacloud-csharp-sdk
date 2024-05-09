// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListTableGenerationsResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListTableGenerationsResponseBodyResult> Result { get; set; }
        public class ListTableGenerationsResponseBodyResult : TeaModel {
            /// <summary>
            /// generationId
            /// </summary>
            [NameInMap("generationId")]
            [Validation(Required=false)]
            public long? GenerationId { get; set; }

        }

    }

}
