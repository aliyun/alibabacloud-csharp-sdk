// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageMediaMetadata : TeaModel {
        [NameInMap("height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("taken_at")]
        [Validation(Required=false)]
        public string TakenAt { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
