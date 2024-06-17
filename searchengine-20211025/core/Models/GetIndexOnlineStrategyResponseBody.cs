// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexOnlineStrategyResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// IndexOnlineStrategy
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexOnlineStrategyResponseBodyResult Result { get; set; }
        public class GetIndexOnlineStrategyResponseBodyResult : TeaModel {
            [NameInMap("changeRate")]
            [Validation(Required=false)]
            public int? ChangeRate { get; set; }

        }

    }

}
