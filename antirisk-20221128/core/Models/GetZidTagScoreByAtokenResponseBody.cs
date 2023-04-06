// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class GetZidTagScoreByAtokenResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetZidTagScoreByAtokenResponseBodyData Data { get; set; }
        public class GetZidTagScoreByAtokenResponseBodyData : TeaModel {
            /// <summary>
            /// aHook
            /// </summary>
            [NameInMap("aHook")]
            [Validation(Required=false)]
            public string AHook { get; set; }

            [NameInMap("debug")]
            [Validation(Required=false)]
            public string Debug { get; set; }

            [NameInMap("doubleOpen")]
            [Validation(Required=false)]
            public string DoubleOpen { get; set; }

            /// <summary>
            /// javaHook
            /// </summary>
            [NameInMap("javaHook")]
            [Validation(Required=false)]
            public string JavaHook { get; set; }

            [NameInMap("nativeHook")]
            [Validation(Required=false)]
            public string NativeHook { get; set; }

            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("riskScore")]
            [Validation(Required=false)]
            public string RiskScore { get; set; }

            [NameInMap("root")]
            [Validation(Required=false)]
            public string Root { get; set; }

            [NameInMap("simulator")]
            [Validation(Required=false)]
            public string Simulator { get; set; }

            [NameInMap("vpnProxy")]
            [Validation(Required=false)]
            public string VpnProxy { get; set; }

            [NameInMap("wifiProxy")]
            [Validation(Required=false)]
            public string WifiProxy { get; set; }

            [NameInMap("zid")]
            [Validation(Required=false)]
            public string Zid { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
