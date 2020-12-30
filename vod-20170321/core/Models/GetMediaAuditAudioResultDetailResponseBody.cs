// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAuditAudioResultDetailResponseBody : TeaModel {
        [NameInMap("MediaAuditAudioResultDetail")]
        [Validation(Required=false)]
        public GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail MediaAuditAudioResultDetail { get; set; }
        public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetail : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList> List { get; set; }
            public class GetMediaAuditAudioResultDetailResponseBodyMediaAuditAudioResultDetailList : TeaModel {
                public long? EndTime { get; set; }
                public long? StartTime { get; set; }
                public string Text { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("PageTotal")]
            [Validation(Required=false)]
            public int? PageTotal { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
