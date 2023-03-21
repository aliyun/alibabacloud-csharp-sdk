// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckEcsWarningsResponseBody : TeaModel {
        [NameInMap("CanTry")]
        [Validation(Required=false)]
        public string CanTry { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SasVersion")]
        [Validation(Required=false)]
        public string SasVersion { get; set; }

        [NameInMap("WeakPasswordCount")]
        [Validation(Required=false)]
        public string WeakPasswordCount { get; set; }

    }

}
