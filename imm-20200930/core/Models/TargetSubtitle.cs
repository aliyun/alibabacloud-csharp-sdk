// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetSubtitle : TeaModel {
        [NameInMap("DisableSubtitle")]
        [Validation(Required=false)]
        public bool? DisableSubtitle { get; set; }

        [NameInMap("ExtractSubtitle")]
        [Validation(Required=false)]
        public TargetSubtitleExtractSubtitle ExtractSubtitle { get; set; }
        public class TargetSubtitleExtractSubtitle : TeaModel {
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<int?> Stream { get; set; }

    }

}
