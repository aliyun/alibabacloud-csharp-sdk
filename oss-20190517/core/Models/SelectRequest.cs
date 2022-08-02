// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class SelectRequest : TeaModel {
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("InputSerialization")]
        [Validation(Required=false)]
        public InputSerialization InputSerialization { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public SelectRequestOptions Options { get; set; }

        [NameInMap("OutputSerialization")]
        [Validation(Required=false)]
        public OutputSerialization OutputSerialization { get; set; }

    }

}
