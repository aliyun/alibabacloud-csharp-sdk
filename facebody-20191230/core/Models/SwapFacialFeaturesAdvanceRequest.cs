// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SwapFacialFeaturesAdvanceRequest : TeaModel {
        [NameInMap("EditPart")]
        [Validation(Required=false)]
        public string EditPart { get; set; }

        [NameInMap("SourceImageData")]
        [Validation(Required=false)]
        public byte[] SourceImageData { get; set; }

        [NameInMap("SourceImageURL")]
        [Validation(Required=false)]
        public Stream SourceImageURLObject { get; set; }

        [NameInMap("TargetImageData")]
        [Validation(Required=false)]
        public byte[] TargetImageData { get; set; }

        [NameInMap("TargetImageURL")]
        [Validation(Required=false)]
        public Stream TargetImageURLObject { get; set; }

    }

}
