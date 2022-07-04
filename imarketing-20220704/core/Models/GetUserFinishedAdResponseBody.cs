// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetUserFinishedAdResponseBody : TeaModel {
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
        public GetUserFinishedAdResponseBodyHeader Header { get; set; }
        public class GetUserFinishedAdResponseBodyHeader : TeaModel {
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
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUserFinishedAdResponseBodyResult Result { get; set; }
        public class GetUserFinishedAdResponseBodyResult : TeaModel {
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
        };

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
