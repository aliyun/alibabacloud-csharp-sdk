// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordVodConfigsResponseBody : TeaModel {
        [NameInMap("LiveRecordVodConfigs")]
        [Validation(Required=false)]
        public DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigs LiveRecordVodConfigs { get; set; }
        public class DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigs : TeaModel {
            [NameInMap("LiveRecordVodConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigsLiveRecordVodConfig> LiveRecordVodConfig { get; set; }
            public class DescribeLiveRecordVodConfigsResponseBodyLiveRecordVodConfigsLiveRecordVodConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AutoCompose")]
                [Validation(Required=false)]
                public string AutoCompose { get; set; }

                [NameInMap("ComposeVodTranscodeGroupId")]
                [Validation(Required=false)]
                public string ComposeVodTranscodeGroupId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CycleDuration")]
                [Validation(Required=false)]
                public int? CycleDuration { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("VodTranscodeGroupId")]
                [Validation(Required=false)]
                public string VodTranscodeGroupId { get; set; }

            }

        }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
