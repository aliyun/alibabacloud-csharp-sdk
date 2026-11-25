// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DetectHttpApiConflictsRequest : TeaModel {
        [NameInMap("restApiConfig")]
        [Validation(Required=false)]
        public DetectHttpApiConflictsRequestRestApiConfig RestApiConfig { get; set; }
        public class DetectHttpApiConflictsRequestRestApiConfig : TeaModel {
            [NameInMap("backendScene")]
            [Validation(Required=false)]
            public string BackendScene { get; set; }

            [NameInMap("customDomainIds")]
            [Validation(Required=false)]
            public List<string> CustomDomainIds { get; set; }

            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("serviceConfigs")]
            [Validation(Required=false)]
            public List<DetectHttpApiConflictsRequestRestApiConfigServiceConfigs> ServiceConfigs { get; set; }
            public class DetectHttpApiConflictsRequestRestApiConfigServiceConfigs : TeaModel {
                [NameInMap("match")]
                [Validation(Required=false)]
                public HttpApiBackendMatchConditions Match { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

    }

}
