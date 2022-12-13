// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class VerifyRouteRuleRequest : TeaModel {
        [NameInMap("routeRuleId")]
        [Validation(Required=false)]
        public long? RouteRuleId { get; set; }

        [NameInMap("testSourceEvents")]
        [Validation(Required=false)]
        public List<VerifyRouteRuleRequestTestSourceEvents> TestSourceEvents { get; set; }
        public class VerifyRouteRuleRequestTestSourceEvents : TeaModel {
            [NameInMap("eventJson")]
            [Validation(Required=false)]
            public string EventJson { get; set; }

            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

        }

    }

}
