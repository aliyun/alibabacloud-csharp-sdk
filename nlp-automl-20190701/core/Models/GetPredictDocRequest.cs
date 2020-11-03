// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class GetPredictDocRequest : TeaModel {
        [NameInMap("DocId")]
        [Validation(Required=true)]
        public long DocId { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
