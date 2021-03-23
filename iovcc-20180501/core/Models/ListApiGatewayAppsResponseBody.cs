// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListApiGatewayAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ApiGatewayApps")]
        [Validation(Required=false)]
        public List<ListApiGatewayAppsResponseBodyApiGatewayApps> ApiGatewayApps { get; set; }
        public class ListApiGatewayAppsResponseBodyApiGatewayApps : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("GatewayAppKey")]
            [Validation(Required=false)]
            public string GatewayAppKey { get; set; }

            [NameInMap("GatewayAppSecret")]
            [Validation(Required=false)]
            public string GatewayAppSecret { get; set; }

            [NameInMap("GatewayAppId")]
            [Validation(Required=false)]
            public string GatewayAppId { get; set; }

        }

    }

}
