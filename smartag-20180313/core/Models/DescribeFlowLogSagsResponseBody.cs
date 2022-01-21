// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeFlowLogSagsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sags")]
        [Validation(Required=false)]
        public DescribeFlowLogSagsResponseBodySags Sags { get; set; }
        public class DescribeFlowLogSagsResponseBodySags : TeaModel {
            [NameInMap("Sag")]
            [Validation(Required=false)]
            public List<DescribeFlowLogSagsResponseBodySagsSag> Sag { get; set; }
            public class DescribeFlowLogSagsResponseBodySagsSag : TeaModel {
                public string Description { get; set; }
                public string Name { get; set; }
                public string SmartAGId { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
