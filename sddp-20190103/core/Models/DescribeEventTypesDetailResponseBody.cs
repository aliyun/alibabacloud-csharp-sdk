// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public DescribeEventTypesDetailResponseBodyUserStatus UserStatus { get; set; }
        public class DescribeEventTypesDetailResponseBodyUserStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }
            [NameInMap("ConfigContentType")]
            [Validation(Required=false)]
            public int? ConfigContentType { get; set; }
            [NameInMap("DealSuggestion")]
            [Validation(Required=false)]
            public string DealSuggestion { get; set; }
            [NameInMap("EventHitCount")]
            [Validation(Required=false)]
            public int? EventHitCount { get; set; }
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }
            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public int? AccessCount { get; set; }
            [NameInMap("ConfigDescription")]
            [Validation(Required=false)]
            public string ConfigDescription { get; set; }
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }
            [NameInMap("DescEvent")]
            [Validation(Required=false)]
            public string DescEvent { get; set; }
            [NameInMap("RiskEvent")]
            [Validation(Required=false)]
            public string RiskEvent { get; set; }
            [NameInMap("ParentTypeName")]
            [Validation(Required=false)]
            public string ParentTypeName { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DescModel")]
            [Validation(Required=false)]
            public string DescModel { get; set; }
            [NameInMap("ConfigCode")]
            [Validation(Required=false)]
            public string ConfigCode { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("ParentTypeId")]
            [Validation(Required=false)]
            public long? ParentTypeId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("AdaptedProduct")]
            [Validation(Required=false)]
            public string AdaptedProduct { get; set; }
        };

    }

}
