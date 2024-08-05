// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateCalculationJobsResponseBody : TeaModel {
        [NameInMap("CalculationJobIds")]
        [Validation(Required=false)]
        public List<string> CalculationJobIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
