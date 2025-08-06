// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainUvDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UvDataInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainUvDataResponseBodyUvDataInterval UvDataInterval { get; set; }
        public class DescribeVodDomainUvDataResponseBodyUvDataInterval : TeaModel {
            [NameInMap("UvDataInterval")]
            [Validation(Required=false)]
            public List<DescribeVodDomainUvDataResponseBodyUvDataIntervalUvDataInterval> UvDataInterval { get; set; }
            public class DescribeVodDomainUvDataResponseBodyUvDataIntervalUvDataInterval : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
