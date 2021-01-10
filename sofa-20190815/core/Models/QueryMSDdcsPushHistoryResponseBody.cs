// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMSDdcsPushHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("History")]
        [Validation(Required=false)]
        public List<QueryMSDdcsPushHistoryResponseBodyHistory> History { get; set; }
        public class QueryMSDdcsPushHistoryResponseBodyHistory : TeaModel {
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("GmtEnd")]
            [Validation(Required=false)]
            public long? GmtEnd { get; set; }

            [NameInMap("GmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InfluenceApp")]
            [Validation(Required=false)]
            public string InfluenceApp { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public string PushResult { get; set; }

            [NameInMap("PushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
