// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class AppsInteractiveVideoSettings : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public AppsDomain Domain { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public AppsSecurity Severity { get; set; }

        [NameInMap("Transcoding")]
        [Validation(Required=false)]
        public AppsTranscoding Transcoding { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
