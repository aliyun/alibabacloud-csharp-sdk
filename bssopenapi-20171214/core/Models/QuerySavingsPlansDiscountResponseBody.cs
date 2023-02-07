// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDiscountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDiscountResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDiscountResponseBodyData : TeaModel {
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDiscountResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDiscountResponseBodyDataItems : TeaModel {
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                [NameInMap("ContractDiscountRate")]
                [Validation(Required=false)]
                public string ContractDiscountRate { get; set; }

                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("SpnType")]
                [Validation(Required=false)]
                public string SpnType { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
