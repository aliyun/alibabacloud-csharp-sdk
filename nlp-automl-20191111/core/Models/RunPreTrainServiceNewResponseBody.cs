// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class RunPreTrainServiceNewResponseBody : TeaModel {
        [NameInMap("BillingCount")]
        [Validation(Required=false)]
        public int? BillingCount { get; set; }

        [NameInMap("PredictResult")]
        [Validation(Required=false)]
        public string PredictResult { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
