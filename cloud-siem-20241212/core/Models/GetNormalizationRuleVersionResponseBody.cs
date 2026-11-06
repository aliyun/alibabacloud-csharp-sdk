// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetNormalizationRuleVersionResponseBody : TeaModel {
        [NameInMap("NormalizationRuleVersion")]
        [Validation(Required=false)]
        public GetNormalizationRuleVersionResponseBodyNormalizationRuleVersion NormalizationRuleVersion { get; set; }
        public class GetNormalizationRuleVersionResponseBodyNormalizationRuleVersion : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            [NameInMap("NormalizationRuleDescription")]
            [Validation(Required=false)]
            public string NormalizationRuleDescription { get; set; }

            [NameInMap("NormalizationRuleExpression")]
            [Validation(Required=false)]
            public string NormalizationRuleExpression { get; set; }

            [NameInMap("NormalizationRuleFormat")]
            [Validation(Required=false)]
            public string NormalizationRuleFormat { get; set; }

            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            [NameInMap("NormalizationRuleName")]
            [Validation(Required=false)]
            public string NormalizationRuleName { get; set; }

            [NameInMap("NormalizationRuleStatus")]
            [Validation(Required=false)]
            public string NormalizationRuleStatus { get; set; }

            [NameInMap("NormalizationRuleType")]
            [Validation(Required=false)]
            public string NormalizationRuleType { get; set; }

            [NameInMap("NormalizationRuleVersion")]
            [Validation(Required=false)]
            public int? NormalizationRuleVersion { get; set; }

            [NameInMap("NormalizationRuleVersionName")]
            [Validation(Required=false)]
            public string NormalizationRuleVersionName { get; set; }

            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
