// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeQualityOverallDataResponseBody : TeaModel {
        [NameInMap("QualityOverallData")]
        [Validation(Required=false)]
        public List<DescribeQualityOverallDataResponseBodyQualityOverallData> QualityOverallData { get; set; }
        public class DescribeQualityOverallDataResponseBodyQualityOverallData : TeaModel {
            [NameInMap("Average")]
            [Validation(Required=false)]
            public string Average { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQualityOverallDataResponseBodyQualityOverallDataNodes> Nodes { get; set; }
            public class DescribeQualityOverallDataResponseBodyQualityOverallDataNodes : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
