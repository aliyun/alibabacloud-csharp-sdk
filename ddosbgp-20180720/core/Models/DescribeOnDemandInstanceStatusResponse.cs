// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public List<DescribeOnDemandInstanceStatusResponseInstances> Instances { get; set; }
        public class DescribeOnDemandInstanceStatusResponseInstances : TeaModel {
            [NameInMap("UserId")]
            [Validation(Required=true)]
            public string UserId { get; set; }

            [NameInMap("Net")]
            [Validation(Required=true)]
            public string Net { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("RegistedAs")]
            [Validation(Required=true)]
            public string RegistedAs { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=true)]
            public string Desc { get; set; }

            [NameInMap("Declared")]
            [Validation(Required=true)]
            public string Declared { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=true)]
            public string Mode { get; set; }

        }

    }

}
