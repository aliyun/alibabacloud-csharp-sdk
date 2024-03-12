// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class CheckAddRegionToExpressConnectRouterResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("AnyCrossBorderLink")]
        [Validation(Required=false)]
        public bool? AnyCrossBorderLink { get; set; }

        [NameInMap("AnyInterRegionLink")]
        [Validation(Required=false)]
        public bool? AnyInterRegionLink { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("IsCdtCrossBorderEnabled")]
        [Validation(Required=false)]
        public bool? IsCdtCrossBorderEnabled { get; set; }

        [NameInMap("IsCdtInterRegionEnabled")]
        [Validation(Required=false)]
        public bool? IsCdtInterRegionEnabled { get; set; }

        [NameInMap("IsUserAllowedToCreateCrossBorderLink")]
        [Validation(Required=false)]
        public bool? IsUserAllowedToCreateCrossBorderLink { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
