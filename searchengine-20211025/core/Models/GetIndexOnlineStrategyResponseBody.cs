// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexOnlineStrategyResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexOnlineStrategyResponseBodyResult Result { get; set; }
        public class GetIndexOnlineStrategyResponseBodyResult : TeaModel {
            /// <summary>
            /// The index change rate.
            /// </summary>
            [NameInMap("changeRate")]
            [Validation(Required=false)]
            public int? ChangeRate { get; set; }

        }

    }

}
