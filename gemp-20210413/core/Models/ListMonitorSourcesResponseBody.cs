// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListMonitorSourcesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMonitorSourcesResponseBodyData> Data { get; set; }
        public class ListMonitorSourcesResponseBodyData : TeaModel {
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("fieldKeys")]
            [Validation(Required=false)]
            public List<string> FieldKeys { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
