// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class DataResultsValue : TeaModel {
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("skipReason")]
        [Validation(Required=false)]
        public string SkipReason { get; set; }

    }

}
