// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class DescribePackageOrdersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribePackageOrdersResponseBodyPage Page { get; set; }
        public class DescribePackageOrdersResponseBodyPage : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public List<DescribePackageOrdersResponseBodyPageOrderList> OrderList { get; set; }
            public class DescribePackageOrdersResponseBodyPageOrderList : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public int? Amount { get; set; }

                [NameInMap("CreatorAliUid")]
                [Validation(Required=false)]
                public long? CreatorAliUid { get; set; }

                [NameInMap("DeliveryAddress")]
                [Validation(Required=false)]
                public string DeliveryAddress { get; set; }

                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// </summary>
                [NameInMap("GmtCanceledTime")]
                [Validation(Required=false)]
                public string GmtCanceledTime { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// </summary>
                [NameInMap("GmtPaidTime")]
                [Validation(Required=false)]
                public string GmtPaidTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductSkuCode")]
                [Validation(Required=false)]
                public string ProductSkuCode { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public string TradePrice { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
