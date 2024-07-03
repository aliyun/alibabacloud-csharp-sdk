// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class GetPredictDocResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public string ResultContent { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("XLIFFInfo")]
        [Validation(Required=false)]
        public string XLIFFInfo { get; set; }

    }

}
