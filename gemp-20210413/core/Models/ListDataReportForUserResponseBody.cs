// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListDataReportForUserResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataReportForUserResponseBodyData> Data { get; set; }
        public class ListDataReportForUserResponseBodyData : TeaModel {
            [NameInMap("distributionIncidentCount")]
            [Validation(Required=false)]
            public long? DistributionIncidentCount { get; set; }

            [NameInMap("escalationIncidentCount")]
            [Validation(Required=false)]
            public long? EscalationIncidentCount { get; set; }

            [NameInMap("finishIncidentNumber")]
            [Validation(Required=false)]
            public long? FinishIncidentNumber { get; set; }

            [NameInMap("finishProportion")]
            [Validation(Required=false)]
            public string FinishProportion { get; set; }

            /// <summary>
            /// MRRA
            /// </summary>
            [NameInMap("meanTimeToAcknowledge")]
            [Validation(Required=false)]
            public string MeanTimeToAcknowledge { get; set; }

            /// <summary>
            /// MTTA
            /// </summary>
            [NameInMap("meanTimeToRepair")]
            [Validation(Required=false)]
            public string MeanTimeToRepair { get; set; }

            [NameInMap("unAcknowledgedEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnAcknowledgedEscalationIncidentCount { get; set; }

            [NameInMap("unDistributionIncidentCount")]
            [Validation(Required=false)]
            public long? UnDistributionIncidentCount { get; set; }

            [NameInMap("unFinishEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnFinishEscalationIncidentCount { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

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
