// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryOneconsoleIndexesRequest : TeaModel {
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("MaxMatch")]
        [Validation(Required=false)]
        public long? MaxMatch { get; set; }

    }

}
