// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsPullStreamConfigResponseBody : TeaModel {
        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeVsPullStreamConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeVsPullStreamConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeVsPullStreamConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeVsPullStreamConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
                public string AppName { get; set; }
                public string DomainName { get; set; }
                public string EndTime { get; set; }
                public string SourceUrl { get; set; }
                public string StartTime { get; set; }
                public string StreamName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
