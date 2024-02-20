// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aigen20240111.Models
{
    public class GenerateCosplayImageAdvanceRequest : TeaModel {
        [NameInMap("FaceImageUrl")]
        [Validation(Required=false)]
        public Stream FaceImageUrlObject { get; set; }

        [NameInMap("Style")]
        [Validation(Required=false)]
        public long? Style { get; set; }

        [NameInMap("TemplateImageUrl")]
        [Validation(Required=false)]
        public Stream TemplateImageUrlObject { get; set; }

    }

}
