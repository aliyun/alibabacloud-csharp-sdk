// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class InvestigationInfo : TeaModel {
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        [NameInMap("video_detail")]
        [Validation(Required=false)]
        public InvestigationInfoVideoDetail VideoDetail { get; set; }
        public class InvestigationInfoVideoDetail : TeaModel {
            [NameInMap("block_frames")]
            [Validation(Required=false)]
            public List<InvestigationInfoVideoDetailBlockFrames> BlockFrames { get; set; }
            public class InvestigationInfoVideoDetailBlockFrames : TeaModel {
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("offset")]
                [Validation(Required=false)]
                public long? Offset { get; set; }

                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

            }

        }

    }

}
