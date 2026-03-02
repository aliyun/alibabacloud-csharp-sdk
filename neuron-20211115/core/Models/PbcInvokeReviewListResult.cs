// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcInvokeReviewListResult : TeaModel {
        [NameInMap("pbcInvokeReviews")]
        [Validation(Required=false)]
        public List<PbcInvokeReview> PbcInvokeReviews { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
