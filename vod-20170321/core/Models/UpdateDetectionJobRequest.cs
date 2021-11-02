// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateDetectionJobRequest : TeaModel {
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

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("WhiteListUrls")]
        [Validation(Required=false)]
        public string WhiteListUrls { get; set; }

    }

}
