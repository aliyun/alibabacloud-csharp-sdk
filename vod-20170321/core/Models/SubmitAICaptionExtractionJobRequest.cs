// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAICaptionExtractionJobRequest : TeaModel {
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        [NameInMap("JobConfig")]
        [Validation(Required=false)]
        public string JobConfig { get; set; }

        [NameInMap("AIPipelineId")]
        [Validation(Required=false)]
        public string AIPipelineId { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
