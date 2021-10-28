// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayStockResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Stocks")]
        [Validation(Required=false)]
        public DescribeGatewayStockResponseBodyStocks Stocks { get; set; }
        public class DescribeGatewayStockResponseBodyStocks : TeaModel {
            [NameInMap("Stock")]
            [Validation(Required=false)]
            public List<DescribeGatewayStockResponseBodyStocksStock> Stock { get; set; }
            public class DescribeGatewayStockResponseBodyStocksStock : TeaModel {
                public string StockInfo { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
