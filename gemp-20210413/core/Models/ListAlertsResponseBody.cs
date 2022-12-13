// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListAlertsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAlertsResponseBodyData> Data { get; set; }
        public class ListAlertsResponseBodyData : TeaModel {
            [NameInMap("alertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            [NameInMap("alertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            [NameInMap("alertNumber")]
            [Validation(Required=false)]
            public string AlertNumber { get; set; }

            [NameInMap("alertSourceName")]
            [Validation(Required=false)]
            public string AlertSourceName { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("firstEventTime")]
            [Validation(Required=false)]
            public string FirstEventTime { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("relServiceDeleteType")]
            [Validation(Required=false)]
            public int? RelServiceDeleteType { get; set; }

            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            [NameInMap("routeRuleDeleteType")]
            [Validation(Required=false)]
            public int? RouteRuleDeleteType { get; set; }

            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            [NameInMap("routeRuleName")]
            [Validation(Required=false)]
            public string RouteRuleName { get; set; }

            [NameInMap("sourceEventCount")]
            [Validation(Required=false)]
            public long? SourceEventCount { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
