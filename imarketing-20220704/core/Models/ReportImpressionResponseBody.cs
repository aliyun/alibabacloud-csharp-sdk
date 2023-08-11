// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ReportImpressionResponseBody : TeaModel {
        /// <summary>
        /// errorCode
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// ext
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public Dictionary<string, string> Ext { get; set; }

        /// <summary>
        /// header
        /// </summary>
        [NameInMap("Header")]
        [Validation(Required=false)]
        public ReportImpressionResponseBodyHeader Header { get; set; }
        public class ReportImpressionResponseBodyHeader : TeaModel {
            /// <summary>
            /// costTime
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            /// <summary>
            /// rpcId
            /// </summary>
            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            /// <summary>
            /// traceId
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ReportImpressionResponseBodyResult Result { get; set; }
        public class ReportImpressionResponseBodyResult : TeaModel {
            [NameInMap("Bidid")]
            [Validation(Required=false)]
            public string Bidid { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
