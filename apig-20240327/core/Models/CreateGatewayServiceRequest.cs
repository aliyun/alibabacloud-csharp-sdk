// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateGatewayServiceRequest : TeaModel {
        [NameInMap("gatewayServiceConfigs")]
        [Validation(Required=false)]
        public List<CreateGatewayServiceRequestGatewayServiceConfigs> GatewayServiceConfigs { get; set; }
        public class CreateGatewayServiceRequestGatewayServiceConfigs : TeaModel {
            [NameInMap("addresses")]
            [Validation(Required=false)]
            public List<string> Addresses { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

        }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
