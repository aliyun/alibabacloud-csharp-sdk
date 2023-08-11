// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class QueryOrderResponseBody : TeaModel {
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
        public QueryOrderResponseBodyHeader Header { get; set; }
        public class QueryOrderResponseBodyHeader : TeaModel {
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
        public QueryOrderResponseBodyResult Result { get; set; }
        public class QueryOrderResponseBodyResult : TeaModel {
            [NameInMap("AlipayTradeId")]
            [Validation(Required=false)]
            public string AlipayTradeId { get; set; }

            [NameInMap("ChannelTradeId")]
            [Validation(Required=false)]
            public string ChannelTradeId { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TaobaoTradeId")]
            [Validation(Required=false)]
            public string TaobaoTradeId { get; set; }

            [NameInMap("TradeId")]
            [Validation(Required=false)]
            public string TradeId { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
