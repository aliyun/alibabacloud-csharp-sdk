// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class RunPreTrainServiceNewRequest : TeaModel {
        [NameInMap("PredictContent")]
        [Validation(Required=false)]
        public string PredictContent { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

    }

}
