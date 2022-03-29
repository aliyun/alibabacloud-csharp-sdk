// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceAccessDetailResponseBody : TeaModel {
        [NameInMap("AccessDetail")]
        [Validation(Required=false)]
        public DescribeServiceAccessDetailResponseBodyAccessDetail AccessDetail { get; set; }
        public class DescribeServiceAccessDetailResponseBodyAccessDetail : TeaModel {
            [NameInMap("ClusterIP")]
            [Validation(Required=false)]
            public string ClusterIP { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
