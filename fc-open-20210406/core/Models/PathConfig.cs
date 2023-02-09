// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PathConfig : TeaModel {
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("rewriteConfig")]
        [Validation(Required=false)]
        public RewriteConfig RewriteConfig { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
