// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class RunContactReviewRequest : TeaModel {
        [NameInMap("ContactScene")]
        [Validation(Required=false)]
        public string ContactScene { get; set; }

        [NameInMap("ContactPath")]
        [Validation(Required=false)]
        public string ContactPath { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
