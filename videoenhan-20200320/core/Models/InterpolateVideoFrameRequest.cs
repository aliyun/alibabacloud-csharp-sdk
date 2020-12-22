// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class InterpolateVideoFrameRequest : TeaModel {
        [NameInMap("VideoURL")]
        [Validation(Required=true)]
        public string VideoURL { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public int? FrameRate { get; set; }

        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public int? Bitrate { get; set; }

    }

}
