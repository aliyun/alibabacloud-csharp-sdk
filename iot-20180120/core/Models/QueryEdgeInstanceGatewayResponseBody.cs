// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceGatewayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("GatewayList")]
        [Validation(Required=false)]
        public List<QueryEdgeInstanceGatewayResponseBodyGatewayList> GatewayList { get; set; }
        public class QueryEdgeInstanceGatewayResponseBodyGatewayList : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("EdgeVersion")]
            [Validation(Required=false)]
            public string EdgeVersion { get; set; }

        }

    }

}
