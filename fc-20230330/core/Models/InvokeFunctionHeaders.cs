// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InvokeFunctionHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("x-fc-invocation-type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        [NameInMap("x-fc-log-type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

    }

}
