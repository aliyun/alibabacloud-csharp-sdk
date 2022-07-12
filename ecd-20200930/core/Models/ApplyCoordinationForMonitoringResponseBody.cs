// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringResponseBody : TeaModel {
        [NameInMap("CoordinateFlowModels")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels> CoordinateFlowModels { get; set; }
        public class ApplyCoordinationForMonitoringResponseBodyCoordinateFlowModels : TeaModel {
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            [NameInMap("CoordinateStatus")]
            [Validation(Required=false)]
            public string CoordinateStatus { get; set; }

            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            [NameInMap("InitiatorType")]
            [Validation(Required=false)]
            public string InitiatorType { get; set; }

            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
