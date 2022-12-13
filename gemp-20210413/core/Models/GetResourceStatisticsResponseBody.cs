// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetResourceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetResourceStatisticsResponseBodyData Data { get; set; }
        public class GetResourceStatisticsResponseBodyData : TeaModel {
            [NameInMap("alertCount")]
            [Validation(Required=false)]
            public int? AlertCount { get; set; }

            [NameInMap("incidentCount")]
            [Validation(Required=false)]
            public int? IncidentCount { get; set; }

            [NameInMap("integrationCount")]
            [Validation(Required=false)]
            public int? IntegrationCount { get; set; }

            [NameInMap("problemCount")]
            [Validation(Required=false)]
            public int? ProblemCount { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
