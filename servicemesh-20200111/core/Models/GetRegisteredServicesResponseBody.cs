// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceDirectory")]
        [Validation(Required=false)]
        public GetRegisteredServicesResponseBodyServiceDirectory ServiceDirectory { get; set; }
        public class GetRegisteredServicesResponseBodyServiceDirectory : TeaModel {
            [NameInMap("ServiceListStages")]
            [Validation(Required=false)]
            public List<GetRegisteredServicesResponseBodyServiceDirectoryServiceListStages> ServiceListStages { get; set; }
            public class GetRegisteredServicesResponseBodyServiceDirectoryServiceListStages : TeaModel {
                public string ClusterId { get; set; }
                public string Marker { get; set; }
            }
            [NameInMap("Services")]
            [Validation(Required=false)]
            public Dictionary<string, string> Services { get; set; }
        };

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<string> Services { get; set; }

    }

}
