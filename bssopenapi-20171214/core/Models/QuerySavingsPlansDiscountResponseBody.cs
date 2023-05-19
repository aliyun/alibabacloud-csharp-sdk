// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDiscountResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDiscountResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDiscountResponseBodyData : TeaModel {
            /// <summary>
            /// The IP address of the request.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The information about the discounts on saving plans.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDiscountResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDiscountResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The details of the service.
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// The contracted discount.
                /// </summary>
                [NameInMap("ContractDiscountRate")]
                [Validation(Required=false)]
                public string ContractDiscountRate { get; set; }

                /// <summary>
                /// The cycle based on which queries were performed.
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                /// <summary>
                /// The discount provided by the official website.
                /// </summary>
                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                /// <summary>
                /// The name of the pricing module.
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// The payment mode. Valid values:
                /// 
                /// *   total: all upfront
                /// *   half: half upfront
                /// *   zero: no upfront
                /// </summary>
                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The type of the savings plan.
                /// </summary>
                [NameInMap("SpnType")]
                [Validation(Required=false)]
                public string SpnType { get; set; }

            }

        }

        /// <summary>
        /// The error message returned.
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
