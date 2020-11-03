// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class GetPredictDocResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=true)]
        public string ResultContent { get; set; }

        [NameInMap("Status")]
        [Validation(Required=true)]
        public int? Status { get; set; }

        [NameInMap("XLIFFInfo")]
        [Validation(Required=true)]
        public string XLIFFInfo { get; set; }

    }

}
