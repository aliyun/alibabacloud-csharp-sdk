// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryMonitorKeywordsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMonitorKeywordsResponseBodyData Data { get; set; }
        public class QueryMonitorKeywordsResponseBodyData : TeaModel {
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
