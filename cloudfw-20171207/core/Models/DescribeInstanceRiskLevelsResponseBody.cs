// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRiskLevelsResponseBody : TeaModel {
        [NameInMap("InstanceRisks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRiskLevelsResponseBodyInstanceRisks> InstanceRisks { get; set; }
        public class DescribeInstanceRiskLevelsResponseBodyInstanceRisks : TeaModel {
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeInstanceRiskLevelsResponseBodyInstanceRisksDetails> Details { get; set; }
            public class DescribeInstanceRiskLevelsResponseBodyInstanceRisksDetails : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
