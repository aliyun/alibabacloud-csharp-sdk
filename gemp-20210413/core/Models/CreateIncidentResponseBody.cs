// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIncidentResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateIncidentResponseBodyData Data { get; set; }
        public class CreateIncidentResponseBodyData : TeaModel {
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }
        };

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
