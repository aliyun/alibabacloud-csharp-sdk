// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GetHistoryStatsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistoryStatsResponseBodyData Data { get; set; }
        public class GetHistoryStatsResponseBodyData : TeaModel {
            [NameInMap("HistoryPv")]
            [Validation(Required=false)]
            public Dictionary<string, string> HistoryPv { get; set; }

            [NameInMap("HistoryUv")]
            [Validation(Required=false)]
            public Dictionary<string, string> HistoryUv { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
