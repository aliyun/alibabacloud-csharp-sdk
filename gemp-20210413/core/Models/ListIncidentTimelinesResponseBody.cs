// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentTimelinesResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentTimelinesResponseBodyData> Data { get; set; }
        public class ListIncidentTimelinesResponseBodyData : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public long? Description { get; set; }

            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            [NameInMap("incidentNumber")]
            [Validation(Required=false)]
            public string IncidentNumber { get; set; }

            [NameInMap("incidentTitle")]
            [Validation(Required=false)]
            public string IncidentTitle { get; set; }

            [NameInMap("relRouteRuleDeleteType")]
            [Validation(Required=false)]
            public int? RelRouteRuleDeleteType { get; set; }

            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("snapshotData")]
            [Validation(Required=false)]
            public string SnapshotData { get; set; }

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

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
