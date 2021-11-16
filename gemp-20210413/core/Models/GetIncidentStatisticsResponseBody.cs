// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetIncidentStatisticsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIncidentStatisticsResponseBodyData Data { get; set; }
        public class GetIncidentStatisticsResponseBodyData : TeaModel {
            [NameInMap("allFinish")]
            [Validation(Required=false)]
            public int? AllFinish { get; set; }
            [NameInMap("allResponse")]
            [Validation(Required=false)]
            public int? AllResponse { get; set; }
            [NameInMap("myFinish")]
            [Validation(Required=false)]
            public int? MyFinish { get; set; }
            [NameInMap("myResponse")]
            [Validation(Required=false)]
            public int? MyResponse { get; set; }
        };

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
