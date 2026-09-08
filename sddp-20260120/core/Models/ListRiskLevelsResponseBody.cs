// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListRiskLevelsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<ListRiskLevelsResponseBodyRiskLevelList> RiskLevelList { get; set; }
        public class ListRiskLevelsResponseBodyRiskLevelList : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ReferenceNum")]
            [Validation(Required=false)]
            public int? ReferenceNum { get; set; }

        }

    }

}
