// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAccountLabelResponseBody : TeaModel {
        [NameInMap("AccountLabelList")]
        [Validation(Required=false)]
        public List<GetAccountLabelResponseBodyAccountLabelList> AccountLabelList { get; set; }
        public class GetAccountLabelResponseBodyAccountLabelList : TeaModel {
            [NameInMap("LabelSeries")]
            [Validation(Required=false)]
            public string LabelSeries { get; set; }

            [NameInMap("LabelStatus")]
            [Validation(Required=false)]
            public bool? LabelStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
