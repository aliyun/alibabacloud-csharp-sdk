// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayRouteCORSRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("CorsJSON")]
        [Validation(Required=false)]
        public UpdateGatewayRouteCORSRequestCorsJSON CorsJSON { get; set; }
        public class UpdateGatewayRouteCORSRequestCorsJSON : TeaModel {
            [NameInMap("AllowCredentials")]
            [Validation(Required=false)]
            public bool? AllowCredentials { get; set; }

            [NameInMap("AllowHeaders")]
            [Validation(Required=false)]
            public string AllowHeaders { get; set; }

            [NameInMap("AllowMethods")]
            [Validation(Required=false)]
            public string AllowMethods { get; set; }

            [NameInMap("AllowOrigins")]
            [Validation(Required=false)]
            public string AllowOrigins { get; set; }

            [NameInMap("ExposeHeaders")]
            [Validation(Required=false)]
            public string ExposeHeaders { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

        }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("MseSessionId")]
        [Validation(Required=false)]
        public string MseSessionId { get; set; }

    }

}
