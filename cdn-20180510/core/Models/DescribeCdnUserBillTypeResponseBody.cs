// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillTypeResponseBody : TeaModel {
        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeCdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
