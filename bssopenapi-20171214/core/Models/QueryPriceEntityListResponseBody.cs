// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPriceEntityListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPriceEntityListResponseBodyData Data { get; set; }
        public class QueryPriceEntityListResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the billable items.
            /// </summary>
            [NameInMap("PriceEntityInfoList")]
            [Validation(Required=false)]
            public List<QueryPriceEntityListResponseBodyDataPriceEntityInfoList> PriceEntityInfoList { get; set; }
            public class QueryPriceEntityListResponseBodyDataPriceEntityInfoList : TeaModel {
                /// <summary>
                /// The code of the billable item.
                /// </summary>
                [NameInMap("PriceEntityCode")]
                [Validation(Required=false)]
                public string PriceEntityCode { get; set; }

                /// <summary>
                /// The name of the billable item.
                /// </summary>
                [NameInMap("PriceEntityName")]
                [Validation(Required=false)]
                public string PriceEntityName { get; set; }

                /// <summary>
                /// The factors of the billable item.
                /// </summary>
                [NameInMap("PriceFactorList")]
                [Validation(Required=false)]
                public List<QueryPriceEntityListResponseBodyDataPriceEntityInfoListPriceFactorList> PriceFactorList { get; set; }
                public class QueryPriceEntityListResponseBodyDataPriceEntityInfoListPriceFactorList : TeaModel {
                    /// <summary>
                    /// The code of the factor.
                    /// </summary>
                    [NameInMap("PriceFactorCode")]
                    [Validation(Required=false)]
                    public string PriceFactorCode { get; set; }

                    /// <summary>
                    /// The name of the factor.
                    /// </summary>
                    [NameInMap("PriceFactorName")]
                    [Validation(Required=false)]
                    public string PriceFactorName { get; set; }

                    /// <summary>
                    /// The values of the factor.
                    /// </summary>
                    [NameInMap("PriceFactorValueList")]
                    [Validation(Required=false)]
                    public List<string> PriceFactorValueList { get; set; }

                }

            }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
