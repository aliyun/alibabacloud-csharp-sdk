// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceExtResponseBody : TeaModel {
        [NameInMap("InstanceExtSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceExtResponseBodyInstanceExtSpecs> InstanceExtSpecs { get; set; }
        public class DescribeInstanceExtResponseBodyInstanceExtSpecs : TeaModel {
            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public long? FunctionVersion { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NormalBandwidth")]
            [Validation(Required=false)]
            public long? NormalBandwidth { get; set; }

            [NameInMap("ProductPlan")]
            [Validation(Required=false)]
            public long? ProductPlan { get; set; }

            [NameInMap("ServicePartner")]
            [Validation(Required=false)]
            public string ServicePartner { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
