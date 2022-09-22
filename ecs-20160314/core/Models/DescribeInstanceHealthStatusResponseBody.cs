// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeInstanceHealthStatusResponseBody : TeaModel {
        [NameInMap("HealthStatusModel")]
        [Validation(Required=false)]
        public List<DescribeInstanceHealthStatusResponseBodyHealthStatusModel> HealthStatusModel { get; set; }
        public class DescribeInstanceHealthStatusResponseBodyHealthStatusModel : TeaModel {
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public DescribeInstanceHealthStatusResponseBodyHealthStatusModelHealthStatus HealthStatus { get; set; }
            public class DescribeInstanceHealthStatusResponseBodyHealthStatusModelHealthStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
