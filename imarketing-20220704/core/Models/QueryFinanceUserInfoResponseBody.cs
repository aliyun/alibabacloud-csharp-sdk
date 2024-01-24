// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class QueryFinanceUserInfoResponseBody : TeaModel {
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
        public QueryFinanceUserInfoResponseBodyHeader Header { get; set; }
        public class QueryFinanceUserInfoResponseBodyHeader : TeaModel {
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
        public QueryFinanceUserInfoResponseBodyResult Result { get; set; }
        public class QueryFinanceUserInfoResponseBodyResult : TeaModel {
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("TotalIncomeAmount")]
            [Validation(Required=false)]
            public long? TotalIncomeAmount { get; set; }

            [NameInMap("UserPageType")]
            [Validation(Required=false)]
            public string UserPageType { get; set; }

            [NameInMap("YesterdayIncomeAmount")]
            [Validation(Required=false)]
            public long? YesterdayIncomeAmount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
