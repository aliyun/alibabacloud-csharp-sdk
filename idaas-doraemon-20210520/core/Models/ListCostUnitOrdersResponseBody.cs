// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListCostUnitOrdersResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListCostUnitOrdersResponseBodyItems> Items { get; set; }
        public class ListCostUnitOrdersResponseBodyItems : TeaModel {
            [NameInMap("AliOrderCode")]
            [Validation(Required=false)]
            public string AliOrderCode { get; set; }

            [NameInMap("AliOrderInstanceId")]
            [Validation(Required=false)]
            public string AliOrderInstanceId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Exhausted")]
            [Validation(Required=false)]
            public bool? Exhausted { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

            [NameInMap("RefundTime")]
            [Validation(Required=false)]
            public long? RefundTime { get; set; }

            [NameInMap("TotalCostUnit")]
            [Validation(Required=false)]
            public long? TotalCostUnit { get; set; }

            [NameInMap("UsedCostUnit")]
            [Validation(Required=false)]
            public long? UsedCostUnit { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public long? TotalElements { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public long? TotalPages { get; set; }

    }

}
