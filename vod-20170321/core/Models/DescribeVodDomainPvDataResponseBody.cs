// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainPvDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PvDataInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainPvDataResponseBodyPvDataInterval PvDataInterval { get; set; }
        public class DescribeVodDomainPvDataResponseBodyPvDataInterval : TeaModel {
            [NameInMap("PvDataInterval")]
            [Validation(Required=false)]
            public List<DescribeVodDomainPvDataResponseBodyPvDataIntervalPvDataInterval> PvDataInterval { get; set; }
            public class DescribeVodDomainPvDataResponseBodyPvDataIntervalPvDataInterval : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

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
