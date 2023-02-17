// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class GenerateSuperResolutionImageAdvanceRequest : TeaModel {
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public Stream ImageUrlObject { get; set; }

        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        [NameInMap("OutputQuality")]
        [Validation(Required=false)]
        public int? OutputQuality { get; set; }

        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
