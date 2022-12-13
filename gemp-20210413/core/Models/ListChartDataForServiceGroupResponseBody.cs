// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListChartDataForServiceGroupResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListChartDataForServiceGroupResponseBodyData> Data { get; set; }
        public class ListChartDataForServiceGroupResponseBodyData : TeaModel {
            [NameInMap("effectionLevel")]
            [Validation(Required=false)]
            public Dictionary<string, object> EffectionLevel { get; set; }

            [NameInMap("escalationIncidentCount")]
            [Validation(Required=false)]
            public long? EscalationIncidentCount { get; set; }

            [NameInMap("incidentCount")]
            [Validation(Required=false)]
            public long? IncidentCount { get; set; }

            [NameInMap("meanTimeToAcknowledge")]
            [Validation(Required=false)]
            public long? MeanTimeToAcknowledge { get; set; }

            [NameInMap("meanTimeToRepair")]
            [Validation(Required=false)]
            public long? MeanTimeToRepair { get; set; }

            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("totalMeanTimeToAcknowledge")]
            [Validation(Required=false)]
            public long? TotalMeanTimeToAcknowledge { get; set; }

            [NameInMap("totalMeanTimeToRepair")]
            [Validation(Required=false)]
            public long? TotalMeanTimeToRepair { get; set; }

            [NameInMap("unAcknowledgedEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnAcknowledgedEscalationIncidentCount { get; set; }

            [NameInMap("unFinishEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnFinishEscalationIncidentCount { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
