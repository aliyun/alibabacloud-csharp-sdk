// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationRuleVersionsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("NormalizationRuleVersions")]
        [Validation(Required=false)]
        public List<ListNormalizationRuleVersionsResponseBodyNormalizationRuleVersions> NormalizationRuleVersions { get; set; }
        public class ListNormalizationRuleVersionsResponseBodyNormalizationRuleVersions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("NormalizationRuleExpression")]
            [Validation(Required=false)]
            public string NormalizationRuleExpression { get; set; }

            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            [NameInMap("NormalizationRuleVersion")]
            [Validation(Required=false)]
            public int? NormalizationRuleVersion { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
