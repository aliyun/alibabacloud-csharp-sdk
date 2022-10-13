// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CheckUserFinishAdResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, string> Ext { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public CheckUserFinishAdResponseBodyHeader Header { get; set; }
        public class CheckUserFinishAdResponseBodyHeader : TeaModel {
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckUserFinishAdResponseBodyResult Result { get; set; }
        public class CheckUserFinishAdResponseBodyResult : TeaModel {
            [NameInMap("Commission")]
            [Validation(Required=false)]
            public string Commission { get; set; }

            [NameInMap("MarketingType")]
            [Validation(Required=false)]
            public string MarketingType { get; set; }

            [NameInMap("Objective")]
            [Validation(Required=false)]
            public string Objective { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
