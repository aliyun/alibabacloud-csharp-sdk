// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRiskLevelsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<DescribeRiskLevelsResponseBodyRiskLevelList> RiskLevelList { get; set; }
        public class DescribeRiskLevelsResponseBodyRiskLevelList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ReferenceNum")]
            [Validation(Required=false)]
            public int? ReferenceNum { get; set; }

        }

    }

}
