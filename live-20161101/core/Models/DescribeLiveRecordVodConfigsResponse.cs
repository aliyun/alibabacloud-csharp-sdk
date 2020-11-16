// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordVodConfigsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=true)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public string Total { get; set; }

        [NameInMap("LiveRecordVodConfigs")]
        [Validation(Required=true)]
        public DescribeLiveRecordVodConfigsResponseLiveRecordVodConfigs LiveRecordVodConfigs { get; set; }
        public class DescribeLiveRecordVodConfigsResponseLiveRecordVodConfigs : TeaModel {
            [NameInMap("LiveRecordVodConfig")]
            [Validation(Required=true)]
            public List<DescribeLiveRecordVodConfigsResponseLiveRecordVodConfigsLiveRecordVodConfig> LiveRecordVodConfig { get; set; }
            public class DescribeLiveRecordVodConfigsResponseLiveRecordVodConfigsLiveRecordVodConfig : TeaModel {
                public string CreateTime { get; set; }
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string VodTranscodeGroupId { get; set; }
                public int? CycleDuration { get; set; }
                public string AutoCompose { get; set; }
                public string ComposeVodTranscodeGroupId { get; set; }
            }
        };

    }

}
