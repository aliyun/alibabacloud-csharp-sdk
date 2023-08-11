// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ConfirmSampleReceivedResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, object> Ext { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public ConfirmSampleReceivedResponseBodyHeader Header { get; set; }
        public class ConfirmSampleReceivedResponseBodyHeader : TeaModel {
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            [NameInMap("InnerErrorCode")]
            [Validation(Required=false)]
            public string InnerErrorCode { get; set; }

            [NameInMap("InnerErrorMsg")]
            [Validation(Required=false)]
            public string InnerErrorMsg { get; set; }

            /// <summary>
            /// RPC ID
            /// </summary>
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

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ConfirmSampleReceivedResponseBodyResult Result { get; set; }
        public class ConfirmSampleReceivedResponseBodyResult : TeaModel {
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
