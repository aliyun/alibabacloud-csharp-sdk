// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetAliasHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("X-Fc-Account-Id")]
        [Validation(Required=false)]
        public string XFcAccountId { get; set; }

        [NameInMap("X-Fc-Code-Checksum")]
        [Validation(Required=false)]
        public string XFcCodeChecksum { get; set; }

        [NameInMap("X-Fc-Date")]
        [Validation(Required=false)]
        public string XFcDate { get; set; }

        [NameInMap("X-Fc-Invocation-Type")]
        [Validation(Required=false)]
        public string XFcInvocationType { get; set; }

        [NameInMap("X-Fc-Log-Type")]
        [Validation(Required=false)]
        public string XFcLogType { get; set; }

        [NameInMap("X-Fc-Trace-Id")]
        [Validation(Required=false)]
        public string XFcTraceId { get; set; }

    }

}
