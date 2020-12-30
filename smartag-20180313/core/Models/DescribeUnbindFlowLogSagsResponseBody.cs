// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUnbindFlowLogSagsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Sags")]
        [Validation(Required=false)]
        public DescribeUnbindFlowLogSagsResponseBodySags Sags { get; set; }
        public class DescribeUnbindFlowLogSagsResponseBodySags : TeaModel {
            [NameInMap("Sag")]
            [Validation(Required=false)]
            public List<DescribeUnbindFlowLogSagsResponseBodySagsSag> Sag { get; set; }
            public class DescribeUnbindFlowLogSagsResponseBodySagsSag : TeaModel {
                public string Description { get; set; }
                public string SmartAGId { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
