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
                [NameInMap("AliFee")]
                [Validation(Required=false)]
                public string AliFee { get; set; }

                [NameInMap("ApnName")]
                [Validation(Required=false)]
                public string ApnName { get; set; }

                [NameInMap("ApnRegion")]
                [Validation(Required=false)]
                public string ApnRegion { get; set; }

                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                [NameInMap("BuyNum")]
                [Validation(Required=false)]
                public int? BuyNum { get; set; }

                [NameInMap("CardPayCount")]
                [Validation(Required=false)]
                public int? CardPayCount { get; set; }

                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                [NameInMap("CredentialPackage")]
                [Validation(Required=false)]
                public string CredentialPackage { get; set; }

                [NameInMap("DataLevel")]
                [Validation(Required=false)]
                public string DataLevel { get; set; }

                [NameInMap("DeliveryInfo")]
                [Validation(Required=false)]
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

                [NameInMap("ExpressNoList")]
                [Validation(Required=false)]
                public List<string> ExpressNoList { get; set; }

                [NameInMap("FlowType")]
                [Validation(Required=false)]
                public string FlowType { get; set; }

                [NameInMap("FunctionFee")]
                [Validation(Required=false)]
                public int? FunctionFee { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("OrderDetailUrl")]
                [Validation(Required=false)]
                public string OrderDetailUrl { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("OrderInfo")]
                [Validation(Required=false)]
                public string OrderInfo { get; set; }

                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("PayDuration")]
                [Validation(Required=false)]
                public string PayDuration { get; set; }

                [NameInMap("PayTime")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                [NameInMap("PoolCapacity")]
                [Validation(Required=false)]
                public string PoolCapacity { get; set; }

                [NameInMap("PoolCapacityUnit")]
                [Validation(Required=false)]
                public string PoolCapacityUnit { get; set; }

                [NameInMap("PoolNo")]
                [Validation(Required=false)]
                public string PoolNo { get; set; }

                [NameInMap("ResourceQuantity")]
                [Validation(Required=false)]
                public long? ResourceQuantity { get; set; }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
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

        }

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
