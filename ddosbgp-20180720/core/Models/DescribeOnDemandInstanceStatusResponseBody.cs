// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeOnDemandInstanceStatusResponseBodyInstances> Instances { get; set; }
        public class DescribeOnDemandInstanceStatusResponseBodyInstances : TeaModel {
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Declared")]
            [Validation(Required=false)]
            public string Declared { get; set; }

            [NameInMap("RegistedAs")]
            [Validation(Required=false)]
            public string RegistedAs { get; set; }

            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
