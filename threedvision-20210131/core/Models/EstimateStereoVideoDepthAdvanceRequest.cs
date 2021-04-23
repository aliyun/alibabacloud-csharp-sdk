// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateStereoVideoDepthAdvanceRequest : TeaModel {
        [NameInMap("VideoURLObject")]
        [Validation(Required=true)]
        public Stream VideoURLObject { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

    }

}
