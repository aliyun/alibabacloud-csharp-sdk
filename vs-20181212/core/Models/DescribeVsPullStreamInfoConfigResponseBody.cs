// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsPullStreamInfoConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
                public string EndTime { get; set; }
                public string AppName { get; set; }
                public string SourceUrl { get; set; }
                public string StartTime { get; set; }
                public string StreamName { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
