// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateMonocularVideoDepthAdvanceRequest : TeaModel {
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public Stream VideoURLObject { get; set; }

    }

}
