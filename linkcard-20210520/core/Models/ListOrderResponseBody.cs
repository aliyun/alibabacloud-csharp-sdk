// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class ListOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOrderResponseBodyData Data { get; set; }
        public class ListOrderResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListOrderResponseBodyDataList> List { get; set; }
            public class ListOrderResponseBodyDataList : TeaModel {
                public string AliFee { get; set; }
                public string BillingCycle { get; set; }
                public int? BuyNum { get; set; }
                public int? CardPayCount { get; set; }
                public string CredentialNo { get; set; }
                public string CredentialPackage { get; set; }
                public string DataLevel { get; set; }
                public ListOrderResponseBodyDataListDeliveryInfo DeliveryInfo { get; set; }
                public class ListOrderResponseBodyDataListDeliveryInfo : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("BuyerMessage")]
                    [Validation(Required=false)]
                    public string BuyerMessage { get; set; }

                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    [NameInMap("Receiver")]
                    [Validation(Required=false)]
                    public string Receiver { get; set; }

                    [NameInMap("ZipCode")]
                    [Validation(Required=false)]
                    public string ZipCode { get; set; }

                }
                public List<string> ExpressNoList { get; set; }
                public string FlowType { get; set; }
                public int? FunctionFee { get; set; }
                public string OrderDetailUrl { get; set; }
                public string OrderId { get; set; }
                public string OrderInfo { get; set; }
                public string OrderStatus { get; set; }
                public string OrderType { get; set; }
                public string PayDuration { get; set; }
                public string PayTime { get; set; }
                public string PoolCapacity { get; set; }
                public string PoolCapacityUnit { get; set; }
                public string PoolNo { get; set; }
                public string Vendor { get; set; }
            }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
