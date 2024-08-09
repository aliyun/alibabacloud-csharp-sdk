// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UdfClass : TeaModel {
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        [NameInMap("classType")]
        [Validation(Required=false)]
        public string ClassType { get; set; }

        [NameInMap("functionNames")]
        [Validation(Required=false)]
        public List<string> FunctionNames { get; set; }

        [NameInMap("udfArtifactName")]
        [Validation(Required=false)]
        public string UdfArtifactName { get; set; }

    }

}
