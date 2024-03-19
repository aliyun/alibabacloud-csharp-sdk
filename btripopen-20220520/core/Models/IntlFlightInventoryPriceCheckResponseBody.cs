// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightInventoryPriceCheckResponseBodyModule Module { get; set; }
        public class IntlFlightInventoryPriceCheckResponseBodyModule : TeaModel {
            [NameInMap("check_success")]
            [Validation(Required=false)]
            public bool? CheckSuccess { get; set; }

            [NameInMap("fail_type")]
            [Validation(Required=false)]
            public int? FailType { get; set; }

            [NameInMap("passenger_changed_price_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoList> PassengerChangedPriceInfoList { get; set; }
            public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoList : TeaModel {
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                [NameInMap("changed_price")]
                [Validation(Required=false)]
                public IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListChangedPrice ChangedPrice { get; set; }
                public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListChangedPrice : TeaModel {
                    [NameInMap("build_price")]
                    [Validation(Required=false)]
                    public long? BuildPrice { get; set; }

                    [NameInMap("oil_price")]
                    [Validation(Required=false)]
                    public long? OilPrice { get; set; }

                    [NameInMap("tax_price")]
                    [Validation(Required=false)]
                    public long? TaxPrice { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                [NameInMap("original_price")]
                [Validation(Required=false)]
                public IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListOriginalPrice OriginalPrice { get; set; }
                public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListOriginalPrice : TeaModel {
                    [NameInMap("build_price")]
                    [Validation(Required=false)]
                    public long? BuildPrice { get; set; }

                    [NameInMap("oil_price")]
                    [Validation(Required=false)]
                    public long? OilPrice { get; set; }

                    [NameInMap("tax_price")]
                    [Validation(Required=false)]
                    public long? TaxPrice { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

            }

            [NameInMap("render_key")]
            [Validation(Required=false)]
            public string RenderKey { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
