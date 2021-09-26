// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CountList")]
        [Validation(Required=false)]
        public List<GetLogStatisticsResponseBodyCountList> CountList { get; set; }
        public class GetLogStatisticsResponseBodyCountList : TeaModel {
            [NameInMap("SqlKeyword")]
            [Validation(Required=false)]
            public string SqlKeyword { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("ClientProgram")]
            [Validation(Required=false)]
            public string ClientProgram { get; set; }

            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("DbServer")]
            [Validation(Required=false)]
            public string DbServer { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

    }

}
