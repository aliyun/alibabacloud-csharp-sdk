// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordVodConfigsResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("LiveRecordVodConfigs")]
        [Validation(Required=false)]
        public DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigs LiveRecordVodConfigs { get; set; }
        public class DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigs : TeaModel {
            [NameInMap("LiveRecordVodConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigsLiveRecordVodConfig> LiveRecordVodConfig { get; set; }
            public class DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigsLiveRecordVodConfig : TeaModel {
                public string AppName { get; set; }
                public string AutoCompose { get; set; }
                public string StreamName { get; set; }
                public string CreateTime { get; set; }
                public string VodTranscodeGroupId { get; set; }
                public int? CycleDuration { get; set; }
                public string DomainName { get; set; }
                public string ComposeVodTranscodeGroupId { get; set; }
            }
        };

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
