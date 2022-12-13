// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListDataReportForServiceGroupResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataReportForServiceGroupResponseBodyData> Data { get; set; }
        public class ListDataReportForServiceGroupResponseBodyData : TeaModel {
            [NameInMap("escalationIncidentCount")]
            [Validation(Required=false)]
            public long? EscalationIncidentCount { get; set; }

            [NameInMap("finishIncidentCount")]
            [Validation(Required=false)]
            public long? FinishIncidentCount { get; set; }

            [NameInMap("finishProportion")]
            [Validation(Required=false)]
            public string FinishProportion { get; set; }

            [NameInMap("incidentCount")]
            [Validation(Required=false)]
            public long? IncidentCount { get; set; }

            /// <summary>
            /// MRRA
            /// </summary>
            [NameInMap("meanTimeToAcknowledge")]
            [Validation(Required=false)]
            public long? MeanTimeToAcknowledge { get; set; }

            /// <summary>
            /// MTTR
            /// </summary>
            [NameInMap("meanTimeToRepair")]
            [Validation(Required=false)]
            public long? MeanTimeToRepair { get; set; }

            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

            [NameInMap("unAcknowledgedEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnAcknowledgedEscalationIncidentCount { get; set; }

            [NameInMap("unFinishEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnFinishEscalationIncidentCount { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSIze")]
        [Validation(Required=false)]
        public long? PageSIze { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
