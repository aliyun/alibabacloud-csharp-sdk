// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPriceEntityListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPriceEntityListResponseBodyData Data { get; set; }
        public class QueryPriceEntityListResponseBodyData : TeaModel {
            [NameInMap("PriceEntityInfoList")]
            [Validation(Required=false)]
            public List<QueryPriceEntityListResponseBodyDataPriceEntityInfoList> PriceEntityInfoList { get; set; }
            public class QueryPriceEntityListResponseBodyDataPriceEntityInfoList : TeaModel {
                [NameInMap("PriceEntityCode")]
                [Validation(Required=false)]
                public string PriceEntityCode { get; set; }

                [NameInMap("PriceEntityName")]
                [Validation(Required=false)]
                public string PriceEntityName { get; set; }

                [NameInMap("PriceFactorList")]
                [Validation(Required=false)]
                public List<QueryPriceEntityListResponseBodyDataPriceEntityInfoListPriceFactorList> PriceFactorList { get; set; }
                public class QueryPriceEntityListResponseBodyDataPriceEntityInfoListPriceFactorList : TeaModel {
                    [NameInMap("PriceFactorCode")]
                    [Validation(Required=false)]
                    public string PriceFactorCode { get; set; }

                    [NameInMap("PriceFactorName")]
                    [Validation(Required=false)]
                    public string PriceFactorName { get; set; }

                    [NameInMap("PriceFactorValueList")]
                    [Validation(Required=false)]
                    public List<string> PriceFactorValueList { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
