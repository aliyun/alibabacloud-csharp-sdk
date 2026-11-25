// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchUndeployHttpApiRoutesRequest : TeaModel {
        [NameInMap("async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("routeIds")]
        [Validation(Required=false)]
        public List<string> RouteIds { get; set; }

        [NameInMap("undeployAll")]
        [Validation(Required=false)]
        public bool? UndeployAll { get; set; }

    }

}
