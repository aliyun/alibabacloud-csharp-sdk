// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListAlertsRequest : TeaModel {
        [NameInMap("alertLevel")]
        [Validation(Required=false)]
        public string AlertLevel { get; set; }

        [NameInMap("alertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        [NameInMap("alertSourceName")]
        [Validation(Required=false)]
        public string AlertSourceName { get; set; }

        /// <summary>
        /// 2020-09-10 21:00:00
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("monitorSourceId")]
        [Validation(Required=false)]
        public string MonitorSourceId { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// 2020-09-10 13:00:00
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
