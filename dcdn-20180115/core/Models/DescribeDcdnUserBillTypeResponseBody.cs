// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserBillTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeDcdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeDcdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeDcdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
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
