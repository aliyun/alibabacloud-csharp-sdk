// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class BatchSaveOrderPopRequest : TeaModel {
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public List<BatchSaveOrderPopRequestOrders> Orders { get; set; }
        public class BatchSaveOrderPopRequestOrders : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ChannelOpenId")]
            [Validation(Required=false)]
            public string ChannelOpenId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenOrderId")]
            [Validation(Required=false)]
            public string OpenOrderId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OrderCreateTime")]
            [Validation(Required=false)]
            public string OrderCreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OrderPayment")]
            [Validation(Required=false)]
            public string OrderPayment { get; set; }

            [NameInMap("PayTime")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ShopId")]
            [Validation(Required=false)]
            public string ShopId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("SubOrderModelList")]
            [Validation(Required=false)]
            public List<BatchSaveOrderPopRequestOrdersSubOrderModelList> SubOrderModelList { get; set; }
            public class BatchSaveOrderPopRequestOrdersSubOrderModelList : TeaModel {
                [NameInMap("Feature")]
                [Validation(Required=false)]
                public string Feature { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("OpenSubOrderId")]
                [Validation(Required=false)]
                public string OpenSubOrderId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("OrderPayment")]
                [Validation(Required=false)]
                public string OrderPayment { get; set; }

                [NameInMap("OutProductId")]
                [Validation(Required=false)]
                public string OutProductId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ProductAmount")]
                [Validation(Required=false)]
                public string ProductAmount { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("RefundStatus")]
                [Validation(Required=false)]
                public string RefundStatus { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("TotalFee")]
                [Validation(Required=false)]
                public string TotalFee { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("TotalFee")]
            [Validation(Required=false)]
            public string TotalFee { get; set; }

            [NameInMap("buyerOpenUid")]
            [Validation(Required=false)]
            public string BuyerOpenUid { get; set; }

        }

    }

}
