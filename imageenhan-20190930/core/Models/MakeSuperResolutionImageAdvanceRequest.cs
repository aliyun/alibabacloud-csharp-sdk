// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class MakeSuperResolutionImageAdvanceRequest : TeaModel {
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("OutputQuality")]
        [Validation(Required=false)]
        public long? OutputQuality { get; set; }

        [NameInMap("UpscaleFactor")]
        [Validation(Required=false)]
        public long? UpscaleFactor { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public Stream UrlObject { get; set; }

    }

}
