// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillPredictionResponseBody : TeaModel {
        [NameInMap("BillPredictionData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillPredictionResponseBodyBillPredictionData BillPredictionData { get; set; }
        public class DescribeCdnUserBillPredictionResponseBodyBillPredictionData : TeaModel {
            [NameInMap("BillPredictionDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem> BillPredictionDataItem { get; set; }
            public class DescribeCdnUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem : TeaModel {
                public string Area { get; set; }
                public string TimeStp { get; set; }
                public float? Value { get; set; }
            }
        };

        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
