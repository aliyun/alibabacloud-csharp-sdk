// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListDemosResponseBody : TeaModel {
        [NameInMap("Demos")]
        [Validation(Required=false)]
        public List<ListDemosResponseBodyDemos> Demos { get; set; }
        public class ListDemosResponseBodyDemos : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("DemoDescription")]
            [Validation(Required=false)]
            public string DemoDescription { get; set; }

            [NameInMap("DemoName")]
            [Validation(Required=false)]
            public string DemoName { get; set; }

            [NameInMap("DemoUrl")]
            [Validation(Required=false)]
            public string DemoUrl { get; set; }

            [NameInMap("Order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
