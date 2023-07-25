// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class PutEvaluationsRequest : TeaModel {
        [NameInMap("DeleteMode")]
        [Validation(Required=false)]
        public bool? DeleteMode { get; set; }

        [NameInMap("Evaluations")]
        [Validation(Required=false)]
        public string Evaluations { get; set; }

        [NameInMap("ResultToken")]
        [Validation(Required=false)]
        public string ResultToken { get; set; }

    }

}
