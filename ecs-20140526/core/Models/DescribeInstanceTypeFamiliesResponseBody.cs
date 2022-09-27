// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypeFamiliesResponseBody : TeaModel {
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamilies : TeaModel {
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily> InstanceTypeFamily { get; set; }
            public class DescribeInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily : TeaModel {
                [NameInMap("Generation")]
                [Validation(Required=false)]
                public string Generation { get; set; }

                [NameInMap("InstanceTypeFamilyId")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
