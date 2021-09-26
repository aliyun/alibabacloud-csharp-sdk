// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetLogTopStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CountList")]
        [Validation(Required=false)]
        public List<GetLogTopStatisticsResponseBodyCountList> CountList { get; set; }
        public class GetLogTopStatisticsResponseBodyCountList : TeaModel {
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            [NameInMap("ClientProgram")]
            [Validation(Required=false)]
            public string ClientProgram { get; set; }

        }

    }

}
