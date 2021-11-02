// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDetectionJobResponseBody : TeaModel {
        [NameInMap("DetectionJob")]
        [Validation(Required=false)]
        public GetDetectionJobResponseBodyDetectionJob DetectionJob { get; set; }
        public class GetDetectionJobResponseBodyDetectionJob : TeaModel {
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }
            [NameInMap("CopyrightBeginTime")]
            [Validation(Required=false)]
            public string CopyrightBeginTime { get; set; }
            [NameInMap("CopyrightEndTime")]
            [Validation(Required=false)]
            public string CopyrightEndTime { get; set; }
            [NameInMap("CopyrightFile")]
            [Validation(Required=false)]
            public string CopyrightFile { get; set; }
            [NameInMap("CopyrightStatus")]
            [Validation(Required=false)]
            public string CopyrightStatus { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }
            [NameInMap("WhitelistUrls")]
            [Validation(Required=false)]
            public string WhitelistUrls { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
