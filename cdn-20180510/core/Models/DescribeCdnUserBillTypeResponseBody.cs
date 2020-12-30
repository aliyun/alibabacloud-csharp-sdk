// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeCdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string BillingCycle { get; set; }
                public string Product { get; set; }
                public string BillType { get; set; }
                public string Dimension { get; set; }
            }
        };

    }

}
