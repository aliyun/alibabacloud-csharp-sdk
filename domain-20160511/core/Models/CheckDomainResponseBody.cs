// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class CheckDomainResponseBody : TeaModel {
        [NameInMap("Avail")]
        [Validation(Required=false)]
        public int? Avail { get; set; }

        [NameInMap("FeeCommand")]
        [Validation(Required=false)]
        public string FeeCommand { get; set; }

        [NameInMap("FeeCurrency")]
        [Validation(Required=false)]
        public string FeeCurrency { get; set; }

        [NameInMap("FeeFee")]
        [Validation(Required=false)]
        public string FeeFee { get; set; }

        [NameInMap("FeePeriod")]
        [Validation(Required=false)]
        public int? FeePeriod { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RmbFee")]
        [Validation(Required=false)]
        public string RmbFee { get; set; }

    }

}
