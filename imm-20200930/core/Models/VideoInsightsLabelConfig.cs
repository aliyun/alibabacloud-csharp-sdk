// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsightsLabelConfig : TeaModel {
        [NameInMap("Highlight")]
        [Validation(Required=false)]
        public VideoInsightsHighlightLabelConfig Highlight { get; set; }

        [NameInMap("System")]
        [Validation(Required=false)]
        public VideoInsightsSystemLabelConfig System { get; set; }

        [NameInMap("UserDefined")]
        [Validation(Required=false)]
        public VideoInsightsUserDefinedLabelConfig UserDefined { get; set; }

    }

}
