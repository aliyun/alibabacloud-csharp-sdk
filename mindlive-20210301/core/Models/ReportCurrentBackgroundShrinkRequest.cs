// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MindLive20210301.Models
{
    public class ReportCurrentBackgroundShrinkRequest : TeaModel {
        [NameInMap("BgConfig")]
        [Validation(Required=false)]
        public string BgConfigShrink { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("Open")]
        [Validation(Required=false)]
        public bool? Open { get; set; }

        [NameInMap("ResourceUuid")]
        [Validation(Required=false)]
        public string ResourceUuid { get; set; }

    }

}
