// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeCapResponseBody : TeaModel {
        [NameInMap("CapUrl")]
        [Validation(Required=false)]
        public DescribeCapResponseBodyCapUrl CapUrl { get; set; }
        public class DescribeCapResponseBodyCapUrl : TeaModel {
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
