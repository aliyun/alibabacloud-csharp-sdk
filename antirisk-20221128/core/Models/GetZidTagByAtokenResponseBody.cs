// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antirisk20221128.Models
{
    public class GetZidTagByAtokenResponseBody : TeaModel {
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetZidTagByAtokenResponseBodyData Data { get; set; }
        public class GetZidTagByAtokenResponseBodyData : TeaModel {
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
