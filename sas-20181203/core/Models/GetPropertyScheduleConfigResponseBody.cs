// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetPropertyScheduleConfigResponseBody : TeaModel {
        [NameInMap("PropertyScheduleConfig")]
        [Validation(Required=false)]
        public GetPropertyScheduleConfigResponseBodyPropertyScheduleConfig PropertyScheduleConfig { get; set; }
        public class GetPropertyScheduleConfigResponseBodyPropertyScheduleConfig : TeaModel {
            [NameInMap("NextScheduleTime")]
            [Validation(Required=false)]
            public long? NextScheduleTime { get; set; }

            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public string ScheduleTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
