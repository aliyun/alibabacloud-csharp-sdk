// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListByMonitorSourceIdResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListByMonitorSourceIdResponseBodyData> Data { get; set; }
        public class ListByMonitorSourceIdResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
