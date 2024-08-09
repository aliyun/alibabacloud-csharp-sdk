// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UdfFunction : TeaModel {
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
