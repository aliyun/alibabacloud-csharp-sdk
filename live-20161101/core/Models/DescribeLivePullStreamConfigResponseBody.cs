// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullStreamConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeLivePullStreamConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLivePullStreamConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeLivePullStreamConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLivePullStreamConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
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
