// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class RestartHpoTrialsRequest : TeaModel {
        [NameInMap("TrialHyperParameters")]
        [Validation(Required=false)]
        public string TrialHyperParameters { get; set; }

        [NameInMap("TrialIds")]
        [Validation(Required=false)]
        public List<string> TrialIds { get; set; }

    }

}
