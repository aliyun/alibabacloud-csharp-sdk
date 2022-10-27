// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Respond")]
        [Validation(Required=false)]
        public List<DescribeParametersHistoryResponseBodyRespond> Respond { get; set; }
        public class DescribeParametersHistoryResponseBodyRespond : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeParametersHistoryResponseBodyRespondParameters> Parameters { get; set; }
            public class DescribeParametersHistoryResponseBodyRespondParameters : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                [NameInMap("OldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
