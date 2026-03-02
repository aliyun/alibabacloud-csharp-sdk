// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class FeedbackLibraryReviewRequest : TeaModel {
        [NameInMap("approve")]
        [Validation(Required=false)]
        public string Approve { get; set; }

        [NameInMap("feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        [NameInMap("reviewId")]
        [Validation(Required=false)]
        public long? ReviewId { get; set; }

    }

}
