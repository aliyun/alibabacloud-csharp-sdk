// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeRiUtilizationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Utilizations")]
        [Validation(Required=false)]
        public DescribeRiUtilizationResponseBodyUtilizations Utilizations { get; set; }
        public class DescribeRiUtilizationResponseBodyUtilizations : TeaModel {
            [NameInMap("Utilization")]
            [Validation(Required=false)]
            public List<DescribeRiUtilizationResponseBodyUtilizationsUtilization> Utilization { get; set; }
            public class DescribeRiUtilizationResponseBodyUtilizationsUtilization : TeaModel {
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                [NameInMap("Utilization")]
                [Validation(Required=false)]
                public string Utilization { get; set; }

            }

        }

    }

}
