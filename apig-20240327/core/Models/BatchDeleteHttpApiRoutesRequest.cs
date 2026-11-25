// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchDeleteHttpApiRoutesRequest : TeaModel {
        [NameInMap("deleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

        [NameInMap("routeIds")]
        [Validation(Required=false)]
        public List<string> RouteIds { get; set; }

    }

}
