// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeRateResponseBody : TeaModel {
        [NameInMap("AdditionalContent")]
        [Validation(Required=false)]
        public string AdditionalContent { get; set; }

        [NameInMap("AdditionalExplaintion")]
        [Validation(Required=false)]
        public string AdditionalExplaintion { get; set; }

        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Explaintion")]
        [Validation(Required=false)]
        public string Explaintion { get; set; }

        [NameInMap("GmtAdditional")]
        [Validation(Required=false)]
        public long? GmtAdditional { get; set; }

        [NameInMap("GmtAdditionalExplaintion")]
        [Validation(Required=false)]
        public long? GmtAdditionalExplaintion { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        [NameInMap("GmtExplaintion")]
        [Validation(Required=false)]
        public long? GmtExplaintion { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Score")]
        [Validation(Required=false)]
        public string Score { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
