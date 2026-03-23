// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceTypeFamiliesResponseBody : TeaModel {
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamilies InstanceTypeFamilies { get; set; }
        public class DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamilies : TeaModel {
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily> InstanceTypeFamily { get; set; }
            public class DescribeRCInstanceTypeFamiliesResponseBodyInstanceTypeFamiliesInstanceTypeFamily : TeaModel {
                [NameInMap("InstanceTypeFamilyDesc")]
                [Validation(Required=false)]
                public string InstanceTypeFamilyDesc { get; set; }

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
