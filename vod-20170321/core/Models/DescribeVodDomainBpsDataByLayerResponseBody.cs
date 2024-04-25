// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainBpsDataByLayerResponseBody : TeaModel {
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeVodDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public long? TrafficValue { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

        }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public int? DataInterval { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
