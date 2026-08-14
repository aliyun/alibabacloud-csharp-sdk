// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebReportTopIpResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeWebReportTopIpResponseBodyDataList> DataList { get; set; }
        public class DescribeWebReportTopIpResponseBodyDataList : TeaModel {
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
