// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ErrorDetails : TeaModel {
        [NameInMap("columnNumber")]
        [Validation(Required=false)]
        public string ColumnNumber { get; set; }

        [NameInMap("endColumnNumber")]
        [Validation(Required=false)]
        public string EndColumnNumber { get; set; }

        [NameInMap("endLineNumber")]
        [Validation(Required=false)]
        public string EndLineNumber { get; set; }

        [NameInMap("invalidflinkConf")]
        [Validation(Required=false)]
        public List<string> InvalidflinkConf { get; set; }

        [NameInMap("lineNumber")]
        [Validation(Required=false)]
        public string LineNumber { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
