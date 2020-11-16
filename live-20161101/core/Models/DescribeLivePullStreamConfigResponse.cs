// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullStreamConfigResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveAppRecordList")]
        [Validation(Required=true)]
        public DescribeLivePullStreamConfigResponseLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLivePullStreamConfigResponseLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=true)]
            public List<DescribeLivePullStreamConfigResponseLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLivePullStreamConfigResponseLiveAppRecordListLiveAppRecord : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string SourceUrl { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
            }
        };

    }

}
