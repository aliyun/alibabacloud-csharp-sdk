// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserBillPredictionResponseBody : TeaModel {
        [NameInMap("BillPredictionData")]
        [Validation(Required=false)]
        public DescribeVodUserBillPredictionResponseBodyBillPredictionData BillPredictionData { get; set; }
        public class DescribeVodUserBillPredictionResponseBodyBillPredictionData : TeaModel {
            [NameInMap("BillPredictionDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem> BillPredictionDataItem { get; set; }
            public class DescribeVodUserBillPredictionResponseBodyBillPredictionDataBillPredictionDataItem : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("TimeStp")]
                [Validation(Required=false)]
                public string TimeStp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

        }

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
