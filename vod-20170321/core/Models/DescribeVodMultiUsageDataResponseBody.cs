// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodMultiUsageDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("MultiUsageData")]
        [Validation(Required=false)]
        public DescribeVodMultiUsageDataResponseBodyMultiUsageData MultiUsageData { get; set; }
        public class DescribeVodMultiUsageDataResponseBodyMultiUsageData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodMultiUsageDataResponseBodyMultiUsageDataDataModule> DataModule { get; set; }
            public class DescribeVodMultiUsageDataResponseBodyMultiUsageDataDataModule : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

                [NameInMap("ValueType")]
                [Validation(Required=false)]
                public string ValueType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
