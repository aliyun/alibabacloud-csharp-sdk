// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeProjectInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeProjectInfoResponseBodyResult Result { get; set; }
        public class DescribeProjectInfoResponseBodyResult : TeaModel {
            [NameInMap("CurrentStepNo")]
            [Validation(Required=false)]
            public int? CurrentStepNo { get; set; }
            [NameInMap("CustomerAliUid")]
            [Validation(Required=false)]
            public long? CustomerAliUid { get; set; }
            [NameInMap("FinalStepNo")]
            [Validation(Required=false)]
            public int? FinalStepNo { get; set; }
            [NameInMap("FinishType")]
            [Validation(Required=false)]
            public string FinishType { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public long? GmtExpired { get; set; }
            [NameInMap("GmtFinished")]
            [Validation(Required=false)]
            public long? GmtFinished { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }
            [NameInMap("ProductSkuCode")]
            [Validation(Required=false)]
            public string ProductSkuCode { get; set; }
            [NameInMap("ProductSkuName")]
            [Validation(Required=false)]
            public string ProductSkuName { get; set; }
            [NameInMap("ProjectStatus")]
            [Validation(Required=false)]
            public string ProjectStatus { get; set; }
            [NameInMap("SupplierAliUid")]
            [Validation(Required=false)]
            public long? SupplierAliUid { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
